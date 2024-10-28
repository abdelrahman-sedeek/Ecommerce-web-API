using EcommerceAPI._ُEntities;
using EcommerceAPI.StoreContext;
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

        public async Task<Product> GetProductByIdAsync(int Id)
        {
            return await _context.Products.FindAsync(Id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}
