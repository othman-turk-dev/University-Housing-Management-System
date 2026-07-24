using Data_Access_Layer.Entities;

namespace Business_Layer.DTOs.Mappers
{
    public static class SimpleUserMapper
    {

        public static SimpleUserDto ToDto(User user)
        {
            return new SimpleUserDto
            {
                UserId = user.UserId,
                Username = user.Username,
                Permmission = user.Permmission,
                IsActive = user.IsActive
            };
        }
    }
}
