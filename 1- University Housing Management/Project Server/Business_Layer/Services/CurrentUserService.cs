using System.Security.Claims;
using Business_Layer.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Business_Layer.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
            => _httpContextAccessor = httpContextAccessor;

        public int UserId
        {
            get
            {
                var UserIdClaim = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                return int.TryParse(UserIdClaim, out int id) ? id : 0;
            }
        }

    }
}
