namespace Resturant
{
    partial class Bill_List
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Dgv_Bills_List = new Guna.UI2.WinForms.Guna2DataGridView();
            DgvSR = new DataGridViewTextBoxColumn();
            Dgv_Id_Order = new DataGridViewTextBoxColumn();
            Dgv_Type_Order = new DataGridViewTextBoxColumn();
            Dgv_Table = new DataGridViewTextBoxColumn();
            Dgv_State_Order = new DataGridViewTextBoxColumn();
            DgvPrice = new DataGridViewTextBoxColumn();
            Dgv_Pay = new DataGridViewImageColumn();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Bills_List).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2Panel1.Size = new Size(884, 125);
            // 
            // guna2Panel2
            // 
            guna2Panel2.Location = new Point(0, 406);
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel2.Size = new Size(884, 99);
            // 
            // label1
            // 
            label1.ForeColor = Color.Black;
            label1.Size = new Size(105, 32);
            label1.Text = "Bills List ";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.Image = Properties.Resources.shopping_list;
            guna2PictureBox1.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.None;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.None;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges5;
            // 
            // Dgv_Bills_List
            // 
            Dgv_Bills_List.AllowUserToAddRows = false;
            Dgv_Bills_List.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            Dgv_Bills_List.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Dgv_Bills_List.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Dgv_Bills_List.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            Dgv_Bills_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            Dgv_Bills_List.ColumnHeadersHeight = 40;
            Dgv_Bills_List.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Dgv_Bills_List.Columns.AddRange(new DataGridViewColumn[] { DgvSR, Dgv_Id_Order, Dgv_Type_Order, Dgv_Table, Dgv_State_Order, DgvPrice, Dgv_Pay });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(232, 234, 237);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            Dgv_Bills_List.DefaultCellStyle = dataGridViewCellStyle3;
            Dgv_Bills_List.GridColor = Color.FromArgb(231, 229, 255);
            Dgv_Bills_List.Location = new Point(12, 131);
            Dgv_Bills_List.Name = "Dgv_Bills_List";
            Dgv_Bills_List.ReadOnly = true;
            Dgv_Bills_List.RowHeadersVisible = false;
            Dgv_Bills_List.RowHeadersWidth = 51;
            Dgv_Bills_List.RowTemplate.Height = 35;
            Dgv_Bills_List.Size = new Size(860, 269);
            Dgv_Bills_List.TabIndex = 8;
            Dgv_Bills_List.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            Dgv_Bills_List.ThemeStyle.AlternatingRowsStyle.Font = null;
            Dgv_Bills_List.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            Dgv_Bills_List.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            Dgv_Bills_List.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            Dgv_Bills_List.ThemeStyle.BackColor = Color.White;
            Dgv_Bills_List.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            Dgv_Bills_List.ThemeStyle.HeaderStyle.BackColor = Color.Transparent;
            Dgv_Bills_List.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            Dgv_Bills_List.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dgv_Bills_List.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
            Dgv_Bills_List.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            Dgv_Bills_List.ThemeStyle.HeaderStyle.Height = 40;
            Dgv_Bills_List.ThemeStyle.ReadOnly = true;
            Dgv_Bills_List.ThemeStyle.RowsStyle.BackColor = Color.White;
            Dgv_Bills_List.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Dgv_Bills_List.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Dgv_Bills_List.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            Dgv_Bills_List.ThemeStyle.RowsStyle.Height = 35;
            Dgv_Bills_List.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            Dgv_Bills_List.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            Dgv_Bills_List.CellContentClick += Dgv_Bills_List_CellContentClick;
            // 
            // DgvSR
            // 
            DgvSR.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DgvSR.FillWeight = 70F;
            DgvSR.HeaderText = "Sr#";
            DgvSR.MinimumWidth = 10;
            DgvSR.Name = "DgvSR";
            DgvSR.ReadOnly = true;
            DgvSR.Width = 30;
            // 
            // Dgv_Id_Order
            // 
            Dgv_Id_Order.FillWeight = 50F;
            Dgv_Id_Order.HeaderText = "Id Order";
            Dgv_Id_Order.MinimumWidth = 6;
            Dgv_Id_Order.Name = "Dgv_Id_Order";
            Dgv_Id_Order.ReadOnly = true;
            // 
            // Dgv_Type_Order
            // 
            Dgv_Type_Order.FillWeight = 29.4206257F;
            Dgv_Type_Order.HeaderText = "Type Order";
            Dgv_Type_Order.MinimumWidth = 6;
            Dgv_Type_Order.Name = "Dgv_Type_Order";
            Dgv_Type_Order.ReadOnly = true;
            // 
            // Dgv_Table
            // 
            Dgv_Table.FillWeight = 40F;
            Dgv_Table.HeaderText = "Table ";
            Dgv_Table.MinimumWidth = 6;
            Dgv_Table.Name = "Dgv_Table";
            Dgv_Table.ReadOnly = true;
            // 
            // Dgv_State_Order
            // 
            Dgv_State_Order.FillWeight = 40F;
            Dgv_State_Order.HeaderText = "State";
            Dgv_State_Order.MinimumWidth = 6;
            Dgv_State_Order.Name = "Dgv_State_Order";
            Dgv_State_Order.ReadOnly = true;
            // 
            // DgvPrice
            // 
            DgvPrice.FillWeight = 50F;
            DgvPrice.HeaderText = "Price";
            DgvPrice.MinimumWidth = 6;
            DgvPrice.Name = "DgvPrice";
            DgvPrice.ReadOnly = true;
            // 
            // Dgv_Pay
            // 
            Dgv_Pay.FillWeight = 40F;
            Dgv_Pay.HeaderText = "";
            Dgv_Pay.Image = Properties.Resources.pen;
            Dgv_Pay.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Dgv_Pay.MinimumWidth = 6;
            Dgv_Pay.Name = "Dgv_Pay";
            Dgv_Pay.ReadOnly = true;
            // 
            // Bill_List
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 505);
            Controls.Add(Dgv_Bills_List);
            Name = "Bill_List";
            Text = "Bill_List";
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(guna2Panel2, 0);
            Controls.SetChildIndex(Dgv_Bills_List, 0);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Dgv_Bills_List).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Dgv_Bills_List;
        private DataGridViewTextBoxColumn DgvSR;
        private DataGridViewTextBoxColumn Dgv_Id_Order;
        private DataGridViewTextBoxColumn Dgv_Type_Order;
        private DataGridViewTextBoxColumn Dgv_Table;
        private DataGridViewTextBoxColumn Dgv_State_Order;
        private DataGridViewTextBoxColumn DgvPrice;
        private DataGridViewImageColumn Dgv_Pay;
    }
}