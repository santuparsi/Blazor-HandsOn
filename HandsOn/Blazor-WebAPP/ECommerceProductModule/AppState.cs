using ECommerceProductModule;

public class AppState
{
    public List<Product> Products { get; private set; } = new();
    public Product? SelectedProduct { get; private set; }

    public event Action? OnChange;

    public void Load()
    {
        Products = new()
        {
            new Product { Id = 1, Name = "Laptop", Price = 75000 },
            new Product { Id = 2, Name = "Headphones", Price = 2500 }
        };
        Notify();
    }

    public void Add(Product product)
    {
        product.Id = Products.Any() ? Products.Max(p => p.Id) + 1 : 1;
        Products.Add(product);
        Notify();
    }

    public void Update(Product product)
    {
        var existing = Products.First(p => p.Id == product.Id);
        existing.Name = product.Name;
        existing.Price = product.Price;
        Notify();
    }

    public void Delete(int id)
    {
        Products.RemoveAll(p => p.Id == id);
        Notify();
    }

    public void Select(int id)
    {
        SelectedProduct = Products.First(p => p.Id == id);
        Notify();
    }

    public void ClearSelection()
    {
        SelectedProduct = null;
        Notify();
    }

    private void Notify() => OnChange?.Invoke(); // Notify subscribers about state changes
}
