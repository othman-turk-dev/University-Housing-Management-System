using Business_Layer.DTOs.Auth;
using Business_Layer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace University_Housing_Management_Project.Controllers
{
    
    [ApiController]
    [Route("api/Auth")]
    [EnableRateLimiting("AuthLimiter")]
    public class AuthController : ControllerBase
    {
        
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
            => _authService = authService;


        [HttpPost("login")]
        public async Task<ActionResult<TokenResponse>> Login([FromBody] LoginRequest loginRequest)
        {

            var respone = await _authService.LoginAsync(loginRequest);

            return respone != null ? Ok(respone) : Unauthorized("Invalid credentials");
        }

        [HttpPost("refresh")]
        public async Task<ActionResult<TokenResponse>> Refresh([FromBody] RefreshRequest request)
        {

            var respone = await _authService.RefreshTokenAsync(request);

            return respone != null ? Ok(respone) : Unauthorized("Invalid refresh token");
        }

        [HttpPost("logout")]
        [EnableRateLimiting("ApiLimiter")]
        public async Task<IActionResult> Logout([FromBody] LogoutRequest request)
        {

            var respone = await _authService.LogoutAsync(request);

            return respone ? NoContent() : Unauthorized("Invalid refresh token");
        }

    }
}
