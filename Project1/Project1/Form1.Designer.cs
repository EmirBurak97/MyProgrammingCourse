namespace Project1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbxCategory = new GroupBox();
            cbxCategory = new ComboBox();
            lblCategory = new Label();
            gbxtbxSearch = new GroupBox();
            tbxSearch = new TextBox();
            lbltbxSearch = new Label();
            dgwProducts = new DataGridView();
            gbxCategory.SuspendLayout();
            gbxtbxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            SuspendLayout();
            // 
            // gbxCategory
            // 
            gbxCategory.Controls.Add(cbxCategory);
            gbxCategory.Controls.Add(lblCategory);
            gbxCategory.Location = new Point(12, 12);
            gbxCategory.Name = "gbxCategory";
            gbxCategory.Size = new Size(776, 93);
            gbxCategory.TabIndex = 0;
            gbxCategory.TabStop = false;
            gbxCategory.Text = "Kategoriye Göre Listele";
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(87, 36);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(196, 23);
            cbxCategory.TabIndex = 1;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(21, 39);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(60, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Kategori : ";
            // 
            // gbxtbxSearch
            // 
            gbxtbxSearch.Controls.Add(tbxSearch);
            gbxtbxSearch.Controls.Add(lbltbxSearch);
            gbxtbxSearch.Location = new Point(12, 111);
            gbxtbxSearch.Name = "gbxtbxSearch";
            gbxtbxSearch.Size = new Size(776, 93);
            gbxtbxSearch.TabIndex = 2;
            gbxtbxSearch.TabStop = false;
            gbxtbxSearch.Text = "Ürün İsmine Göre Listele";
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(87, 36);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(196, 23);
            tbxSearch.TabIndex = 1;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // lbltbxSearch
            // 
            lbltbxSearch.AutoSize = true;
            lbltbxSearch.Location = new Point(21, 39);
            lbltbxSearch.Name = "lbltbxSearch";
            lbltbxSearch.Size = new Size(34, 15);
            lbltbxSearch.TabIndex = 0;
            lbltbxSearch.Text = "Ara : ";
            // 
            // dgwProducts
            // 
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(12, 210);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowTemplate.Height = 25;
            dgwProducts.Size = new Size(776, 252);
            dgwProducts.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 530);
            Controls.Add(dgwProducts);
            Controls.Add(gbxtbxSearch);
            Controls.Add(gbxCategory);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbxCategory.ResumeLayout(false);
            gbxCategory.PerformLayout();
            gbxtbxSearch.ResumeLayout(false);
            gbxtbxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxCategory;
        private ComboBox cbxCategory;
        private Label lblCategory;
        private GroupBox gbxtbxSearch;
        private TextBox tbxSearch;
        private Label lbltbxSearch;
        private DataGridView dgwProducts;
    }
}