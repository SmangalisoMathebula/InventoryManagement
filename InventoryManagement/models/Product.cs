namespace InventoryManagement.Models;

public class Product
{
    public int ProductId { get; set; }
    public string Sku { get; set; } = "";
    public string Name { get; set; } = "";
    public int CategoryId { get; set; }
    public decimal CostPrice { get; set; }
    public decimal SellingPrice { get; set; }
    public int ReorderLevel { get; set; }
    public int QuantityOnHand { get; set; }
    public bool IsActive { get; set; } = true;

    public override string ToString() => $"{Sku} - {Name}";
}