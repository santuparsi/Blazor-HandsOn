namespace BlazorApp.Web.Services
{
    public class ProductService : IProductService
    {
        public async Task<List<string>> GetProductsAsync()
        {
            // Removed ToListAsync(), as List<string> is already a list and does not require async conversion.
            return await Task.FromResult(new List<string>
            {
                "Laptop", "Keyboard"
            });
        }
    }
}
