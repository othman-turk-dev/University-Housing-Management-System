using Business_Layer.DTOs;

namespace Business_Layer.Interfaces
{
    public interface IUserService
    {

        Task<UserDto?> AddUserAsync(UserDto user);
        Task<SimpleUserDto?> UpdateUserAsync(SimpleUserDto user);
        Task<bool> ChangePasswordAsync(int UserId,
            string CurrentPassword, string NewPassword);

        Task<bool> DeleteUserAsync(int id);
        Task<SimpleUserDto?> GetCurrentUserAsync();
        Task<SimpleUserDto?> GetUserByIdAsync(int id);
        Task<bool> IsUserExistAsync(int id);
        Task<bool> IsUserExistAsync(string username);


        Task<bool> ChangeUserStatusAsync(int id, bool IsActive);
        Task<IEnumerable<CustomUserDto>> GetAllUsersAsync();

        Task<IEnumerable<CustomUserDto>> UsersFilterAsync(string Username);

    }
}
