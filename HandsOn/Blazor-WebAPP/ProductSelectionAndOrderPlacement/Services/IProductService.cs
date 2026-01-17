using ProductSelectionAndOrderPlacement.Models;

namespace ProductSelectionAndOrderPlacement.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
    }
}
