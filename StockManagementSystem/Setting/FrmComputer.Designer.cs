namespace StockManagementSystem.Setting
{
    partial class FrmComputer
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.DgvComputer = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComputerInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComputerConfiguration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBranchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegisteredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvComputer)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.BtnRefresh.Text = "ទិន្នន័យបច្ចុប្បន្ន";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            // 
            // DgvComputer
            // 
            this.DgvComputer.AllowUserToAddRows = false;
            this.DgvComputer.AllowUserToDeleteRows = false;
            this.DgvComputer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvComputer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvComputer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvComputer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colComputerInfo,
            this.colComputerConfiguration,
            this.colCompanyName,
            this.colBranchName,
            this.colRegisteredDate,
            this.colIsActive});
            this.tableLayoutPanel1.SetColumnSpan(this.DgvComputer, 5);
            this.DgvComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvComputer.Location = new System.Drawing.Point(3, 48);
            this.DgvComputer.Name = "DgvComputer";
            this.DgvComputer.ReadOnly = true;
            this.DgvComputer.RowHeadersVisible = false;
            this.DgvComputer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvComputer.Size = new System.Drawing.Size(894, 504);
            this.DgvComputer.TabIndex = 3;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "លេខសម្គាល់";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "ឈ្មោះ";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colComputerInfo
            // 
            this.colComputerInfo.DataPropertyName = "ComputerInfo";
            this.colComputerInfo.HeaderText = "ព័ត៍មានកុំព្យូទ័រ";
            this.colComputerInfo.Name = "colComputerInfo";
            this.colComputerInfo.ReadOnly = true;
            // 
            // colComputerConfiguration
            // 
            this.colComputerConfiguration.DataPropertyName = "ComputerConfiguration";
            this.colComputerConfiguration.HeaderText = "ការកំណត់លើកុំព្យូទ័រ";
            this.colComputerConfiguration.Name = "colComputerConfiguration";
            this.colComputerConfiguration.ReadOnly = true;
            // 
            // colCompanyName
            // 
            this.colCompanyName.DataPropertyName = "CompanyName";
            this.colCompanyName.HeaderText = "ក្រុមហ៊ុន";
            this.colCompanyName.Name = "colCompanyName";
            this.colCompanyName.ReadOnly = true;
            // 
            // colBranchName
            // 
            this.colBranchName.DataPropertyName = "BranchName";
            this.colBranchName.HeaderText = "សាខា";
            this.colBranchName.Name = "colBranchName";
            this.colBranchName.ReadOnly = true;
            // 
            // colRegisteredDate
            // 
            this.colRegisteredDate.DataPropertyName = "RegisteredDate";
            this.colRegisteredDate.HeaderText = "កាលបរិច្ឆេទបង្កើត";
            this.colRegisteredDate.Name = "colRegisteredDate";
            this.colRegisteredDate.ReadOnly = true;
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
            this.BtnCreate.TabIndex = 2;
            this.BtnCreate.Text = "បង្កើត";
            this.BtnCreate.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnEdit.Location = new System.Drawing.Point(703, 558);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(88, 39);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "កែប្រែ";
            this.BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Location = new System.Drawing.Point(797, 558);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(100, 39);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "លុប";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.BtnDelete, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.DgvComputer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnEdit, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnCreate, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.BtnRefresh, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 600);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // FrmComputer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmComputer";
            this.Text = "កុំព្យូទ័រ";
            ((System.ComponentModel.ISupportInitialize)(this.DgvComputer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.DataGridView DgvComputer;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComputerInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComputerConfiguration;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBranchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegisteredDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colIsActive;
    }
}