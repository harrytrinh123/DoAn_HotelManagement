
namespace hotel_management
{
    partial class frmMainManagement
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_sidebar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTrangThietBi = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel_workarea = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panel_sidebar
            // 
            this.panel_sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_sidebar.Controls.Add(this.label2);
            this.panel_sidebar.Controls.Add(this.btnLogout);
            this.panel_sidebar.Controls.Add(this.pictureBox2);
            this.panel_sidebar.Controls.Add(this.btnTrangThietBi);
            this.panel_sidebar.Controls.Add(this.btnPhong);
            this.panel_sidebar.Controls.Add(this.btnNhanVien);
            this.panel_sidebar.Controls.Add(this.btnDichVu);
            this.panel_sidebar.Controls.Add(this.btnHome);
            this.panel_sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_sidebar.Location = new System.Drawing.Point(0, 82);
            this.panel_sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_sidebar.Name = "panel_sidebar";
            this.panel_sidebar.Size = new System.Drawing.Size(252, 473);
            this.panel_sidebar.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sadio mane";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DimGray;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Location = new System.Drawing.Point(0, 432);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(252, 41);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(68, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnTrangThietBi
            // 
            this.btnTrangThietBi.BackColor = System.Drawing.Color.DimGray;
            this.btnTrangThietBi.Location = new System.Drawing.Point(1, 378);
            this.btnTrangThietBi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrangThietBi.Name = "btnTrangThietBi";
            this.btnTrangThietBi.Size = new System.Drawing.Size(252, 41);
            this.btnTrangThietBi.TabIndex = 4;
            this.btnTrangThietBi.Text = "Trang Thiết Bị";
            this.btnTrangThietBi.UseVisualStyleBackColor = false;
            this.btnTrangThietBi.Click += new System.EventHandler(this.btnTrangThietBi_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.BackColor = System.Drawing.Color.DimGray;
            this.btnPhong.Location = new System.Drawing.Point(-2, 322);
            this.btnPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(254, 41);
            this.btnPhong.TabIndex = 4;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.UseVisualStyleBackColor = false;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.DimGray;
            this.btnNhanVien.Location = new System.Drawing.Point(1, 266);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(252, 41);
            this.btnNhanVien.TabIndex = 4;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.BackColor = System.Drawing.Color.DimGray;
            this.btnDichVu.Location = new System.Drawing.Point(-2, 213);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(254, 41);
            this.btnDichVu.TabIndex = 4;
            this.btnDichVu.Text = "Dịch Vụ";
            this.btnDichVu.UseVisualStyleBackColor = false;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DimGray;
            this.btnHome.Location = new System.Drawing.Point(-2, 158);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(254, 41);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel_workarea
            // 
            this.panel_workarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_workarea.Location = new System.Drawing.Point(0, 82);
            this.panel_workarea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_workarea.Name = "panel_workarea";
            this.panel_workarea.Size = new System.Drawing.Size(1115, 473);
            this.panel_workarea.TabIndex = 10;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_header.Controls.Add(this.pictureBox1);
            this.panel_header.Controls.Add(this.label3);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1115, 82);
            this.panel_header.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1066, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "x";
            // 
            // frmMainManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 555);
            this.Controls.Add(this.panel_sidebar);
            this.Controls.Add(this.panel_workarea);
            this.Controls.Add(this.panel_header);
            this.Name = "frmMainManagement";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_sidebar.ResumeLayout(false);
            this.panel_sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_sidebar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTrangThietBi;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel_workarea;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label3;
    }
}