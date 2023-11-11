
namespace Ayuraj_Computer_Shopee_App.Forms.Product
{
    partial class frm_View_Product_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Navigation_Bar = new System.Windows.Forms.Panel();
            this.pb_Logout = new System.Windows.Forms.PictureBox();
            this.pb_Back = new System.Windows.Forms.PictureBox();
            this.lbl_View_Product_Details = new System.Windows.Forms.Label();
            this.dgv_Product_Details = new System.Windows.Forms.DataGridView();
            this.pnl_Navigation_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Navigation_Bar
            // 
            this.pnl_Navigation_Bar.BackColor = System.Drawing.Color.Purple;
            this.pnl_Navigation_Bar.Controls.Add(this.pb_Logout);
            this.pnl_Navigation_Bar.Controls.Add(this.pb_Back);
            this.pnl_Navigation_Bar.Controls.Add(this.lbl_View_Product_Details);
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
            this.pb_Logout.TabIndex = 37;
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
            this.pb_Back.TabIndex = 36;
            this.pb_Back.TabStop = false;
            this.pb_Back.Click += new System.EventHandler(this.pb_Back_Click);
            // 
            // lbl_View_Product_Details
            // 
            this.lbl_View_Product_Details.AutoSize = true;
            this.lbl_View_Product_Details.Font = new System.Drawing.Font("Modern No. 20", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Product_Details.ForeColor = System.Drawing.Color.White;
            this.lbl_View_Product_Details.Location = new System.Drawing.Point(266, 23);
            this.lbl_View_Product_Details.Name = "lbl_View_Product_Details";
            this.lbl_View_Product_Details.Size = new System.Drawing.Size(635, 70);
            this.lbl_View_Product_Details.TabIndex = 0;
            this.lbl_View_Product_Details.Text = "View Product Details";
            // 
            // dgv_Product_Details
            // 
            this.dgv_Product_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Product_Details.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Product_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Product_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product_Details.Location = new System.Drawing.Point(12, 144);
            this.dgv_Product_Details.Name = "dgv_Product_Details";
            this.dgv_Product_Details.RowHeadersWidth = 51;
            this.dgv_Product_Details.RowTemplate.Height = 24;
            this.dgv_Product_Details.Size = new System.Drawing.Size(1158, 524);
            this.dgv_Product_Details.TabIndex = 35;
            // 
            // frm_View_Product_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1182, 693);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Product_Details);
            this.Controls.Add(this.pnl_Navigation_Bar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Product_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Product Details";
            this.Load += new System.EventHandler(this.frm_View_Product_Details_Load);
            this.pnl_Navigation_Bar.ResumeLayout(false);
            this.pnl_Navigation_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Navigation_Bar;
        private System.Windows.Forms.Label lbl_View_Product_Details;
        private System.Windows.Forms.DataGridView dgv_Product_Details;
        private System.Windows.Forms.PictureBox pb_Back;
        private System.Windows.Forms.PictureBox pb_Logout;
    }
}