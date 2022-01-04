namespace Sweet_Bay_Point_Of_Sale.Screens.CustomerF
{
    partial class NewCustomerForm
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
            this.textBoxcustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCustomerMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxadress = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxcustomersearch = new System.Windows.Forms.TextBox();
            this.Customersearch = new System.Windows.Forms.Label();
            this.dataGridViewcustomer = new System.Windows.Forms.DataGridView();
            this.Deletebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name:";
            // 
            // textBoxcustomerName
            // 
            this.textBoxcustomerName.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxcustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcustomerName.Location = new System.Drawing.Point(222, 110);
            this.textBoxcustomerName.Multiline = true;
            this.textBoxcustomerName.Name = "textBoxcustomerName";
            this.textBoxcustomerName.Size = new System.Drawing.Size(233, 25);
            this.textBoxcustomerName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(480, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Mobile:";
            // 
            // textBoxCustomerMobile
            // 
            this.textBoxCustomerMobile.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxCustomerMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomerMobile.Location = new System.Drawing.Point(684, 110);
            this.textBoxCustomerMobile.MaxLength = 15;
            this.textBoxCustomerMobile.Multiline = true;
            this.textBoxCustomerMobile.Name = "textBoxCustomerMobile";
            this.textBoxCustomerMobile.Size = new System.Drawing.Size(233, 25);
            this.textBoxCustomerMobile.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Khaki;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(942, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Adress:";
            // 
            // textBoxadress
            // 
            this.textBoxadress.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.textBoxadress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxadress.Location = new System.Drawing.Point(1150, 110);
            this.textBoxadress.Multiline = true;
            this.textBoxadress.Name = "textBoxadress";
            this.textBoxadress.Size = new System.Drawing.Size(239, 27);
            this.textBoxadress.TabIndex = 2;
            this.textBoxadress.Text = " ";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.DodgerBlue;
            this.Close.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(778, 451);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(139, 39);
            this.Close.TabIndex = 5;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.DodgerBlue;
            this.Savebutton.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.ForeColor = System.Drawing.Color.White;
            this.Savebutton.Location = new System.Drawing.Point(395, 451);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(146, 40);
            this.Savebutton.TabIndex = 4;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Verdana", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(411, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(538, 59);
            this.label4.TabIndex = 6;
            this.label4.Text = "Manage Customers";
            // 
            // textBoxcustomersearch
            // 
            this.textBoxcustomersearch.BackColor = System.Drawing.Color.NavajoWhite;
            this.textBoxcustomersearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxcustomersearch.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxcustomersearch.Location = new System.Drawing.Point(550, 168);
            this.textBoxcustomersearch.Multiline = true;
            this.textBoxcustomersearch.Name = "textBoxcustomersearch";
            this.textBoxcustomersearch.Size = new System.Drawing.Size(399, 32);
            this.textBoxcustomersearch.TabIndex = 8;
            this.textBoxcustomersearch.TextChanged += new System.EventHandler(this.textBoxcustomersearch_TextChanged);
            // 
            // Customersearch
            // 
            this.Customersearch.AutoSize = true;
            this.Customersearch.BackColor = System.Drawing.Color.White;
            this.Customersearch.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customersearch.ForeColor = System.Drawing.Color.Black;
            this.Customersearch.Location = new System.Drawing.Point(279, 168);
            this.Customersearch.Name = "Customersearch";
            this.Customersearch.Size = new System.Drawing.Size(275, 32);
            this.Customersearch.TabIndex = 7;
            this.Customersearch.Text = "SearchCustomer:";
            // 
            // dataGridViewcustomer
            // 
            this.dataGridViewcustomer.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridViewcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcustomer.Location = new System.Drawing.Point(285, 217);
            this.dataGridViewcustomer.Name = "dataGridViewcustomer";
            this.dataGridViewcustomer.Size = new System.Drawing.Size(701, 211);
            this.dataGridViewcustomer.TabIndex = 9;
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.DodgerBlue;
            this.Deletebutton.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.ForeColor = System.Drawing.Color.White;
            this.Deletebutton.Location = new System.Drawing.Point(585, 451);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(139, 39);
            this.Deletebutton.TabIndex = 10;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // NewCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1432, 539);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.dataGridViewcustomer);
            this.Controls.Add(this.textBoxcustomersearch);
            this.Controls.Add(this.Customersearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.textBoxadress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCustomerMobile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxcustomerName);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1432, 539);
            this.Name = "NewCustomerForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.NewCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxcustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCustomerMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.TextBox textBoxadress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxcustomersearch;
        private System.Windows.Forms.Label Customersearch;
        private System.Windows.Forms.DataGridView dataGridViewcustomer;
        private System.Windows.Forms.Button Deletebutton;
    }
}