namespace ProductSelectionAndOrderPlacement.Models
{
    public class Order
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
