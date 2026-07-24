using Business_Layer.Authorization;
using Business_Layer.DTOs;
using Business_Layer.Global.Enums;
using Business_Layer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.RateLimiting;

namespace University_Housing_Management_Project.Controllers
{

    [Authorize]
    [ApiController]
    [EnableRateLimiting("ApiLimiter")]
    [Route("api/StudentSubscriptions")]
    [Permission(UserPermission.SubscriptionManagement)]
    public class StudentSubscriptionsController : ControllerBase
    {

        private readonly IStudentSubscriptionService _studentSubscriptionService;
        private readonly IStudentService _studentService;
        public StudentSubscriptionsController(IStudentSubscriptionService studentSubscriptionService,
            IStudentService studentService)
        {

            _studentService = studentService;
            _studentSubscriptionService = studentSubscriptionService;
        }


        [HttpPost()]
        public async Task<IActionResult> AddStudentSubscription(string UniversityNumber,
            int subscriptionTypeId)
        {

            if (string.IsNullOrWhiteSpace(UniversityNumber) ||
                subscriptionTypeId <= 0 || subscriptionTypeId > 4)

                return BadRequest("Data is invalid.");

            if(! await _studentService.IsStudentExistAsync(UniversityNumber))
                return NotFound($"Student with university number {UniversityNumber} not found.");

            if(await _studentSubscriptionService.IsStudentSubscriptionExistAsync(UniversityNumber))
                return BadRequest($"Student with university number {UniversityNumber} have subscribe.");


            var StudentSubscription = await _studentSubscriptionService
                .AddStudentSubscriptionAsync(UniversityNumber, subscriptionTypeId);


            return StudentSubscription ? Ok() : BadRequest("Failed to add the student subscription.");
        }


        [HttpPut("DeactivateExpired")]
        public async Task<IActionResult> DeactivateExpiredSubscriptions()
        {

            return Ok(await _studentSubscriptionService.DeactivateExpiredSubscriptionsAsync());
        }

        
        [HttpPut("Renew")]
        public async Task<IActionResult> RenewSubscription(string UniversityNumber,
            int subscriptionTypeId, decimal latePenalty)
        {

            if (string.IsNullOrWhiteSpace(UniversityNumber) || latePenalty < 0
                || subscriptionTypeId <= 0 || subscriptionTypeId > 4)

                return BadRequest("Data is invalid.");

            if (!await _studentService.IsStudentExistAsync(UniversityNumber))
                return NotFound($"Student with university number {UniversityNumber} not found.");

            if (!await _studentSubscriptionService.IsStudentSubscriptionExistAsync(UniversityNumber))
                return BadRequest($"Student with university number {UniversityNumber} dont have subscribe.");


            var Renew = await _studentSubscriptionService.
                RenewSubscriptionAsync(UniversityNumber, subscriptionTypeId, latePenalty);

            return Renew ? Ok() : BadRequest("Failed to renew the student subscription.");
        }
        
        
        [HttpGet("IsExist/{UniversityNumber}")]
        public async Task<IActionResult> IsStudentSubscriptionExist(string UniversityNumber)
        {

            if(string.IsNullOrWhiteSpace(UniversityNumber))
                return BadRequest("Data is invalid."); ;

            if (!await _studentService.IsStudentExistAsync(UniversityNumber))
                return NotFound($"Student with university number {UniversityNumber} not found.");

            return Ok(await _studentSubscriptionService.
                IsStudentSubscriptionExistAsync(UniversityNumber));
        
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<AllSubscriptionsDto>>> GetAllSubscriptions()
        {

            return Ok(await _studentSubscriptionService.GetAllSubscriptionsAsync());
        }

        [HttpGet("Active")]
        public async Task<ActionResult<IEnumerable<AllSubscriptionsDto>>> GetAllActiveSubscriptions()
        {

            return Ok(await _studentSubscriptionService.GetAllActiveSubscriptionsAsync());
        }

        [HttpGet("Filter")]
        public async Task<ActionResult<IEnumerable<AllSubscriptionsDto>>> 
            SubscriptionsFilter([FromQuery] SubscriptionsFilterDto subscriptionsFilter)
        {

            return Ok(await _studentSubscriptionService.
                SubscriptionsFilterAsync(subscriptionsFilter));
        }


    }
}
