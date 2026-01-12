using HandsOnBlazorRoutingAndNavigation.Models;
using System.Xml.Linq;

namespace HandsOnBlazorRoutingAndNavigation.Services
{
    public class ProductService
    {
        private static readonly List<Product> _products = new();
        private int _id = 1;

        public List<Product> GetAll() => _products;

        public Product? GetById(int id) =>
            _products.FirstOrDefault(p => p.Id == id);

        public void Add(Product product)
        {
            product.Id = _id++;
            _products.Add(product);
        }

        public void Update(Product product)
        {
            var existing = GetById(product.Id);
            if (existing == null) return;

            existing.Name = product.Name;
            existing.Price = product.Price;
            existing.Stock = product.Stock;
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
                _products.Remove(product);
        }
    }

}
