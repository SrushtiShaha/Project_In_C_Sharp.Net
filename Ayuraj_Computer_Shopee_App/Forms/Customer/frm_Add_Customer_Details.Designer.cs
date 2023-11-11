
namespace Ayuraj_Computer_Shopee_App.Forms.Customer
{
    partial class frm_Add_Customer_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Navigation_Bar = new System.Windows.Forms.Panel();
            this.pb_Logout = new System.Windows.Forms.PictureBox();
            this.pb_Back = new System.Windows.Forms.PictureBox();
            this.lbl_Add_New_Customer = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dtp_Bill_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Cust_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Cust_Name = new System.Windows.Forms.TextBox();
            this.tb_Customer_ID = new System.Windows.Forms.TextBox();
            this.lbl_Bill_Date = new System.Windows.Forms.Label();
            this.lbl_Cust_Name = new System.Windows.Forms.Label();
            this.lbl_Cust_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Customer_Id = new System.Windows.Forms.Label();
            this.dgv_Customer_Details = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.tb_Total_Price = new System.Windows.Forms.TextBox();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Cust_Total_Price = new System.Windows.Forms.Label();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Cust_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Cust_Price = new System.Windows.Forms.Label();
            this.lbl_Cust_Quantity = new System.Windows.Forms.Label();
            this.tb_Total_Bill = new System.Windows.Forms.TextBox();
            this.lbl_Total_Bill = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.pnl_Navigation_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Navigation_Bar
            // 
            this.pnl_Navigation_Bar.BackColor = System.Drawing.Color.Purple;
            this.pnl_Navigation_Bar.Controls.Add(this.pb_Logout);
            this.pnl_Navigation_Bar.Controls.Add(this.pb_Back);
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_Add_New_Customer);
            this.pnl_Navigation_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Navigation_Bar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Navigation_Bar.Name = "pnl_Navigation_Bar";
            this.pnl_Navigation_Bar.Size = new System.Drawing.Size(1182, 110);
            this.pnl_Navigation_Bar.TabIndex = 7;
            // 
            // pb_Logout
            // 
            this.pb_Logout.BackColor = System.Drawing.Color.White;
            this.pb_Logout.Image = global::Ayuraj_Computer_Shopee_App.Properties.Resources.LOG;
            this.pb_Logout.Location = new System.Drawing.Point(1028, 0);
            this.pb_Logout.Name = "pb_Logout";
            this.pb_Logout.Size = new System.Drawing.Size(154, 110);
            this.pb_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logout.TabIndex = 2;
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
            this.pb_Back.TabIndex = 1;
            this.pb_Back.TabStop = false;
            this.pb_Back.Click += new System.EventHandler(this.pb_Back_Click);
            // 
            // lbl_Add_New_Customer
            // 
            this.lbl_Add_New_Customer.AutoSize = true;
            this.lbl_Add_New_Customer.Font = new System.Drawing.Font("Modern No. 20", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Customer.ForeColor = System.Drawing.Color.White;
            this.lbl_Add_New_Customer.Location = new System.Drawing.Point(301, 19);
            this.lbl_Add_New_Customer.Name = "lbl_Add_New_Customer";
            this.lbl_Add_New_Customer.Size = new System.Drawing.Size(564, 70);
            this.lbl_Add_New_Customer.TabIndex = 0;
            this.lbl_Add_New_Customer.Text = "Add New Customer";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Save.Location = new System.Drawing.Point(292, 625);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(131, 52);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dtp_Bill_Date
            // 
            this.dtp_Bill_Date.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Bill_Date.Location = new System.Drawing.Point(839, 192);
            this.dtp_Bill_Date.Name = "dtp_Bill_Date";
            this.dtp_Bill_Date.Size = new System.Drawing.Size(257, 34);
            this.dtp_Bill_Date.TabIndex = 4;
            // 
            // tb_Cust_Mobile_No
            // 
            this.tb_Cust_Mobile_No.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cust_Mobile_No.Location = new System.Drawing.Point(839, 142);
            this.tb_Cust_Mobile_No.MaxLength = 10;
            this.tb_Cust_Mobile_No.Name = "tb_Cust_Mobile_No";
            this.tb_Cust_Mobile_No.Size = new System.Drawing.Size(257, 34);
            this.tb_Cust_Mobile_No.TabIndex = 3;
            this.tb_Cust_Mobile_No.TextChanged += new System.EventHandler(this.tb_Cust_Mobile_No_TextChanged);
            this.tb_Cust_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Cust_Name
            // 
            this.tb_Cust_Name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Cust_Name.Location = new System.Drawing.Point(292, 192);
            this.tb_Cust_Name.MaxLength = 30;
            this.tb_Cust_Name.Name = "tb_Cust_Name";
            this.tb_Cust_Name.Size = new System.Drawing.Size(257, 34);
            this.tb_Cust_Name.TabIndex = 2;
            // 
            // tb_Customer_ID
            // 
            this.tb_Customer_ID.Enabled = false;
            this.tb_Customer_ID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Customer_ID.Location = new System.Drawing.Point(292, 142);
            this.tb_Customer_ID.MaxLength = 5;
            this.tb_Customer_ID.Name = "tb_Customer_ID";
            this.tb_Customer_ID.Size = new System.Drawing.Size(257, 34);
            this.tb_Customer_ID.TabIndex = 1;
            // 
            // lbl_Bill_Date
            // 
            this.lbl_Bill_Date.AutoSize = true;
            this.lbl_Bill_Date.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bill_Date.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Bill_Date.Location = new System.Drawing.Point(645, 195);
            this.lbl_Bill_Date.Name = "lbl_Bill_Date";
            this.lbl_Bill_Date.Size = new System.Drawing.Size(110, 32);
            this.lbl_Bill_Date.TabIndex = 18;
            this.lbl_Bill_Date.Text = "Bill Date";
            // 
            // lbl_Cust_Name
            // 
            this.lbl_Cust_Name.AutoSize = true;
            this.lbl_Cust_Name.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cust_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Cust_Name.Location = new System.Drawing.Point(55, 195);
            this.lbl_Cust_Name.Name = "lbl_Cust_Name";
            this.lbl_Cust_Name.Size = new System.Drawing.Size(192, 32);
            this.lbl_Cust_Name.TabIndex = 16;
            this.lbl_Cust_Name.Text = "Customer Name";
            // 
            // lbl_Cust_Mobile_No
            // 
            this.lbl_Cust_Mobile_No.AutoSize = true;
            this.lbl_Cust_Mobile_No.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cust_Mobile_No.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Cust_Mobile_No.Location = new System.Drawing.Point(645, 145);
            this.lbl_Cust_Mobile_No.Name = "lbl_Cust_Mobile_No";
            this.lbl_Cust_Mobile_No.Size = new System.Drawing.Size(137, 32);
            this.lbl_Cust_Mobile_No.TabIndex = 17;
            this.lbl_Cust_Mobile_No.Text = "Mobile No.";
            // 
            // lbl_Customer_Id
            // 
            this.lbl_Customer_Id.AutoSize = true;
            this.lbl_Customer_Id.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Id.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Customer_Id.Location = new System.Drawing.Point(55, 145);
            this.lbl_Customer_Id.Name = "lbl_Customer_Id";
            this.lbl_Customer_Id.Size = new System.Drawing.Size(156, 32);
            this.lbl_Customer_Id.TabIndex = 12;
            this.lbl_Customer_Id.Text = "Customer ID";
            // 
            // dgv_Customer_Details
            // 
            this.dgv_Customer_Details.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("MingLiU-ExtB", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Customer_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Customer_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer_Details.Location = new System.Drawing.Point(584, 284);
            this.dgv_Customer_Details.Name = "dgv_Customer_Details";
            this.dgv_Customer_Details.RowHeadersWidth = 51;
            this.dgv_Customer_Details.RowTemplate.Height = 24;
            this.dgv_Customer_Details.Size = new System.Drawing.Size(586, 287);
            this.dgv_Customer_Details.TabIndex = 66;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.White;
            this.btn_Add.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Add.Location = new System.Drawing.Point(470, 372);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 52);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // tb_Total_Price
            // 
            this.tb_Total_Price.Enabled = false;
            this.tb_Total_Price.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Price.Location = new System.Drawing.Point(201, 469);
            this.tb_Total_Price.MaxLength = 10;
            this.tb_Total_Price.Name = "tb_Total_Price";
            this.tb_Total_Price.Size = new System.Drawing.Size(257, 34);
            this.tb_Total_Price.TabIndex = 8;
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Enabled = false;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(201, 284);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(257, 35);
            this.cmb_Product_Name.TabIndex = 5;
            this.cmb_Product_Name.TextChanged += new System.EventHandler(this.cmb_Product_Name_TextChanged);
            // 
            // lbl_Cust_Total_Price
            // 
            this.lbl_Cust_Total_Price.AutoSize = true;
            this.lbl_Cust_Total_Price.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cust_Total_Price.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Cust_Total_Price.Location = new System.Drawing.Point(11, 469);
            this.lbl_Cust_Total_Price.Name = "lbl_Cust_Total_Price";
            this.lbl_Cust_Total_Price.Size = new System.Drawing.Size(131, 32);
            this.lbl_Cust_Total_Price.TabIndex = 57;
            this.lbl_Cust_Total_Price.Text = "Total Price";
            // 
            // tb_Price
            // 
            this.tb_Price.Enabled = false;
            this.tb_Price.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Price.Location = new System.Drawing.Point(201, 347);
            this.tb_Price.MaxLength = 7;
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(257, 34);
            this.tb_Price.TabIndex = 6;
            this.tb_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Quantity
            // 
            this.tb_Quantity.Enabled = false;
            this.tb_Quantity.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Quantity.Location = new System.Drawing.Point(201, 409);
            this.tb_Quantity.MaxLength = 10;
            this.tb_Quantity.Name = "tb_Quantity";
            this.tb_Quantity.Size = new System.Drawing.Size(257, 34);
            this.tb_Quantity.TabIndex = 7;
            this.tb_Quantity.TextChanged += new System.EventHandler(this.tb_Quantity_TextChanged);
            this.tb_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Cust_Product_Name
            // 
            this.lbl_Cust_Product_Name.AutoSize = true;
            this.lbl_Cust_Product_Name.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cust_Product_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Cust_Product_Name.Location = new System.Drawing.Point(11, 284);
            this.lbl_Cust_Product_Name.Name = "lbl_Cust_Product_Name";
            this.lbl_Cust_Product_Name.Size = new System.Drawing.Size(171, 32);
            this.lbl_Cust_Product_Name.TabIndex = 60;
            this.lbl_Cust_Product_Name.Text = "Product Name";
            // 
            // lbl_Cust_Price
            // 
            this.lbl_Cust_Price.AutoSize = true;
            this.lbl_Cust_Price.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cust_Price.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Cust_Price.Location = new System.Drawing.Point(11, 347);
            this.lbl_Cust_Price.Name = "lbl_Cust_Price";
            this.lbl_Cust_Price.Size = new System.Drawing.Size(69, 32);
            this.lbl_Cust_Price.TabIndex = 59;
            this.lbl_Cust_Price.Text = "Price";
            // 
            // lbl_Cust_Quantity
            // 
            this.lbl_Cust_Quantity.AutoSize = true;
            this.lbl_Cust_Quantity.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cust_Quantity.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Cust_Quantity.Location = new System.Drawing.Point(11, 409);
            this.lbl_Cust_Quantity.Name = "lbl_Cust_Quantity";
            this.lbl_Cust_Quantity.Size = new System.Drawing.Size(113, 32);
            this.lbl_Cust_Quantity.TabIndex = 61;
            this.lbl_Cust_Quantity.Text = "Quantity";
            // 
            // tb_Total_Bill
            // 
            this.tb_Total_Bill.Enabled = false;
            this.tb_Total_Bill.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Total_Bill.Location = new System.Drawing.Point(201, 538);
            this.tb_Total_Bill.MaxLength = 10;
            this.tb_Total_Bill.Name = "tb_Total_Bill";
            this.tb_Total_Bill.Size = new System.Drawing.Size(257, 34);
            this.tb_Total_Bill.TabIndex = 9;
            // 
            // lbl_Total_Bill
            // 
            this.lbl_Total_Bill.AutoSize = true;
            this.lbl_Total_Bill.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Bill.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Total_Bill.Location = new System.Drawing.Point(12, 538);
            this.lbl_Total_Bill.Name = "lbl_Total_Bill";
            this.lbl_Total_Bill.Size = new System.Drawing.Size(114, 32);
            this.lbl_Total_Bill.TabIndex = 67;
            this.lbl_Total_Bill.Text = "Total Bill";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Location = new System.Drawing.Point(709, 625);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(173, 52);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Add_Customer_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.tb_Total_Bill);
            this.Controls.Add(this.lbl_Total_Bill);
            this.Controls.Add(this.dgv_Customer_Details);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.tb_Total_Price);
            this.Controls.Add(this.cmb_Product_Name);
            this.Controls.Add(this.lbl_Cust_Total_Price);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_Quantity);
            this.Controls.Add(this.lbl_Cust_Product_Name);
            this.Controls.Add(this.lbl_Cust_Price);
            this.Controls.Add(this.lbl_Cust_Quantity);
            this.Controls.Add(this.dtp_Bill_Date);
            this.Controls.Add(this.tb_Cust_Mobile_No);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Cust_Name);
            this.Controls.Add(this.tb_Customer_ID);
            this.Controls.Add(this.lbl_Bill_Date);
            this.Controls.Add(this.lbl_Cust_Name);
            this.Controls.Add(this.pnl_Navigation_Bar);
            this.Controls.Add(this.lbl_Cust_Mobile_No);
            this.Controls.Add(this.lbl_Customer_Id);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Customer_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer Details";
            this.Load += new System.EventHandler(this.frm_Add_Customer_Details_Load);
            this.pnl_Navigation_Bar.ResumeLayout(false);
            this.pnl_Navigation_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Navigation_Bar;
        private System.Windows.Forms.Label lbl_Add_New_Customer;
        private System.Windows.Forms.PictureBox pb_Back;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.PictureBox pb_Logout;
        private System.Windows.Forms.DateTimePicker dtp_Bill_Date;
        private System.Windows.Forms.TextBox tb_Cust_Mobile_No;
        private System.Windows.Forms.TextBox tb_Cust_Name;
        private System.Windows.Forms.TextBox tb_Customer_ID;
        private System.Windows.Forms.Label lbl_Bill_Date;
        private System.Windows.Forms.Label lbl_Cust_Name;
        private System.Windows.Forms.Label lbl_Cust_Mobile_No;
        private System.Windows.Forms.Label lbl_Customer_Id;
        private System.Windows.Forms.DataGridView dgv_Customer_Details;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox tb_Total_Price;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.Label lbl_Cust_Total_Price;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_Quantity;
        private System.Windows.Forms.Label lbl_Cust_Product_Name;
        private System.Windows.Forms.Label lbl_Cust_Price;
        private System.Windows.Forms.Label lbl_Cust_Quantity;
        private System.Windows.Forms.TextBox tb_Total_Bill;
        private System.Windows.Forms.Label lbl_Total_Bill;
        private System.Windows.Forms.Button btn_Refresh;
    }
}