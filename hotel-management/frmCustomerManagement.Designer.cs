
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
            this.lvwKhachHang = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwKhachHang
            // 
            this.lvwKhachHang.HideSelection = false;
            this.lvwKhachHang.Location = new System.Drawing.Point(353, 55);
            this.lvwKhachHang.Name = "lvwKhachHang";
            this.lvwKhachHang.Size = new System.Drawing.Size(428, 366);
            this.lvwKhachHang.TabIndex = 0;
            this.lvwKhachHang.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // frmCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 505);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwKhachHang);
            this.Name = "frmCustomerManagement";
            this.Text = "frmCustomerManagement";
            this.Load += new System.EventHandler(this.frmCustomerManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwKhachHang;
        private System.Windows.Forms.Label label1;
    }
}