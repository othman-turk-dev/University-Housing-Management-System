using Business_Layer.DTOs;
using Business_Layer.Global.Constants;
using Business_Layer.Interfaces;
using Data_Access_Layer.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Business_Layer.Services
{
    public class BankService : IBankService
    {

        private readonly IBankRepositry _bankRepositry;
        private readonly IUserRepositry _userRepositry;
        private readonly IStudentRepositry _studentRepositry;
        public BankService(IBankRepositry bankRepositry,
            IStudentRepositry studentRepositry, IUserRepositry userRepositry)
        {
            
            _bankRepositry = bankRepositry;
            _userRepositry = userRepositry;
            _studentRepositry = studentRepositry;
        }
        
        public async Task<IEnumerable<StudentOperationsDto>> GetAllStudentOperationsAsync()
        {
            
            var StudentOperations = new List<string> { BankOperations.NewSubscription,
                BankOperations.RenewSubscription, BankOperations.PayFine };

            return await _bankRepositry.GetAllBanks()
            .Where(b => StudentOperations.Contains(b.OperationType))
            .Join(
                _studentRepositry.GetAllStudents(),
                bank => bank.StudentId,
                student => student.UniversityNumber,
                (bank, student) => new StudentOperationsDto
                {
                    UniversityNumber = student.UniversityNumber,
                    FullName = student.FullName,
                    OperationType = bank.OperationType,
                    Date = bank.Date,
                    Amount = bank.Amount,
                    Username = bank.CreatedByUser.Username

                }).OrderByDescending(x => x.Date)
                .ToListAsync();
        }
        public async Task<IEnumerable<StoreOperationsDto>> GetAllStoreOperationsAsync()
        {

            var StoreOperations = new List<string> { BankOperations.BuyNewProduct,
                BankOperations.PurchaseNewQuantity, BankOperations.SellProducts };


            return await _bankRepositry.GetAllBanks()
            .Where(b => StoreOperations.Contains(b.OperationType) && b.StudentId == null)
            .Select(b => new StoreOperationsDto
            {
                OperationType = b.OperationType,
                Date = b.Date,
                Amount = b.Amount,
                Username = b.CreatedByUser.Username,

            }).OrderByDescending(x => x.Date)
                .ToListAsync();

        }


        public async Task<IEnumerable<StudentOperationsDto>> StudentOperationsFilterAsync(StudentOperationsFilterDto filterDto)
        {
            
            var studentOperations = new[]
            { BankOperations.NewSubscription, BankOperations.RenewSubscription, BankOperations.PayFine };


            var query = _bankRepositry.GetAllBanks()
            .Where(b => studentOperations.Contains(b.OperationType))
            .Join(
                _studentRepositry.GetAllStudents(),
                bank => bank.StudentId,
                student => student.UniversityNumber,
                (bank, student) => new StudentOperationsDto
                {
                    UniversityNumber = student.UniversityNumber,
                    FullName = student.FullName,
                    OperationType = bank.OperationType,
                    Date = bank.Date,
                    Amount = bank.Amount,
                    Username = bank.CreatedByUser.Username
                });

            if (!string.IsNullOrWhiteSpace(filterDto.OperationType)
                && filterDto.OperationType != "All")
            {
                query = query.Where(x => x.OperationType == filterDto.OperationType);
            }

            if (!string.IsNullOrWhiteSpace(filterDto.StudentName))
            {
                query = query.Where(x => x.FullName.Contains(filterDto.StudentName));
            }

            if (filterDto.OperationDate.HasValue)
            {
                var start = filterDto.OperationDate.Value.Date;
                var end = start.AddDays(1);

                query = query.Where(x => x.Date >= start && x.Date < end);
            }

            return await query
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
        public async Task<IEnumerable<StoreOperationsDto>> StoreOperationsFilterAsync(StoreOperationsFilterDto filterDto)
        {

            var StoreOperations = new List<string> { BankOperations.BuyNewProduct,
                BankOperations.PurchaseNewQuantity, BankOperations.SellProducts };

            var query = _bankRepositry.GetAllBanks()
            .Where(b => StoreOperations.Contains(b.OperationType) && b.StudentId == null)
            .Select(b => new StoreOperationsDto
            {
                OperationType = b.OperationType,
                Date = b.Date,
                Amount = b.Amount,
                Username = b.CreatedByUser.Username,

            });

            if (!string.IsNullOrWhiteSpace(filterDto.OperationType)
                && filterDto.OperationType != "All")
            {
                query = query.Where(x => x.OperationType == filterDto.OperationType);
            }

            if (filterDto.OperationDate.HasValue)
            {
                var start = filterDto.OperationDate.Value.Date;
                var end = start.AddDays(1);

                query = query.Where(x => x.Date >= start && x.Date < end);
            }

            return await query
                .OrderByDescending(x => x.Date)
                .ToListAsync();

        }


        public async Task<IEnumerable<StudentOperationsDto>> GetAllStudentOperationsInThisMonthAsync()
        {

            var StudentOperations = new List<string> { BankOperations.NewSubscription,
                BankOperations.RenewSubscription, BankOperations.PayFine };

            var firstDayOfMonth = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1);

            return await _bankRepositry.GetAllBanks()
            .Where(b => StudentOperations.Contains(b.OperationType))
            .Where(b => b.Date >= firstDayOfMonth)
            .Join(
                _studentRepositry.GetAllStudents(),
                bank => bank.StudentId,
                student => student.UniversityNumber,
                (bank, student) => new StudentOperationsDto
                {
                    UniversityNumber = student.UniversityNumber,
                    FullName = student.FullName,
                    OperationType = bank.OperationType,
                    Date = bank.Date,
                    Amount = bank.Amount,
                    Username = bank.CreatedByUser.Username

                }).OrderByDescending(x => x.Date)
                .ToListAsync();
        }
        public async Task<IEnumerable<StoreOperationsDto>> GetAllStoreOperationsInThisMonthAsync()
        {

            var StoreOperations = new List<string> { BankOperations.BuyNewProduct,
                BankOperations.PurchaseNewQuantity, BankOperations.SellProducts };

            var firstDayOfMonth = new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, 1);

            return await _bankRepositry.GetAllBanks()
            .Where(b => StoreOperations.Contains(b.OperationType) && b.StudentId == null)
            .Where(b => b.Date >= firstDayOfMonth)
            .Select(b => new StoreOperationsDto
            {
                OperationType = b.OperationType,
                Date = b.Date,
                Amount = b.Amount,
                Username = b.CreatedByUser.Username,

            }).OrderByDescending(x => x.Date)
                .ToListAsync();

        }

    }
}
