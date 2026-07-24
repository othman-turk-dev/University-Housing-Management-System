using Business_Layer.DTOs;
using Business_Layer.Interfaces;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Business_Layer.Global.Constants;
using Data_Access_Layer.Repository.Interfaces;

namespace Business_Layer.Services
{
    public class StudentSubscriptionService: IStudentSubscriptionService
    {

        private readonly IBankRepositry _bankRepositry;
        private readonly ICurrentUserService _currentUserService;
        private readonly ITransactionManager _transactionManager;
        private readonly ISubscriptionRepositry _subscriptionRepositry;
        private readonly ISubscriptionTypeService _subscriptionTypeService;
        private readonly IStudentSubscriptionRepositry _studentSubscriptionRepositry;
        public StudentSubscriptionService(IStudentSubscriptionRepositry studentSubscriptionRepositry,
            IBankRepositry bankRepositry, ICurrentUserService currentUserService,
            ITransactionManager transactionManager, ISubscriptionRepositry subscriptionRepositry,
            ISubscriptionTypeService subscriptionTypeService)

        {

            _bankRepositry = bankRepositry;
            _currentUserService = currentUserService;
            _transactionManager = transactionManager;
            _subscriptionRepositry = subscriptionRepositry;
            _subscriptionTypeService = subscriptionTypeService;
            _studentSubscriptionRepositry = studentSubscriptionRepositry;
        }

