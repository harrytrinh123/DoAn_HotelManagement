
namespace hotel_management
{
    partial class frmHome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnDVThanhToan = new System.Windows.Forms.Button();
            this.btnQLKhachHang = new System.Windows.Forms.Button();
            this.btnQLDon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 67);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(24, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Home";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(929, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Location = new System.Drawing.Point(60, 115);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(166, 239);
            this.btnDatPhong.TabIndex = 1;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Location = new System.Drawing.Point(280, 115);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(166, 239);
            this.btnNhanPhong.TabIndex = 1;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = true;
            this.btnNhanPhong.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDVThanhToan
            // 
            this.btnDVThanhToan.Location = new System.Drawing.Point(60, 407);
            this.btnDVThanhToan.Name = "btnDVThanhToan";
            this.btnDVThanhToan.Size = new System.Drawing.Size(386, 164);
            this.btnDVThanhToan.TabIndex = 1;
            this.btnDVThanhToan.Text = "Dịch vụ và thanh toán";
            this.btnDVThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.Location = new System.Drawing.Point(563, 115);
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.Size = new System.Drawing.Size(166, 239);
            this.btnQLKhachHang.TabIndex = 1;
            this.btnQLKhachHang.Text = "Quản lý khách hàng";
            this.btnQLKhachHang.UseVisualStyleBackColor = true;
            // 
            // btnQLDon
            // 
            this.btnQLDon.Location = new System.Drawing.Point(765, 115);
            this.btnQLDon.Name = "btnQLDon";
            this.btnQLDon.Size = new System.Drawing.Size(166, 239);
            this.btnQLDon.TabIndex = 1;
            this.btnQLDon.Text = "Quản lý hóa đơn";
            this.btnQLDon.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 642);
            this.Controls.Add(this.btnQLDon);
            this.Controls.Add(this.btnQLKhachHang);
            this.Controls.Add(this.btnNhanPhong);
            this.Controls.Add(this.btnDVThanhToan);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Button btnDVThanhToan;
        private System.Windows.Forms.Button btnQLKhachHang;
        private System.Windows.Forms.Button btnQLDon;
    }
}