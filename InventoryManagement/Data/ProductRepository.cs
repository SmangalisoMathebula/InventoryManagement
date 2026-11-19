using Microsoft.Data.Sqlite;
using InventoryManagement.Models;

namespace InventoryManagement.Data;

public class ProductRepository
{
    public List<Product> GetAll(string search = "")
    {
        var list = new List<Product>();
        using var conn = Database.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            SELECT ProductId, Sku, Name, CategoryId, CostPrice,
                   SellingPrice, ReorderLevel, QuantityOnHand, IsActive
            FROM Products
            WHERE IsActive = 1 AND (Sku LIKE @s OR Name LIKE @s)
            ORDER BY Name";
        cmd.Parameters.AddWithValue("@s", $"%{search}%");

        using var r = cmd.ExecuteReader();
        while (r.Read())
        {
            list.Add(new Product
            {
                ProductId = r.GetInt32(0),
                Sku = r.GetString(1),
                Name = r.GetString(2),
                CategoryId = r.GetInt32(3),
                CostPrice = (decimal)r.GetDouble(4),
                SellingPrice = (decimal)r.GetDouble(5),
                ReorderLevel = r.GetInt32(6),
                QuantityOnHand = r.GetInt32(7),
                IsActive = r.GetInt32(8) == 1
            });
        }
        return list;
    }

    public void Add(Product p)
    {
        using var conn = Database.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            INSERT INTO Products (Sku, Name, CategoryId, CostPrice, SellingPrice, ReorderLevel)
            VALUES (@sku, @name, @cat, @cost, @sell, @reorder)";
        cmd.Parameters.AddWithValue("@sku", p.Sku);
        cmd.Parameters.AddWithValue("@name", p.Name);
        cmd.Parameters.AddWithValue("@cat", p.CategoryId);
        cmd.Parameters.AddWithValue("@cost", (double)p.CostPrice);
        cmd.Parameters.AddWithValue("@sell", (double)p.SellingPrice);
        cmd.Parameters.AddWithValue("@reorder", p.ReorderLevel);
        cmd.ExecuteNonQuery();
    }

    public void Update(Product p)
    {
        using var conn = Database.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = @"
            UPDATE Products
            SET Sku = @sku, Name = @name, CategoryId = @cat,
                CostPrice = @cost, SellingPrice = @sell, ReorderLevel = @reorder
            WHERE ProductId = @id";
        cmd.Parameters.AddWithValue("@id", p.ProductId);
        cmd.Parameters.AddWithValue("@sku", p.Sku);
        cmd.Parameters.AddWithValue("@name", p.Name);
        cmd.Parameters.AddWithValue("@cat", p.CategoryId);
        cmd.Parameters.AddWithValue("@cost", (double)p.CostPrice);
        cmd.Parameters.AddWithValue("@sell", (double)p.SellingPrice);
        cmd.Parameters.AddWithValue("@reorder", p.ReorderLevel);
        cmd.ExecuteNonQuery();
    }

    // Soft delete: hides the product but keeps its stock history intact
    public void Delete(int productId)
    {
        using var conn = Database.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "UPDATE Products SET IsActive = 0 WHERE ProductId = @id";
        cmd.Parameters.AddWithValue("@id", productId);
        cmd.ExecuteNonQuery();
    }
}