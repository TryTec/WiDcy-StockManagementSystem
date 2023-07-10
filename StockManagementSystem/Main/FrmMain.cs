using StockManagementSystem.Products;
using StockManagementSystem.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagementSystem.Main
{
    public partial class FrmMain : Form
    {
        FrmEmployee objFrmEmployee = null;
        FrmProduct objFrmProduct = null;
        public FrmMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmLogin objFrmLogin = new FrmLogin();
            objFrmLogin.Show();
        }

        private void Obj_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form objForm = sender as Form;
            if (objForm != null)
            {
                switch (objForm.Name)
                {
                    case "FrmEmployee":
                        objFrmEmployee = null;
                        break;
                    case "FrmProduct":
                        objFrmProduct = null;
                        break;
                }
            }
        }

        private void TsmiEmployee_Click(object sender, EventArgs e)
        {
            if (objFrmEmployee != null)
            {
                objFrmEmployee.MdiParent = this;
                objFrmEmployee.Focus();
            }
            else
            {
                objFrmEmployee = new FrmEmployee();
                objFrmEmployee.FormClosing += new FormClosingEventHandler(Obj_FormClosing);
                objFrmEmployee.MdiParent = this;
                objFrmEmployee.Dock = DockStyle.Fill;
                objFrmEmployee.Show();
            }
        }

        private void TsmiProduct_Click(object sender, EventArgs e)
        {
            if (objFrmProduct != null)
            {
                objFrmProduct.MdiParent = this;
                objFrmProduct.Focus();
            }
            else
            {
                objFrmProduct = new FrmProduct();
                objFrmProduct.FormClosing += new FormClosingEventHandler(Obj_FormClosing);
                objFrmProduct.MdiParent = this;
                objFrmProduct.Dock = DockStyle.Fill;
                objFrmProduct.Show();
            }
        }

        private void TsmiCloseChildForm_Click(object sender, EventArgs e)
        {
            ActiveMdiChild?.Close();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}