using Data_Access_Layer.Entities;

namespace Business_Layer.Interfaces
{
    public interface IJwtService
    {
        string GenerateAccessToken(User user);
        string GenerateRefreshToken();

    }

}
