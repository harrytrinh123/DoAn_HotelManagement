
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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQLDon = new System.Windows.Forms.Button();
            this.btnQLKhachHang = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnDVThanhToan = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(55, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 37);
            this.label11.TabIndex = 1;
            this.label11.Text = "Home";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.DeepPink;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1152, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 40);
            this.label12.TabIndex = 0;
            this.label12.Text = "x";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 62);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQLDon);
            this.panel2.Controls.Add(this.btnQLKhachHang);
            this.panel2.Controls.Add(this.btnNhanPhong);
            this.panel2.Controls.Add(this.btnDVThanhToan);
            this.panel2.Controls.Add(this.btnDatPhong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 638);
            this.panel2.TabIndex = 4;
            // 
            // btnQLDon
            // 
            this.btnQLDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQLDon.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnQLDon.BackgroundImage = global::hotel_management.Properties.Resources.icons8_paid_bill_96;
            this.btnQLDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQLDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDon.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnQLDon.Location = new System.Drawing.Point(912, 60);
            this.btnQLDon.Name = "btnQLDon";
            this.btnQLDon.Size = new System.Drawing.Size(186, 269);
            this.btnQLDon.TabIndex = 2;
            this.btnQLDon.Text = "Quản lý hóa đơn";
            this.btnQLDon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLDon.UseVisualStyleBackColor = false;
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQLKhachHang.BackColor = System.Drawing.Color.Pink;
            this.btnQLKhachHang.BackgroundImage = global::hotel_management.Properties.Resources.customer;
            this.btnQLKhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnQLKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKhachHang.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnQLKhachHang.Location = new System.Drawing.Point(674, 60);
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.Size = new System.Drawing.Size(188, 269);
            this.btnQLKhachHang.TabIndex = 3;
            this.btnQLKhachHang.Text = "Quản lý khách hàng";
            this.btnQLKhachHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQLKhachHang.UseVisualStyleBackColor = false;
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNhanPhong.BackColor = System.Drawing.Color.Cyan;
            this.btnNhanPhong.BackgroundImage = global::hotel_management.Properties.Resources.icons8_room_64;
            this.btnNhanPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNhanPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanPhong.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNhanPhong.Location = new System.Drawing.Point(362, 60);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(190, 269);
            this.btnNhanPhong.TabIndex = 4;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhanPhong.UseVisualStyleBackColor = false;
            // 
            // btnDVThanhToan
            // 
            this.btnDVThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDVThanhToan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDVThanhToan.BackgroundImage = global::hotel_management.Properties.Resources.icons8_service_96;
            this.btnDVThanhToan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDVThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDVThanhToan.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDVThanhToan.Location = new System.Drawing.Point(128, 397);
            this.btnDVThanhToan.Name = "btnDVThanhToan";
            this.btnDVThanhToan.Size = new System.Drawing.Size(424, 178);
            this.btnDVThanhToan.TabIndex = 5;
            this.btnDVThanhToan.Text = "Dịch vụ và thanh toán";
            this.btnDVThanhToan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDVThanhToan.UseVisualStyleBackColor = false;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDatPhong.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnDatPhong.BackgroundImage = global::hotel_management.Properties.Resources.icons8_key_64;
            this.btnDatPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDatPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnDatPhong.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDatPhong.Location = new System.Drawing.Point(128, 60);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(200, 269);
            this.btnDatPhong.TabIndex = 6;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(85)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 44;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 9);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(46, 44);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQLDon;
        private System.Windows.Forms.Button btnQLKhachHang;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Button btnDVThanhToan;
        private System.Windows.Forms.Button btnDatPhong;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}