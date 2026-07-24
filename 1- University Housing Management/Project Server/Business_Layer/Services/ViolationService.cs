using Business_Layer.DTOs;
using Business_Layer.Interfaces;
using Data_Access_Layer.Entities;
using Business_Layer.DTOs.Mappers;
using Microsoft.EntityFrameworkCore;
using Business_Layer.Global.Constants;
using Data_Access_Layer.Repository.Interfaces;

namespace Business_Layer.Services
{
    public class ViolationService : IViolationService
    {

        private readonly IBankRepositry _bankRepositry;
        private readonly ICurrentUserService _currentUserService;
        private readonly IViolationRepositry _violationRepositry;
        private readonly ITransactionManager _transactionManager;
        private readonly IViolationTypeRepositry _violationTypeRepositry;

        public ViolationService(ICurrentUserService currentUserService, IBankRepositry bankRepositry,
            IViolationRepositry violationRepositry, IViolationTypeRepositry violationTypeRepositry,
            ITransactionManager transactionManager)
        {

            _bankRepositry = bankRepositry;
            _transactionManager = transactionManager;
            _currentUserService = currentUserService;
            _violationRepositry = violationRepositry;
            _violationTypeRepositry = violationTypeRepositry;
        }


        public async Task<ViolationDto?> AddViolationAsync(AddViolationDto violation)
        {

            var ViolationType = await _violationTypeRepositry.GetViolationByIdAsync(violation.ViolationTypeId);

            if (ViolationType == null)
                return null;

            var Fine = ViolationType.PenaltyAmount;

            Violation newViolation = new Violation
            {
                
                StudentId = violation.UniversityNumber,
                ViolationTypeId = violation.ViolationTypeId,
                IsPaid = false,
                Date = DateTime.UtcNow,
                Fine = Fine,
                CreatedByUserId = _currentUserService.UserId,
            };

            var addViolation = await _violationRepositry
                .AddViolationAsync(newViolation);


            return addViolation != null ? 
                ViolationMapper.ToDto(addViolation) : null;
        }
        public async Task<ViolationDto?> GetViolationByIdAsync(int ViolationId)
        {

            var Violation = await _violationRepositry.GetViolationByIdAsync(ViolationId);

            return Violation != null ?
                ViolationMapper.ToDto(Violation) : null;
        }
        public async Task<bool> DeleteViolationAsync(int ViolationId)
        {
            
            return await _violationRepositry.
                DeleteViolationAsync(ViolationId);
        }
        public async Task<bool> IsViolationExistAsync(int id)
        {

            return await _violationRepositry.IsViolationExistAsync(id);
        }
        public async Task<bool> PayFineForViolationAsync(int ViolationId)
        {
            
            await _transactionManager.BeginTransactionAsync();

            try
            {
                var existing = await _violationRepositry.GetViolationByIdAsync(ViolationId);
                
                if (existing == null)
                { 
                    await _transactionManager.RollbackAsync();
                    return false;
                }
                
                existing.IsPaid = true;

                await _violationRepositry.UpdateViolationAsync(existing);

                var bank = new Bank
                {
                    StudentId = existing.StudentId,
                    Amount = existing.Fine,
                    OperationType = BankOperations.PayFine,
                    CreatedByUserId = _currentUserService.UserId,
                    Date = DateTime.UtcNow
                };

                var addedBank = await _bankRepositry.AddBankAsync(bank);

                if (addedBank == null)
                {
                    await _transactionManager.RollbackAsync();
                    return false;
                }

                await _transactionManager.CommitAsync();

                return true;

            }
            catch
            {

                await _transactionManager.RollbackAsync();
                return false;
            }
        }
        public async Task<IEnumerable<AllViolationsDto>> GetAllViolationsAsync()
        {

            return await _violationRepositry.GetAllViolations().
                OrderBy(v => v.IsPaid).
                ThenByDescending(v => v.Date).
                Select(v => new AllViolationsDto
                {

                    ViolationId = v.ViolationId,
                    ViolationType = v.ViolationType.Name,
                    Student = v.Student.FullName,
                    UniversityNumber = v.Student.UniversityNumber,
                    IsPaid = v.IsPaid ? "Paid" : "Unpaid",
                    Fine = v.Fine,
                    Date = v.Date,
                    CreatedByUser = v.CreatedByUser.Username

                }).ToListAsync();
        }
        public async Task<IEnumerable<ViolationDetailsDto>> GetViolationDetailsAsync(string UniversityNumber)
        {

            return await _violationRepositry.GetAllViolations().
                Where(r => r.StudentId == UniversityNumber).
                GroupBy(v => new
                {
                    v.ViolationType.Name,
                    v.ViolationType.Description,
                    v.Fine,
                }).
                Select(group => new ViolationDetailsDto
                {
                    Violation = group.Key.Name,
                    Description = group.Key.Description,
                    Fine = group.Key.Fine,
                    NumberOfViolations = group.Count(),
                }).
                OrderByDescending(x => x.NumberOfViolations).
                ToListAsync();
        }
        public async Task<IEnumerable<ViolationRateDto>> GetStatisticsForViolationsAsync()
        {

            var totalViolations = await _violationRepositry
                .GetAllViolations().CountAsync();

            return await _violationTypeRepositry.GetAll()
                .GroupJoin(
                    _violationRepositry.GetAllViolations(),
                    vt => vt.ViolationTypeId,
                    v => v.ViolationTypeId,
                    (vt, v) => new ViolationRateDto
                    {
                        ViolationName = vt.Name,
                        StudentsHaveViolations = v.Count(),
                        ViolationRate = (decimal)(v.Count() * 100.0 / (totalViolations == 0 ? 1 : totalViolations))
                    })
                .OrderByDescending(x => x.ViolationRate)
                .ToListAsync();

        }


        public async Task<IEnumerable<AllViolationsDto>> ViolationsFilterAsync(ViolationsFilterDto violationsFilter)
        {

            var query = _violationRepositry.GetAllViolations();

            
            if (violationsFilter.ViolationDate.HasValue)
            {

                var start = violationsFilter.ViolationDate.Value.Date;
                var end = start.AddDays(1);

                query = query.Where(v =>
                    v.Date >= start &&
                    v.Date < end);

            }

            if (!string.IsNullOrWhiteSpace(violationsFilter.StudentName))
                query = query.Where(s => s.Student.FullName.Contains(violationsFilter.StudentName));

            if (!string.IsNullOrWhiteSpace(violationsFilter.ViolationType) && violationsFilter.ViolationType != "All")
                query = query.Where(s => s.ViolationType.Name == violationsFilter.ViolationType);

            if(!string.IsNullOrWhiteSpace(violationsFilter.PaymentStatus) && violationsFilter.PaymentStatus != "All")
            {

                if (violationsFilter.PaymentStatus == "Paid")
                    query = query.Where(s => s.IsPaid);

                else
                    query = query.Where(s => !s.IsPaid);

            }


            return await query.Select(v => new AllViolationsDto
            {

                ViolationId = v.ViolationId,
                ViolationType = v.ViolationType.Name,
                Student = v.Student.FullName,
                UniversityNumber = v.Student.UniversityNumber,
                IsPaid = v.IsPaid ? "Paid" : "Unpaid",
                Fine = v.Fine,
                Date = v.Date,
                CreatedByUser = v.CreatedByUser.Username

            }).ToListAsync(); ;

        }

    }
}
