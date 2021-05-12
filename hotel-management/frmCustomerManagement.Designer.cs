
namespace hotel_management
{
    partial class frmCustomerManagement
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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTimCMND = new System.Windows.Forms.TextBox();
            this.lvwDSKhachHang = new System.Windows.Forms.ListView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.txtCNMD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.btnLuuThayDoi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(24, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(240, 29);
            this.label11.TabIndex = 1;
            this.label11.Text = "Quản lý khách hàng";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(884, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 37);
            this.label12.TabIndex = 0;
            this.label12.Text = "x";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 67);
            this.panel1.TabIndex = 10;
            // 
            // txtTimCMND
            // 
            this.txtTimCMND.Location = new System.Drawing.Point(39, 103);
            this.txtTimCMND.Name = "txtTimCMND";
            this.txtTimCMND.Size = new System.Drawing.Size(265, 26);
            this.txtTimCMND.TabIndex = 11;
            this.txtTimCMND.Text = "CMND/CCCD";
            // 
            // lvwDSKhachHang
            // 
            this.lvwDSKhachHang.HideSelection = false;
            this.lvwDSKhachHang.Location = new System.Drawing.Point(493, 149);
            this.lvwDSKhachHang.Name = "lvwDSKhachHang";
            this.lvwDSKhachHang.Size = new System.Drawing.Size(414, 441);
            this.lvwDSKhachHang.TabIndex = 12;
            this.lvwDSKhachHang.UseCompatibleStateImageBehavior = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(356, 103);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(80, 37);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtGioiTinh);
            this.groupBox1.Controls.Add(this.txtCNMD);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSoDT);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Location = new System.Drawing.Point(29, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 340);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số CMND/CCCD";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(222, 242);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(174, 26);
            this.txtDiaChi.TabIndex = 0;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(222, 153);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(174, 26);
            this.txtGioiTinh.TabIndex = 0;
            // 
            // txtCNMD
            // 
            this.txtCNMD.Location = new System.Drawing.Point(222, 62);
            this.txtCNMD.Name = "txtCNMD";
            this.txtCNMD.Size = new System.Drawing.Size(174, 26);
            this.txtCNMD.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(18, 242);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 26);
            this.txtEmail.TabIndex = 0;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(18, 153);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(174, 26);
            this.txtSoDT.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(18, 62);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(174, 26);
            this.txtHoTen.TabIndex = 0;
            // 
            // btnLuuThayDoi
            // 
            this.btnLuuThayDoi.Location = new System.Drawing.Point(47, 527);
            this.btnLuuThayDoi.Name = "btnLuuThayDoi";
            this.btnLuuThayDoi.Size = new System.Drawing.Size(126, 46);
            this.btnLuuThayDoi.TabIndex = 15;
            this.btnLuuThayDoi.Text = "Lưu thay đổi";
            this.btnLuuThayDoi.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(323, 527);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 46);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(544, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Danh sách khách hàng";
            // 
            // frmCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 602);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuuThayDoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.lvwDSKhachHang);
            this.Controls.Add(this.txtTimCMND);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCustomerManagement";
            this.Text = "frmCustomerManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTimCMND;
        private System.Windows.Forms.ListView lvwDSKhachHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.TextBox txtCNMD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Button btnLuuThayDoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label7;
    }
}