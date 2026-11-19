using Microsoft.Data.Sqlite;

namespace InventoryManagement.Data;

public static class Database
{
    private static readonly string DbPath =
        Path.Combine(AppContext.BaseDirectory, "inventory.db");

    public static SqliteConnection GetConnection()
    {
        var conn = new SqliteConnection($"Data Source={DbPath}");
        conn.Open();

        using var cmd = conn.CreateCommand();
        cmd.CommandText = "PRAGMA foreign_keys = ON;";
        cmd.ExecuteNonQuery();

        return conn;
    }

    public static void Initialize()
    {
        using var conn = GetConnection();
        using var cmd = conn.CreateCommand();

        cmd.CommandText = @"
            CREATE TABLE IF NOT EXISTS Categories (
                CategoryId INTEGER PRIMARY KEY AUTOINCREMENT,
                Name       TEXT NOT NULL UNIQUE
            );

            CREATE TABLE IF NOT EXISTS Suppliers (
                SupplierId    INTEGER PRIMARY KEY AUTOINCREMENT,
                Name          TEXT NOT NULL,
                ContactPerson TEXT,
                Phone         TEXT,
                Email         TEXT
            );

            CREATE TABLE IF NOT EXISTS Products (
                ProductId      INTEGER PRIMARY KEY AUTOINCREMENT,
                Sku            TEXT NOT NULL UNIQUE,
                Name           TEXT NOT NULL,
                CategoryId     INTEGER NOT NULL,
                CostPrice      REAL NOT NULL DEFAULT 0,
                SellingPrice   REAL NOT NULL DEFAULT 0,
                ReorderLevel   INTEGER NOT NULL DEFAULT 0,
                QuantityOnHand INTEGER NOT NULL DEFAULT 0,
                IsActive       INTEGER NOT NULL DEFAULT 1,
                FOREIGN KEY (CategoryId) REFERENCES Categories(CategoryId)
            );

            CREATE TABLE IF NOT EXISTS StockMovements (
                MovementId INTEGER PRIMARY KEY AUTOINCREMENT,
                ProductId  INTEGER NOT NULL,
                Type       INTEGER NOT NULL,
                Quantity   INTEGER NOT NULL,
                Date       TEXT NOT NULL,
                Note       TEXT,
                FOREIGN KEY (ProductId) REFERENCES Products(ProductId)
            );

            INSERT OR IGNORE INTO Categories (Name) VALUES ('General');
        ";

        cmd.ExecuteNonQuery();
    }
}