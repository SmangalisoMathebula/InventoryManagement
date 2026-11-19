using Microsoft.Data.Sqlite;
using InventoryManagement.Models;

namespace InventoryManagement.Data;

public class CategoryRepository
{
    public List<Category> GetAll()
    {
        var list = new List<Category>();
        using var conn = Database.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "SELECT CategoryId, Name FROM Categories ORDER BY Name";

        using var r = cmd.ExecuteReader();
        while (r.Read())
        {
            list.Add(new Category
            {
                CategoryId = r.GetInt32(0),
                Name = r.GetString(1)
            });
        }
        return list;
    }

    public void Add(string name)
    {
        using var conn = Database.GetConnection();
        using var cmd = conn.CreateCommand();
        cmd.CommandText = "INSERT INTO Categories (Name) VALUES (@name)";
        cmd.Parameters.AddWithValue("@name", name);
        cmd.ExecuteNonQuery();
    }
}