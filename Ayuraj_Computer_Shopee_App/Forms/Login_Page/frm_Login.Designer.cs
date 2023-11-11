
namespace Ayuraj_Computer_Shopee_App.Forms.Login_Page
{
    partial class frm_Login
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
            this.lbl_Login_Username = new System.Windows.Forms.Label();
            this.lbl_Login_Password = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Login_Submit = new System.Windows.Forms.Button();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.pb_Login = new System.Windows.Forms.PictureBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Login_Username
            // 
            this.lbl_Login_Username.AutoSize = true;
            this.lbl_Login_Username.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Username.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Login_Username.Location = new System.Drawing.Point(574, 284);
            this.lbl_Login_Username.Name = "lbl_Login_Username";
            this.lbl_Login_Username.Size = new System.Drawing.Size(197, 44);
            this.lbl_Login_Username.TabIndex = 2;
            this.lbl_Login_Username.Text = "Username";
            // 
            // lbl_Login_Password
            // 
            this.lbl_Login_Password.AutoSize = true;
            this.lbl_Login_Password.Font = new System.Drawing.Font("Modern No. 20", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Password.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Login_Password.Location = new System.Drawing.Point(574, 418);
            this.lbl_Login_Password.Name = "lbl_Login_Password";
            this.lbl_Login_Password.Size = new System.Drawing.Size(187, 44);
            this.lbl_Login_Password.TabIndex = 4;
            this.lbl_Login_Password.Text = "Password";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(813, 426);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(308, 37);
            this.tb_Password.TabIndex = 7;
            // 
            // btn_Login_Submit
            // 
            this.btn_Login_Submit.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Login_Submit.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login_Submit.ForeColor = System.Drawing.Color.Navy;
            this.btn_Login_Submit.Location = new System.Drawing.Point(766, 554);
            this.btn_Login_Submit.Name = "btn_Login_Submit";
            this.btn_Login_Submit.Size = new System.Drawing.Size(181, 65);
            this.btn_Login_Submit.TabIndex = 8;
            this.btn_Login_Submit.Text = "Submit";
            this.btn_Login_Submit.UseVisualStyleBackColor = false;
            this.btn_Login_Submit.Click += new System.EventHandler(this.btn_Login_Submit_Click);
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(813, 292);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(308, 37);
            this.tb_Username.TabIndex = 7;
            // 
            // pb_Login
            // 
            this.pb_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Login.Image = global::Ayuraj_Computer_Shopee_App.Properties.Resources.Login;
            this.pb_Login.Location = new System.Drawing.Point(28, 23);
            this.pb_Login.Name = "pb_Login";
            this.pb_Login.Size = new System.Drawing.Size(523, 648);
            this.pb_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Login.TabIndex = 9;
            this.pb_Login.TabStop = false;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Login.Font = new System.Drawing.Font("Imprint MT Shadow", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Login.Location = new System.Drawing.Point(649, 110);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(342, 99);
            this.lbl_Login.TabIndex = 12;
            this.lbl_Login.Text = "LOGIN";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1182, 693);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.pb_Login);
            this.Controls.Add(this.btn_Login_Submit);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lbl_Login_Password);
            this.Controls.Add(this.lbl_Login_Username);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Login_Username;
        private System.Windows.Forms.Label lbl_Login_Password;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Login_Submit;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.PictureBox pb_Login;
        private System.Windows.Forms.Label lbl_Login;
    }
}