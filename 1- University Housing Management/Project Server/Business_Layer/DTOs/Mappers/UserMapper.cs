using Data_Access_Layer.Entities;

namespace Business_Layer.DTOs.Mappers
{
    public static class UserMapper
    {

        public static UserDto ToDto(User user)
        {
            return new UserDto
            {
                UserId = user.UserId,
                Username = user.Username,
                Password = user.Password,
                Permmission = user.Permmission,
                IsActive = user.IsActive
            };
        }
        public static User ToEntity(UserDto userDto)
        {
            return new User
            {
                UserId = userDto.UserId,
                Username = userDto.Username,
                Password = userDto.Password,
                Permmission = userDto.Permmission,
                IsActive = userDto.IsActive
            };
        }

    }
}
