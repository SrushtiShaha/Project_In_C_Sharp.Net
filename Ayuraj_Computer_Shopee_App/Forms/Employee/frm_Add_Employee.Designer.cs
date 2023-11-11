
namespace Ayuraj_Computer_Shopee_App.Forms.Employee
{
    partial class frm_Add_Employee
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Add_New_Employee = new System.Windows.Forms.Label();
            this.dtp_Joining_Date = new System.Windows.Forms.DateTimePicker();
            this.tb_Emp_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_Emp_Name = new System.Windows.Forms.TextBox();
            this.tb_Employee_ID = new System.Windows.Forms.TextBox();
            this.lbl_Joining_Date = new System.Windows.Forms.Label();
            this.lbl_Emp_Name = new System.Windows.Forms.Label();
            this.lbl_Emp_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Employee_ID = new System.Windows.Forms.Label();
            this.tb_Adhar_No = new System.Windows.Forms.TextBox();
            this.tb_Email_ID = new System.Windows.Forms.TextBox();
            this.tb_Emp_Address = new System.Windows.Forms.TextBox();
            this.lbl_Email_ID = new System.Windows.Forms.Label();
            this.lbl_Adhar_No = new System.Windows.Forms.Label();
            this.lbl_Emp_Address = new System.Windows.Forms.Label();
            this.lbl_Job_Role = new System.Windows.Forms.Label();
            this.tb_Job_Role = new System.Windows.Forms.TextBox();
            this.lbl_Qualification = new System.Windows.Forms.Label();
            this.lbl_Salary = new System.Windows.Forms.Label();
            this.tb_Qualification = new System.Windows.Forms.TextBox();
            this.tb_Salary = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
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
            this.pnl_Navigation_Bar.Controls.Add(this.label1);
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_Add_New_Employee);
            this.pnl_Navigation_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Navigation_Bar.Location = new System.Drawing.Point(0, 0);
            this.pnl_Navigation_Bar.Name = "pnl_Navigation_Bar";
            this.pnl_Navigation_Bar.Size = new System.Drawing.Size(1182, 110);
            this.pnl_Navigation_Bar.TabIndex = 8;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(297, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Employee";
            // 
            // lbl_Add_New_Employee
            // 
            this.lbl_Add_New_Employee.AutoSize = true;
            this.lbl_Add_New_Employee.Font = new System.Drawing.Font("Modern No. 20", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Employee.ForeColor = System.Drawing.Color.White;
            this.lbl_Add_New_Employee.Location = new System.Drawing.Point(301, 19);
            this.lbl_Add_New_Employee.Name = "lbl_Add_New_Employee";
            this.lbl_Add_New_Employee.Size = new System.Drawing.Size(579, 70);
            this.lbl_Add_New_Employee.TabIndex = 0;
            this.lbl_Add_New_Employee.Text = "Add New Employee";
            // 
            // dtp_Joining_Date
            // 
            this.dtp_Joining_Date.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Joining_Date.Location = new System.Drawing.Point(885, 244);
            this.dtp_Joining_Date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_Joining_Date.Name = "dtp_Joining_Date";
            this.dtp_Joining_Date.Size = new System.Drawing.Size(257, 34);
            this.dtp_Joining_Date.TabIndex = 7;
            // 
            // tb_Emp_Mobile_No
            // 
            this.tb_Emp_Mobile_No.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_Mobile_No.Location = new System.Drawing.Point(281, 316);
            this.tb_Emp_Mobile_No.MaxLength = 10;
            this.tb_Emp_Mobile_No.Name = "tb_Emp_Mobile_No";
            this.tb_Emp_Mobile_No.Size = new System.Drawing.Size(257, 34);
            this.tb_Emp_Mobile_No.TabIndex = 3;
            this.tb_Emp_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Emp_Name
            // 
            this.tb_Emp_Name.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_Name.Location = new System.Drawing.Point(281, 244);
            this.tb_Emp_Name.MaxLength = 30;
            this.tb_Emp_Name.Name = "tb_Emp_Name";
            this.tb_Emp_Name.Size = new System.Drawing.Size(257, 34);
            this.tb_Emp_Name.TabIndex = 2;
            this.tb_Emp_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Employee_ID
            // 
            this.tb_Employee_ID.Enabled = false;
            this.tb_Employee_ID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employee_ID.Location = new System.Drawing.Point(281, 175);
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
            this.lbl_Joining_Date.Location = new System.Drawing.Point(648, 244);
            this.lbl_Joining_Date.Name = "lbl_Joining_Date";
            this.lbl_Joining_Date.Size = new System.Drawing.Size(152, 32);
            this.lbl_Joining_Date.TabIndex = 18;
            this.lbl_Joining_Date.Text = "Joining Date";
            // 
            // lbl_Emp_Name
            // 
            this.lbl_Emp_Name.AutoSize = true;
            this.lbl_Emp_Name.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Name.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Emp_Name.Location = new System.Drawing.Point(44, 247);
            this.lbl_Emp_Name.Name = "lbl_Emp_Name";
            this.lbl_Emp_Name.Size = new System.Drawing.Size(193, 32);
            this.lbl_Emp_Name.TabIndex = 16;
            this.lbl_Emp_Name.Text = "Employee Name";
            // 
            // lbl_Emp_Mobile_No
            // 
            this.lbl_Emp_Mobile_No.AutoSize = true;
            this.lbl_Emp_Mobile_No.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Mobile_No.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Emp_Mobile_No.Location = new System.Drawing.Point(44, 316);
            this.lbl_Emp_Mobile_No.Name = "lbl_Emp_Mobile_No";
            this.lbl_Emp_Mobile_No.Size = new System.Drawing.Size(137, 32);
            this.lbl_Emp_Mobile_No.TabIndex = 17;
            this.lbl_Emp_Mobile_No.Text = "Mobile No.";
            // 
            // lbl_Employee_ID
            // 
            this.lbl_Employee_ID.AutoSize = true;
            this.lbl_Employee_ID.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_ID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Employee_ID.Location = new System.Drawing.Point(44, 178);
            this.lbl_Employee_ID.Name = "lbl_Employee_ID";
            this.lbl_Employee_ID.Size = new System.Drawing.Size(157, 32);
            this.lbl_Employee_ID.TabIndex = 12;
            this.lbl_Employee_ID.Text = "Employee ID";
            // 
            // tb_Adhar_No
            // 
            this.tb_Adhar_No.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Adhar_No.Location = new System.Drawing.Point(885, 175);
            this.tb_Adhar_No.MaxLength = 12;
            this.tb_Adhar_No.Name = "tb_Adhar_No";
            this.tb_Adhar_No.Size = new System.Drawing.Size(257, 34);
            this.tb_Adhar_No.TabIndex = 6;
            this.tb_Adhar_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Email_ID
            // 
            this.tb_Email_ID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email_ID.Location = new System.Drawing.Point(281, 465);
            this.tb_Email_ID.MaxLength = 30;
            this.tb_Email_ID.Name = "tb_Email_ID";
            this.tb_Email_ID.Size = new System.Drawing.Size(257, 34);
            this.tb_Email_ID.TabIndex = 5;
            // 
            // tb_Emp_Address
            // 
            this.tb_Emp_Address.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Emp_Address.Location = new System.Drawing.Point(281, 389);
            this.tb_Emp_Address.MaxLength = 50;
            this.tb_Emp_Address.Name = "tb_Emp_Address";
            this.tb_Emp_Address.Size = new System.Drawing.Size(257, 34);
            this.tb_Emp_Address.TabIndex = 4;
            // 
            // lbl_Email_ID
            // 
            this.lbl_Email_ID.AutoSize = true;
            this.lbl_Email_ID.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_ID.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Email_ID.Location = new System.Drawing.Point(44, 468);
            this.lbl_Email_ID.Name = "lbl_Email_ID";
            this.lbl_Email_ID.Size = new System.Drawing.Size(112, 32);
            this.lbl_Email_ID.TabIndex = 24;
            this.lbl_Email_ID.Text = "Email ID";
            // 
            // lbl_Adhar_No
            // 
            this.lbl_Adhar_No.AutoSize = true;
            this.lbl_Adhar_No.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adhar_No.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Adhar_No.Location = new System.Drawing.Point(648, 175);
            this.lbl_Adhar_No.Name = "lbl_Adhar_No";
            this.lbl_Adhar_No.Size = new System.Drawing.Size(187, 32);
            this.lbl_Adhar_No.TabIndex = 25;
            this.lbl_Adhar_No.Text = "Adhar Card No.";
            // 
            // lbl_Emp_Address
            // 
            this.lbl_Emp_Address.AutoSize = true;
            this.lbl_Emp_Address.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emp_Address.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Emp_Address.Location = new System.Drawing.Point(44, 392);
            this.lbl_Emp_Address.Name = "lbl_Emp_Address";
            this.lbl_Emp_Address.Size = new System.Drawing.Size(105, 32);
            this.lbl_Emp_Address.TabIndex = 20;
            this.lbl_Emp_Address.Text = "Address";
            // 
            // lbl_Job_Role
            // 
            this.lbl_Job_Role.AutoSize = true;
            this.lbl_Job_Role.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Job_Role.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Job_Role.Location = new System.Drawing.Point(648, 316);
            this.lbl_Job_Role.Name = "lbl_Job_Role";
            this.lbl_Job_Role.Size = new System.Drawing.Size(106, 32);
            this.lbl_Job_Role.TabIndex = 17;
            this.lbl_Job_Role.Text = "Job Role";
            // 
            // tb_Job_Role
            // 
            this.tb_Job_Role.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Job_Role.Location = new System.Drawing.Point(885, 316);
            this.tb_Job_Role.MaxLength = 30;
            this.tb_Job_Role.Name = "tb_Job_Role";
            this.tb_Job_Role.Size = new System.Drawing.Size(257, 34);
            this.tb_Job_Role.TabIndex = 8;
            // 
            // lbl_Qualification
            // 
            this.lbl_Qualification.AutoSize = true;
            this.lbl_Qualification.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qualification.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Qualification.Location = new System.Drawing.Point(648, 392);
            this.lbl_Qualification.Name = "lbl_Qualification";
            this.lbl_Qualification.Size = new System.Drawing.Size(157, 32);
            this.lbl_Qualification.TabIndex = 20;
            this.lbl_Qualification.Text = "Qualification";
            // 
            // lbl_Salary
            // 
            this.lbl_Salary.AutoSize = true;
            this.lbl_Salary.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Salary.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_Salary.Location = new System.Drawing.Point(648, 468);
            this.lbl_Salary.Name = "lbl_Salary";
            this.lbl_Salary.Size = new System.Drawing.Size(83, 32);
            this.lbl_Salary.TabIndex = 24;
            this.lbl_Salary.Text = "Salary";
            // 
            // tb_Qualification
            // 
            this.tb_Qualification.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Qualification.Location = new System.Drawing.Point(885, 389);
            this.tb_Qualification.MaxLength = 30;
            this.tb_Qualification.Name = "tb_Qualification";
            this.tb_Qualification.Size = new System.Drawing.Size(257, 34);
            this.tb_Qualification.TabIndex = 9;
            // 
            // tb_Salary
            // 
            this.tb_Salary.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Salary.Location = new System.Drawing.Point(885, 465);
            this.tb_Salary.MaxLength = 7;
            this.tb_Salary.Name = "tb_Salary";
            this.tb_Salary.Size = new System.Drawing.Size(257, 34);
            this.tb_Salary.TabIndex = 10;
            this.tb_Salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Save.Location = new System.Drawing.Point(722, 595);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(173, 55);
            this.btn_Save.TabIndex = 55;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_Refresh.Location = new System.Drawing.Point(313, 595);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(173, 55);
            this.btn_Refresh.TabIndex = 56;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // frm_Add_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Adhar_No);
            this.Controls.Add(this.tb_Salary);
            this.Controls.Add(this.tb_Email_ID);
            this.Controls.Add(this.tb_Qualification);
            this.Controls.Add(this.tb_Emp_Address);
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
            this.Controls.Add(this.lbl_Job_Role);
            this.Controls.Add(this.lbl_Emp_Name);
            this.Controls.Add(this.lbl_Emp_Mobile_No);
            this.Controls.Add(this.lbl_Employee_ID);
            this.Controls.Add(this.pnl_Navigation_Bar);
            this.Name = "frm_Add_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employee";
            this.Load += new System.EventHandler(this.frm_Add_Employee_Load);
            this.pnl_Navigation_Bar.ResumeLayout(false);
            this.pnl_Navigation_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Navigation_Bar;
        private System.Windows.Forms.PictureBox pb_Logout;
        private System.Windows.Forms.PictureBox pb_Back;
        private System.Windows.Forms.Label lbl_Add_New_Employee;
        private System.Windows.Forms.DateTimePicker dtp_Joining_Date;
        private System.Windows.Forms.TextBox tb_Emp_Mobile_No;
        private System.Windows.Forms.TextBox tb_Emp_Name;
        private System.Windows.Forms.TextBox tb_Employee_ID;
        private System.Windows.Forms.Label lbl_Joining_Date;
        private System.Windows.Forms.Label lbl_Emp_Name;
        private System.Windows.Forms.Label lbl_Emp_Mobile_No;
        private System.Windows.Forms.Label lbl_Employee_ID;
        private System.Windows.Forms.TextBox tb_Adhar_No;
        private System.Windows.Forms.TextBox tb_Email_ID;
        private System.Windows.Forms.TextBox tb_Emp_Address;
        private System.Windows.Forms.Label lbl_Email_ID;
        private System.Windows.Forms.Label lbl_Adhar_No;
        private System.Windows.Forms.Label lbl_Emp_Address;
        private System.Windows.Forms.Label lbl_Job_Role;
        private System.Windows.Forms.TextBox tb_Job_Role;
        private System.Windows.Forms.Label lbl_Qualification;
        private System.Windows.Forms.Label lbl_Salary;
        private System.Windows.Forms.TextBox tb_Qualification;
        private System.Windows.Forms.TextBox tb_Salary;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Refresh;
    }
}