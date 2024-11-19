using EcommerceAPI.Core.Entities;
using EcommerceAPI.Core.Interfaces;
using EcommerceAPI.Repositories.ProductRepo;
using EcommerceAPI.StoreContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace EcommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IGenericRepository<Product> _productRepo;
        private readonly IGenericRepository<ProductBrand> _brandRepo;
        private readonly IGenericRepository<ProductType> _typeRepo;

        public ProductsController(IGenericRepository <Product> productRepo ,
        IGenericRepository<ProductBrand>brandRepo,
        IGenericRepository<ProductType> typeRepo)
        {
            _productRepo= productRepo;
            _brandRepo = brandRepo;
            _typeRepo = typeRepo;
        }

        [HttpGet]
        public async Task< ActionResult<List<Product>>> Getproducts()
        {
            var products = await _productRepo.ListAllAsync();
            return Ok(products);
        } 
        [HttpGet("{id}")]
        public async Task< ActionResult<Product>> GetProduct(int id)
        {
            return await _productRepo.GetByIdAsync(id);
            
        }
        [HttpGet("brands")]
        public async Task<ActionResult<List<ProductType>>> GetProductBrands()
        {
            return  Ok(await _brandRepo.ListAllAsync());
        }
        [HttpGet("types")]
        public async Task<ActionResult<List<ProductType>>> GetProductTypes()
        {
            return  Ok(await _typeRepo.ListAllAsync());
        }
    }
}
