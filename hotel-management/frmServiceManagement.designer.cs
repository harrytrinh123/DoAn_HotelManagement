
namespace hotel_management
{
    partial class frmServiceManagement
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLoadView = new System.Windows.Forms.Button();
            this.txtTenLDV = new System.Windows.Forms.TextBox();
            this.txtID_LDV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThemLDV = new System.Windows.Forms.Button();
            this.btnSuaLDV = new System.Windows.Forms.Button();
            this.btnXoaLDV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwService = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.cboLDV = new System.Windows.Forms.ComboBox();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.txtID_DV = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.radDichVu = new System.Windows.Forms.RadioButton();
            this.radLoaiDichVu = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lvwLDV = new System.Windows.Forms.ListView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLoadView);
            this.groupBox3.Controls.Add(this.txtTenLDV);
            this.groupBox3.Controls.Add(this.txtID_LDV);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnThemLDV);
            this.groupBox3.Controls.Add(this.btnSuaLDV);
            this.groupBox3.Controls.Add(this.btnXoaLDV);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(18, 473);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 239);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại Dịch Vụ";
            // 
            // btnLoadView
            // 
            this.btnLoadView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadView.Location = new System.Drawing.Point(469, 180);
            this.btnLoadView.Name = "btnLoadView";
            this.btnLoadView.Size = new System.Drawing.Size(95, 34);
            this.btnLoadView.TabIndex = 43;
            this.btnLoadView.Text = "Tải lại";
            this.btnLoadView.UseVisualStyleBackColor = true;
            this.btnLoadView.Click += new System.EventHandler(this.btnLoadView_Click);
            // 
            // txtTenLDV
            // 
            this.txtTenLDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLDV.Location = new System.Drawing.Point(164, 90);
            this.txtTenLDV.Name = "txtTenLDV";
            this.txtTenLDV.Size = new System.Drawing.Size(313, 30);
            this.txtTenLDV.TabIndex = 6;
            this.txtTenLDV.TextChanged += new System.EventHandler(this.txtTenDV_Leave);
            // 
            // txtID_LDV
            // 
            this.txtID_LDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_LDV.Location = new System.Drawing.Point(164, 40);
            this.txtID_LDV.Name = "txtID_LDV";
            this.txtID_LDV.Size = new System.Drawing.Size(313, 30);
            this.txtID_LDV.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tên :";
            // 
            // btnThemLDV
            // 
            this.btnThemLDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLDV.Location = new System.Drawing.Point(10, 180);
            this.btnThemLDV.Name = "btnThemLDV";
            this.btnThemLDV.Size = new System.Drawing.Size(120, 35);
            this.btnThemLDV.TabIndex = 41;
            this.btnThemLDV.Text = "Thêm";
            this.btnThemLDV.UseVisualStyleBackColor = true;
            this.btnThemLDV.Click += new System.EventHandler(this.btnThemLDV_Click);
            // 
            // btnSuaLDV
            // 
            this.btnSuaLDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLDV.Location = new System.Drawing.Point(164, 180);
            this.btnSuaLDV.Name = "btnSuaLDV";
            this.btnSuaLDV.Size = new System.Drawing.Size(120, 35);
            this.btnSuaLDV.TabIndex = 40;
            this.btnSuaLDV.Text = "Sửa";
            this.btnSuaLDV.UseVisualStyleBackColor = true;
            this.btnSuaLDV.Click += new System.EventHandler(this.btnSuaLDV_Click);
            // 
            // btnXoaLDV
            // 
            this.btnXoaLDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLDV.Location = new System.Drawing.Point(331, 180);
            this.btnXoaLDV.Name = "btnXoaLDV";
            this.btnXoaLDV.Size = new System.Drawing.Size(120, 35);
            this.btnXoaLDV.TabIndex = 39;
            this.btnXoaLDV.Text = "Xóa";
            this.btnXoaLDV.UseVisualStyleBackColor = true;
            this.btnXoaLDV.Click += new System.EventHandler(this.btnXoaLDV_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 33);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tìm kiếm :";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(166, 76);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(303, 22);
            this.txtTimKiem.TabIndex = 42;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(487, 67);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 37);
            this.btnTim.TabIndex = 38;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(317, 252);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 35);
            this.btnXoa.TabIndex = 39;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(160, 252);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 35);
            this.btnSua.TabIndex = 40;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(20, 252);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 35);
            this.btnThem.TabIndex = 41;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwService);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(642, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(810, 385);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Dịch Vụ";
            // 
            // lvwService
            // 
            this.lvwService.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwService.HideSelection = false;
            this.lvwService.Location = new System.Drawing.Point(19, 39);
            this.lvwService.Name = "lvwService";
            this.lvwService.Size = new System.Drawing.Size(776, 323);
            this.lvwService.TabIndex = 0;
            this.lvwService.UseCompatibleStateImageBehavior = false;
            this.lvwService.SelectedIndexChanged += new System.EventHandler(this.lvwService_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.cboLDV);
            this.groupBox1.Controls.Add(this.txtTenDV);
            this.groupBox1.Controls.Add(this.txtID_DV);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 310);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Dịch Vụ";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(469, 253);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(95, 34);
            this.btnView.TabIndex = 43;
            this.btnView.Text = "Tải lại";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // cboLDV
            // 
            this.cboLDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cboLDV.FormattingEnabled = true;
            this.cboLDV.Location = new System.Drawing.Point(160, 190);
            this.cboLDV.Name = "cboLDV";
            this.cboLDV.Size = new System.Drawing.Size(313, 31);
            this.cboLDV.TabIndex = 42;
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Location = new System.Drawing.Point(158, 88);
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(313, 30);
            this.txtTenDV.TabIndex = 1;
            this.txtTenDV.Leave += new System.EventHandler(this.txtTenDV_Leave);
            // 
            // txtID_DV
            // 
            this.txtID_DV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_DV.Location = new System.Drawing.Point(160, 37);
            this.txtID_DV.Name = "txtID_DV";
            this.txtID_DV.Size = new System.Drawing.Size(313, 30);
            this.txtID_DV.TabIndex = 1;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(160, 146);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(313, 30);
            this.txtGia.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại dịch vụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên:";
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
            this.panel1.Size = new System.Drawing.Size(1452, 50);
            this.panel1.TabIndex = 45;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(85)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SearchDollar;
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
            this.label11.TabIndex = 3;
            this.label11.Text = "Service";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radDichVu
            // 
            this.radDichVu.AutoSize = true;
            this.radDichVu.Location = new System.Drawing.Point(166, 104);
            this.radDichVu.Name = "radDichVu";
            this.radDichVu.Size = new System.Drawing.Size(76, 21);
            this.radDichVu.TabIndex = 46;
            this.radDichVu.TabStop = true;
            this.radDichVu.Text = "Dịch vụ";
            this.radDichVu.UseVisualStyleBackColor = true;
            this.radDichVu.CheckedChanged += new System.EventHandler(this.radDichVu_CheckedChanged);
            // 
            // radLoaiDichVu
            // 
            this.radLoaiDichVu.AutoSize = true;
            this.radLoaiDichVu.Location = new System.Drawing.Point(364, 104);
            this.radLoaiDichVu.Name = "radLoaiDichVu";
            this.radLoaiDichVu.Size = new System.Drawing.Size(105, 21);
            this.radLoaiDichVu.TabIndex = 46;
            this.radLoaiDichVu.TabStop = true;
            this.radLoaiDichVu.Text = "Loại dịch vụ";
            this.radLoaiDichVu.UseVisualStyleBackColor = true;
            this.radLoaiDichVu.CheckedChanged += new System.EventHandler(this.radLoaiDichVu_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lvwLDV);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(649, 502);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(473, 210);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách loại dịch vụ";
            // 
            // lvwLDV
            // 
            this.lvwLDV.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwLDV.HideSelection = false;
            this.lvwLDV.Location = new System.Drawing.Point(21, 38);
            this.lvwLDV.Name = "lvwLDV";
            this.lvwLDV.Size = new System.Drawing.Size(431, 148);
            this.lvwLDV.TabIndex = 0;
            this.lvwLDV.UseCompatibleStateImageBehavior = false;
            this.lvwLDV.SelectedIndexChanged += new System.EventHandler(this.lvwLDV_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmServiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 746);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.radLoaiDichVu);
            this.Controls.Add(this.radDichVu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServiceManagement";
            this.Text = "frmServiceManagement";
            this.Load += new System.EventHandler(this.frmServiceManagement_Load);
            this.Click += new System.EventHandler(this.frmServiceManagement_Click);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTenLDV;
        private System.Windows.Forms.TextBox txtID_LDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvwService;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtID_DV;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Button btnThemLDV;
        private System.Windows.Forms.Button btnSuaLDV;
        private System.Windows.Forms.Button btnXoaLDV;
        private System.Windows.Forms.ComboBox cboLDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radDichVu;
        private System.Windows.Forms.RadioButton radLoaiDichVu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lvwLDV;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnLoadView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}