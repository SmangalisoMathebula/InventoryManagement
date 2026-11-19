namespace InventoryManagement;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnProducts_Click(object sender, EventArgs e)
    {
        using var form = new InventoryManagement.Forms.ProductsForm();
        form.ShowDialog();
    }
}