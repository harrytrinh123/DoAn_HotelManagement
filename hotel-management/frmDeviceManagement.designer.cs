
namespace hotel_management
{
    partial class frmDeviceManagement
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
            this.btnALL = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwThietBi = new System.Windows.Forms.ListView();
            this.txtID = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.txtID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnALL
            // 
            this.btnALL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnALL.Location = new System.Drawing.Point(403, 318);
            this.btnALL.Name = "btnALL";
            this.btnALL.Size = new System.Drawing.Size(107, 35);
            this.btnALL.TabIndex = 17;
            this.btnALL.Text = "ALL";
            this.btnALL.UseVisualStyleBackColor = true;
            this.btnALL.Click += new System.EventHandler(this.btnALL_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(275, 318);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 35);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(145, 318);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 35);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(17, 318);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 35);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tìm kiếm :";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(179, 72);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(227, 22);
            this.txtTimKiem.TabIndex = 15;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(412, 72);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(98, 33);
            this.btnTim.TabIndex = 14;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.txtTen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 182);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thiết bị";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(113, 125);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(338, 30);
            this.txtGia.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(113, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 30);
            this.textBox1.TabIndex = 1;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(113, 87);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(338, 30);
            this.txtTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwThietBi);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(527, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 256);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thiết bị ";
            // 
            // lvwThietBi
            // 
            this.lvwThietBi.HideSelection = false;
            this.lvwThietBi.Location = new System.Drawing.Point(22, 29);
            this.lvwThietBi.Name = "lvwThietBi";
            this.lvwThietBi.Size = new System.Drawing.Size(619, 204);
            this.lvwThietBi.TabIndex = 0;
            this.lvwThietBi.UseCompatibleStateImageBehavior = false;
            this.lvwThietBi.SelectedIndexChanged += new System.EventHandler(this.lvwDSTB_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.Blue;
            this.txtID.Controls.Add(this.iconPictureBox1);
            this.txtID.Controls.Add(this.label11);
            this.txtID.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtID.Location = new System.Drawing.Point(0, 0);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(1234, 50);
            this.txtID.TabIndex = 21;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(85)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Desktop;
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
            this.label11.Text = "Device";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // frmDeviceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 386);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnALL);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDeviceManagement";
            this.Text = "Huydeptrai";
            this.Load += new System.EventHandler(this.frmDeviceManagement_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.txtID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnALL;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwThietBi;
        private System.Windows.Forms.Panel txtID;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}