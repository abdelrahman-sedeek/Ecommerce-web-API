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

                await context.ProductBrand.AddRangeAsync(brands);

            }

            if (!context.ProductType.Any())
            {
                var ProductTypeData = File.ReadAllText("../EcommerceAPI/Data/SeedData/types.json");
                var ProductTypes = JsonSerializer.Deserialize<List<ProductType>>(ProductTypeData);
                context.ProductType.AddRange(ProductTypes);
            }
            if (!context.Products.Any())
            {
                var ProductData = File.ReadAllText("../EcommerceAPI/Data/SeedData/products.json");
                var Products =JsonSerializer.Deserialize<List<Product>>(ProductData);
                context.Products.AddRange(Products);
            }
            if (context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();

          
        }
    }
}
