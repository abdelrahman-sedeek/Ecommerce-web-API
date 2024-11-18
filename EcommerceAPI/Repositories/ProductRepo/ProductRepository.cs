using EcommerceAPI.Core.Entities;
using EcommerceAPI.StoreContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Repositories.ProductRepo
{
    public class ProductRepository:IproductRepository
    {
        private readonly EcommerceContext _context;

        public ProductRepository(EcommerceContext Context )
        {
            _context = Context;
        }

        [HttpGet("{id}")]
        public async Task<Product> GetProductByIdAsync(int Id)
        {
            return await _context.Products
                .Include(p => p.productBrand)
                .Include(p=>p.ProductType)
                .FirstOrDefaultAsync(p=>p.Id==Id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products
                .Include(p => p.productBrand)
                .Include(p => p.ProductType)
                .ToListAsync();
        }

      
        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync()
        {
            return await _context.ProductBrand.ToListAsync();
        }

   
        public async Task<IReadOnlyList<ProductType>> GetProductTypesAsync()
        {
            return await _context.ProductType.ToListAsync();
            
        }
    }
}
