namespace StockManagementSystem.Main
{
    partial class FrmMain
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEmployeeCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProductCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProductUnit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSuppyer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStockPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStockAjustment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStockDispatch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReports = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStockPurchaseReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStockAdjustmentReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStockDispatchReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiGroupCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCompanyCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiBranch = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiGroupComputer = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiComputer = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiComputerConfiguration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiApplicationLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInterface = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInterfaceDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCloseChildForm = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiUsers,
            this.tsmiMenuProduct,
            this.tsmiStock,
            this.tsmiReports,
            this.tsmiSetting,
            this.TsmiCloseChildForm});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(784, 32);
            this.msMain.TabIndex = 0;
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(61, 28);
            this.tsmiFile.Text = "ឯ&កសារ";
            // 
            // tsmiUsers
            // 
            this.tsmiUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiEmployee,
            this.tsmiEmployeeCategories});
            this.tsmiUsers.Name = "tsmiUsers";
            this.tsmiUsers.Size = new System.Drawing.Size(109, 28);
            this.tsmiUsers.Text = "ក្រុមអ្នកប្រើប្រាស់";
            // 
            // TsmiEmployee
            // 
            this.TsmiEmployee.Name = "TsmiEmployee";
            this.TsmiEmployee.Size = new System.Drawing.Size(120, 28);
            this.TsmiEmployee.Text = "បុគ្គលិក";
            this.TsmiEmployee.Click += new System.EventHandler(this.TsmiEmployee_Click);
            // 
            // tsmiEmployeeCategories
            // 
            this.tsmiEmployeeCategories.Name = "tsmiEmployeeCategories";
            this.tsmiEmployeeCategories.Size = new System.Drawing.Size(120, 28);
            this.tsmiEmployeeCategories.Text = "តួនាទី";
            // 
            // tsmiMenuProduct
            // 
            this.tsmiMenuProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiProduct,
            this.tsmiProductCategories,
            this.tsmiProductUnit});
            this.tsmiMenuProduct.Name = "tsmiMenuProduct";
            this.tsmiMenuProduct.Size = new System.Drawing.Size(75, 28);
            this.tsmiMenuProduct.Text = "ផលិតផល";
            // 
            // TsmiProduct
            // 
            this.TsmiProduct.Name = "TsmiProduct";
            this.TsmiProduct.Size = new System.Drawing.Size(133, 28);
            this.TsmiProduct.Text = "ផលិតផល";
            this.TsmiProduct.Click += new System.EventHandler(this.TsmiProduct_Click);
            // 
            // tsmiProductCategories
            // 
            this.tsmiProductCategories.Name = "tsmiProductCategories";
            this.tsmiProductCategories.Size = new System.Drawing.Size(133, 28);
            this.tsmiProductCategories.Text = "ប្រភេទ";
            // 
            // tsmiProductUnit
            // 
            this.tsmiProductUnit.Name = "tsmiProductUnit";
            this.tsmiProductUnit.Size = new System.Drawing.Size(133, 28);
            this.tsmiProductUnit.Text = "ខ្នាត";
            // 
            // tsmiStock
            // 
            this.tsmiStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSuppyer,
            this.tsmiStockPurchase,
            this.tsmiStockAjustment,
            this.tsmiStockDispatch});
            this.tsmiStock.Name = "tsmiStock";
            this.tsmiStock.Size = new System.Drawing.Size(44, 28);
            this.tsmiStock.Text = "ស្តុក";
            // 
            // tsmiSuppyer
            // 
            this.tsmiSuppyer.Name = "tsmiSuppyer";
            this.tsmiSuppyer.Size = new System.Drawing.Size(134, 28);
            this.tsmiSuppyer.Text = "អ្នកផ្គត់ផ្គង់";
            // 
            // tsmiStockPurchase
            // 
            this.tsmiStockPurchase.Name = "tsmiStockPurchase";
            this.tsmiStockPurchase.Size = new System.Drawing.Size(134, 28);
            this.tsmiStockPurchase.Text = "ទិញចូល";
            // 
            // tsmiStockAjustment
            // 
            this.tsmiStockAjustment.Name = "tsmiStockAjustment";
            this.tsmiStockAjustment.Size = new System.Drawing.Size(134, 28);
            this.tsmiStockAjustment.Text = "កែសម្រួល";
            // 
            // tsmiStockDispatch
            // 
            this.tsmiStockDispatch.Name = "tsmiStockDispatch";
            this.tsmiStockDispatch.Size = new System.Drawing.Size(134, 28);
            this.tsmiStockDispatch.Text = "បញ្ចូន";
            // 
            // tsmiReports
            // 
            this.tsmiReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStockPurchaseReport,
            this.tsmiStockAdjustmentReport,
            this.tsmiStockDispatchReport});
            this.tsmiReports.Name = "tsmiReports";
            this.tsmiReports.Size = new System.Drawing.Size(86, 28);
            this.tsmiReports.Text = "របាយការណ៍";
            // 
            // tsmiStockPurchaseReport
            // 
            this.tsmiStockPurchaseReport.Name = "tsmiStockPurchaseReport";
            this.tsmiStockPurchaseReport.Size = new System.Drawing.Size(132, 28);
            this.tsmiStockPurchaseReport.Text = "ទិញចូល";
            // 
            // tsmiStockAdjustmentReport
            // 
            this.tsmiStockAdjustmentReport.Name = "tsmiStockAdjustmentReport";
            this.tsmiStockAdjustmentReport.Size = new System.Drawing.Size(132, 28);
            this.tsmiStockAdjustmentReport.Text = "កែសម្រួល";
            // 
            // tsmiStockDispatchReport
            // 
            this.tsmiStockDispatchReport.Name = "tsmiStockDispatchReport";
            this.tsmiStockDispatchReport.Size = new System.Drawing.Size(132, 28);
            this.tsmiStockDispatchReport.Text = "បញ្ចូន";
            // 
            // tsmiSetting
            // 
            this.tsmiSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiGroupCompany,
            this.TsmiGroupComputer,
            this.tsmiApplicationLogin,
            this.tsmiProfile,
            this.tsmiInterface,
            this.tsmiInterfaceDetail});
            this.tsmiSetting.Name = "tsmiSetting";
            this.tsmiSetting.Size = new System.Drawing.Size(74, 28);
            this.tsmiSetting.Text = "ការកំណត់";
            // 
            // TsmiGroupCompany
            // 
            this.TsmiGroupCompany.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiCompany,
            this.TsmiCompanyCategories,
            this.TsmiBranch});
            this.TsmiGroupCompany.Name = "TsmiGroupCompany";
            this.TsmiGroupCompany.Size = new System.Drawing.Size(172, 28);
            this.TsmiGroupCompany.Text = "ក្រុមហ៊ុន";
            // 
            // TsmiCompany
            // 
            this.TsmiCompany.Name = "TsmiCompany";
            this.TsmiCompany.Size = new System.Drawing.Size(124, 28);
            this.TsmiCompany.Text = "ក្រុមហ៊ុន";
            // 
            // TsmiCompanyCategories
            // 
            this.TsmiCompanyCategories.Name = "TsmiCompanyCategories";
            this.TsmiCompanyCategories.Size = new System.Drawing.Size(124, 28);
            this.TsmiCompanyCategories.Text = "ប្រភេទ";
            // 
            // TsmiBranch
            // 
            this.TsmiBranch.Name = "TsmiBranch";
            this.TsmiBranch.Size = new System.Drawing.Size(124, 28);
            this.TsmiBranch.Text = "សាខា";
            // 
            // TsmiGroupComputer
            // 
            this.TsmiGroupComputer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiComputer,
            this.TsmiComputerConfiguration});
            this.TsmiGroupComputer.Name = "TsmiGroupComputer";
            this.TsmiGroupComputer.Size = new System.Drawing.Size(172, 28);
            this.TsmiGroupComputer.Text = "កុំព្យូទ័រ";
            // 
            // TsmiComputer
            // 
            this.TsmiComputer.Name = "TsmiComputer";
            this.TsmiComputer.Size = new System.Drawing.Size(150, 28);
            this.TsmiComputer.Text = " កុំព្យូទ័រ";
            // 
            // TsmiComputerConfiguration
            // 
            this.TsmiComputerConfiguration.Name = "TsmiComputerConfiguration";
            this.TsmiComputerConfiguration.Size = new System.Drawing.Size(150, 28);
            this.TsmiComputerConfiguration.Text = "កំណត់កុំព្យូទ័រ";
            // 
            // tsmiApplicationLogin
            // 
            this.tsmiApplicationLogin.Name = "tsmiApplicationLogin";
            this.tsmiApplicationLogin.Size = new System.Drawing.Size(172, 28);
            this.tsmiApplicationLogin.Text = "អ្នកប្រើប្រាស់";
            // 
            // tsmiProfile
            // 
            this.tsmiProfile.Name = "tsmiProfile";
            this.tsmiProfile.Size = new System.Drawing.Size(172, 28);
            this.tsmiProfile.Text = "សិទ្ធចូលប្រើប្រព័ន្ធ";
            // 
            // tsmiInterface
            // 
            this.tsmiInterface.Name = "tsmiInterface";
            this.tsmiInterface.Size = new System.Drawing.Size(172, 28);
            this.tsmiInterface.Text = "កម្មវិធី";
            // 
            // tsmiInterfaceDetail
            // 
            this.tsmiInterfaceDetail.Name = "tsmiInterfaceDetail";
            this.tsmiInterfaceDetail.Size = new System.Drawing.Size(172, 28);
            this.tsmiInterfaceDetail.Text = "ផ្ដល់សិទ្ធ";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = global::StockManagementSystem.Properties.Resources.exit_24;
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(128, 28);
            this.tsmiExit.Text = "&ចាកចេញ";
            // 
            // TsmiCloseChildForm
            // 
            this.TsmiCloseChildForm.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TsmiCloseChildForm.BackColor = System.Drawing.SystemColors.Control;
            this.TsmiCloseChildForm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TsmiCloseChildForm.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F, System.Drawing.FontStyle.Bold);
            this.TsmiCloseChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TsmiCloseChildForm.Image = global::StockManagementSystem.Properties.Resources.close_24;
            this.TsmiCloseChildForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TsmiCloseChildForm.Name = "TsmiCloseChildForm";
            this.TsmiCloseChildForm.Size = new System.Drawing.Size(28, 28);
            this.TsmiCloseChildForm.Click += new System.EventHandler(this.TsmiCloseChildForm_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F);
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "មីនុយ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmiMenuProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiStock;
        private System.Windows.Forms.ToolStripMenuItem tsmiReports;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem TsmiEmployee;
        private System.Windows.Forms.ToolStripMenuItem tsmiEmployeeCategories;
        private System.Windows.Forms.ToolStripMenuItem TsmiProduct;
        private System.Windows.Forms.ToolStripMenuItem tsmiProductCategories;
        private System.Windows.Forms.ToolStripMenuItem tsmiProductUnit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSuppyer;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockPurchase;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockAjustment;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockDispatch;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockPurchaseReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockAdjustmentReport;
        private System.Windows.Forms.ToolStripMenuItem tsmiStockDispatchReport;
        private System.Windows.Forms.ToolStripMenuItem TsmiGroupComputer;
        private System.Windows.Forms.ToolStripMenuItem tsmiApplicationLogin;
        private System.Windows.Forms.ToolStripMenuItem tsmiProfile;
        private System.Windows.Forms.ToolStripMenuItem tsmiInterface;
        private System.Windows.Forms.ToolStripMenuItem tsmiInterfaceDetail;
        private System.Windows.Forms.ToolStripMenuItem TsmiGroupCompany;
        private System.Windows.Forms.ToolStripMenuItem TsmiCompanyCategories;
        private System.Windows.Forms.ToolStripMenuItem TsmiComputerConfiguration;
        private System.Windows.Forms.ToolStripMenuItem TsmiBranch;
        private System.Windows.Forms.ToolStripMenuItem TsmiCompany;
        private System.Windows.Forms.ToolStripMenuItem TsmiComputer;
        private System.Windows.Forms.ToolStripMenuItem TsmiCloseChildForm;
    }
}

