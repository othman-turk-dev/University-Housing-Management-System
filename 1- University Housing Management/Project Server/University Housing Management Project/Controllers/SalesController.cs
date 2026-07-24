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
    [Route("api/Sales")]
    [EnableRateLimiting("ApiLimiter")]
    [Permission(UserPermission.Sales)]
    public class SalesController : ControllerBase
    {

        private readonly ISaleDetailService _saleDetailService;
        public SalesController(ISaleDetailService saleDetailService)
            => _saleDetailService = saleDetailService;


        [HttpPost()]
        public async Task<IActionResult> AddNewSale(List<SaleInfoDto> saleDetails)
        {

            var result = await _saleDetailService.AddNewSaleAsync(saleDetails);

            return result ? NoContent() : BadRequest("Failed to add the sale.");
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<SaleSummaryDto>>> GetAllSales()
        {

            return Ok(await _saleDetailService.GetAllSalesAsync());
        }

        [HttpGet("Month")]
        public async Task<ActionResult<IEnumerable<SaleSummaryDto>>> GetAllSalesInThisMonthAsync()
        {

            return Ok(await _saleDetailService.GetAllSalesInThisMonthAsync());
        }

        [HttpGet("Filter")]
        public async Task<ActionResult<IEnumerable<SaleSummaryDto>>> SalesFilter([FromQuery] SalesFilterDto salesFilter)
        {

            return Ok(await _saleDetailService.FilterSalesAsync(salesFilter));
        }

        [HttpGet("Details/{saleId}")]
        public async Task<ActionResult<IEnumerable<SaleDetailsByIdDto>>> GetAllSaleDetails(int saleId)
        {
            
            if(saleId <= 0)
                return BadRequest();

            return Ok(await _saleDetailService.GetAllSaleDetailsAsync(saleId));
        }

    }
}
