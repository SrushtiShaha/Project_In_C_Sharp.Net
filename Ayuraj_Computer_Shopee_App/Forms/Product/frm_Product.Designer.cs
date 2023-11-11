
namespace Ayuraj_Computer_Shopee_App.Forms.Product
{
    partial class frm_Product
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
            this.btn_View_Product = new System.Windows.Forms.Button();
            this.btn_Search_Update_Product = new System.Windows.Forms.Button();
            this.btn_Add_Product = new System.Windows.Forms.Button();
            this.pb_Logout = new System.Windows.Forms.PictureBox();
            this.pb_Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_View_Product
            // 
            this.btn_View_Product.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_View_Product.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Product.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_View_Product.Location = new System.Drawing.Point(266, 507);
            this.btn_View_Product.Name = "btn_View_Product";
            this.btn_View_Product.Size = new System.Drawing.Size(642, 86);
            this.btn_View_Product.TabIndex = 67;
            this.btn_View_Product.Text = "View Product Details";
            this.btn_View_Product.UseVisualStyleBackColor = false;
            this.btn_View_Product.Click += new System.EventHandler(this.btn_View_Product_Click);
            // 
            // btn_Search_Update_Product
            // 
            this.btn_Search_Update_Product.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Search_Update_Product.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Update_Product.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_Search_Update_Product.Location = new System.Drawing.Point(266, 362);
            this.btn_Search_Update_Product.Name = "btn_Search_Update_Product";
            this.btn_Search_Update_Product.Size = new System.Drawing.Size(642, 86);
            this.btn_Search_Update_Product.TabIndex = 66;
            this.btn_Search_Update_Product.Text = "Search Or Update Product";
            this.btn_Search_Update_Product.UseVisualStyleBackColor = false;
            this.btn_Search_Update_Product.Click += new System.EventHandler(this.btn_Search_Update_Product_Click);
            // 
            // btn_Add_Product
            // 
            this.btn_Add_Product.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Add_Product.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Product.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_Add_Product.Location = new System.Drawing.Point(266, 216);
            this.btn_Add_Product.Name = "btn_Add_Product";
            this.btn_Add_Product.Size = new System.Drawing.Size(642, 86);
            this.btn_Add_Product.TabIndex = 65;
            this.btn_Add_Product.Text = "Add New Product";
            this.btn_Add_Product.UseVisualStyleBackColor = false;
            this.btn_Add_Product.Click += new System.EventHandler(this.btn_Add_Product_Click);
            // 
            // pb_Logout
            // 
            this.pb_Logout.BackColor = System.Drawing.Color.White;
            this.pb_Logout.Image = global::Ayuraj_Computer_Shopee_App.Properties.Resources.LOG;
            this.pb_Logout.Location = new System.Drawing.Point(1029, 2);
            this.pb_Logout.Name = "pb_Logout";
            this.pb_Logout.Size = new System.Drawing.Size(154, 110);
            this.pb_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logout.TabIndex = 64;
            this.pb_Logout.TabStop = false;
            this.pb_Logout.Click += new System.EventHandler(this.pb_Logout_Click);
            // 
            // pb_Back
            // 
            this.pb_Back.BackColor = System.Drawing.Color.White;
            this.pb_Back.Image = global::Ayuraj_Computer_Shopee_App.Properties.Resources.Back;
            this.pb_Back.Location = new System.Drawing.Point(0, 1);
            this.pb_Back.Name = "pb_Back";
            this.pb_Back.Size = new System.Drawing.Size(154, 110);
            this.pb_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Back.TabIndex = 63;
            this.pb_Back.TabStop = false;
            this.pb_Back.Click += new System.EventHandler(this.pb_Back_Click);
            // 
            // frm_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.ControlBox = false;
            this.Controls.Add(this.btn_View_Product);
            this.Controls.Add(this.btn_Search_Update_Product);
            this.Controls.Add(this.btn_Add_Product);
            this.Controls.Add(this.pb_Logout);
            this.Controls.Add(this.pb_Back);
            this.Name = "frm_Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_View_Product;
        private System.Windows.Forms.Button btn_Search_Update_Product;
        private System.Windows.Forms.Button btn_Add_Product;
        private System.Windows.Forms.PictureBox pb_Logout;
        private System.Windows.Forms.PictureBox pb_Back;
    }
}