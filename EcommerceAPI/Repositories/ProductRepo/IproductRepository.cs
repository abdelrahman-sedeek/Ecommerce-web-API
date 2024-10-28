using EcommerceAPI._ُEntities;

namespace EcommerceAPI.Repositories.ProductRepo
{
    public interface IproductRepository
    {
        

        Task<Product> GetProductByIdAsync(int Id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
       
    }
}
