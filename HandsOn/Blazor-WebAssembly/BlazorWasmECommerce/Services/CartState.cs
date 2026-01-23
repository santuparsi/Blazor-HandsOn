using BlazorWasmECommerce.Models;

namespace BlazorWasmECommerce.Services;

public class CartState
{
    public List<CartItem> Items { get; } = new();
    public event Action OnChange;

    public void Add(Product product)
    {
        var item = Items.FirstOrDefault(i => i.Product.Id == product.Id);

        if (item == null)
            Items.Add(new CartItem { Product = product });
        else
            item.Quantity++;

        OnChange?.Invoke();
    }

    public decimal Total => Items.Sum(i => i.Product.Price * i.Quantity);
    public void Increase(CartItem item)
    {
        item.Quantity++;
        OnChange?.Invoke();
    }

    public void Decrease(CartItem item)
    {
        item.Quantity--;

        if (item.Quantity <= 0)
            Items.Remove(item);

        OnChange?.Invoke();
    }

}
