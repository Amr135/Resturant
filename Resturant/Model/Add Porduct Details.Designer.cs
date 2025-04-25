namespace Resturant.Model
{
    partial class Add_Porduct_Details
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Txt_NameProduct = new TextBox();
            Txt_PriceProduct = new TextBox();
            Pb_PictureProduct = new PictureBox();
            Bnt_Browse = new Guna.UI2.WinForms.Guna2Button();
            Cb_CategoriesName = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            guna2Panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Pb_PictureProduct).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2Panel1.Size = new Size(800, 125);
            // 
            // guna2Panel2
            // 
            guna2Panel2.Location = new Point(0, 351);
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel2.Size = new Size(800, 99);
            // 
            // label1
            // 
            label1.Size = new Size(175, 32);
            label1.Text = "Prodcut Details";
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
            btnSave.Click += btnSave_Click_1;
            // 
            // Txt_NameProduct
            // 
            Txt_NameProduct.Location = new Point(49, 188);
            Txt_NameProduct.Name = "Txt_NameProduct";
            Txt_NameProduct.Size = new Size(145, 30);
            Txt_NameProduct.TabIndex = 2;
            // 
            // Txt_PriceProduct
            // 
            Txt_PriceProduct.Location = new Point(49, 261);
            Txt_PriceProduct.Name = "Txt_PriceProduct";
            Txt_PriceProduct.Size = new Size(145, 30);
            Txt_PriceProduct.TabIndex = 3;
            // 
            // Pb_PictureProduct
            // 
            Pb_PictureProduct.Location = new Point(570, 150);
            Pb_PictureProduct.Name = "Pb_PictureProduct";
            Pb_PictureProduct.Size = new Size(144, 129);
            Pb_PictureProduct.SizeMode = PictureBoxSizeMode.Zoom;
            Pb_PictureProduct.TabIndex = 5;
            Pb_PictureProduct.TabStop = false;
            // 
            // Bnt_Browse
            // 
            Bnt_Browse.AutoRoundedCorners = true;
            Bnt_Browse.BorderRadius = 21;
            Bnt_Browse.CustomizableEdges = customizableEdges6;
            Bnt_Browse.DisabledState.BorderColor = Color.DarkGray;
            Bnt_Browse.DisabledState.CustomBorderColor = Color.DarkGray;
            Bnt_Browse.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Bnt_Browse.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Bnt_Browse.Font = new Font("Segoe UI", 9F);
            Bnt_Browse.ForeColor = Color.White;
            Bnt_Browse.Location = new Point(593, 285);
            Bnt_Browse.Name = "Bnt_Browse";
            Bnt_Browse.ShadowDecoration.CustomizableEdges = customizableEdges7;
            Bnt_Browse.Size = new Size(108, 44);
            Bnt_Browse.TabIndex = 6;
            Bnt_Browse.Text = "Browse";
            Bnt_Browse.Click += btnBrowse_Click;
            // 
            // Cb_CategoriesName
            // 
            Cb_CategoriesName.FormattingEnabled = true;
            Cb_CategoriesName.Location = new Point(266, 187);
            Cb_CategoriesName.Name = "Cb_CategoriesName";
            Cb_CategoriesName.Size = new Size(178, 31);
            Cb_CategoriesName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 162);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 8;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 161);
            label3.Name = "label3";
            label3.Size = new Size(79, 23);
            label3.TabIndex = 8;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 233);
            label4.Name = "label4";
            label4.Size = new Size(47, 23);
            label4.TabIndex = 8;
            label4.Text = "Price";
            // 
            // Add_Porduct_Details
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Cb_CategoriesName);
            Controls.Add(Bnt_Browse);
            Controls.Add(Pb_PictureProduct);
            Controls.Add(Txt_PriceProduct);
            Controls.Add(Txt_NameProduct);
            Name = "Add_Porduct_Details";
            Text = "Add_Porduct_Details";
            Controls.SetChildIndex(guna2Panel1, 0);
            Controls.SetChildIndex(guna2Panel2, 0);
            Controls.SetChildIndex(Txt_NameProduct, 0);
            Controls.SetChildIndex(Txt_PriceProduct, 0);
            Controls.SetChildIndex(Pb_PictureProduct, 0);
            Controls.SetChildIndex(Bnt_Browse, 0);
            Controls.SetChildIndex(Cb_CategoriesName, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(label4, 0);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Pb_PictureProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Txt_NameProduct;
        private TextBox Txt_PriceProduct;
        private PictureBox Pb_PictureProduct;
        private Guna.UI2.WinForms.Guna2Button Bnt_Browse;
        private ComboBox Cb_CategoriesName;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}