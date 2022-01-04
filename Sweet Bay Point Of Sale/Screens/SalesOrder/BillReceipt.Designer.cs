namespace Sweet_Bay_Point_Of_Sale.Screens.SalesOrder
{
    partial class BillReceipt
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
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.billgrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxpaidamount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxReturnamount = new System.Windows.Forms.TextBox();
            this.billbtn = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.billgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Grand Total:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label8.Font = new System.Drawing.Font("Verdana", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(407, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(440, 78);
            this.label8.TabIndex = 24;
            this.label8.Text = "Bill Receipt";
            // 
            // billgrid
            // 
            this.billgrid.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.billgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billgrid.Location = new System.Drawing.Point(218, 201);
            this.billgrid.Name = "billgrid";
            this.billgrid.Size = new System.Drawing.Size(839, 287);
            this.billgrid.TabIndex = 25;
            this.billgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billgrid_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(420, 509);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 29);
            this.label9.TabIndex = 29;
            this.label9.Text = "ReturnAmount:";
            // 
            // textBoxpaidamount
            // 
            this.textBoxpaidamount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBoxpaidamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxpaidamount.Location = new System.Drawing.Point(747, 154);
            this.textBoxpaidamount.Multiline = true;
            this.textBoxpaidamount.Name = "textBoxpaidamount";
            this.textBoxpaidamount.Size = new System.Drawing.Size(209, 32);
            this.textBoxpaidamount.TabIndex = 26;
            this.textBoxpaidamount.TextChanged += new System.EventHandler(this.textBoxpaidamount_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(578, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Paid Amount:";
            // 
            // textBoxReturnamount
            // 
            this.textBoxReturnamount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBoxReturnamount.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxReturnamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReturnamount.Location = new System.Drawing.Point(622, 512);
            this.textBoxReturnamount.Multiline = true;
            this.textBoxReturnamount.Name = "textBoxReturnamount";
            this.textBoxReturnamount.ReadOnly = true;
            this.textBoxReturnamount.Size = new System.Drawing.Size(209, 32);
            this.textBoxReturnamount.TabIndex = 27;
            // 
            // billbtn
            // 
            this.billbtn.BackColor = System.Drawing.Color.DimGray;
            this.billbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.billbtn.Location = new System.Drawing.Point(989, 151);
            this.billbtn.Name = "billbtn";
            this.billbtn.Size = new System.Drawing.Size(141, 36);
            this.billbtn.TabIndex = 30;
            this.billbtn.Text = "GetBill";
            this.billbtn.UseVisualStyleBackColor = false;
            this.billbtn.Click += new System.EventHandler(this.billbtn_Click);
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.DodgerBlue;
            this.EXIT.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.Color.White;
            this.EXIT.Location = new System.Drawing.Point(411, 577);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(522, 49);
            this.EXIT.TabIndex = 31;
            this.EXIT.Text = "Exit";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.Backbtn.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.Color.White;
            this.Backbtn.Location = new System.Drawing.Point(1147, 151);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(131, 37);
            this.Backbtn.TabIndex = 34;
            this.Backbtn.Text = "Go Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(345, 154);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(209, 32);
            this.textBox2.TabIndex = 36;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BillReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 638);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.billbtn);
            this.Controls.Add(this.textBoxReturnamount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxpaidamount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.billgrid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(1344, 1000);
            this.Name = "BillReceipt";
            this.Load += new System.EventHandler(this.BillReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView billgrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxpaidamount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxReturnamount;
        private System.Windows.Forms.Button billbtn;
        private System.Windows.Forms.Button EXIT;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.TextBox textBox2;
    }
}