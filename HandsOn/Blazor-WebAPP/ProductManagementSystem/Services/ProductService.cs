using ProductManagementSystem.Models;
using System.Xml.Linq;

namespace ProductManagementSystem.Services
{
    public class ProductService
    {
        private readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Laptop", Price = 80000 },
        new Product { Id = 2, Name = "Mouse", Price = 1500 }
    };

        public List<Product> GetAll() => _products;

        public Product? GetById(int id) =>
            _products.FirstOrDefault(p => p.Id == id);

        public void Add(Product product)
        {
            product.Id = _products.Max(p => p.Id) + 1;
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var existing = GetById(product.Id);
            if (existing == null) return;

            existing.Name = product.Name;
            existing.Price = product.Price;
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
                _products.Remove(product);
        }
    }
}