        public async Task<bool> AddStudentSubscriptionAsync(string studentId, int subscriptionTypeId)
        {

            await _transactionManager.BeginTransactionAsync();

            try
            {
                var subscription = new Subscription
                {
                    SubscriptionTypeId = subscriptionTypeId
                };

                var addedSubscription =
                    await _subscriptionRepositry.AddNewSubscriptionAsync(subscription);

                if (addedSubscription == null)
                {
                    await _transactionManager.RollbackAsync();
                    return false;
                }

                DateTime endDate = subscriptionTypeId switch
                {
                    1 => DateTime.UtcNow.AddDays(7),
                    2 => DateTime.UtcNow.AddMonths(1),
                    3 => DateTime.UtcNow.AddMonths(4),
                    4 => DateTime.UtcNow.AddYears(1),
                };

                var studentSubscription = new StudentSubscription
                {
                    StudentId = studentId,
                    SubscriptionId = addedSubscription.SubscriptionId,
                    StartDate = DateTime.UtcNow,
                    EndDate = endDate,
                    IsActive = true
                };

                var addedStudentSubscription =
                    await _studentSubscriptionRepositry
                        .AddNewStudentSubscriptionAsync(studentSubscription);

                if (addedStudentSubscription == null)
                {
                    await _transactionManager.RollbackAsync();
                    return false;
                }

                
                var SubscriptionType = await _subscriptionTypeService.
                    GetSubscriptionTypeByIdAsync(subscriptionTypeId);

                if (SubscriptionType == null)
                {
                    await _transactionManager.RollbackAsync();
                    return false;
                }


                var bank = new Bank
                {
                    StudentId = studentId,
                    Amount = SubscriptionType.Price,
                    OperationType = BankOperations.NewSubscription,
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
        public async Task<bool> IsStudentSubscriptionExistAsync(string UniversityNumber)
        {

            return await _studentSubscriptionRepositry.
                IsStudentSubscriptionExistAsync(UniversityNumber);
        }
        public async Task<bool> DeactivateExpiredSubscriptionsAsync()
        {

            return await _studentSubscriptionRepositry
                .DeactivateExpiredSubscriptionsAsync() != 0;
        }
        public async Task<bool> RenewSubscriptionAsync(string UniversityNumber,
            int subscriptionTypeId, decimal latePenalty)
        {

            await _transactionManager.BeginTransactionAsync();

            try
            {
                
                var studentSubscription =
                    await _studentSubscriptionRepositry
                    .GetStudentSubscriptionByIdAsync(UniversityNumber);



                if (studentSubscription == null || studentSubscription.IsActive)
                {
                    await _transactionManager.RollbackAsync();
                    return false;
                }

                DateTime endDate = subscriptionTypeId switch
                {
                    1 => DateTime.UtcNow.AddDays(7),
                    2 => DateTime.UtcNow.AddMonths(1),
                    3 => DateTime.UtcNow.AddMonths(4),
                    4 => DateTime.UtcNow.AddYears(1),
                };

                studentSubscription.StartDate = DateTime.UtcNow;
                studentSubscription.EndDate = endDate;
                studentSubscription.IsActive = true;
                


                studentSubscription.Subscription.SubscriptionTypeId =
                    subscriptionTypeId;

                await _studentSubscriptionRepositry
                    .UpdateStudentSubscriptionAsync(studentSubscription);

                var SubscriptionType = await _subscriptionTypeService.
                    GetSubscriptionTypeByIdAsync(subscriptionTypeId);


                if (SubscriptionType == null)
                {
                    await _transactionManager.RollbackAsync();
                    return false;
                }

                // Discount 25% for renew
                decimal discountedPrice = SubscriptionType.Price * 0.75m;
                
                var bank = new Bank
                {
                    StudentId = UniversityNumber,
                    Amount = discountedPrice + latePenalty,
                    OperationType = BankOperations.RenewSubscription,
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

        public async Task<IEnumerable<AllSubscriptionsDto>> GetAllSubscriptionsAsync()
        {

            return await _studentSubscriptionRepositry.GetAllStudentSubscriptions().
                Select(s => new AllSubscriptionsDto
                {

                    UniversityNumber = s.Student.UniversityNumber,
                    Name = s.Student.FullName,
                    RoomLocation = s.Student.Room.RoomLocation,
                    SubscriptionType = s.Subscription.SubscriptionType.Description,
                    StartDate = s.StartDate,
                    EndDate = s.EndDate,
                    Status = s.IsActive ? "Active" : "Unactive"

                })
                .OrderByDescending(s => s.Status)
                .ToListAsync();

        }
        public async Task<IEnumerable<AllSubscriptionsDto>> GetAllActiveSubscriptionsAsync()
        {

            return await _studentSubscriptionRepositry.GetAllStudentSubscriptions().
                Where(s => s.IsActive).
                Select(s => new AllSubscriptionsDto
                {

                    UniversityNumber = s.Student.UniversityNumber,
                    Name = s.Student.FullName,
                    RoomLocation = s.Student.Room.RoomLocation,
                    SubscriptionType = s.Subscription.SubscriptionType.Description,
                    StartDate = s.StartDate,
                    EndDate = s.EndDate,
                    Status = s.IsActive ? "Active" : "Unactive"

                })
                .ToListAsync();

        }

        public async Task <IEnumerable<AllSubscriptionsDto>> 
            SubscriptionsFilterAsync(SubscriptionsFilterDto subscriptionsFilter)
        {

            var query = _studentSubscriptionRepositry.GetAllStudentSubscriptions();

            if (!string.IsNullOrWhiteSpace(subscriptionsFilter.StudentName))
                query = query.Where(s => s.Student.FullName.Contains(subscriptionsFilter.StudentName));

            if(!string.IsNullOrWhiteSpace(subscriptionsFilter.SubscriptionStatus) 
                && subscriptionsFilter.SubscriptionStatus != "All")
            {

                if (subscriptionsFilter.SubscriptionStatus == "Active")
                    query = query.Where(s => s.IsActive);

                else
                    query = query.Where(s => !s.IsActive);
            }

            if (!string.IsNullOrWhiteSpace(subscriptionsFilter.SubscriptionType)
                && subscriptionsFilter.SubscriptionType != "All")
            {
                query = query.Where(s => s.Subscription.
                SubscriptionType.Description.Contains(subscriptionsFilter.SubscriptionType));
            }

            if(!string.IsNullOrWhiteSpace(subscriptionsFilter.NearestOrFurthestDate)
                && subscriptionsFilter.NearestOrFurthestDate != "All")
            {

                if (subscriptionsFilter.NearestOrFurthestDate == "Nearest Expiry Date")
                    query = query.OrderBy(s => s.EndDate);

                else
                    query = query.OrderByDescending(s => s.EndDate);

            }


            return await query.Select(s => new AllSubscriptionsDto
            {

                UniversityNumber = s.Student.UniversityNumber,
                Name = s.Student.FullName,
                RoomLocation = s.Student.Room.RoomLocation,
                SubscriptionType = s.Subscription.SubscriptionType.Description,
                StartDate = s.StartDate,
                EndDate = s.EndDate,
                Status = s.IsActive ? "Active" : "Unactive"

            }).ToListAsync();

        }

    }

}
