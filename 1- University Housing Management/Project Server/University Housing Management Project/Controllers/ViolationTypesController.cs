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
    [Route("api/ViolationTypes")]
    [EnableRateLimiting("ApiLimiter")]
    public class ViolationTypesController : ControllerBase
    {

        private readonly IViolationTypeService _violationTypeService;

        public ViolationTypesController(IViolationTypeService violationTypeService)
        => _violationTypeService = violationTypeService;


        [HttpGet()]
        public async Task<ActionResult<IEnumerable<ViolationTypeDto>>> GetAllViolationTypes()
        {

            return Ok(await _violationTypeService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ViolationTypeDto>> GetViolationTypeById(int id)
        {
            var violationType = await _violationTypeService.GetViolationTypeByIdAsync(id);

            if (violationType == null)
                return NotFound("Violation type not found");

            return Ok(violationType);
        }

        [HttpGet("Name/{name}")]
        public async Task<ActionResult<ViolationTypeDto>> GetViolationTypeByName(string name)
        {
            var violationType = await _violationTypeService.GetViolationTypeByNameAsync(name);

            if (violationType == null)
                return NotFound("Violation type not found");

            return Ok(violationType);
        }

    }
}
