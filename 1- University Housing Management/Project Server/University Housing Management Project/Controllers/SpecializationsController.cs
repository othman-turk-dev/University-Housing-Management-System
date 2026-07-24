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
    [Route("api/Specializations")]
    [EnableRateLimiting("ApiLimiter")]
    public class SpecializationsController : ControllerBase
    {

        private readonly ISpecializationService _specializationService;

        public SpecializationsController(ISpecializationService specializationService) 
            => _specializationService = specializationService;


        [HttpGet()]
        public async Task<ActionResult<IEnumerable<string>>> GetAllSpecializations()
        {
            return Ok(await _specializationService.GetAll());
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<SpecializationDto>> GetSpecializationById(int id)
        {

            if (id <= 0)
            {
                return BadRequest("Invalid specialization ID.");
            }

            var specialization = await _specializationService.GetByIdAsync(id);

            if (specialization == null)
                return NotFound("Specialization not found.");

            return Ok(specialization);
        }

        [HttpGet("Name/{name}")]
        public async Task<ActionResult<SpecializationDto>> GetSpecializationByName(string name)
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Invalid specialization name.");
            }

            var specialization = await _specializationService.GetByNameAsync(name);

            if (specialization == null)
                return NotFound("Specialization not found.");

            return Ok(specialization);
        }

        [HttpGet("Statistics")]
        public async Task<ActionResult<IEnumerable<SpecializationStatisticsDto>>> GetSpecializationStatistics()
        {
            return Ok(await _specializationService.GetSpecializationStatisticsAsync());
        }

    }
}