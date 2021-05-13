
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
            this.panel_header = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_workarea = new System.Windows.Forms.Panel();
            this.btnQL = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_header.Controls.Add(this.label3);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1254, 102);
            this.panel_header.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1199, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "x";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnQL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 592);
            this.panel1.TabIndex = 9;
            // 
            // panel_workarea
            // 
            this.panel_workarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_workarea.Location = new System.Drawing.Point(200, 102);
            this.panel_workarea.Name = "panel_workarea";
            this.panel_workarea.Size = new System.Drawing.Size(1054, 592);
            this.panel_workarea.TabIndex = 10;
            // 
            // btnQL
            // 
            this.btnQL.Location = new System.Drawing.Point(0, 137);
            this.btnQL.Name = "btnQL";
            this.btnQL.Size = new System.Drawing.Size(101, 70);
            this.btnQL.TabIndex = 0;
            this.btnQL.Text = "button1";
            this.btnQL.UseVisualStyleBackColor = true;
            this.btnQL.Click += new System.EventHandler(this.btnQL_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 70);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmMainManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 694);
            this.Controls.Add(this.panel_workarea);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_header);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMainManagement";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainManagement_Load);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnQL;
        private System.Windows.Forms.Panel panel_workarea;
    }
}