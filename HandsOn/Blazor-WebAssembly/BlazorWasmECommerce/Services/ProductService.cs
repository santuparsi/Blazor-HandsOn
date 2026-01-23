using BlazorWasmECommerce.Models;

namespace BlazorWasmECommerce.Services;

public class ProductService
{
    public async Task<List<Product>> GetProductsAsync()
    {
        await Task.Delay(500); // simulate API
        return new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 75000 },
            new Product { Id = 2, Name = "Phone", Price = 35000 },
            new Product { Id = 3, Name = "Headphones", Price = 5000 }
        };
    }

    public async Task<Product> GetProductByIdAsync(int id)
    {
        var products = await GetProductsAsync();
        return products.First(p => p.Id == id);
    }
}
