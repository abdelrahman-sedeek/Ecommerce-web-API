﻿using EcommerceAPI.Core.Entities;
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
        private readonly IproductRepository _repo;

        public ProductsController(IproductRepository Repo)
        {

            _repo = Repo;
        }

        [HttpGet]
        public async Task< ActionResult<List<Product>>> Getproducts()
        {
            var products = await _repo.GetProductsAsync();
            return Ok(products);
        } 
        [HttpGet("{id}")]
        public async Task< ActionResult<Product>> GetProduct(int id)
        {
            return await _repo.GetProductByIdAsync(id);
            
        }
        [HttpGet("brands")]
        public async Task<ActionResult<List<ProductType>>> GetProductBrands()
        {
            return  Ok(await _repo.GetProductBrandsAsync());
        }
        [HttpGet("types")]
        public async Task<ActionResult<List<ProductType>>> GetProductTypes()
        {
            return  Ok(await _repo.GetProductTypesAsync());
        }
    }
}
