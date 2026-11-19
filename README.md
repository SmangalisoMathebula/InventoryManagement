 Inventory Management System

A Windows Forms desktop application for managing products and stock. It is built with C# and uses a local SQLite database, so there is nothing to install or configure to run it.


 About the Project

This project is a simple inventory tool for small businesses. At the moment it covers product management, and it is being extended step by step into a full inventory and business management system with suppliers, stock movements, purchase orders and reports.

The code is split into layers. The screens never contain SQL. They call repository classes, which talk to the database, and data classes carry the information between them. All database queries use parameters, which protects against SQL injection.

 Features

- Add, edit, search and delete products
- Live search by SKU or product name
- Input validation for required fields, duplicate SKUs and unusual prices
- Soft delete, so product history is preserved
- Database and tables created automatically on first run

 Tech Stack

- C#
- .NET and Windows Forms
- SQLite through the Microsoft.Data.Sqlite package
- Visual Studio

 Project Structure

- models: data classes such as Product, Category, Supplier and StockMovement
- Data: database setup and the repository classes that run the queries
- Forms**: the Windows Forms screens
- Program.cs: the application entry point

## Getting Started

To run the project:

1. Clone the repository from `https://github.com/SmangalisoMathebula/InventoryManagement.git`
2. Open `InventoryManagement.sln` in Visual Studio
3. Press F5 to build and run

No database setup is needed. The tables are created the first time the app starts.

 Roadmap

- Products screen (done)
- Suppliers and categories screens
- Stock movements
- Purchase orders
- Reports
- Login and user roles

 Author

Smangaliso Mathebula

GitHub: [@SmangalisoMathebula](https://github.com/SmangalisoMathebula)
