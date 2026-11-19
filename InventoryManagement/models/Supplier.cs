namespace InventoryManagement.Models;

public class Supplier
{
    public int SupplierId { get; set; }
    public string Name { get; set; } = "";
    public string ContactPerson { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Email { get; set; } = "";

    public override string ToString() => Name;
}