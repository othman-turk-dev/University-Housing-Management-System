using Business_Layer.DTOs.Auth;

namespace Business_Layer.Interfaces
{
    public interface IAuthService
    {
        Task<TokenResponse?> LoginAsync(LoginRequest request);
        Task<TokenResponse?> RefreshTokenAsync(RefreshRequest request);
        Task<bool> LogoutAsync(LogoutRequest logoutRequest);
    }
}
