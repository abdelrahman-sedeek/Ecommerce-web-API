using EcommerceAPI._ُEntities;
using EcommerceAPI.StoreContext;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace EcommerceAPI.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync( EcommerceContext context)
        {
            if (!context.ProductBrand.Any())
            {
                var productBrandData = File.ReadAllText("../EcommerceAPI/Data/SeedData/brands.json");
                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(productBrandData);

                // Add ProductBrands and save changes
                await context.ProductBrand.AddRangeAsync(brands);
                await context.SaveChangesAsync();
            }

            if (!context.ProductType.Any())
            {
                var productTypeData = File.ReadAllText("../EcommerceAPI/Data/SeedData/types.json");
                var productTypes = JsonSerializer.Deserialize<List<ProductType>>(productTypeData);

                // Add ProductTypes and save changes
                context.ProductType.AddRange(productTypes);
                await context.SaveChangesAsync();
            }

            if (!context.Products.Any())
            {
                var productData = File.ReadAllText("../EcommerceAPI/Data/SeedData/products.json");
                var products = JsonSerializer.Deserialize<List<Product>>(productData);

                // Add Products and save changes
                context.Products.AddRange(products);
                await context.SaveChangesAsync();
            }
            //if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();


        }
    }
}
