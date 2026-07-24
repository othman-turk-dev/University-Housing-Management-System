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
    [Route("api/Products")]
    [EnableRateLimiting("ApiLimiter")]
    [Permission(UserPermission.Products)]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
            => _productService  = productService;
        

        [HttpPost()]
        public async Task<ActionResult<AddProductDto>> AddProduct(AddProductDto product)
        {

            if (product == null || string.IsNullOrWhiteSpace(product.ProductId) ||
                string.IsNullOrWhiteSpace(product.ProductName)) 

                return BadRequest("Product data is invalid.");

            if(product.PurchasePrice < 0 || product.Price <= 0 || product.Quantity <= 0)
                return BadRequest("Product data is invalid.");

            if(await _productService.IsProductExistAsync(product.ProductId))
                return BadRequest("Product with the same product Id already exists.");


            var addedProduct = await _productService.AddProductAsync(product);

            return addedProduct == null ? BadRequest("Failed to add the product.") : Ok(addedProduct);
        }

        [HttpPut()]
        public async Task<ActionResult<bool>> UpdateStudent([FromBody] UpdateProductDto product)
        {

            if (!await _productService.IsProductExistAsync(product.ProductId))
                return NotFound($"Product with {product.ProductId} not found.");

            var updatedStudent = await _productService.UpdateProductAsync(product);

            return updatedStudent ? Ok(updatedStudent) 
                : NotFound($"Product with {product.ProductId} update failed.");
        }

        [HttpPut("AddNewQuantity")]
        public async Task<ActionResult<bool>> AddNewQuantity(AddQuantityDto product)
        {

            if(product == null || string.IsNullOrWhiteSpace(product.ProductId) )
                return BadRequest("Product data is invalid.");

            if (product.PurchasePrice < 0 || product.Price <= 0 || product.Quantity <= 0)
                return BadRequest("Product data is invalid.");

            if (! await _productService.IsProductExistAsync(product.ProductId))
                return NotFound($"Product with product Id {product.ProductId} not found.");

            var addNewQuantity = await _productService.AddNewQuantityAsync(product);
 
            return addNewQuantity ? Ok(addNewQuantity) : BadRequest("Failed to add the quantity.");
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ProductDto>> GetProductById(string productId)
        {

            if (string.IsNullOrWhiteSpace(productId))
                return BadRequest("Product data is invalid.");

            var product = await _productService.GetProductByIdAsync(productId);

            return product != null ? Ok(product) : 
                NotFound($"Product with product Id {productId} not found.");
        }

        [HttpGet("IsExist/{productId}")]
        public async Task<ActionResult<bool>> IsProductExist(string productId)
        {

            if (string.IsNullOrWhiteSpace(productId))
                return BadRequest("Invalid product id.");

            var exists = await _productService.IsProductExistAsync(productId);

            if (!exists)
                return NotFound($"Product with {productId} not found.");

            return Ok(exists);
        }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<AllProductsDto>>> AllProducts()
        {

            return Ok(await _productService.GetAllProductsAsync());
        }

        [HttpGet("Filter")]
        public async Task<ActionResult<IEnumerable<AllProductsDto>>> ProductsFilter([FromQuery] string? Product)
        {

            return Ok(await _productService.ProductsFilterAsync(Product));
        }

        [AllowAnonymous]
        [HttpGet("WithoutDetails")]
        public async Task<ActionResult<IEnumerable<AllProductsWithoutDetailsDto>>> AllProductsWithoutDetails()
        {

            return Ok(await _productService.GetAllProductsWithoutDetailsAsync());
        }

        
        [HttpGet("WithoutDetails/Filter")]
        public async Task<ActionResult<IEnumerable<AllProductsWithoutDetailsDto>>>
            ProductsFilterWithoutDetails([FromQuery] string? Product)
        {

            return Ok(await _productService.ProductsFilterWithoutDetailsAsync(Product));
        }


        [HttpGet("TotalPrice")]
        public async Task<ActionResult<decimal>> TotalPrice()
        {

            return Ok(await _productService.TotalPriceAsync());
        }

    }
}
