namespace Sweet_Bay_Point_Of_Sale.Screens
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Closse = new System.Windows.Forms.Button();
            this.sales = new System.Windows.Forms.Button();
            this.Customermanage = new System.Windows.Forms.Button();
            this.productbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(80, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1197, 116);
            this.label2.TabIndex = 1;
            this.label2.Text = "SweetBay|SuperMart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(745, 608);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "ContactUs +92 21 546 87256";
            // 
            // Closse
            // 
            this.Closse.BackColor = System.Drawing.Color.White;
            this.Closse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Closse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Closse.ForeColor = System.Drawing.Color.Black;
            this.Closse.Image = global::Sweet_Bay_Point_Of_Sale.Properties.Resources.exit;
            this.Closse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Closse.Location = new System.Drawing.Point(279, 517);
            this.Closse.Name = "Closse";
            this.Closse.Size = new System.Drawing.Size(395, 108);
            this.Closse.TabIndex = 5;
            this.Closse.Text = "Exit";
            this.Closse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Closse.UseVisualStyleBackColor = false;
            this.Closse.Click += new System.EventHandler(this.Closse_Click);
            // 
            // sales
            // 
            this.sales.BackColor = System.Drawing.Color.White;
            this.sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sales.ForeColor = System.Drawing.Color.Black;
            this.sales.Image = global::Sweet_Bay_Point_Of_Sale.Properties.Resources.sales;
            this.sales.Location = new System.Drawing.Point(279, 389);
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(395, 107);
            this.sales.TabIndex = 2;
            this.sales.Text = "Add New Sales Order";
            this.sales.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sales.UseVisualStyleBackColor = false;
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // Customermanage
            // 
            this.Customermanage.BackColor = System.Drawing.Color.White;
            this.Customermanage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Customermanage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Customermanage.ForeColor = System.Drawing.Color.Black;
            this.Customermanage.Image = global::Sweet_Bay_Point_Of_Sale.Properties.Resources.j;
            this.Customermanage.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Customermanage.Location = new System.Drawing.Point(279, 264);
            this.Customermanage.Name = "Customermanage";
            this.Customermanage.Size = new System.Drawing.Size(395, 104);
            this.Customermanage.TabIndex = 1;
            this.Customermanage.Text = "Add Customers";
            this.Customermanage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Customermanage.UseVisualStyleBackColor = false;
            this.Customermanage.Click += new System.EventHandler(this.Customermanage_Click);
            // 
            // productbutton
            // 
            this.productbutton.BackColor = System.Drawing.Color.White;
            this.productbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.productbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productbutton.Image = global::Sweet_Bay_Point_Of_Sale.Properties.Resources.products;
            this.productbutton.Location = new System.Drawing.Point(279, 122);
            this.productbutton.Name = "productbutton";
            this.productbutton.Size = new System.Drawing.Size(395, 123);
            this.productbutton.TabIndex = 0;
            this.productbutton.Text = "Add Products";
            this.productbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.productbutton.UseVisualStyleBackColor = false;
            this.productbutton.Click += new System.EventHandler(this.productbutton_Click);
            // 
            // DashboardForm
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Sweet_Bay_Point_Of_Sale.Properties.Resources._500_F_195969397_NO7BSew9KPa2DoxZJeFWgbyUc7joPGDc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1001, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Closse);
            this.Controls.Add(this.sales);
            this.Controls.Add(this.Customermanage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1027, 800);
            this.MinimumSize = new System.Drawing.Size(1027, 624);
            this.Name = "DashboardForm";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Button manageproducts;
        private System.Windows.Forms.Button stockmanage;
        private System.Windows.Forms.Button categories;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button salesorder;
        private System.Windows.Forms.Button orderecord;
        private System.Windows.Forms.Button passwordchange;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Button closing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button productbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Customermanage;
        private System.Windows.Forms.Button sales;
        private System.Windows.Forms.Button Closse;
        private System.Windows.Forms.Label label3;

    }
}