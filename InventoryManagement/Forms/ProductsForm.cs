using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.Data.Sqlite;

namespace InventoryManagement.Forms;

public partial class ProductsForm : Form
{
    private readonly ProductRepository _products = new();
    private readonly CategoryRepository _categories = new();
    private int _selectedId = 0;   // 0 = nothing selected

    public ProductsForm()
    {
        InitializeComponent();
        dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
    }

    private void ProductsForm_Load(object sender, EventArgs e)
    {
        cmbCategory.DataSource = _categories.GetAll();
        cmbCategory.DisplayMember = "Name";
        cmbCategory.ValueMember = "CategoryId";
        LoadGrid();
    }

    private void LoadGrid()
    {
        dgvProducts.DataSource = _products.GetAll(txtSearch.Text.Trim());

        foreach (var col in new[] { "ProductId", "CategoryId", "IsActive" })
        {
            if (dgvProducts.Columns[col] != null)
                dgvProducts.Columns[col]!.Visible = false;
        }
        dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        ClearForm();
    }

    private void ClearForm()
    {
        _selectedId = 0;
        txtSku.Clear();
        txtName.Clear();
        numCost.Value = 0;
        numSell.Value = 0;
        numReorder.Value = 0;
        if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;
        dgvProducts.ClearSelection();
    }

    // Reads the inputs into a Product, or shows a message and returns null
    private Product? ReadInputs()
    {
        if (string.IsNullOrWhiteSpace(txtSku.Text))
        {
            MessageBox.Show("SKU is required.");
            return null;
        }
        if (string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Name is required.");
            return null;
        }
        if (cmbCategory.SelectedValue == null)
        {
            MessageBox.Show("Please choose a category.");
            return null;
        }
        if (numSell.Value < numCost.Value)
        {
            var answer = MessageBox.Show(
                "Selling price is lower than cost price. Continue?",
                "Check prices", MessageBoxButtons.YesNo);
            if (answer == DialogResult.No) return null;
        }

        return new Product
        {
            ProductId = _selectedId,
            Sku = txtSku.Text.Trim(),
            Name = txtName.Text.Trim(),
            CategoryId = (int)cmbCategory.SelectedValue,
            CostPrice = numCost.Value,
            SellingPrice = numSell.Value,
            ReorderLevel = (int)numReorder.Value
        };
    }

    private void dgvProducts_SelectionChanged(object? sender, EventArgs e)
    {
        if (dgvProducts.CurrentRow?.DataBoundItem is not Product p) return;

        _selectedId = p.ProductId;
        txtSku.Text = p.Sku;
        txtName.Text = p.Name;
        cmbCategory.SelectedValue = p.CategoryId;
        numCost.Value = p.CostPrice;
        numSell.Value = p.SellingPrice;
        numReorder.Value = p.ReorderLevel;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        var p = ReadInputs();
        if (p == null) return;

        try
        {
            _products.Add(p);
            LoadGrid();
        }
        catch (SqliteException)
        {
            MessageBox.Show("A product with that SKU already exists.");
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (_selectedId == 0)
        {
            MessageBox.Show("Select a product in the list first.");
            return;
        }

        var p = ReadInputs();
        if (p == null) return;

        try
        {
            _products.Update(p);
            LoadGrid();
        }
        catch (SqliteException)
        {
            MessageBox.Show("A product with that SKU already exists.");
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedId == 0)
        {
            MessageBox.Show("Select a product in the list first.");
            return;
        }

        var answer = MessageBox.Show("Delete this product?", "Confirm",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        if (answer == DialogResult.Yes)
        {
            _products.Delete(_selectedId);
            LoadGrid();
        }
    }

    private void btnClear_Click(object sender, EventArgs e) => ClearForm();

    private void txtSearch_TextChanged(object sender, EventArgs e) => LoadGrid();
}