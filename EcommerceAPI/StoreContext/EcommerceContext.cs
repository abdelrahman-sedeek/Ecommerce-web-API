using EcommerceAPI._ُEntities;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.StoreContext
{
    public class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrand { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
    }
}
