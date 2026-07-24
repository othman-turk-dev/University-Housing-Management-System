using Business_Layer.DTOs.Auth;
using Business_Layer.Interfaces;
using Data_Access_Layer.Entities;
using Data_Access_Layer.Repository.Interfaces;
using Microsoft.Extensions.Logging;

namespace Business_Layer.Services
{
    public class AuthService : IAuthService
    {

        private readonly IJwtService _jwtService;
        private readonly ILogger<AuthService> _logger;
        private readonly IUserRepositry _userRepositry;
        public AuthService(IUserRepositry userRepositry, IJwtService jwtService,
            ILogger<AuthService> logger)
        {
            
            _logger = logger;
            _userRepositry = userRepositry;
            _jwtService = jwtService;
        }

        public async Task<TokenResponse?> LoginAsync(LoginRequest request)
        {
            
            var User = await _userRepositry.GetUserByUsernameAsync(request.Username);

            if (User == null)
            {

                _logger.LogInformation("Login faild with {request.Username}"
                    , request.Username);

                return null;
            }
                

            if(! BCrypt.Net.BCrypt.Verify(request.Password, User.Password))
            {

                _logger.LogInformation("Login faild with {request.Username}"
                    , request.Username);
                return null; 
            }

            if(! User.IsActive)
            {
                return null;
            }

            var accessToken = _jwtService.GenerateAccessToken(User);
            var refreshToken = _jwtService.GenerateRefreshToken();

            User.RefreshToken = BCrypt.Net.BCrypt.HashPassword(refreshToken);
            User.RefreshTokenExpiresAt = DateTime.UtcNow.AddDays(7);
            User.RefreshTokenRevokedAt = null;

            var userUpdated = await _userRepositry.UpdateUserAsync(User);

            if (userUpdated == null)
                return null;

            _logger.LogInformation("Login successfuly with {request.Username}"
                    , request.Username);

            return new TokenResponse
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken
            };
        }
        public async Task<bool> LogoutAsync(LogoutRequest logoutRequest)
        {

            var user = await _userRepositry.
                GetUserByUsernameAsync(logoutRequest.Username);

            if (user == null) 
                return false;

            if(! BCrypt.Net.BCrypt.Verify(logoutRequest.RefreshToken, user.RefreshToken))
                return false;

            user.RefreshTokenRevokedAt = DateTime.UtcNow;

            var userUpdated = await _userRepositry.UpdateUserAsync(user);

            if (userUpdated == null)
                return false;


            _logger.LogInformation("User {request.Username} logout successfuly"
                , logoutRequest.Username);

            return true;
        }
        public async Task<TokenResponse?> RefreshTokenAsync(RefreshRequest request)
        {

            var user = await _userRepositry.GetUserByUsernameAsync(request.Username);

            if (user == null)
                return null;

            if(user.RefreshTokenRevokedAt.HasValue) 
                return null;

            if(user.RefreshTokenExpiresAt <= DateTime.UtcNow) 
                return null;

            if(! BCrypt.Net.BCrypt.Verify(request.RefreshToken, user.RefreshToken))
                return null;

            var newAccessToken = _jwtService.GenerateAccessToken(user);
            var newRefreshToken = _jwtService.GenerateRefreshToken();

            user.RefreshToken = BCrypt.Net.BCrypt.HashPassword(newRefreshToken);
            user.RefreshTokenExpiresAt = DateTime.UtcNow.AddDays(7);
            user.RefreshTokenRevokedAt = null;

            var userUpdated = await _userRepositry.UpdateUserAsync(user);

            if (userUpdated == null)
                return null;

            _logger.LogInformation("Refresh successfuly with {request.Username}"
                    , request.Username);

            return new TokenResponse
            {
                AccessToken = newAccessToken,
                RefreshToken = newRefreshToken
            };
        }

    }
}
