namespace StockManagementSystem.Products
{
    partial class FrmProduct
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.DgvProduct = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCostUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductUnitName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnRefresh, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.DgvProduct, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnCreate, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnEdit, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnDelete, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "ស្វែងរក";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtSearch
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TxtSearch, 3);
            this.TxtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtSearch.Location = new System.Drawing.Point(63, 3);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(728, 31);
            this.TxtSearch.TabIndex = 1;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRefresh.Location = new System.Drawing.Point(797, 3);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(100, 39);
            this.BtnRefresh.TabIndex = 2;
            this.BtnRefresh.Text = "ទិន្នន័យបច្ចប្បន្ន";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            // 
            // DgvProduct
            // 
            this.DgvProduct.AllowUserToAddRows = false;
            this.DgvProduct.AllowUserToDeleteRows = false;
            this.DgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colProductCategoryName,
            this.colTaxName,
            this.colCostUnitPrice,
            this.colProductUnitName,
            this.colBarcode,
            this.colCreatedDate,
            this.colIsActive});
            this.tableLayoutPanel1.SetColumnSpan(this.DgvProduct, 5);
            this.DgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvProduct.Location = new System.Drawing.Point(3, 48);
            this.DgvProduct.Name = "DgvProduct";
            this.DgvProduct.ReadOnly = true;
            this.DgvProduct.RowHeadersVisible = false;
            this.DgvProduct.Size = new System.Drawing.Size(894, 504);
            this.DgvProduct.TabIndex = 3;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colName
            // 
            this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "ឈ្មោះផលិតផល";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colProductCategoryName
            // 
            this.colProductCategoryName.DataPropertyName = "ProductCategoryName";
            this.colProductCategoryName.HeaderText = "ប្រភេទផលិតផល";
            this.colProductCategoryName.Name = "colProductCategoryName";
            this.colProductCategoryName.ReadOnly = true;
            // 
            // colTaxName
            // 
            this.colTaxName.DataPropertyName = "TaxName";
            this.colTaxName.HeaderText = "ពន្ធ";
            this.colTaxName.Name = "colTaxName";
            this.colTaxName.ReadOnly = true;
            // 
            // colCostUnitPrice
            // 
            this.colCostUnitPrice.DataPropertyName = "CostUnitPrice";
            this.colCostUnitPrice.HeaderText = "ថ្លៃដើម";
            this.colCostUnitPrice.Name = "colCostUnitPrice";
            this.colCostUnitPrice.ReadOnly = true;
            // 
            // colProductUnitName
            // 
            this.colProductUnitName.DataPropertyName = "ProductUnitName";
            this.colProductUnitName.HeaderText = "ខ្នាតផលិតផល";
            this.colProductUnitName.Name = "colProductUnitName";
            this.colProductUnitName.ReadOnly = true;
            // 
            // colBarcode
            // 
            this.colBarcode.DataPropertyName = "Barcode";
            this.colBarcode.HeaderText = "បារកូដ";
            this.colBarcode.Name = "colBarcode";
            this.colBarcode.ReadOnly = true;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.DataPropertyName = "CreatedDate";
            this.colCreatedDate.HeaderText = "ថ្ងៃបង្កើតផលិតផល";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.ReadOnly = true;
            this.colCreatedDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colCreatedDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCreatedDate.Width = 120;
            // 
            // colIsActive
            // 
            this.colIsActive.DataPropertyName = "IsActive";
            this.colIsActive.HeaderText = "សកម្ម";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.ReadOnly = true;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCreate.Location = new System.Drawing.Point(603, 558);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(94, 39);
            this.BtnCreate.TabIndex = 4;
            this.BtnCreate.Text = "បង្កើត";
            this.BtnCreate.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEdit.Location = new System.Drawing.Point(703, 558);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(88, 39);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "កែប្រែ";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Location = new System.Drawing.Point(797, 558);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 39);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "លុប";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmProduct";
            this.Text = "ផលិតផល";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.DataGridView DgvProduct;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCostUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductUnitName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsActive;
    }
}