using Business_Layer.DTOs;
using Business_Layer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace University_Housing_Management_Project.Controllers
{

    [Authorize]
    [ApiController]
    [AllowAnonymous]
    [Route("api/SubscriptionTypes")]
    [EnableRateLimiting("ApiLimiter")]
    public class SubscriptionTypesController : ControllerBase
    {
        private readonly ISubscriptionTypeService _subscriptionTypeService;
        public SubscriptionTypesController(ISubscriptionTypeService subscriptionTypeService)
            => _subscriptionTypeService = subscriptionTypeService;


        [HttpGet("{SubscriptionTypeId}")]
        public async Task<ActionResult<SubscriptionTypeDto>> GetSubscriptionTypeById(int SubscriptionTypeId)
        {

            if (SubscriptionTypeId <= 0)
                return BadRequest();

            var SubscriptionType = await _subscriptionTypeService.GetSubscriptionTypeByIdAsync(SubscriptionTypeId);

            return SubscriptionType == null ? NotFound() : Ok(SubscriptionType);
        }

        [HttpGet("Description/{Description}")]
        public async Task<ActionResult<SubscriptionTypeDto>> GetSubscriptionTypeByDescription(string Description)
        {

            if (string.IsNullOrWhiteSpace(Description))
                return BadRequest();

            var SubscriptionType = await _subscriptionTypeService.GetSubscriptionTypeByDescriptionAsync(Description);

            return SubscriptionType == null ? NotFound() : Ok(SubscriptionType);
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerator<SubscriptionTypeDto>>> GetAllSubscriptionTypes()
        {

            return Ok(await _subscriptionTypeService.GetAllSubscriptionTypesAsync());
        }


    }
}
