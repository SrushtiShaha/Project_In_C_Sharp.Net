
namespace Ayuraj_Computer_Shopee_App.Forms.Product
{
    partial class frm_Add_New_Product
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
            this.pnl_Navigation_Bar = new System.Windows.Forms.Panel();
            this.pb_Logout = new System.Windows.Forms.PictureBox();
            this.pb_Back = new System.Windows.Forms.PictureBox();
            this.lbl_Add_Product = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_Product_Quantity = new System.Windows.Forms.Label();
            this.tb_Product_Quantity = new System.Windows.Forms.TextBox();
            this.dtp_Import_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Sales_Price = new System.Windows.Forms.TextBox();
            this.tb_Purchase_Price = new System.Windows.Forms.TextBox();
            this.lbl_Import_Date = new System.Windows.Forms.Label();
            this.lbl_Sales_Price = new System.Windows.Forms.Label();
            this.lbl_Purchase_Prise = new System.Windows.Forms.Label();
            this.tb_Product_Id = new System.Windows.Forms.TextBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.lbl_Product_Id = new System.Windows.Forms.Label();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.tb_Product_Name = new System.Windows.Forms.TextBox();
            this.tb_Category_Name = new System.Windows.Forms.TextBox();
            this.pnl_Navigation_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Navigation_Bar
            // 
            this.pnl_Navigation_Bar.BackColor = System.Drawing.Color.Purple;
            this.pnl_Navigation_Bar.Controls.Add(this.pb_Logout);
            this.pnl_Navigation_Bar.Controls.Add(this.pb_Back);
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_Add_Product);
            this.pnl_Navigation_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Navigation_Bar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Navigation_Bar.Name = "pnl_Navigation_Bar";
            this.pnl_Navigation_Bar.Size = new System.Drawing.Size(1182, 110);
            this.pnl_Navigation_Bar.TabIndex = 2;
            // 
            // pb_Logout
            // 
            this.pb_Logout.BackColor = System.Drawing.Color.White;
            this.pb_Logout.Image = global::Ayuraj_Computer_Shopee_App.Properties.Resources.LOG;
            this.pb_Logout.Location = new System.Drawing.Point(1028, 0);
            this.pb_Logout.Name = "pb_Logout";
            this.pb_Logout.Size = new System.Drawing.Size(154, 110);
            this.pb_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logout.TabIndex = 59;
            this.pb_Logout.TabStop = false;
            this.pb_Logout.Click += new System.EventHandler(this.pb_Logout_Click);
            // 
            // pb_Back
            // 
            this.pb_Back.BackColor = System.Drawing.Color.White;
            this.pb_Back.Image = global::Ayuraj_Computer_Shopee_App.Properties.Resources.Back;
            this.pb_Back.Location = new System.Drawing.Point(0, 0);
            this.pb_Back.Name = "pb_Back";
            this.pb_Back.Size = new System.Drawing.Size(154, 110);
            this.pb_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Back.TabIndex = 58;
            this.pb_Back.TabStop = false;
            this.pb_Back.Click += new System.EventHandler(this.pb_Back_Click);
            // 
            // lbl_Add_Product
            // 
            this.lbl_Add_Product.AutoSize = true;
            this.lbl_Add_Product.Font = new System.Drawing.Font("Modern No. 20", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Product.ForeColor = System.Drawing.Color.White;
            this.lbl_Add_Product.Location = new System.Drawing.Point(316, 19);
            this.lbl_Add_Product.Name = "lbl_Add_Product";
            this.lbl_Add_Product.Size = new System.Drawing.Size(527, 70);
            this.lbl_Add_Product.TabIndex = 0;
            this.lbl_Add_Product.Text = "Add New Product";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Save.Location = new System.Drawing.Point(733, 605);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(173, 52);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Location = new System.Drawing.Point(244, 605);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(173, 52);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // lbl_Product_Quantity
            // 
            this.lbl_Product_Quantity.AutoSize = true;
            this.lbl_Product_Quantity.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Quantity.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Product_Quantity.Location = new System.Drawing.Point(69, 470);
            this.lbl_Product_Quantity.Name = "lbl_Product_Quantity";
            this.lbl_Product_Quantity.Size = new System.Drawing.Size(204, 32);
            this.lbl_Product_Quantity.TabIndex = 71;
            this.lbl_Product_Quantity.Text = "Product Quantity";
            // 
            // tb_Product_Quantity
            // 
            this.tb_Product_Quantity.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Quantity.Location = new System.Drawing.Point(310, 470);
            this.tb_Product_Quantity.MaxLength = 5;
            this.tb_Product_Quantity.Name = "tb_Product_Quantity";
            this.tb_Product_Quantity.Size = new System.Drawing.Size(257, 34);
            this.tb_Product_Quantity.TabIndex = 4;
            this.tb_Product_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // dtp_Import_Date
            // 
            this.dtp_Import_Date.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Import_Date.Location = new System.Drawing.Point(857, 382);
            this.dtp_Import_Date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_Import_Date.Name = "dtp_Import_Date";
            this.dtp_Import_Date.Size = new System.Drawing.Size(257, 34);
            this.dtp_Import_Date.TabIndex = 7;
            this.dtp_Import_Date.Value = new System.DateTime(2023, 10, 28, 0, 0, 0, 0);
            // 
            // tb_Sales_Price
            // 
            this.tb_Sales_Price.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Sales_Price.Location = new System.Drawing.Point(857, 286);
            this.tb_Sales_Price.MaxLength = 7;
            this.tb_Sales_Price.Name = "tb_Sales_Price";
            this.tb_Sales_Price.Size = new System.Drawing.Size(257, 34);
            this.tb_Sales_Price.TabIndex = 6;
            this.tb_Sales_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Purchase_Price
            // 
            this.tb_Purchase_Price.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Purchase_Price.Location = new System.Drawing.Point(857, 188);
            this.tb_Purchase_Price.MaxLength = 7;
            this.tb_Purchase_Price.Name = "tb_Purchase_Price";
            this.tb_Purchase_Price.Size = new System.Drawing.Size(257, 34);
            this.tb_Purchase_Price.TabIndex = 5;
            this.tb_Purchase_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Import_Date
            // 
            this.lbl_Import_Date.AutoSize = true;
            this.lbl_Import_Date.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Import_Date.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Import_Date.Location = new System.Drawing.Point(621, 382);
            this.lbl_Import_Date.Name = "lbl_Import_Date";
            this.lbl_Import_Date.Size = new System.Drawing.Size(147, 32);
            this.lbl_Import_Date.TabIndex = 68;
            this.lbl_Import_Date.Text = "Import Date";
            // 
            // lbl_Sales_Price
            // 
            this.lbl_Sales_Price.AutoSize = true;
            this.lbl_Sales_Price.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sales_Price.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Sales_Price.Location = new System.Drawing.Point(616, 288);
            this.lbl_Sales_Price.Name = "lbl_Sales_Price";
            this.lbl_Sales_Price.Size = new System.Drawing.Size(132, 32);
            this.lbl_Sales_Price.TabIndex = 67;
            this.lbl_Sales_Price.Text = "Sales Price";
            // 
            // lbl_Purchase_Prise
            // 
            this.lbl_Purchase_Prise.AutoSize = true;
            this.lbl_Purchase_Prise.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Purchase_Prise.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Purchase_Prise.Location = new System.Drawing.Point(616, 191);
            this.lbl_Purchase_Prise.Name = "lbl_Purchase_Prise";
            this.lbl_Purchase_Prise.Size = new System.Drawing.Size(175, 32);
            this.lbl_Purchase_Prise.TabIndex = 66;
            this.lbl_Purchase_Prise.Text = "Purchase Price";
            // 
            // tb_Product_Id
            // 
            this.tb_Product_Id.Enabled = false;
            this.tb_Product_Id.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Id.Location = new System.Drawing.Point(310, 188);
            this.tb_Product_Id.MaxLength = 5;
            this.tb_Product_Id.Name = "tb_Product_Id";
            this.tb_Product_Id.Size = new System.Drawing.Size(257, 34);
            this.tb_Product_Id.TabIndex = 1;
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Category_Name.Location = new System.Drawing.Point(69, 382);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(183, 32);
            this.lbl_Category_Name.TabIndex = 65;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // lbl_Product_Id
            // 
            this.lbl_Product_Id.AutoSize = true;
            this.lbl_Product_Id.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Id.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Product_Id.Location = new System.Drawing.Point(69, 188);
            this.lbl_Product_Id.Name = "lbl_Product_Id";
            this.lbl_Product_Id.Size = new System.Drawing.Size(135, 32);
            this.lbl_Product_Id.TabIndex = 64;
            this.lbl_Product_Id.Text = "Product ID";
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Product_Name.Location = new System.Drawing.Point(69, 288);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(171, 32);
            this.lbl_Product_Name.TabIndex = 73;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // tb_Product_Name
            // 
            this.tb_Product_Name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Product_Name.Location = new System.Drawing.Point(310, 288);
            this.tb_Product_Name.MaxLength = 30;
            this.tb_Product_Name.Name = "tb_Product_Name";
            this.tb_Product_Name.Size = new System.Drawing.Size(257, 34);
            this.tb_Product_Name.TabIndex = 2;
            // 
            // tb_Category_Name
            // 
            this.tb_Category_Name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Category_Name.Location = new System.Drawing.Point(310, 380);
            this.tb_Category_Name.MaxLength = 30;
            this.tb_Category_Name.Name = "tb_Category_Name";
            this.tb_Category_Name.Size = new System.Drawing.Size(257, 34);
            this.tb_Category_Name.TabIndex = 3;
            // 
            // frm_Add_New_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1182, 693);
            this.ControlBox = false;
            this.Controls.Add(this.tb_Category_Name);
            this.Controls.Add(this.lbl_Product_Name);
            this.Controls.Add(this.tb_Product_Name);
            this.Controls.Add(this.lbl_Product_Quantity);
            this.Controls.Add(this.tb_Product_Quantity);
            this.Controls.Add(this.dtp_Import_Date);
            this.Controls.Add(this.tb_Sales_Price);
            this.Controls.Add(this.tb_Purchase_Price);
            this.Controls.Add(this.lbl_Import_Date);
            this.Controls.Add(this.lbl_Sales_Price);
            this.Controls.Add(this.lbl_Purchase_Prise);
            this.Controls.Add(this.tb_Product_Id);
            this.Controls.Add(this.lbl_Category_Name);
            this.Controls.Add(this.lbl_Product_Id);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.pnl_Navigation_Bar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.frm_Add_New_Product_Load);
            this.pnl_Navigation_Bar.ResumeLayout(false);
            this.pnl_Navigation_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Navigation_Bar;
        private System.Windows.Forms.Label lbl_Add_Product;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.PictureBox pb_Back;
        private System.Windows.Forms.PictureBox pb_Logout;
        private System.Windows.Forms.Label lbl_Product_Quantity;
        private System.Windows.Forms.TextBox tb_Product_Quantity;
        private System.Windows.Forms.DateTimePicker dtp_Import_Date;
        private System.Windows.Forms.TextBox tb_Sales_Price;
        private System.Windows.Forms.TextBox tb_Purchase_Price;
        private System.Windows.Forms.Label lbl_Import_Date;
        private System.Windows.Forms.Label lbl_Sales_Price;
        private System.Windows.Forms.Label lbl_Purchase_Prise;
        private System.Windows.Forms.TextBox tb_Product_Id;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.Label lbl_Product_Id;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.TextBox tb_Product_Name;
        private System.Windows.Forms.TextBox tb_Category_Name;
    }
}