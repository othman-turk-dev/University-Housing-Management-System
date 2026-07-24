using Business_Layer.DTOs;
using Business_Layer.DTOs.Mappers;
using Business_Layer.Global.Enums;
using Business_Layer.Interfaces;
using Data_Access_Layer.Entities;
using Data_Access_Layer.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Business_Layer.Services
{
    public class UserService : IUserService
    {

        private readonly IUserRepositry _userRepositry;
        private readonly ICurrentUserService _currentUserService;
        public UserService(IUserRepositry userRepositry, ICurrentUserService currentUserService)
        {
         
            _currentUserService = currentUserService;
            _userRepositry = userRepositry;
        }

        public async Task<UserDto?> AddUserAsync(UserDto user)
        {
            
            User newUser = new User
            {
                Username = user.Username,
                Password = BCrypt.Net.BCrypt.HashPassword(user.Password),
                IsActive = user.IsActive,
                Permmission = user.Permmission,
            };

            var addedUser = await _userRepositry.AddUserAsync(newUser);

            if(addedUser == null)
                return null;

            return UserMapper.ToDto(addedUser);
        }
        public async Task<SimpleUserDto?> UpdateUserAsync(SimpleUserDto user)
        {
            
            var existingUser = await _userRepositry.GetUserByIdAsync(user.UserId);

            if (existingUser == null)
                return null;

            existingUser.Username = user.Username;
            existingUser.IsActive = user.IsActive;
            existingUser.Permmission = user.Permmission;

            var updatedUser = await _userRepositry.UpdateUserAsync(existingUser);

            return updatedUser != null ? SimpleUserMapper.ToDto(updatedUser) : null;
        }
        public async Task<bool> ChangePasswordAsync
            (int UserId, string CurrentPassword, string NewPassword)
        {

            var existingUser = await _userRepositry.GetUserByIdAsync(UserId);

            if (existingUser == null)
                return false;

            if (!BCrypt.Net.BCrypt.Verify(CurrentPassword, existingUser.Password)) 
                return false;

            existingUser.Password = BCrypt.Net.BCrypt.HashPassword(NewPassword);

            var updatedUser = await _userRepositry.UpdateUserAsync(existingUser);

            return updatedUser != null ? true : false;
        }

        public async Task<bool> DeleteUserAsync(int id)
        {

            return await _userRepositry.DeleteUserAsync(id);
        }
        public async Task<SimpleUserDto?> GetUserByIdAsync(int id)
        {
            
            var user = await _userRepositry
                .GetUserByIdAsync(id);

            return user != null ? SimpleUserMapper.ToDto(user) : null;
        }
        public async Task<SimpleUserDto?> GetCurrentUserAsync()
        {
            
            var userId = _currentUserService.UserId;

            var user = await _userRepositry
                .GetUserByIdAsync(userId);

            return user != null ? SimpleUserMapper.ToDto(user) : null;
        }
        public async Task<bool> IsUserExistAsync(int id)
        {

            return await _userRepositry.IsUserExistAsync(id);
        }
        public async Task<bool> IsUserExistAsync(string username)
        {

            return await _userRepositry.IsUserExistAsync(username);
        }

        public async Task<bool> ChangeUserStatusAsync(int id, bool IsActive)
        {

            var existingUser = await _userRepositry.GetUserByIdAsync(id);
            
            if (existingUser == null)
                return false;

            existingUser.IsActive = IsActive;

            var updatedUser = await _userRepositry.UpdateUserAsync(existingUser);

            return updatedUser != null;
        }
        public async Task<IEnumerable<CustomUserDto>> GetAllUsersAsync()
        {

            return await _userRepositry.GetAll()
                 .Select(r => new CustomUserDto
                 {
                     
                     UserId = r.UserId,
                     Username = r.Username,

                     StudentManager = ((r.Permmission & (int)UserPermission.StudentManagement ) != 0 || r.Permmission == -1),
                     StudentSubscription = ((r.Permmission & (int)UserPermission.SubscriptionManagement ) != 0 || r.Permmission == -1),
                     RoomManager = ((r.Permmission & (int)UserPermission.RoomManagement) != 0 || r.Permmission == -1),
                     ProductManager = ((r.Permmission & (int)UserPermission.Products ) != 0 || r.Permmission == -1),
                     SaleManager = ((r.Permmission & (int)UserPermission.Sales ) != 0 || r.Permmission == -1),
                     ViolationManager = ((r.Permmission & (int)UserPermission.Violations ) != 0 || r.Permmission == -1),
                     UserManager = ((r.Permmission & (int)UserPermission.UserManagment ) != 0 || r.Permmission == -1),
                     BankSystem = ((r.Permmission & (int)UserPermission.BankManagment ) != 0 || r.Permmission == -1),

                     Status = r.IsActive ? "Active" : "Inactive"

                 }).ToListAsync();
        }


        public async Task<IEnumerable<CustomUserDto>> UsersFilterAsync(string? username)
        {

            var query = _userRepositry.GetAll();

            if (!string.IsNullOrWhiteSpace(username))
                query = query.Where(x => x.Username.Contains(username));

            return await query.Select(r => new CustomUserDto
            {

                UserId = r.UserId,
                Username = r.Username,

                StudentManager = ((r.Permmission & (int)UserPermission.StudentManagement) != 0 || r.Permmission == -1),
                StudentSubscription = ((r.Permmission & (int)UserPermission.SubscriptionManagement) != 0 || r.Permmission == -1),
                RoomManager = ((r.Permmission & (int)UserPermission.RoomManagement) != 0 || r.Permmission == -1),
                ProductManager = ((r.Permmission & (int)UserPermission.Products) != 0 || r.Permmission == -1),
                SaleManager = ((r.Permmission & (int)UserPermission.Sales) != 0 || r.Permmission == -1),
                ViolationManager = ((r.Permmission & (int)UserPermission.Violations) != 0 || r.Permmission == -1),
                UserManager = ((r.Permmission & (int)UserPermission.UserManagment) != 0 || r.Permmission == -1),
                BankSystem = ((r.Permmission & (int)UserPermission.BankManagment) != 0 || r.Permmission == -1),

                Status = r.IsActive ? "Active" : "Inactive"

            }).ToListAsync();

        }

    }
}
