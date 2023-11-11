
namespace Ayuraj_Computer_Shopee_App.Forms.Employee
{
    partial class frm_Employee
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
            this.btn_View_Employee = new System.Windows.Forms.Button();
            this.btn_Search_Update_Employee = new System.Windows.Forms.Button();
            this.btn_Add_Employee = new System.Windows.Forms.Button();
            this.pb_Logout = new System.Windows.Forms.PictureBox();
            this.pb_Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_View_Employee
            // 
            this.btn_View_Employee.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_View_Employee.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_Employee.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_View_Employee.Location = new System.Drawing.Point(266, 507);
            this.btn_View_Employee.Name = "btn_View_Employee";
            this.btn_View_Employee.Size = new System.Drawing.Size(642, 86);
            this.btn_View_Employee.TabIndex = 72;
            this.btn_View_Employee.Text = "View Employee Details";
            this.btn_View_Employee.UseVisualStyleBackColor = false;
            this.btn_View_Employee.Click += new System.EventHandler(this.btn_View_Employee_Click);
            // 
            // btn_Search_Update_Employee
            // 
            this.btn_Search_Update_Employee.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Search_Update_Employee.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Update_Employee.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_Search_Update_Employee.Location = new System.Drawing.Point(266, 362);
            this.btn_Search_Update_Employee.Name = "btn_Search_Update_Employee";
            this.btn_Search_Update_Employee.Size = new System.Drawing.Size(642, 86);
            this.btn_Search_Update_Employee.TabIndex = 71;
            this.btn_Search_Update_Employee.Text = "Search Or Update Employee";
            this.btn_Search_Update_Employee.UseVisualStyleBackColor = false;
            this.btn_Search_Update_Employee.Click += new System.EventHandler(this.btn_Search_Update_Employee_Click);
            // 
            // btn_Add_Employee
            // 
            this.btn_Add_Employee.BackColor = System.Drawing.Color.BlueViolet;
            this.btn_Add_Employee.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Employee.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_Add_Employee.Location = new System.Drawing.Point(266, 216);
            this.btn_Add_Employee.Name = "btn_Add_Employee";
            this.btn_Add_Employee.Size = new System.Drawing.Size(642, 86);
            this.btn_Add_Employee.TabIndex = 70;
            this.btn_Add_Employee.Text = "Add New Employee";
            this.btn_Add_Employee.UseVisualStyleBackColor = false;
            this.btn_Add_Employee.Click += new System.EventHandler(this.btn_Add_Employee_Click);
            // 
            // pb_Logout
            // 
            this.pb_Logout.BackColor = System.Drawing.Color.White;
            this.pb_Logout.Image = global::Ayuraj_Computer_Shopee_App.Properties.Resources.LOG;
            this.pb_Logout.Location = new System.Drawing.Point(1029, 2);
            this.pb_Logout.Name = "pb_Logout";
            this.pb_Logout.Size = new System.Drawing.Size(154, 110);
            this.pb_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Logout.TabIndex = 69;
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
            this.pb_Back.TabIndex = 68;
            this.pb_Back.TabStop = false;
            this.pb_Back.Click += new System.EventHandler(this.pb_Back_Click);
            // 
            // frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.ControlBox = false;
            this.Controls.Add(this.btn_View_Employee);
            this.Controls.Add(this.btn_Search_Update_Employee);
            this.Controls.Add(this.btn_Add_Employee);
            this.Controls.Add(this.pb_Logout);
            this.Controls.Add(this.pb_Back);
            this.Name = "frm_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_View_Employee;
        private System.Windows.Forms.Button btn_Search_Update_Employee;
        private System.Windows.Forms.Button btn_Add_Employee;
        private System.Windows.Forms.PictureBox pb_Logout;
        private System.Windows.Forms.PictureBox pb_Back;
    }
}