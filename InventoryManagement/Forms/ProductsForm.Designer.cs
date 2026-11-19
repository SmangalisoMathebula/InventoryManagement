namespace InventoryManagement.Forms
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSearch = new TextBox();
            dgvProducts = new DataGridView();
            label1 = new Label();
            txtSku = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            cmbCategory = new ComboBox();
            label4 = new Label();
            numCost = new NumericUpDown();
            label5 = new Label();
            numSell = new NumericUpDown();
            label6 = new Label();
            numReorder = new NumericUpDown();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSell).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReorder).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by SKU or name";
            txtSearch.Size = new Size(880, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 50);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(880, 330);
            dgvProducts.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 403);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 2;
            label1.Text = "SKU";
            // 
            // txtSku
            // 
            txtSku.Location = new Point(110, 400);
            txtSku.Name = "txtSku";
            txtSku.Size = new Size(125, 27);
            txtSku.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(300, 403);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(410, 400);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(600, 403);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 6;
            label3.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(700, 400);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(180, 28);
            cmbCategory.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 448);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 8;
            label4.Text = "Cost Price";
            // 
            // numCost
            // 
            numCost.DecimalPlaces = 2;
            numCost.Location = new Point(110, 445);
            numCost.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCost.Name = "numCost";
            numCost.Size = new Size(170, 27);
            numCost.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(300, 448);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 10;
            label5.Text = "Selling Price";
            // 
            // numSell
            // 
            numSell.DecimalPlaces = 2;
            numSell.Location = new Point(410, 445);
            numSell.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSell.Name = "numSell";
            numSell.Size = new Size(150, 27);
            numSell.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(600, 448);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 12;
            label6.Text = "Reorder level";
            // 
            // numReorder
            // 
            numReorder.Location = new Point(720, 445);
            numReorder.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numReorder.Name = "numReorder";
            numReorder.Size = new Size(160, 27);
            numReorder.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 500);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(122, 500);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(232, 500);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(342, 500);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 35);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 612);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(numReorder);
            Controls.Add(label6);
            Controls.Add(numSell);
            Controls.Add(label5);
            Controls.Add(numCost);
            Controls.Add(label4);
            Controls.Add(cmbCategory);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(txtSku);
            Controls.Add(label1);
            Controls.Add(dgvProducts);
            Controls.Add(txtSearch);
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += ProductsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSell).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReorder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearch;
        private DataGridView dgvProducts;
        private Label label1;
        private TextBox txtSku;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private ComboBox cmbCategory;
        private Label label4;
        private NumericUpDown numCost;
        private Label label5;
        private NumericUpDown numSell;
        private Label label6;
        private NumericUpDown numReorder;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}