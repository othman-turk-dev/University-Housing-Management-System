using Business_Layer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;
using Microsoft.AspNetCore.Authorization;

namespace University_Housing_Management_Project.Controllers
{

    [Authorize]
    [ApiController]
    [AllowAnonymous]
    [Route("api/Settings")]
    [EnableRateLimiting("ApiLimiter")]
    public class SettingsController : ControllerBase
    {

        private readonly ISettingsService _settingsService;

        public SettingsController(ISettingsService settingsService)
            => _settingsService = settingsService;

        
        [HttpGet("RoomCapacity")]
        public async Task<ActionResult<int>> GetRoomCapacity()
        {

            return Ok(await _settingsService.
                GetRoomCapacityAsync());
        }

    }
}
