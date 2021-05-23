
namespace hotel_management
{
    partial class frmRoomManagement
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLoaiPhongTen = new System.Windows.Forms.TextBox();
            this.txtLoaiPhongID = new System.Windows.Forms.TextBox();
            this.txtLoaiPhongGia = new System.Windows.Forms.TextBox();
            this.lblLoaiPhongGia = new System.Windows.Forms.Label();
            this.lblLoaiPhongID = new System.Windows.Forms.Label();
            this.lblLoaiPhongTen = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimKiemThongTinPhong = new System.Windows.Forms.Button();
            this.btnXoaThongTinPhong = new System.Windows.Forms.Button();
            this.btnSuaThongTinPhong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwDanhSachPhong = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThongTinPhongLuuY = new System.Windows.Forms.TextBox();
            this.txtThongTinPhongTrangThai = new System.Windows.Forms.TextBox();
            this.cboThongTinPhongTang = new System.Windows.Forms.ComboBox();
            this.txtThongTinPhongID = new System.Windows.Forms.TextBox();
            this.txtThongTinIDLoaiPhong = new System.Windows.Forms.TextBox();
            this.txtThongTinPhongSoPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblThongTinPhongSoPhong = new System.Windows.Forms.Label();
            this.lblThongTinPhongID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblThongTinPhongTang = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTimKiemThongTinPhong = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvwDanhSachLoaiPhong = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiemLoaiPhong = new System.Windows.Forms.TextBox();
            this.btnTimKiemLoaiPhong = new System.Windows.Forms.Button();
            this.btnThemLoaiPhong = new System.Windows.Forms.Button();
            this.btnSuaLoaiPhong = new System.Windows.Forms.Button();
            this.btnXoaLoaiPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtLoaiPhongTen);
            this.groupBox3.Controls.Add(this.txtLoaiPhongID);
            this.groupBox3.Controls.Add(this.txtLoaiPhongGia);
            this.groupBox3.Controls.Add(this.lblLoaiPhongGia);
            this.groupBox3.Controls.Add(this.lblLoaiPhongID);
            this.groupBox3.Controls.Add(this.lblLoaiPhongTen);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(869, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(575, 320);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại Phòng";
            // 
            // txtLoaiPhongTen
            // 
            this.txtLoaiPhongTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiPhongTen.Location = new System.Drawing.Point(162, 96);
            this.txtLoaiPhongTen.Name = "txtLoaiPhongTen";
            this.txtLoaiPhongTen.Size = new System.Drawing.Size(297, 30);
            this.txtLoaiPhongTen.TabIndex = 16;
            this.txtLoaiPhongTen.Leave += new System.EventHandler(this.txtNameStyleRoom);
            // 
            // txtLoaiPhongID
            // 
            this.txtLoaiPhongID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiPhongID.Location = new System.Drawing.Point(162, 40);
            this.txtLoaiPhongID.Name = "txtLoaiPhongID";
            this.txtLoaiPhongID.Size = new System.Drawing.Size(297, 30);
            this.txtLoaiPhongID.TabIndex = 15;
            this.txtLoaiPhongID.Leave += new System.EventHandler(this.txtStyleRoomID);
            // 
            // txtLoaiPhongGia
            // 
            this.txtLoaiPhongGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiPhongGia.Location = new System.Drawing.Point(162, 156);
            this.txtLoaiPhongGia.Name = "txtLoaiPhongGia";
            this.txtLoaiPhongGia.Size = new System.Drawing.Size(299, 30);
            this.txtLoaiPhongGia.TabIndex = 17;
            this.txtLoaiPhongGia.Leave += new System.EventHandler(this.txtPriceStyleRoom);
            // 
            // lblLoaiPhongGia
            // 
            this.lblLoaiPhongGia.AutoSize = true;
            this.lblLoaiPhongGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhongGia.Location = new System.Drawing.Point(35, 164);
            this.lblLoaiPhongGia.Name = "lblLoaiPhongGia";
            this.lblLoaiPhongGia.Size = new System.Drawing.Size(50, 22);
            this.lblLoaiPhongGia.TabIndex = 3;
            this.lblLoaiPhongGia.Text = "Giá :";
            // 
            // lblLoaiPhongID
            // 
            this.lblLoaiPhongID.AutoSize = true;
            this.lblLoaiPhongID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhongID.Location = new System.Drawing.Point(35, 48);
            this.lblLoaiPhongID.Name = "lblLoaiPhongID";
            this.lblLoaiPhongID.Size = new System.Drawing.Size(36, 22);
            this.lblLoaiPhongID.TabIndex = 4;
            this.lblLoaiPhongID.Text = "ID:";
            // 
            // lblLoaiPhongTen
            // 
            this.lblLoaiPhongTen.AutoSize = true;
            this.lblLoaiPhongTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhongTen.Location = new System.Drawing.Point(35, 104);
            this.lblLoaiPhongTen.Name = "lblLoaiPhongTen";
            this.lblLoaiPhongTen.Size = new System.Drawing.Size(51, 22);
            this.lblLoaiPhongTen.TabIndex = 5;
            this.lblLoaiPhongTen.Text = "Tên :";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(18, 74);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(158, 46);
            this.lblTimKiem.TabIndex = 23;
            this.lblTimKiem.Text = "Tìm kiếm :";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(690, 449);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 35);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimKiemThongTinPhong
            // 
            this.btnTimKiemThongTinPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemThongTinPhong.Location = new System.Drawing.Point(479, 74);
            this.btnTimKiemThongTinPhong.Name = "btnTimKiemThongTinPhong";
            this.btnTimKiemThongTinPhong.Size = new System.Drawing.Size(120, 30);
            this.btnTimKiemThongTinPhong.TabIndex = 2;
            this.btnTimKiemThongTinPhong.Text = "Tìm";
            this.btnTimKiemThongTinPhong.UseVisualStyleBackColor = true;
            this.btnTimKiemThongTinPhong.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoaThongTinPhong
            // 
            this.btnXoaThongTinPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThongTinPhong.Location = new System.Drawing.Point(491, 449);
            this.btnXoaThongTinPhong.Name = "btnXoaThongTinPhong";
            this.btnXoaThongTinPhong.Size = new System.Drawing.Size(120, 35);
            this.btnXoaThongTinPhong.TabIndex = 11;
            this.btnXoaThongTinPhong.Text = "Xóa";
            this.btnXoaThongTinPhong.UseVisualStyleBackColor = true;
            this.btnXoaThongTinPhong.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSuaThongTinPhong
            // 
            this.btnSuaThongTinPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThongTinPhong.Location = new System.Drawing.Point(257, 449);
            this.btnSuaThongTinPhong.Name = "btnSuaThongTinPhong";
            this.btnSuaThongTinPhong.Size = new System.Drawing.Size(120, 35);
            this.btnSuaThongTinPhong.TabIndex = 10;
            this.btnSuaThongTinPhong.Text = "Sửa";
            this.btnSuaThongTinPhong.UseVisualStyleBackColor = true;
            this.btnSuaThongTinPhong.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwDanhSachPhong);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 508);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 392);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Phòng";
            // 
            // lvwDanhSachPhong
            // 
            this.lvwDanhSachPhong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDanhSachPhong.HideSelection = false;
            this.lvwDanhSachPhong.Location = new System.Drawing.Point(6, 38);
            this.lvwDanhSachPhong.Name = "lvwDanhSachPhong";
            this.lvwDanhSachPhong.Size = new System.Drawing.Size(752, 343);
            this.lvwDanhSachPhong.TabIndex = 0;
            this.lvwDanhSachPhong.UseCompatibleStateImageBehavior = false;
            this.lvwDanhSachPhong.SelectedIndexChanged += new System.EventHandler(this.lvwDanhSachPhong_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtThongTinPhongLuuY);
            this.groupBox1.Controls.Add(this.txtThongTinPhongTrangThai);
            this.groupBox1.Controls.Add(this.cboThongTinPhongTang);
            this.groupBox1.Controls.Add(this.txtThongTinPhongID);
            this.groupBox1.Controls.Add(this.txtThongTinIDLoaiPhong);
            this.groupBox1.Controls.Add(this.txtThongTinPhongSoPhong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblThongTinPhongSoPhong);
            this.groupBox1.Controls.Add(this.lblThongTinPhongID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblThongTinPhongTang);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 320);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phòng";
            // 
            // txtThongTinPhongLuuY
            // 
            this.txtThongTinPhongLuuY.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtThongTinPhongLuuY.Location = new System.Drawing.Point(160, 223);
            this.txtThongTinPhongLuuY.Name = "txtThongTinPhongLuuY";
            this.txtThongTinPhongLuuY.Size = new System.Drawing.Size(301, 30);
            this.txtThongTinPhongLuuY.TabIndex = 7;
            this.txtThongTinPhongLuuY.Leave += new System.EventHandler(this.txtNoteRoom);
            // 
            // txtThongTinPhongTrangThai
            // 
            this.txtThongTinPhongTrangThai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtThongTinPhongTrangThai.Location = new System.Drawing.Point(160, 174);
            this.txtThongTinPhongTrangThai.Name = "txtThongTinPhongTrangThai";
            this.txtThongTinPhongTrangThai.Size = new System.Drawing.Size(301, 30);
            this.txtThongTinPhongTrangThai.TabIndex = 6;
            this.txtThongTinPhongTrangThai.Leave += new System.EventHandler(this.txtStatusRoom);
            // 
            // cboThongTinPhongTang
            // 
            this.cboThongTinPhongTang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThongTinPhongTang.FormattingEnabled = true;
            this.cboThongTinPhongTang.Location = new System.Drawing.Point(160, 128);
            this.cboThongTinPhongTang.Name = "cboThongTinPhongTang";
            this.cboThongTinPhongTang.Size = new System.Drawing.Size(171, 30);
            this.cboThongTinPhongTang.TabIndex = 5;
            this.cboThongTinPhongTang.Leave += new System.EventHandler(this.txtGradeRoom);
            // 
            // txtThongTinPhongID
            // 
            this.txtThongTinPhongID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTinPhongID.Location = new System.Drawing.Point(160, 38);
            this.txtThongTinPhongID.Name = "txtThongTinPhongID";
            this.txtThongTinPhongID.Size = new System.Drawing.Size(301, 30);
            this.txtThongTinPhongID.TabIndex = 1;
            this.txtThongTinPhongID.Leave += new System.EventHandler(this.txtRoomID);
            // 
            // txtThongTinIDLoaiPhong
            // 
            this.txtThongTinIDLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTinIDLoaiPhong.Location = new System.Drawing.Point(160, 272);
            this.txtThongTinIDLoaiPhong.Name = "txtThongTinIDLoaiPhong";
            this.txtThongTinIDLoaiPhong.Size = new System.Drawing.Size(302, 30);
            this.txtThongTinIDLoaiPhong.TabIndex = 8;
            this.txtThongTinIDLoaiPhong.Leave += new System.EventHandler(this.txtIDStyleRoomLst);
            // 
            // txtThongTinPhongSoPhong
            // 
            this.txtThongTinPhongSoPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongTinPhongSoPhong.Location = new System.Drawing.Point(160, 82);
            this.txtThongTinPhongSoPhong.Name = "txtThongTinPhongSoPhong";
            this.txtThongTinPhongSoPhong.Size = new System.Drawing.Size(301, 30);
            this.txtThongTinPhongSoPhong.TabIndex = 4;
            this.txtThongTinPhongSoPhong.Leave += new System.EventHandler(this.txtNumbersRoom);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID loại phòng:";
            // 
            // lblThongTinPhongSoPhong
            // 
            this.lblThongTinPhongSoPhong.AutoSize = true;
            this.lblThongTinPhongSoPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinPhongSoPhong.Location = new System.Drawing.Point(35, 90);
            this.lblThongTinPhongSoPhong.Name = "lblThongTinPhongSoPhong";
            this.lblThongTinPhongSoPhong.Size = new System.Drawing.Size(94, 22);
            this.lblThongTinPhongSoPhong.TabIndex = 0;
            this.lblThongTinPhongSoPhong.Text = "Số phòng :";
            // 
            // lblThongTinPhongID
            // 
            this.lblThongTinPhongID.AutoSize = true;
            this.lblThongTinPhongID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinPhongID.Location = new System.Drawing.Point(35, 46);
            this.lblThongTinPhongID.Name = "lblThongTinPhongID";
            this.lblThongTinPhongID.Size = new System.Drawing.Size(36, 22);
            this.lblThongTinPhongID.TabIndex = 0;
            this.lblThongTinPhongID.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lưu ý:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng thái:";
            // 
            // lblThongTinPhongTang
            // 
            this.lblThongTinPhongTang.AutoSize = true;
            this.lblThongTinPhongTang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinPhongTang.Location = new System.Drawing.Point(35, 136);
            this.lblThongTinPhongTang.Name = "lblThongTinPhongTang";
            this.lblThongTinPhongTang.Size = new System.Drawing.Size(60, 22);
            this.lblThongTinPhongTang.TabIndex = 0;
            this.lblThongTinPhongTang.Text = "Tầng :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 50);
            this.panel1.TabIndex = 25;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(85)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Restroom;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 50;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(52, 50);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(58, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 50);
            this.label11.TabIndex = 0;
            this.label11.Text = "Room";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTimKiemThongTinPhong
            // 
            this.txtTimKiemThongTinPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemThongTinPhong.Location = new System.Drawing.Point(174, 74);
            this.txtTimKiemThongTinPhong.Name = "txtTimKiemThongTinPhong";
            this.txtTimKiemThongTinPhong.Size = new System.Drawing.Size(299, 30);
            this.txtTimKiemThongTinPhong.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvwDanhSachLoaiPhong);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(863, 508);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(575, 381);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh Sách Loại Phòng";
            // 
            // lvwDanhSachLoaiPhong
            // 
            this.lvwDanhSachLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwDanhSachLoaiPhong.HideSelection = false;
            this.lvwDanhSachLoaiPhong.Location = new System.Drawing.Point(6, 40);
            this.lvwDanhSachLoaiPhong.Name = "lvwDanhSachLoaiPhong";
            this.lvwDanhSachLoaiPhong.Size = new System.Drawing.Size(563, 341);
            this.lvwDanhSachLoaiPhong.TabIndex = 0;
            this.lvwDanhSachLoaiPhong.UseCompatibleStateImageBehavior = false;
            this.lvwDanhSachLoaiPhong.SelectedIndexChanged += new System.EventHandler(this.lvwDanhSachLoaiPhong_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(857, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 46);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tìm kiếm :";
            // 
            // txtTimKiemLoaiPhong
            // 
            this.txtTimKiemLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemLoaiPhong.Location = new System.Drawing.Point(992, 69);
            this.txtTimKiemLoaiPhong.Name = "txtTimKiemLoaiPhong";
            this.txtTimKiemLoaiPhong.Size = new System.Drawing.Size(310, 30);
            this.txtTimKiemLoaiPhong.TabIndex = 13;
            // 
            // btnTimKiemLoaiPhong
            // 
            this.btnTimKiemLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTimKiemLoaiPhong.Location = new System.Drawing.Point(1308, 69);
            this.btnTimKiemLoaiPhong.Name = "btnTimKiemLoaiPhong";
            this.btnTimKiemLoaiPhong.Size = new System.Drawing.Size(130, 30);
            this.btnTimKiemLoaiPhong.TabIndex = 14;
            this.btnTimKiemLoaiPhong.Text = "Tìm ";
            this.btnTimKiemLoaiPhong.UseVisualStyleBackColor = true;
            this.btnTimKiemLoaiPhong.Click += new System.EventHandler(this.btnTimKiemLoaiPhong_Click);
            // 
            // btnThemLoaiPhong
            // 
            this.btnThemLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThemLoaiPhong.Location = new System.Drawing.Point(869, 447);
            this.btnThemLoaiPhong.Name = "btnThemLoaiPhong";
            this.btnThemLoaiPhong.Size = new System.Drawing.Size(116, 35);
            this.btnThemLoaiPhong.TabIndex = 18;
            this.btnThemLoaiPhong.Text = "Thêm";
            this.btnThemLoaiPhong.UseVisualStyleBackColor = true;
            this.btnThemLoaiPhong.Click += new System.EventHandler(this.btnThemLoaiPhong_Click);
            // 
            // btnSuaLoaiPhong
            // 
            this.btnSuaLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSuaLoaiPhong.Location = new System.Drawing.Point(1093, 447);
            this.btnSuaLoaiPhong.Name = "btnSuaLoaiPhong";
            this.btnSuaLoaiPhong.Size = new System.Drawing.Size(120, 35);
            this.btnSuaLoaiPhong.TabIndex = 19;
            this.btnSuaLoaiPhong.Text = "Sửa";
            this.btnSuaLoaiPhong.UseVisualStyleBackColor = true;
            this.btnSuaLoaiPhong.Click += new System.EventHandler(this.btnSuaLoaiPhong_Click);
            // 
            // btnXoaLoaiPhong
            // 
            this.btnXoaLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnXoaLoaiPhong.Location = new System.Drawing.Point(1324, 447);
            this.btnXoaLoaiPhong.Name = "btnXoaLoaiPhong";
            this.btnXoaLoaiPhong.Size = new System.Drawing.Size(120, 35);
            this.btnXoaLoaiPhong.TabIndex = 20;
            this.btnXoaLoaiPhong.Text = "Xóa";
            this.btnXoaLoaiPhong.UseVisualStyleBackColor = true;
            this.btnXoaLoaiPhong.Click += new System.EventHandler(this.btnXoaLoaiPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThemPhong.Location = new System.Drawing.Point(24, 449);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(110, 35);
            this.btnThemPhong.TabIndex = 9;
            this.btnThemPhong.Text = "Thêm Phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // frmRoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 1102);
            this.Controls.Add(this.btnThemPhong);
            this.Controls.Add(this.btnXoaLoaiPhong);
            this.Controls.Add(this.btnSuaLoaiPhong);
            this.Controls.Add(this.btnThemLoaiPhong);
            this.Controls.Add(this.btnTimKiemLoaiPhong);
            this.Controls.Add(this.txtTimKiemLoaiPhong);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTimKiemThongTinPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiemThongTinPhong);
            this.Controls.Add(this.btnXoaThongTinPhong);
            this.Controls.Add(this.btnSuaThongTinPhong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRoomManagement";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.frmRoomManagement_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLoaiPhongTen;
        private System.Windows.Forms.TextBox txtLoaiPhongID;
        private System.Windows.Forms.TextBox txtLoaiPhongGia;
        private System.Windows.Forms.Label lblLoaiPhongGia;
        private System.Windows.Forms.Label lblLoaiPhongID;
        private System.Windows.Forms.Label lblLoaiPhongTen;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimKiemThongTinPhong;
        private System.Windows.Forms.Button btnXoaThongTinPhong;
        private System.Windows.Forms.Button btnSuaThongTinPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboThongTinPhongTang;
        private System.Windows.Forms.TextBox txtThongTinPhongID;
        private System.Windows.Forms.TextBox txtThongTinPhongSoPhong;
        private System.Windows.Forms.Label lblThongTinPhongSoPhong;
        private System.Windows.Forms.Label lblThongTinPhongID;
        private System.Windows.Forms.Label lblThongTinPhongTang;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvwDanhSachPhong;
        private System.Windows.Forms.TextBox txtTimKiemThongTinPhong;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThongTinIDLoaiPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvwDanhSachLoaiPhong;
        private System.Windows.Forms.TextBox txtTimKiemLoaiPhong;
        private System.Windows.Forms.Button btnTimKiemLoaiPhong;
        private System.Windows.Forms.Button btnThemLoaiPhong;
        private System.Windows.Forms.Button btnSuaLoaiPhong;
        private System.Windows.Forms.Button btnXoaLoaiPhong;
        private System.Windows.Forms.TextBox txtThongTinPhongTrangThai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThongTinPhongLuuY;
        private System.Windows.Forms.Button btnThemPhong;
    }
}