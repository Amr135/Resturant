namespace Resturant.View
{
    partial class FrmProductsView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            DgvID = new DataGridViewTextBoxColumn();
            Dgv_Name = new DataGridViewTextBoxColumn();
            Dgv_Price = new DataGridViewTextBoxColumn();
            Dgv_Edit = new DataGridViewImageColumn();
            Dgv_Delete = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges1;
            // 
            // label1
            // 
            label1.Location = new Point(980, 91);
            // 
            // btnAdd
            // 
            btnAdd.CheckedState.ImageSize = new Size(64, 64);
            btnAdd.DialogResult = DialogResult.None;
            btnAdd.HoverState.ImageSize = new Size(64, 64);
            btnAdd.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            btnAdd.PressedState.ImageSize = new Size(64, 64);
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // label2
            // 
            label2.Size = new Size(106, 32);
            label2.Text = "Products";
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridView1.ColumnHeadersHeight = 40;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { DgvID, Dgv_Name, Dgv_Price, Dgv_Edit, Dgv_Delete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            DataGridView1.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView1.Location = new Point(31, 228);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.ReadOnly = true;
            DataGridView1.RowHeadersVisible = false;
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.RowTemplate.Height = 35;
            DataGridView1.Size = new Size(1532, 332);
            DataGridView1.TabIndex = 6;
            DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            DataGridView1.ThemeStyle.BackColor = Color.White;
            DataGridView1.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.Transparent;
            DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
            DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DataGridView1.ThemeStyle.HeaderStyle.Height = 40;
            DataGridView1.ThemeStyle.ReadOnly = true;
            DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            DataGridView1.ThemeStyle.RowsStyle.Height = 35;
            DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            DataGridView1.CellContentClick += DataGridView1_CellContentClick;
            // 
            // DgvID
            // 
            DgvID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DgvID.FillWeight = 70F;
            DgvID.HeaderText = "ID";
            DgvID.MinimumWidth = 70;
            DgvID.Name = "DgvID";
            DgvID.ReadOnly = true;
            DgvID.Width = 70;
            // 
            // Dgv_Name
            // 
            Dgv_Name.HeaderText = "Name";
            Dgv_Name.MinimumWidth = 6;
            Dgv_Name.Name = "Dgv_Name";
            Dgv_Name.ReadOnly = true;
            // 
            // Dgv_Price
            // 
            Dgv_Price.HeaderText = "Price";
            Dgv_Price.MinimumWidth = 6;
            Dgv_Price.Name = "Dgv_Price";
            Dgv_Price.ReadOnly = true;
            // 
            // Dgv_Edit
            // 
            Dgv_Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Dgv_Edit.FillWeight = 50F;
            Dgv_Edit.HeaderText = "";
            Dgv_Edit.Image = Properties.Resources.pen;
            Dgv_Edit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Dgv_Edit.MinimumWidth = 50;
            Dgv_Edit.Name = "Dgv_Edit";
            Dgv_Edit.ReadOnly = true;
            Dgv_Edit.Width = 50;
            // 
            // Dgv_Delete
            // 
            Dgv_Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Dgv_Delete.FillWeight = 50F;
            Dgv_Delete.HeaderText = "";
            Dgv_Delete.Image = Properties.Resources.delete;
            Dgv_Delete.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Dgv_Delete.MinimumWidth = 50;
            Dgv_Delete.Name = "Dgv_Delete";
            Dgv_Delete.ReadOnly = true;
            Dgv_Delete.Width = 50;
            // 
            // FrmProductsView
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1575, 585);
            Controls.Add(DataGridView1);
            Name = "FrmProductsView";
            Text = "FrmProductsView";
            Controls.SetChildIndex(txtSearch, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(btnAdd, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(guna2Separator1, 0);
            Controls.SetChildIndex(DataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
        private DataGridViewTextBoxColumn DgvID;
        private DataGridViewTextBoxColumn Dgv_Name;
        private DataGridViewTextBoxColumn Dgv_Price;
        private DataGridViewImageColumn Dgv_Edit;
        private DataGridViewImageColumn Dgv_Delete;
    }
}