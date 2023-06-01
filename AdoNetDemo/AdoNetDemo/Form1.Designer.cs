namespace AdoNetDemo
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
            dgwProducts = new DataGridView();
            gbxAdd = new GroupBox();
            tbxUnitPrice = new TextBox();
            lblUnitPrice = new Label();
            tbxStockAmount = new TextBox();
            lblStockAmount = new Label();
            tbxName = new TextBox();
            btnAdd = new Button();
            lblName = new Label();
            gbxUpdate = new GroupBox();
            tbxUnitPriceUpdate = new TextBox();
            label1 = new Label();
            tbxStockAmountUpdate = new TextBox();
            label2 = new Label();
            tbxNameUpdate = new TextBox();
            btnUpdate = new Button();
            label3 = new Label();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwProducts).BeginInit();
            gbxAdd.SuspendLayout();
            gbxUpdate.SuspendLayout();
            SuspendLayout();
            // 
            // dgwProducts
            // 
            dgwProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwProducts.Location = new Point(12, 12);
            dgwProducts.Name = "dgwProducts";
            dgwProducts.RowTemplate.Height = 25;
            dgwProducts.Size = new Size(860, 280);
            dgwProducts.TabIndex = 0;
            dgwProducts.CellClick += dgwProducts_CellClick;
            dgwProducts.CellContentClick += dataGridView1_CellContentClick;
            // 
            // gbxAdd
            // 
            gbxAdd.Controls.Add(tbxUnitPrice);
            gbxAdd.Controls.Add(lblUnitPrice);
            gbxAdd.Controls.Add(tbxStockAmount);
            gbxAdd.Controls.Add(lblStockAmount);
            gbxAdd.Controls.Add(tbxName);
            gbxAdd.Controls.Add(btnAdd);
            gbxAdd.Controls.Add(lblName);
            gbxAdd.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbxAdd.Location = new Point(12, 330);
            gbxAdd.Name = "gbxAdd";
            gbxAdd.Size = new Size(305, 267);
            gbxAdd.TabIndex = 1;
            gbxAdd.TabStop = false;
            gbxAdd.Text = "Add a Product";
            // 
            // tbxUnitPrice
            // 
            tbxUnitPrice.Location = new Point(119, 65);
            tbxUnitPrice.Name = "tbxUnitPrice";
            tbxUnitPrice.Size = new Size(147, 22);
            tbxUnitPrice.TabIndex = 6;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(19, 67);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(59, 14);
            lblUnitPrice.TabIndex = 5;
            lblUnitPrice.Text = "Unit Price";
            // 
            // tbxStockAmount
            // 
            tbxStockAmount.Location = new Point(119, 93);
            tbxStockAmount.Name = "tbxStockAmount";
            tbxStockAmount.Size = new Size(147, 22);
            tbxStockAmount.TabIndex = 4;
            // 
            // lblStockAmount
            // 
            lblStockAmount.AutoSize = true;
            lblStockAmount.Location = new Point(19, 96);
            lblStockAmount.Name = "lblStockAmount";
            lblStockAmount.Size = new Size(86, 14);
            lblStockAmount.TabIndex = 3;
            lblStockAmount.Text = "Stock Amount";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(119, 35);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(147, 22);
            tbxName.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(60, 146);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(148, 42);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 38);
            lblName.Name = "lblName";
            lblName.Size = new Size(38, 14);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // gbxUpdate
            // 
            gbxUpdate.Controls.Add(tbxUnitPriceUpdate);
            gbxUpdate.Controls.Add(label1);
            gbxUpdate.Controls.Add(tbxStockAmountUpdate);
            gbxUpdate.Controls.Add(label2);
            gbxUpdate.Controls.Add(tbxNameUpdate);
            gbxUpdate.Controls.Add(btnUpdate);
            gbxUpdate.Controls.Add(label3);
            gbxUpdate.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbxUpdate.Location = new Point(567, 330);
            gbxUpdate.Name = "gbxUpdate";
            gbxUpdate.Size = new Size(305, 267);
            gbxUpdate.TabIndex = 2;
            gbxUpdate.TabStop = false;
            gbxUpdate.Text = "Update a Product";
            // 
            // tbxUnitPriceUpdate
            // 
            tbxUnitPriceUpdate.Location = new Point(119, 65);
            tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            tbxUnitPriceUpdate.Size = new Size(147, 22);
            tbxUnitPriceUpdate.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 67);
            label1.Name = "label1";
            label1.Size = new Size(59, 14);
            label1.TabIndex = 5;
            label1.Text = "Unit Price";
            // 
            // tbxStockAmountUpdate
            // 
            tbxStockAmountUpdate.Location = new Point(119, 93);
            tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            tbxStockAmountUpdate.Size = new Size(147, 22);
            tbxStockAmountUpdate.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 96);
            label2.Name = "label2";
            label2.Size = new Size(86, 14);
            label2.TabIndex = 3;
            label2.Text = "Stock Amount";
            // 
            // tbxNameUpdate
            // 
            tbxNameUpdate.Location = new Point(119, 35);
            tbxNameUpdate.Name = "tbxNameUpdate";
            tbxNameUpdate.Size = new Size(147, 22);
            tbxNameUpdate.TabIndex = 2;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(60, 146);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(148, 42);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 38);
            label3.Name = "label3";
            label3.Size = new Size(38, 14);
            label3.TabIndex = 0;
            label3.Text = "Name";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(367, 330);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(155, 267);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 609);
            Controls.Add(btnRemove);
            Controls.Add(gbxUpdate);
            Controls.Add(gbxAdd);
            Controls.Add(dgwProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgwProducts).EndInit();
            gbxAdd.ResumeLayout(false);
            gbxAdd.PerformLayout();
            gbxUpdate.ResumeLayout(false);
            gbxUpdate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwProducts;
        private GroupBox gbxAdd;
        private TextBox tbxUnitPrice;
        private Label lblUnitPrice;
        private TextBox tbxStockAmount;
        private Label lblStockAmount;
        private TextBox tbxName;
        private Button btnAdd;
        private Label lblName;
        private GroupBox gbxUpdate;
        private TextBox tbxUnitPriceUpdate;
        private Label label1;
        private TextBox tbxStockAmountUpdate;
        private Label label2;
        private TextBox tbxNameUpdate;
        private Button btnUpdate;
        private Label label3;
        private Button btnRemove;
    }
}