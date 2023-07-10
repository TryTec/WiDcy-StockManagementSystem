namespace StockManagementSystem.Setting
{
    partial class FrmProfile
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
            this.DgvUnassign = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnassign = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colUnassignName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvAssigned = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.colAssignedID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssigned = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colAssignedName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CkbAllUnassign = new System.Windows.Forms.CheckBox();
            this.CkbAllAssigned = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbProfile = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUnassign)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssigned)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Khmer OS Siemreap", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "ផ្ដល់សិទ្ធ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvUnassign
            // 
            this.DgvUnassign.AllowUserToAddRows = false;
            this.DgvUnassign.AllowUserToDeleteRows = false;
            this.DgvUnassign.AllowUserToResizeColumns = false;
            this.DgvUnassign.AllowUserToResizeRows = false;
            this.DgvUnassign.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvUnassign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUnassign.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colUnassign,
            this.colUnassignName});
            this.DgvUnassign.Location = new System.Drawing.Point(3, 35);
            this.DgvUnassign.Name = "DgvUnassign";
            this.DgvUnassign.RowHeadersVisible = false;
            this.DgvUnassign.Size = new System.Drawing.Size(303, 380);
            this.DgvUnassign.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 44);
            this.panel1.TabIndex = 2;
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(547, 2);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(85, 39);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "រក្សា";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = false;
            // 
            // colUnassign
            // 
            this.colUnassign.HeaderText = "ជ្រើសរើស";
            this.colUnassign.Name = "colUnassign";
            this.colUnassign.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colUnassign.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colUnassignName
            // 
            this.colUnassignName.DataPropertyName = "DisplayName";
            this.colUnassignName.HeaderText = "ឈ្មោះកម្មវិធី";
            this.colUnassignName.Name = "colUnassignName";
            this.colUnassignName.Width = 200;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Khmer OS Siemreap", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "មិនទាន់ផ្ដល់សិទ្ធ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Font = new System.Drawing.Font("Khmer OS Siemreap", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "បានផ្ដល់សិទ្ធ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvAssigned
            // 
            this.DgvAssigned.AllowUserToAddRows = false;
            this.DgvAssigned.AllowUserToDeleteRows = false;
            this.DgvAssigned.AllowUserToResizeColumns = false;
            this.DgvAssigned.AllowUserToResizeRows = false;
            this.DgvAssigned.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvAssigned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAssigned.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAssignedID,
            this.colAssigned,
            this.colAssignedName});
            this.DgvAssigned.Location = new System.Drawing.Point(3, 35);
            this.DgvAssigned.Name = "DgvAssigned";
            this.DgvAssigned.RowHeadersVisible = false;
            this.DgvAssigned.Size = new System.Drawing.Size(303, 380);
            this.DgvAssigned.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.CkbAllUnassign);
            this.panel2.Controls.Add(this.DgvUnassign);
            this.panel2.Location = new System.Drawing.Point(2, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 452);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CkbAllAssigned);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.DgvAssigned);
            this.panel3.Location = new System.Drawing.Point(411, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 452);
            this.panel3.TabIndex = 4;
            // 
            // colAssignedID
            // 
            this.colAssignedID.DataPropertyName = "ID";
            this.colAssignedID.HeaderText = "ID";
            this.colAssignedID.Name = "colAssignedID";
            this.colAssignedID.Visible = false;
            // 
            // colAssigned
            // 
            this.colAssigned.HeaderText = "ជ្រើសរើស";
            this.colAssigned.Name = "colAssigned";
            this.colAssigned.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colAssigned.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colAssignedName
            // 
            this.colAssignedName.DataPropertyName = "DisplayName";
            this.colAssignedName.HeaderText = "ឈ្មោះកម្មវិធី";
            this.colAssignedName.Name = "colAssignedName";
            this.colAssignedName.Width = 200;
            // 
            // CkbAllUnassign
            // 
            this.CkbAllUnassign.AutoSize = true;
            this.CkbAllUnassign.Location = new System.Drawing.Point(3, 421);
            this.CkbAllUnassign.Name = "CkbAllUnassign";
            this.CkbAllUnassign.Size = new System.Drawing.Size(124, 28);
            this.CkbAllUnassign.TabIndex = 5;
            this.CkbAllUnassign.Text = "ជ្រើសរើសទាំងអស់";
            this.CkbAllUnassign.UseVisualStyleBackColor = true;
            // 
            // CkbAllAssigned
            // 
            this.CkbAllAssigned.AutoSize = true;
            this.CkbAllAssigned.Location = new System.Drawing.Point(3, 421);
            this.CkbAllAssigned.Name = "CkbAllAssigned";
            this.CkbAllAssigned.Size = new System.Drawing.Size(124, 28);
            this.CkbAllAssigned.TabIndex = 5;
            this.CkbAllAssigned.Text = "ជ្រើសរើសទាំងអស់";
            this.CkbAllAssigned.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnRemove);
            this.panel4.Controls.Add(this.BtnAdd);
            this.panel4.Location = new System.Drawing.Point(317, 261);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 90);
            this.panel4.TabIndex = 5;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(3, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(85, 39);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "បន្ថែម";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(632, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(85, 39);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "បោះបង់";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(3, 48);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(85, 39);
            this.BtnRemove.TabIndex = 0;
            this.BtnRemove.Text = "ដកចេញ";
            this.BtnRemove.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "សិទ្ធ";
            // 
            // CmbProfile
            // 
            this.CmbProfile.FormattingEnabled = true;
            this.CmbProfile.Location = new System.Drawing.Point(42, 43);
            this.CmbProfile.Name = "CmbProfile";
            this.CmbProfile.Size = new System.Drawing.Size(673, 32);
            this.CmbProfile.TabIndex = 7;
            // 
            // FrmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 576);
            this.Controls.Add(this.CmbProfile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "FrmProfile";
            this.Text = "ផ្ដល់សិទ្ធ";
            ((System.ComponentModel.ISupportInitialize)(this.DgvUnassign)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAssigned)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvUnassign;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colUnassign;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnassignName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvAssigned;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colAssigned;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedName;
        private System.Windows.Forms.CheckBox CkbAllUnassign;
        private System.Windows.Forms.CheckBox CkbAllAssigned;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbProfile;
    }
}