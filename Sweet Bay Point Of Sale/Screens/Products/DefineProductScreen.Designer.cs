namespace Sweet_Bay_Point_Of_Sale.Screens.Products
{
    partial class DefineProductScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxproductname = new System.Windows.Forms.TextBox();
            this.BuyingPrice = new System.Windows.Forms.Label();
            this.textBoxprice = new System.Windows.Forms.TextBox();
            this.SalesPrice = new System.Windows.Forms.Label();
            this.textBoxsaleprice = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.ProductName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Customersearch = new System.Windows.Forms.Label();
            this.textBoxproductsearch = new System.Windows.Forms.TextBox();
            this.dataGridViewrecord = new System.Windows.Forms.DataGridView();
            this.buttondeleteitem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrecord)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxproductname
            // 
            this.textBoxproductname.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textBoxproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductname.Location = new System.Drawing.Point(292, 118);
            this.textBoxproductname.Multiline = true;
            this.textBoxproductname.Name = "textBoxproductname";
            this.textBoxproductname.Size = new System.Drawing.Size(228, 31);
            this.textBoxproductname.TabIndex = 0;
            // 
            // BuyingPrice
            // 
            this.BuyingPrice.AutoSize = true;
            this.BuyingPrice.BackColor = System.Drawing.Color.Black;
            this.BuyingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyingPrice.ForeColor = System.Drawing.Color.Transparent;
            this.BuyingPrice.Location = new System.Drawing.Point(535, 119);
            this.BuyingPrice.Name = "BuyingPrice";
            this.BuyingPrice.Size = new System.Drawing.Size(190, 29);
            this.BuyingPrice.TabIndex = 6;
            this.BuyingPrice.Text = "PurchasePrice:";
            // 
            // textBoxprice
            // 
            this.textBoxprice.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textBoxprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxprice.Location = new System.Drawing.Point(731, 119);
            this.textBoxprice.Multiline = true;
            this.textBoxprice.Name = "textBoxprice";
            this.textBoxprice.Size = new System.Drawing.Size(228, 29);
            this.textBoxprice.TabIndex = 1;
            // 
            // SalesPrice
            // 
            this.SalesPrice.AutoSize = true;
            this.SalesPrice.BackColor = System.Drawing.Color.Black;
            this.SalesPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesPrice.ForeColor = System.Drawing.Color.Transparent;
            this.SalesPrice.Location = new System.Drawing.Point(976, 119);
            this.SalesPrice.Name = "SalesPrice";
            this.SalesPrice.Size = new System.Drawing.Size(147, 29);
            this.SalesPrice.TabIndex = 8;
            this.SalesPrice.Text = "SalesPrice:";
            // 
            // textBoxsaleprice
            // 
            this.textBoxsaleprice.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.textBoxsaleprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsaleprice.Location = new System.Drawing.Point(1129, 115);
            this.textBoxsaleprice.Multiline = true;
            this.textBoxsaleprice.Name = "textBoxsaleprice";
            this.textBoxsaleprice.Size = new System.Drawing.Size(228, 33);
            this.textBoxsaleprice.TabIndex = 2;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.DodgerBlue;
            this.Save.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(410, 439);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(152, 39);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // cancelbtn
            // 
            this.cancelbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.cancelbtn.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbtn.ForeColor = System.Drawing.Color.White;
            this.cancelbtn.Location = new System.Drawing.Point(762, 438);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(154, 39);
            this.cancelbtn.TabIndex = 6;
            this.cancelbtn.Text = "Close";
            this.cancelbtn.UseVisualStyleBackColor = false;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.BackColor = System.Drawing.Color.Black;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.ForeColor = System.Drawing.Color.White;
            this.ProductName.Location = new System.Drawing.Point(86, 118);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(200, 31);
            this.ProductName.TabIndex = 0;
            this.ProductName.Text = "ProductName:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(359, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 59);
            this.label1.TabIndex = 9;
            this.label1.Text = "Products Management";
            // 
            // Customersearch
            // 
            this.Customersearch.AutoSize = true;
            this.Customersearch.BackColor = System.Drawing.Color.White;
            this.Customersearch.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customersearch.ForeColor = System.Drawing.Color.Black;
            this.Customersearch.Location = new System.Drawing.Point(313, 170);
            this.Customersearch.Name = "Customersearch";
            this.Customersearch.Size = new System.Drawing.Size(247, 32);
            this.Customersearch.TabIndex = 13;
            this.Customersearch.Text = "SearchProduct:";
            // 
            // textBoxproductsearch
            // 
            this.textBoxproductsearch.BackColor = System.Drawing.Color.Wheat;
            this.textBoxproductsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxproductsearch.ForeColor = System.Drawing.Color.Black;
            this.textBoxproductsearch.Location = new System.Drawing.Point(566, 170);
            this.textBoxproductsearch.Multiline = true;
            this.textBoxproductsearch.Name = "textBoxproductsearch";
            this.textBoxproductsearch.Size = new System.Drawing.Size(411, 32);
            this.textBoxproductsearch.TabIndex = 12;
            this.textBoxproductsearch.TextChanged += new System.EventHandler(this.textBoxproductsearch_TextChanged);
            // 
            // dataGridViewrecord
            // 
            this.dataGridViewrecord.AllowUserToResizeColumns = false;
            this.dataGridViewrecord.AllowUserToResizeRows = false;
            this.dataGridViewrecord.BackgroundColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewrecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewrecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewrecord.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewrecord.Enabled = false;
            this.dataGridViewrecord.Location = new System.Drawing.Point(319, 212);
            this.dataGridViewrecord.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewrecord.Name = "dataGridViewrecord";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewrecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewrecord.RowHeadersWidth = 20;
            this.dataGridViewrecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewrecord.Size = new System.Drawing.Size(682, 213);
            this.dataGridViewrecord.TabIndex = 14;
            // 
            // buttondeleteitem
            // 
            this.buttondeleteitem.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttondeleteitem.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttondeleteitem.ForeColor = System.Drawing.Color.White;
            this.buttondeleteitem.Location = new System.Drawing.Point(589, 439);
            this.buttondeleteitem.Name = "buttondeleteitem";
            this.buttondeleteitem.Size = new System.Drawing.Size(155, 39);
            this.buttondeleteitem.TabIndex = 15;
            this.buttondeleteitem.Text = "Delete";
            this.buttondeleteitem.UseVisualStyleBackColor = false;
            this.buttondeleteitem.Click += new System.EventHandler(this.buttondeleteitem_Click);
            // 
            // DefineProductScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1411, 501);
            this.Controls.Add(this.buttondeleteitem);
            this.Controls.Add(this.dataGridViewrecord);
            this.Controls.Add(this.Customersearch);
            this.Controls.Add(this.textBoxproductsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textBoxsaleprice);
            this.Controls.Add(this.SalesPrice);
            this.Controls.Add(this.textBoxprice);
            this.Controls.Add(this.BuyingPrice);
            this.Controls.Add(this.textBoxproductname);
            this.Controls.Add(this.ProductName);
            this.MaximumSize = new System.Drawing.Size(1411, 501);
            this.Name = "DefineProductScreen";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Load += new System.EventHandler(this.DefineProductScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewrecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxproductname;
        private System.Windows.Forms.Label BuyingPrice;
        private System.Windows.Forms.TextBox textBoxprice;
        private System.Windows.Forms.Label SalesPrice;
        private System.Windows.Forms.TextBox textBoxsaleprice;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Customersearch;
        private System.Windows.Forms.TextBox textBoxproductsearch;
        private System.Windows.Forms.DataGridView dataGridViewrecord;
        private System.Windows.Forms.Button buttondeleteitem;

    }
}