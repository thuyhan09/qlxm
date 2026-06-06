namespace Quản_lý_thuê_xe_máy.cs
{
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnLuotThue = new System.Windows.Forms.Button();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.pnlDoanhThu = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlXeDangThue = new System.Windows.Forms.Panel();
            this.lblXeDangThue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlLuotThue = new System.Windows.Forms.Panel();
            this.lblLuotThue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvThongKe = new System.Windows.Forms.DataGridView();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboXe = new System.Windows.Forms.ComboBox();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.pnlDoanhThu.SuspendLayout();
            this.pnlXeDangThue.SuspendLayout();
            this.pnlLuotThue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Moccasin;
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.txtDoanhThu);
            this.panel1.Controls.Add(this.lblTongDoanhThu);
            this.panel1.Controls.Add(this.cboXe);
            this.panel1.Controls.Add(this.cboThang);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 607);
            this.panel1.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThem.Location = new System.Drawing.Point(44, 273);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(134, 38);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm thống kê";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(29, 344);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(167, 16);
            this.lblTongDoanhThu.TabIndex = 2;
            this.lblTongDoanhThu.Text = "Tổng doanh thu: 0 VNĐ";
            this.lblTongDoanhThu.Click += new System.EventHandler(this.lblTongDoanhThu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống Kê";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // grbChucNang
            // 
            this.grbChucNang.Controls.Add(this.btnLuotThue);
            this.grbChucNang.Controls.Add(this.btnDoanhThu);
            this.grbChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChucNang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grbChucNang.Location = new System.Drawing.Point(235, 86);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(221, 176);
            this.grbChucNang.TabIndex = 2;
            this.grbChucNang.TabStop = false;
            this.grbChucNang.Text = "Chức năng thống kê";
            // 
            // btnLuotThue
            // 
            this.btnLuotThue.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLuotThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuotThue.ForeColor = System.Drawing.Color.Indigo;
            this.btnLuotThue.Location = new System.Drawing.Point(112, 66);
            this.btnLuotThue.Name = "btnLuotThue";
            this.btnLuotThue.Size = new System.Drawing.Size(103, 94);
            this.btnLuotThue.TabIndex = 1;
            this.btnLuotThue.Text = "📋 Thống kê lượt thuê";
            this.btnLuotThue.UseVisualStyleBackColor = false;
            this.btnLuotThue.Click += new System.EventHandler(this.btnLuotThue_Click);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhThu.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDoanhThu.Location = new System.Drawing.Point(5, 64);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Size = new System.Drawing.Size(101, 96);
            this.btnDoanhThu.TabIndex = 0;
            this.btnDoanhThu.Text = "📈 Thống kê doanh thu";
            this.btnDoanhThu.UseVisualStyleBackColor = false;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            // 
            // pnlDoanhThu
            // 
            this.pnlDoanhThu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlDoanhThu.Controls.Add(this.lblDoanhThu);
            this.pnlDoanhThu.Controls.Add(this.label2);
            this.pnlDoanhThu.Location = new System.Drawing.Point(491, 86);
            this.pnlDoanhThu.Name = "pnlDoanhThu";
            this.pnlDoanhThu.Size = new System.Drawing.Size(143, 122);
            this.pnlDoanhThu.TabIndex = 4;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDoanhThu.Location = new System.Drawing.Point(47, 77);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(31, 18);
            this.lblDoanhThu.TabIndex = 5;
            this.lblDoanhThu.Text = "0 đ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng doanh thu";
            // 
            // pnlXeDangThue
            // 
            this.pnlXeDangThue.Controls.Add(this.lblXeDangThue);
            this.pnlXeDangThue.Controls.Add(this.label6);
            this.pnlXeDangThue.Location = new System.Drawing.Point(800, 86);
            this.pnlXeDangThue.Name = "pnlXeDangThue";
            this.pnlXeDangThue.Size = new System.Drawing.Size(140, 122);
            this.pnlXeDangThue.TabIndex = 5;
            // 
            // lblXeDangThue
            // 
            this.lblXeDangThue.AutoSize = true;
            this.lblXeDangThue.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblXeDangThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXeDangThue.Location = new System.Drawing.Point(57, 66);
            this.lblXeDangThue.Name = "lblXeDangThue";
            this.lblXeDangThue.Size = new System.Drawing.Size(24, 25);
            this.lblXeDangThue.TabIndex = 1;
            this.lblXeDangThue.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Xe đang thuê";
            // 
            // pnlLuotThue
            // 
            this.pnlLuotThue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlLuotThue.Controls.Add(this.lblLuotThue);
            this.pnlLuotThue.Controls.Add(this.label4);
            this.pnlLuotThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLuotThue.Location = new System.Drawing.Point(652, 86);
            this.pnlLuotThue.Name = "pnlLuotThue";
            this.pnlLuotThue.Size = new System.Drawing.Size(142, 122);
            this.pnlLuotThue.TabIndex = 3;
            // 
            // lblLuotThue
            // 
            this.lblLuotThue.AutoSize = true;
            this.lblLuotThue.BackColor = System.Drawing.SystemColors.Info;
            this.lblLuotThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuotThue.Location = new System.Drawing.Point(54, 66);
            this.lblLuotThue.Name = "lblLuotThue";
            this.lblLuotThue.Size = new System.Drawing.Size(24, 25);
            this.lblLuotThue.TabIndex = 1;
            this.lblLuotThue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng lượt thuê";
            // 
            // dgvThongKe
            // 
            this.dgvThongKe.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongKe.Location = new System.Drawing.Point(235, 284);
            this.dgvThongKe.Name = "dgvThongKe";
            this.dgvThongKe.RowHeadersWidth = 51;
            this.dgvThongKe.RowTemplate.Height = 24;
            this.dgvThongKe.Size = new System.Drawing.Size(726, 324);
            this.dgvThongKe.TabIndex = 6;
            // 
            // cboThang
            // 
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Location = new System.Drawing.Point(94, 166);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(121, 24);
            this.cboThang.TabIndex = 3;
            // 
            // cboXe
            // 
            this.cboXe.FormattingEnabled = true;
            this.cboXe.Location = new System.Drawing.Point(94, 133);
            this.cboXe.Name = "cboXe";
            this.cboXe.Size = new System.Drawing.Size(121, 24);
            this.cboXe.TabIndex = 4;
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(94, 211);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(100, 22);
            this.txtDoanhThu.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 423);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 606);
            this.Controls.Add(this.dgvThongKe);
            this.Controls.Add(this.pnlLuotThue);
            this.Controls.Add(this.grbChucNang);
            this.Controls.Add(this.pnlXeDangThue);
            this.Controls.Add(this.pnlDoanhThu);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongKe";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbChucNang.ResumeLayout(false);
            this.pnlDoanhThu.ResumeLayout(false);
            this.pnlDoanhThu.PerformLayout();
            this.pnlXeDangThue.ResumeLayout(false);
            this.pnlXeDangThue.PerformLayout();
            this.pnlLuotThue.ResumeLayout(false);
            this.pnlLuotThue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnLuotThue;
        private System.Windows.Forms.Button btnDoanhThu;
        private System.Windows.Forms.Panel pnlDoanhThu;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlXeDangThue;
        private System.Windows.Forms.Label lblXeDangThue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlLuotThue;
        private System.Windows.Forms.Label lblLuotThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.DataGridView dgvThongKe;
        private System.Windows.Forms.ComboBox cboXe;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDoanhThu;
    }
}

