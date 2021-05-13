
namespace hotel_management
{
    partial class frmHomeManagement
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
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnThietBi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDichVu
            // 
            this.btnDichVu.Location = new System.Drawing.Point(640, 130);
            this.btnDichVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Size = new System.Drawing.Size(148, 191);
            this.btnDichVu.TabIndex = 2;
            this.btnDichVu.Text = "Dịch Vụ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            // 
            // btnPhong
            // 
            this.btnPhong.Location = new System.Drawing.Point(460, 130);
            this.btnPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(148, 191);
            this.btnPhong.TabIndex = 3;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(209, 130);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(148, 191);
            this.btnNhanVien.TabIndex = 4;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnThietBi
            // 
            this.btnThietBi.Location = new System.Drawing.Point(13, 130);
            this.btnThietBi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThietBi.Name = "btnThietBi";
            this.btnThietBi.Size = new System.Drawing.Size(148, 191);
            this.btnThietBi.TabIndex = 5;
            this.btnThietBi.Text = "Thiết bị";
            this.btnThietBi.UseVisualStyleBackColor = true;
            // 
            // frmHomeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDichVu);
            this.Controls.Add(this.btnPhong);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.btnThietBi);
            this.Name = "frmHomeManagement";
            this.Text = "frmHomeManagement";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnThietBi;
    }
}