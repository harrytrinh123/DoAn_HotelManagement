
namespace hotel_management
{
    partial class frmMain
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
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_sidebar = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnQLKhachHang = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_workarea = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_header.SuspendLayout();
            this.panel_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_header.Controls.Add(this.pictureBox1);
            this.panel_header.Controls.Add(this.label3);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1071, 103);
            this.panel_header.TabIndex = 2;
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_sidebar.Controls.Add(this.label2);
            this.panel_sidebar.Controls.Add(this.btnLogout);
            this.panel_sidebar.Controls.Add(this.pictureBox2);
            this.panel_sidebar.Controls.Add(this.btnQLKhachHang);
            this.panel_sidebar.Controls.Add(this.btnTraPhong);
            this.panel_sidebar.Controls.Add(this.btnNhanPhong);
            this.panel_sidebar.Controls.Add(this.btnDatPhong);
            this.panel_sidebar.Controls.Add(this.btnHome);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 103);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(283, 628);
            this.panel_sidebar.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DimGray;
            this.btnHome.Location = new System.Drawing.Point(-2, 198);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(286, 51);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.DimGray;
            this.btnDatPhong.Location = new System.Drawing.Point(-2, 266);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Size = new System.Drawing.Size(286, 51);
            this.btnDatPhong.TabIndex = 4;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.BackColor = System.Drawing.Color.DimGray;
            this.btnNhanPhong.Location = new System.Drawing.Point(1, 333);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(283, 51);
            this.btnNhanPhong.TabIndex = 4;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = false;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.BackColor = System.Drawing.Color.DimGray;
            this.btnTraPhong.Location = new System.Drawing.Point(-2, 402);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(286, 51);
            this.btnTraPhong.TabIndex = 4;
            this.btnTraPhong.Text = "Trả phòng";
            this.btnTraPhong.UseVisualStyleBackColor = false;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.BackColor = System.Drawing.Color.DimGray;
            this.btnQLKhachHang.Location = new System.Drawing.Point(1, 473);
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.Size = new System.Drawing.Size(283, 51);
            this.btnQLKhachHang.TabIndex = 4;
            this.btnQLKhachHang.Text = "Quản lý khách hàng";
            this.btnQLKhachHang.UseVisualStyleBackColor = false;
            this.btnQLKhachHang.Click += new System.EventHandler(this.btnQLKhachHang_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DimGray;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Location = new System.Drawing.Point(0, 577);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(283, 51);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sadio mane";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1016, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel_workarea
            // 
            this.panel_workarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_workarea.Location = new System.Drawing.Point(283, 103);
            this.panel_workarea.Name = "panel_workarea";
            this.panel_workarea.Size = new System.Drawing.Size(788, 628);
            this.panel_workarea.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::hotel_management.Properties.Resources.images;
            this.pictureBox2.Location = new System.Drawing.Point(77, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotel_management.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 731);
            this.Controls.Add(this.panel_workarea);
            this.Controls.Add(this.panel_sidebar);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_sidebar.ResumeLayout(false);
            this.panel_sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_sidebar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnQLKhachHang;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_workarea;
    }
}