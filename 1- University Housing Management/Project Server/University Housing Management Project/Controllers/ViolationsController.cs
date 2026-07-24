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
    [Route("api/Violations")]
    [EnableRateLimiting("ApiLimiter")]
    [Permission(UserPermission.Violations)]
    public class ViolationsController : ControllerBase
    {

        private readonly IStudentService _studentService;
        private readonly IViolationService _violationService;
        private readonly IViolationTypeService _violationTyprService;
        public ViolationsController(IViolationService violationService,
            IViolationTypeService violationTypeService, IStudentService studentService)
        {

            _studentService = studentService;
            _violationService = violationService;
            _violationTyprService = violationTypeService;
        }



        [HttpPost()]
        public async Task<ActionResult<ViolationDto>> AddViolation(AddViolationDto violation)
        {

            if (violation == null || string.IsNullOrWhiteSpace(violation.UniversityNumber) ||
                violation.ViolationTypeId <= 0)

                return BadRequest("Violation data is invalid.");


            if (!await _violationTyprService.
                IsViolationTypeExistAsync(violation.ViolationTypeId))

                return NotFound($"Violation type with ID {violation.ViolationTypeId} not found.");

            if (!await _studentService.IsStudentExistAsync(violation.UniversityNumber))
                return NotFound($"Student with university number {violation.UniversityNumber} not found.");


            var addedViolation = await _violationService.AddViolationAsync(violation);

            if (addedViolation == null)
                return BadRequest("Failed to add the violation.");


            return CreatedAtRoute("GetViolationById",
                new { violationId = addedViolation.ViolationId }, addedViolation);

        }

        
        [HttpPut("{violationId}/pay")]
        public async Task<IActionResult> PayFineForViolation(int violationId)
        {

            if (violationId <= 0)
                return BadRequest("Violation data is invalid.");

            if (!await _violationService.IsViolationExistAsync(violationId))
                return NotFound($"Violation with ID {violationId} not found.");


            var result = await _violationService.PayFineForViolationAsync(violationId);
                
            return result ? NoContent(): NotFound($"Violation with ID {violationId} payment failed.");
        }

        
        [HttpDelete("{violationId}")]
        public async Task<IActionResult> DeleteViolationById(int violationId)
        {

            if(violationId <= 0) 
                return BadRequest("Violation data is invalid.");

            if(! await _violationService.IsViolationExistAsync(violationId))
                return NotFound($"Violation with ID {violationId} not found.");


            var result = await _violationService.DeleteViolationAsync(violationId);

            return result ? NoContent() : NotFound($"Violation with ID {violationId} deletion failed.");
        }

        
        [HttpGet("{violationId}", Name = "GetViolationById")]
        public async Task<ActionResult<ViolationDto>> GetViolationById(int violationId)
        {

            if(violationId < 0)
                return BadRequest("Violation data is invalid.");

            var exist = await _violationService.GetViolationByIdAsync(violationId);

            if (exist == null)
                return NotFound($"Violation with violation Id {violationId} not found.");


            return Ok(exist);
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<AllViolationsDto>>> GetAllViolations()
        {

            return Ok(await _violationService.GetAllViolationsAsync());
        }

        [HttpGet("Filter")]
        public async Task<ActionResult<IEnumerable<AllViolationsDto>>> ViolationsFilter([FromQuery] ViolationsFilterDto violationsFilter)
        {

            return Ok(await _violationService.ViolationsFilterAsync(violationsFilter));
        }


        [HttpGet("Student/{UniversityNumber}/Details")]
        public async Task<ActionResult<IEnumerable<ViolationDetailsDto>>> GetViolationDetails(string UniversityNumber)
        {

            if(string.IsNullOrWhiteSpace(UniversityNumber))
                return BadRequest("Violation data is invalid.");

            if (! await _studentService.IsStudentExistAsync(UniversityNumber))
                return NotFound($"Student with university number {UniversityNumber} not found.");

            return Ok(await _violationService.GetViolationDetailsAsync(UniversityNumber));
        }
        
        [HttpGet("Statistics")]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ViolationRateDto>>> GetStatisticsForViolations()
        {

            return Ok(await _violationService.GetStatisticsForViolationsAsync());
        }

    }
}
