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
    [Route("api/Bank")]
    [EnableRateLimiting("ApiLimiter")]
    [Permission(UserPermission.BankManagment)]
    public class BankController : ControllerBase
    {

        private readonly IBankService _bankService;
        public BankController(IBankService bankService)
            => _bankService = bankService;


        [HttpGet("StudentOperations")]
        public async Task<ActionResult<IEnumerable<StudentOperationsDto>>> GetAllStudentOperations()
        {

            return Ok(await _bankService.GetAllStudentOperationsAsync());
        }

        [HttpGet("StudentOperations/ThisMonth")]
        public async Task<ActionResult<IEnumerable<StudentOperationsDto>>> GetAllStudentOperationsThisMonth()
        {

            return Ok(await _bankService.GetAllStudentOperationsInThisMonthAsync());
        }

        [HttpGet("StudentOperations/Filter")]
        public async Task<ActionResult<IEnumerable<StudentOperationsDto>>> 
            FilterStudentOperations([FromQuery] StudentOperationsFilterDto filterDto)
        {

            return Ok(await _bankService.StudentOperationsFilterAsync(filterDto));
        }


        [HttpGet("StoreOperations")]
        public async Task<ActionResult<IEnumerable<StoreOperationsDto>>> GetAllStoreOperations()
        {

            return Ok(await _bankService.GetAllStoreOperationsAsync());
        }

        [HttpGet("StoreOperations/ThisMonth")]
        public async Task<ActionResult<IEnumerable<StoreOperationsDto>>> GetAllStoreOperationsInThisMonth()
        {

            return Ok(await _bankService.GetAllStoreOperationsInThisMonthAsync());
        }

        [HttpGet("StoreOperations/Filter")]
        public async Task<ActionResult<IEnumerable<StoreOperationsDto>>>
            FilterStoreOperations([FromQuery] StoreOperationsFilterDto filterDto)
        {

            return Ok(await _bankService.StoreOperationsFilterAsync(filterDto));
        }


    }
}
