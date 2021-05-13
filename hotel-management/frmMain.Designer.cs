using FontAwesome.Sharp;
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
            this.panel_sidebar = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_workarea = new System.Windows.Forms.Panel();
            this.btnDangXuat = new FontAwesome.Sharp.IconButton();
            this.btnQLKhachHang = new FontAwesome.Sharp.IconButton();
            this.btnTraPhong = new FontAwesome.Sharp.IconButton();
            this.btnNhanPhong = new FontAwesome.Sharp.IconButton();
            this.btnDatPhong = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_sidebar.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel_sidebar.Controls.Add(this.btnDangXuat);
            this.panel_sidebar.Controls.Add(this.btnQLKhachHang);
            this.panel_sidebar.Controls.Add(this.btnTraPhong);
            this.panel_sidebar.Controls.Add(this.btnNhanPhong);
            this.panel_sidebar.Controls.Add(this.btnDatPhong);
            this.panel_sidebar.Controls.Add(this.btnHome);
            this.panel_sidebar.Controls.Add(this.panelInfo);
            this.panel_sidebar.Controls.Add(this.panelLogo);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(328, 702);
            this.panel_sidebar.TabIndex = 3;
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.pictureBox2);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 174);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(328, 174);
            this.panelInfo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sadio mane";
            // 
            // panelLogo
            // 
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(328, 174);
            this.panelLogo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sixboy Hotel";
            // 
            // panel_workarea
            // 
            this.panel_workarea.BackColor = System.Drawing.Color.LightGray;
            this.panel_workarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_workarea.Location = new System.Drawing.Point(328, 0);
            this.panel_workarea.Name = "panel_workarea";
            this.panel_workarea.Size = new System.Drawing.Size(956, 702);
            this.panel_workarea.TabIndex = 4;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnDangXuat.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 642);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDangXuat.Size = new System.Drawing.Size(328, 60);
            this.btnDangXuat.TabIndex = 14;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnQLKhachHang
            // 
            this.btnQLKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLKhachHang.FlatAppearance.BorderSize = 0;
            this.btnQLKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKhachHang.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLKhachHang.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.btnQLKhachHang.IconColor = System.Drawing.Color.Gainsboro;
            this.btnQLKhachHang.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLKhachHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhachHang.Location = new System.Drawing.Point(0, 588);
            this.btnQLKhachHang.Name = "btnQLKhachHang";
            this.btnQLKhachHang.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnQLKhachHang.Size = new System.Drawing.Size(328, 60);
            this.btnQLKhachHang.TabIndex = 13;
            this.btnQLKhachHang.Text = "Quản lý khách hàng";
            this.btnQLKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKhachHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLKhachHang.UseVisualStyleBackColor = true;
            this.btnQLKhachHang.Click += new System.EventHandler(this.btnQLKhachHang_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTraPhong.FlatAppearance.BorderSize = 0;
            this.btnTraPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraPhong.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTraPhong.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnTraPhong.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTraPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTraPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraPhong.Location = new System.Drawing.Point(0, 528);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTraPhong.Size = new System.Drawing.Size(328, 60);
            this.btnTraPhong.TabIndex = 12;
            this.btnTraPhong.Text = "Trả phòng";
            this.btnTraPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanPhong.FlatAppearance.BorderSize = 0;
            this.btnNhanPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanPhong.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNhanPhong.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.btnNhanPhong.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNhanPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanPhong.Location = new System.Drawing.Point(0, 468);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNhanPhong.Size = new System.Drawing.Size(328, 60);
            this.btnNhanPhong.TabIndex = 11;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanPhong.UseVisualStyleBackColor = true;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDatPhong.FlatAppearance.BorderSize = 0;
            this.btnDatPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatPhong.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDatPhong.IconChar = FontAwesome.Sharp.IconChar.LuggageCart;
            this.btnDatPhong.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDatPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.Location = new System.Drawing.Point(0, 408);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDatPhong.Size = new System.Drawing.Size(328, 60);
            this.btnDatPhong.TabIndex = 10;
            this.btnDatPhong.Text = "Đặt phòng";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 348);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(328, 60);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::hotel_management.Properties.Resources.icons8_user_male_500;
            this.pictureBox2.Location = new System.Drawing.Point(74, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hotel_management.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.panel_workarea);
            this.Controls.Add(this.panel_sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel_sidebar.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_sidebar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_workarea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnDangXuat;
        private FontAwesome.Sharp.IconButton btnQLKhachHang;
        private FontAwesome.Sharp.IconButton btnTraPhong;
        private FontAwesome.Sharp.IconButton btnNhanPhong;
        private FontAwesome.Sharp.IconButton btnDatPhong;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}