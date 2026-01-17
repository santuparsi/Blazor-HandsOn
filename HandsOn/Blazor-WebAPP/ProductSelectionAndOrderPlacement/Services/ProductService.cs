using ProductSelectionAndOrderPlacement.Models;

namespace ProductSelectionAndOrderPlacement.Services
{
    public class ProductService : IProductService
    {
        public async Task<List<Product>> GetProductsAsync()
        {
            await Task.Delay(500);
            return new List<Product>
        {
            new() { Id = 1, Name = "Laptop", Price = 50000 },
            new() { Id = 2, Name = "Mouse", Price = 500 },
            new() { Id = 3, Name = "Keyboard", Price = 1500 }
        };
        }
    }

}
