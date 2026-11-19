namespace InventoryManagement.Models;

public enum MovementType
{
    Received,
    Sold,
    Adjustment,
    Damaged
}

public class StockMovement
{
    public int MovementId { get; set; }
    public int ProductId { get; set; }
    public MovementType Type { get; set; }
    public int Quantity { get; set; }      // positive = in, negative = out
    public DateTime Date { get; set; } = DateTime.Now;
    public string Note { get; set; } = "";
}