using EcommerceAPI.Core.Entities;

namespace EcommerceAPI.Repositories.ProductRepo
{
    public interface IproductRepository
    {
        

        Task<Product> GetProductByIdAsync(int Id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
        Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
       
    }
}
