
namespace Ayuraj_Computer_Shopee_App.Forms.Employee
{
    partial class frm_Search_Or_Update_Employee
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
            this.pb_Back = new System.Windows.Forms.PictureBox();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.tb_Qualification = new System.Windows.Forms.TextBox();
            this.pb_Logout = new System.Windows.Forms.PictureBox();
            this.tb_Adhar_No = new System.Windows.Forms.TextBox();
            this.tb_Email_ID = new System.Windows.Forms.TextBox();
            this.tb_Emp_Address = new System.Windows.Forms.TextBox();
            this.lbl_Job_Role = new System.Windows.Forms.Label();
            this.lbl_Search_Or_Update_Employee = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.lbl_Email_ID = new System.Windows.Forms.Label();
            this.lbl_Adhar_No = new System.Windows.Forms.Label();
            this.lbl_Qualification = new System.Windows.Forms.Label();
            this.lbl_Emp_Address = new System.Windows.Forms.Label();
            this.dtp_Joining_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Job_Role = new System.Windows.Forms.TextBox();
            this.tb_Emp_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Emp_Name = new System.Windows.Forms.TextBox();
            this.tb_Employee_ID = new System.Windows.Forms.TextBox();
            this.lbl_Joining_Date = new System.Windows.Forms.Label();
            this.lbl_Emp_Name = new System.Windows.Forms.Label();
            this.lbl_Emp_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Employee_ID = new System.Windows.Forms.Label();
            this.pnl_Navigation_Bar = new System.Windows.Forms.Panel();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout)).BeginInit();
            this.pnl_Navigation_Bar.SuspendLayout();
            this.SuspendLayout();
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
            // tb_Salary
            // 
            this.tb_Salary.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salary.Location = new System.Drawing.Point(899, 489);
            this.tb_Salary.MaxLength = 30;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(257, 34);
            this.tb_Salary.TabIndex = 8;
            this.tb_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Qualification
            // 
            this.tb_Qualification.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Qualification.Location = new System.Drawing.Point(899, 413);
            this.tb_Qualification.MaxLength = 5;
            this.tb_Qualification.Name = "tb_Qualification";
            this.tb_Qualification.Size = new System.Drawing.Size(257, 34);
            this.tb_Qualification.TabIndex = 7;
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
            // tb_Adhar_No
            // 
            this.tb_Adhar_No.Enabled = false;
            this.tb_Adhar_No.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Adhar_No.Location = new System.Drawing.Point(899, 199);
            this.tb_Adhar_No.MaxLength = 10;
            this.tb_Adhar_No.Name = "tb_Adhar_No";
            this.tb_Adhar_No.Size = new System.Drawing.Size(257, 34);
            this.tb_Adhar_No.TabIndex = 0;
            // 
            // tb_Email_ID
            // 
            this.tb_Email_ID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_ID.Location = new System.Drawing.Point(251, 487);
            this.tb_Email_ID.MaxLength = 30;
            this.tb_Email_ID.Name = "tb_Email_ID";
            this.tb_Email_ID.Size = new System.Drawing.Size(257, 34);
            this.tb_Email_ID.TabIndex = 5;
            // 
            // tb_Emp_Address
            // 
            this.tb_Emp_Address.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_Address.Location = new System.Drawing.Point(251, 411);
            this.tb_Emp_Address.MaxLength = 5;
            this.tb_Emp_Address.Name = "tb_Emp_Address";
            this.tb_Emp_Address.Size = new System.Drawing.Size(257, 34);
            this.tb_Emp_Address.TabIndex = 4;
            // 
            // lbl_Job_Role
            // 
            this.lbl_Job_Role.AutoSize = true;
            this.lbl_Job_Role.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Job_Role.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Job_Role.Location = new System.Drawing.Point(671, 340);
            this.lbl_Job_Role.Name = "lbl_Job_Role";
            this.lbl_Job_Role.Size = new System.Drawing.Size(106, 32);
            this.lbl_Job_Role.TabIndex = 64;
            this.lbl_Job_Role.Text = "Job Role";
            // 
            // lbl_Search_Or_Update_Employee
            // 
            this.lbl_Search_Or_Update_Employee.AutoSize = true;
            this.lbl_Search_Or_Update_Employee.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Or_Update_Employee.ForeColor = System.Drawing.Color.White;
            this.lbl_Search_Or_Update_Employee.Location = new System.Drawing.Point(280, 30);
            this.lbl_Search_Or_Update_Employee.Name = "lbl_Search_Or_Update_Employee";
            this.lbl_Search_Or_Update_Employee.Size = new System.Drawing.Size(618, 51);
            this.lbl_Search_Or_Update_Employee.TabIndex = 0;
            this.lbl_Search_Or_Update_Employee.Text = "Search Or Update Employee";
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Salary.Location = new System.Drawing.Point(671, 492);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(83, 32);
            this.lbl_Salary.TabIndex = 75;
            this.lbl_Salary.Text = "Salary";
            // 
            // lbl_Email_ID
            // 
            this.lbl_Email_ID.AutoSize = true;
            this.lbl_Email_ID.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_ID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Email_ID.Location = new System.Drawing.Point(25, 490);
            this.lbl_Email_ID.Name = "lbl_Email_ID";
            this.lbl_Email_ID.Size = new System.Drawing.Size(112, 32);
            this.lbl_Email_ID.TabIndex = 74;
            this.lbl_Email_ID.Text = "Email ID";
            // 
            // lbl_Adhar_No
            // 
            this.lbl_Adhar_No.AutoSize = true;
            this.lbl_Adhar_No.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adhar_No.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Adhar_No.Location = new System.Drawing.Point(671, 199);
            this.lbl_Adhar_No.Name = "lbl_Adhar_No";
            this.lbl_Adhar_No.Size = new System.Drawing.Size(187, 32);
            this.lbl_Adhar_No.TabIndex = 76;
            this.lbl_Adhar_No.Text = "Adhar Card No.";
            // 
            // lbl_Qualification
            // 
            this.lbl_Qualification.AutoSize = true;
            this.lbl_Qualification.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qualification.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Qualification.Location = new System.Drawing.Point(671, 416);
            this.lbl_Qualification.Name = "lbl_Qualification";
            this.lbl_Qualification.Size = new System.Drawing.Size(157, 32);
            this.lbl_Qualification.TabIndex = 67;
            this.lbl_Qualification.Text = "Qualification";
            // 
            // lbl_Emp_Address
            // 
            this.lbl_Emp_Address.AutoSize = true;
            this.lbl_Emp_Address.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Address.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Emp_Address.Location = new System.Drawing.Point(25, 414);
            this.lbl_Emp_Address.Name = "lbl_Emp_Address";
            this.lbl_Emp_Address.Size = new System.Drawing.Size(105, 32);
            this.lbl_Emp_Address.TabIndex = 68;
            this.lbl_Emp_Address.Text = "Address";
            // 
            // dtp_Joining_Date
            // 
            this.dtp_Joining_Date.Enabled = false;
            this.dtp_Joining_Date.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Joining_Date.Location = new System.Drawing.Point(899, 268);
            this.dtp_Joining_Date.Name = "dtp_Joining_Date";
            this.dtp_Joining_Date.Size = new System.Drawing.Size(257, 34);
            this.dtp_Joining_Date.TabIndex = 0;
            // 
            // tb_Job_Role
            // 
            this.tb_Job_Role.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Job_Role.Location = new System.Drawing.Point(899, 340);
            this.tb_Job_Role.MaxLength = 10;
            this.tb_Job_Role.Name = "tb_Job_Role";
            this.tb_Job_Role.Size = new System.Drawing.Size(257, 34);
            this.tb_Job_Role.TabIndex = 6;
            this.tb_Job_Role.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Emp_Mobile_No
            // 
            this.tb_Emp_Mobile_No.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_Mobile_No.Location = new System.Drawing.Point(251, 338);
            this.tb_Emp_Mobile_No.MaxLength = 10;
            this.tb_Emp_Mobile_No.Name = "tb_Emp_Mobile_No";
            this.tb_Emp_Mobile_No.Size = new System.Drawing.Size(257, 34);
            this.tb_Emp_Mobile_No.TabIndex = 3;
            this.tb_Emp_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Emp_Name
            // 
            this.tb_Emp_Name.Enabled = false;
            this.tb_Emp_Name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_Name.Location = new System.Drawing.Point(251, 266);
            this.tb_Emp_Name.MaxLength = 30;
            this.tb_Emp_Name.Name = "tb_Emp_Name";
            this.tb_Emp_Name.Size = new System.Drawing.Size(257, 34);
            this.tb_Emp_Name.TabIndex = 0;
            // 
            // tb_Employee_ID
            // 
            this.tb_Employee_ID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_ID.Location = new System.Drawing.Point(251, 197);
            this.tb_Employee_ID.MaxLength = 5;
            this.tb_Employee_ID.Name = "tb_Employee_ID";
            this.tb_Employee_ID.Size = new System.Drawing.Size(257, 34);
            this.tb_Employee_ID.TabIndex = 1;
            this.tb_Employee_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Joining_Date
            // 
            this.lbl_Joining_Date.AutoSize = true;
            this.lbl_Joining_Date.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Joining_Date.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Joining_Date.Location = new System.Drawing.Point(671, 268);
            this.lbl_Joining_Date.Name = "lbl_Joining_Date";
            this.lbl_Joining_Date.Size = new System.Drawing.Size(152, 32);
            this.lbl_Joining_Date.TabIndex = 65;
            this.lbl_Joining_Date.Text = "Joining Date";
            // 
            // lbl_Emp_Name
            // 
            this.lbl_Emp_Name.AutoSize = true;
            this.lbl_Emp_Name.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Emp_Name.Location = new System.Drawing.Point(25, 269);
            this.lbl_Emp_Name.Name = "lbl_Emp_Name";
            this.lbl_Emp_Name.Size = new System.Drawing.Size(193, 32);
            this.lbl_Emp_Name.TabIndex = 62;
            this.lbl_Emp_Name.Text = "Employee Name";
            // 
            // lbl_Emp_Mobile_No
            // 
            this.lbl_Emp_Mobile_No.AutoSize = true;
            this.lbl_Emp_Mobile_No.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Mobile_No.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Emp_Mobile_No.Location = new System.Drawing.Point(25, 338);
            this.lbl_Emp_Mobile_No.Name = "lbl_Emp_Mobile_No";
            this.lbl_Emp_Mobile_No.Size = new System.Drawing.Size(137, 32);
            this.lbl_Emp_Mobile_No.TabIndex = 63;
            this.lbl_Emp_Mobile_No.Text = "Mobile No.";
            // 
            // lbl_Employee_ID
            // 
            this.lbl_Employee_ID.AutoSize = true;
            this.lbl_Employee_ID.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_ID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Employee_ID.Location = new System.Drawing.Point(25, 200);
            this.lbl_Employee_ID.Name = "lbl_Employee_ID";
            this.lbl_Employee_ID.Size = new System.Drawing.Size(157, 32);
            this.lbl_Employee_ID.TabIndex = 57;
            this.lbl_Employee_ID.Text = "Employee ID";
            // 
            // pnl_Navigation_Bar
            // 
            this.pnl_Navigation_Bar.BackColor = System.Drawing.Color.Purple;
            this.pnl_Navigation_Bar.Controls.Add(this.pb_Logout);
            this.pnl_Navigation_Bar.Controls.Add(this.pb_Back);
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_Search_Or_Update_Employee);
            this.pnl_Navigation_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Navigation_Bar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Navigation_Bar.Name = "pnl_Navigation_Bar";
            this.pnl_Navigation_Bar.Size = new System.Drawing.Size(1182, 110);
            this.pnl_Navigation_Bar.TabIndex = 56;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.White;
            this.btn_Search.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Search.Location = new System.Drawing.Point(532, 188);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(124, 52);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.White;
            this.btn_Update.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Update.Location = new System.Drawing.Point(336, 599);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(160, 52);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Location = new System.Drawing.Point(802, 599);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(173, 52);
            this.btn_Refresh.TabIndex = 10;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Search_Or_Update_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_Salary);
            this.Controls.Add(this.tb_Qualification);
            this.Controls.Add(this.tb_Adhar_No);
            this.Controls.Add(this.tb_Email_ID);
            this.Controls.Add(this.tb_Emp_Address);
            this.Controls.Add(this.lbl_Job_Role);
            this.Controls.Add(this.lbl_Salary);
            this.Controls.Add(this.lbl_Email_ID);
            this.Controls.Add(this.lbl_Adhar_No);
            this.Controls.Add(this.lbl_Qualification);
            this.Controls.Add(this.lbl_Emp_Address);
            this.Controls.Add(this.dtp_Joining_Date);
            this.Controls.Add(this.tb_Job_Role);
            this.Controls.Add(this.tb_Emp_Mobile_No);
            this.Controls.Add(this.tb_Emp_Name);
            this.Controls.Add(this.tb_Employee_ID);
            this.Controls.Add(this.lbl_Joining_Date);
            this.Controls.Add(this.lbl_Emp_Name);
            this.Controls.Add(this.lbl_Emp_Mobile_No);
            this.Controls.Add(this.lbl_Employee_ID);
            this.Controls.Add(this.pnl_Navigation_Bar);
            this.Name = "frm_Search_Or_Update_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Or Update Employee";
            this.Load += new System.EventHandler(this.frm_Search_Or_Update_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout)).EndInit();
            this.pnl_Navigation_Bar.ResumeLayout(false);
            this.pnl_Navigation_Bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Back;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.TextBox tb_Qualification;
        private System.Windows.Forms.PictureBox pb_Logout;
        private System.Windows.Forms.TextBox tb_Adhar_No;
        private System.Windows.Forms.TextBox tb_Email_ID;
        private System.Windows.Forms.TextBox tb_Emp_Address;
        private System.Windows.Forms.Label lbl_Job_Role;
        private System.Windows.Forms.Label lbl_Search_Or_Update_Employee;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.Label lbl_Email_ID;
        private System.Windows.Forms.Label lbl_Adhar_No;
        private System.Windows.Forms.Label lbl_Qualification;
        private System.Windows.Forms.Label lbl_Emp_Address;
        private System.Windows.Forms.DateTimePicker dtp_Joining_Date;
        private System.Windows.Forms.TextBox tb_Job_Role;
        private System.Windows.Forms.TextBox tb_Emp_Mobile_No;
        private System.Windows.Forms.TextBox tb_Emp_Name;
        private System.Windows.Forms.TextBox tb_Employee_ID;
        private System.Windows.Forms.Label lbl_Joining_Date;
        private System.Windows.Forms.Label lbl_Emp_Name;
        private System.Windows.Forms.Label lbl_Emp_Mobile_No;
        private System.Windows.Forms.Label lbl_Employee_ID;
        private System.Windows.Forms.Panel pnl_Navigation_Bar;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Refresh;
    }
}