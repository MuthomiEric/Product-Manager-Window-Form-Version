namespace SSM
{
    partial class Create_Product
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
            this.gbAddProducts = new System.Windows.Forms.GroupBox();
            this.cat2lbl = new System.Windows.Forms.Label();
            this.addcatlink = new System.Windows.Forms.LinkLabel();
            this.Categorylblmsg = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtSpecs = new System.Windows.Forms.TextBox();
            this.txtProp = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbAddProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddProducts
            // 
            this.gbAddProducts.BackColor = System.Drawing.SystemColors.Control;
            this.gbAddProducts.Controls.Add(this.cat2lbl);
            this.gbAddProducts.Controls.Add(this.addcatlink);
            this.gbAddProducts.Controls.Add(this.Categorylblmsg);
            this.gbAddProducts.Controls.Add(this.cbCategory);
            this.gbAddProducts.Controls.Add(this.btnCancel);
            this.gbAddProducts.Controls.Add(this.btnSave);
            this.gbAddProducts.Controls.Add(this.txtQty);
            this.gbAddProducts.Controls.Add(this.txtSpecs);
            this.gbAddProducts.Controls.Add(this.txtProp);
            this.gbAddProducts.Controls.Add(this.txtDesc);
            this.gbAddProducts.Controls.Add(this.txtProductName);
            this.gbAddProducts.Controls.Add(this.label10);
            this.gbAddProducts.Controls.Add(this.label6);
            this.gbAddProducts.Controls.Add(this.label5);
            this.gbAddProducts.Controls.Add(this.label4);
            this.gbAddProducts.Controls.Add(this.label2);
            this.gbAddProducts.Controls.Add(this.label7);
            this.gbAddProducts.Controls.Add(this.label8);
            this.gbAddProducts.Location = new System.Drawing.Point(1, 3);
            this.gbAddProducts.Name = "gbAddProducts";
            this.gbAddProducts.Size = new System.Drawing.Size(952, 476);
            this.gbAddProducts.TabIndex = 5;
            this.gbAddProducts.TabStop = false;
            // 
            // cat2lbl
            // 
            this.cat2lbl.AutoSize = true;
            this.cat2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat2lbl.ForeColor = System.Drawing.Color.Red;
            this.cat2lbl.Location = new System.Drawing.Point(385, 257);
            this.cat2lbl.Name = "cat2lbl";
            this.cat2lbl.Size = new System.Drawing.Size(0, 20);
            this.cat2lbl.TabIndex = 36;
            // 
            // addcatlink
            // 
            this.addcatlink.AutoSize = true;
            this.addcatlink.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addcatlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcatlink.LinkColor = System.Drawing.Color.Black;
            this.addcatlink.Location = new System.Drawing.Point(276, 206);
            this.addcatlink.Name = "addcatlink";
            this.addcatlink.Size = new System.Drawing.Size(103, 20);
            this.addcatlink.TabIndex = 35;
            this.addcatlink.TabStop = true;
            this.addcatlink.Text = "Add category";
            this.addcatlink.Visible = false;
            // 
            // Categorylblmsg
            // 
            this.Categorylblmsg.AutoSize = true;
            this.Categorylblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorylblmsg.ForeColor = System.Drawing.Color.Red;
            this.Categorylblmsg.Location = new System.Drawing.Point(385, 236);
            this.Categorylblmsg.Name = "Categorylblmsg";
            this.Categorylblmsg.Size = new System.Drawing.Size(0, 20);
            this.Categorylblmsg.TabIndex = 34;
            // 
            // cbCategory
            // 
            this.cbCategory.DisplayMember = "Category_Name";
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(104, 229);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(275, 33);
            this.cbCategory.TabIndex = 33;
            this.cbCategory.ValueMember = "CategoryId";
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(580, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 52);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(737, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 52);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(104, 322);
            this.txtQty.Margin = new System.Windows.Forms.Padding(6);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(275, 32);
            this.txtQty.TabIndex = 30;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQty_KeyPress_1);
            // 
            // txtSpecs
            // 
            this.txtSpecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecs.Location = new System.Drawing.Point(580, 229);
            this.txtSpecs.Margin = new System.Windows.Forms.Padding(6);
            this.txtSpecs.Name = "txtSpecs";
            this.txtSpecs.Size = new System.Drawing.Size(275, 32);
            this.txtSpecs.TabIndex = 29;
            // 
            // txtProp
            // 
            this.txtProp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProp.Location = new System.Drawing.Point(580, 322);
            this.txtProp.Margin = new System.Windows.Forms.Padding(6);
            this.txtProp.Name = "txtProp";
            this.txtProp.Size = new System.Drawing.Size(275, 32);
            this.txtProp.TabIndex = 28;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(580, 114);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(6);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(275, 32);
            this.txtDesc.TabIndex = 27;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(104, 114);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(6);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(275, 32);
            this.txtProductName.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(338, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 31);
            this.label10.TabIndex = 25;
            this.label10.Text = "Add Products";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 26);
            this.label6.TabIndex = 24;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 23;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(575, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Specifications e.g Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 26);
            this.label2.TabIndex = 21;
            this.label2.Text = "Property eg Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(575, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(99, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "Product Name";
            // 
            // Create_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 480);
            this.Controls.Add(this.gbAddProducts);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Create_Product";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.Create_Product_Load);
            this.gbAddProducts.ResumeLayout(false);
            this.gbAddProducts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAddProducts;
        private System.Windows.Forms.Label cat2lbl;
        private System.Windows.Forms.LinkLabel addcatlink;
        private System.Windows.Forms.Label Categorylblmsg;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtSpecs;
        private System.Windows.Forms.TextBox txtProp;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}