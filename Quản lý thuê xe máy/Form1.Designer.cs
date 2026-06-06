namespace Quản_lý_thuê_xe_máy
{
    partial class frmChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChinh));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnBaoTri = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblNN = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnThueXe = new System.Windows.Forms.Button();
            this.lblHang = new System.Windows.Forms.Label();
            this.btnXeMay = new System.Windows.Forms.Button();
            this.btnTrangChu = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.pnlTittle = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlNoiDung = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu.SuspendLayout();
            this.pnlUser.SuspendLayout();
            this.pnlTittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(171)))), ((int)(((byte)(227)))));
            this.pnlMenu.Controls.Add(this.btnTaiKhoan);
            this.pnlMenu.Controls.Add(this.btnHoaDon);
            this.pnlMenu.Controls.Add(this.btnDangXuat);
            this.pnlMenu.Controls.Add(this.label4);
            this.pnlMenu.Controls.Add(this.btnThongKe);
            this.pnlMenu.Controls.Add(this.pictureBox2);
            this.pnlMenu.Controls.Add(this.btnBaoTri);
            this.pnlMenu.Controls.Add(this.pnlUser);
            this.pnlMenu.Controls.Add(this.btnThueXe);
            this.pnlMenu.Controls.Add(this.lblHang);
            this.pnlMenu.Controls.Add(this.btnXeMay);
            this.pnlMenu.Controls.Add(this.btnTrangChu);
            this.pnlMenu.Controls.Add(this.btnKhachHang);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(233, 755);
            this.pnlMenu.TabIndex = 0;
            this.pnlMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMenu_Paint);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(107)))));
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTaiKhoan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTaiKhoan.Location = new System.Drawing.Point(10, 502);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Size = new System.Drawing.Size(200, 50);
            this.btnTaiKhoan.TabIndex = 11;
            this.btnTaiKhoan.Text = "⚙ Tài khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(107)))));
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHoaDon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHoaDon.Location = new System.Drawing.Point(10, 390);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(200, 50);
            this.btnHoaDon.TabIndex = 10;
            this.btnHoaDon.Text = "💰 In hóa đơn";
            this.btnHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Red;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangXuat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDangXuat.Location = new System.Drawing.Point(55, 710);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(94, 23);
            this.btnDangXuat.TabIndex = 9;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(87, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hệ thống quản lý";
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(107)))));
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThongKe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThongKe.Location = new System.Drawing.Point(10, 446);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(200, 50);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "📊 Thống kê doanh thu";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnBaoTri
            // 
            this.btnBaoTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(107)))));
            this.btnBaoTri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaoTri.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBaoTri.Location = new System.Drawing.Point(10, 339);
            this.btnBaoTri.Name = "btnBaoTri";
            this.btnBaoTri.Size = new System.Drawing.Size(200, 45);
            this.btnBaoTri.TabIndex = 7;
            this.btnBaoTri.Text = "🔧 Bảo trì";
            this.btnBaoTri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoTri.UseVisualStyleBackColor = false;
            this.btnBaoTri.Click += new System.EventHandler(this.btnBaoTri_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblNN);
            this.pnlUser.Controls.Add(this.pictureBox1);
            this.pnlUser.Controls.Add(this.lblName);
            this.pnlUser.Location = new System.Drawing.Point(19, 598);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(182, 100);
            this.pnlUser.TabIndex = 0;
            // 
            // lblNN
            // 
            this.lblNN.AutoSize = true;
            this.lblNN.ForeColor = System.Drawing.Color.Blue;
            this.lblNN.Location = new System.Drawing.Point(89, 58);
            this.lblNN.Name = "lblNN";
            this.lblNN.Size = new System.Drawing.Size(80, 16);
            this.lblNN.TabIndex = 2;
            this.lblNN.Text = "Quản trị viên";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(79, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nguyễn Văn An";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // btnThueXe
            // 
            this.btnThueXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(107)))));
            this.btnThueXe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThueXe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThueXe.Location = new System.Drawing.Point(10, 285);
            this.btnThueXe.Name = "btnThueXe";
            this.btnThueXe.Size = new System.Drawing.Size(200, 48);
            this.btnThueXe.TabIndex = 6;
            this.btnThueXe.Text = "📝 Thuê xe";
            this.btnThueXe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThueXe.UseVisualStyleBackColor = false;
            this.btnThueXe.Click += new System.EventHandler(this.btnThueXe_Click);
            // 
            // lblHang
            // 
            this.lblHang.AutoSize = true;
            this.lblHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblHang.Location = new System.Drawing.Point(101, 43);
            this.lblHang.Name = "lblHang";
            this.lblHang.Size = new System.Drawing.Size(87, 16);
            this.lblHang.TabIndex = 0;
            this.lblHang.Text = "Lucky Stars";
            this.lblHang.Click += new System.EventHandler(this.lblHang_Click);
            // 
            // btnXeMay
            // 
            this.btnXeMay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(107)))));
            this.btnXeMay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXeMay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXeMay.Location = new System.Drawing.Point(10, 229);
            this.btnXeMay.Name = "btnXeMay";
            this.btnXeMay.Size = new System.Drawing.Size(200, 50);
            this.btnXeMay.TabIndex = 5;
            this.btnXeMay.Text = "🚲 Quản lý xe máy";
            this.btnXeMay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXeMay.UseVisualStyleBackColor = false;
            this.btnXeMay.Click += new System.EventHandler(this.btnXeMay_Click);
            // 
            // btnTrangChu
            // 
            this.btnTrangChu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(107)))));
            this.btnTrangChu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTrangChu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTrangChu.Location = new System.Drawing.Point(10, 123);
            this.btnTrangChu.Name = "btnTrangChu";
            this.btnTrangChu.Size = new System.Drawing.Size(200, 47);
            this.btnTrangChu.TabIndex = 3;
            this.btnTrangChu.Text = "🏠 Trang chủ";
            this.btnTrangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangChu.UseVisualStyleBackColor = false;
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(107)))));
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKhachHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKhachHang.Location = new System.Drawing.Point(10, 176);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(200, 47);
            this.btnKhachHang.TabIndex = 4;
            this.btnKhachHang.Text = "👤 Quản lý khách hàng";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // pnlTittle
            // 
            this.pnlTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlTittle.Controls.Add(this.lblDateTime);
            this.pnlTittle.Controls.Add(this.label5);
            this.pnlTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTittle.Location = new System.Drawing.Point(233, 0);
            this.pnlTittle.Name = "pnlTittle";
            this.pnlTittle.Size = new System.Drawing.Size(950, 156);
            this.pnlTittle.TabIndex = 1;
            this.pnlTittle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTittle_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(446, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "HỆ THỐNG QUẢN LÝ THUÊ XE MÁY";
            // 
            // pnlNoiDung
            // 
            this.pnlNoiDung.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoiDung.Location = new System.Drawing.Point(233, 156);
            this.pnlNoiDung.Name = "pnlNoiDung";
            this.pnlNoiDung.Size = new System.Drawing.Size(950, 599);
            this.pnlNoiDung.TabIndex = 2;
            this.pnlNoiDung.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNoiDung_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Quản_lý_thuê_xe_máy.Properties.Resources.xemay_ic_removebg_preview;
            this.pictureBox2.Location = new System.Drawing.Point(3, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDateTime.Location = new System.Drawing.Point(64, 106);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(53, 20);
            this.lblDateTime.TabIndex = 5;
            this.lblDateTime.Text = "label1";
            this.lblDateTime.Click += new System.EventHandler(this.lblDateTime_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 755);
            this.Controls.Add(this.pnlNoiDung);
            this.Controls.Add(this.pnlTittle);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChinh";
            this.Text = "Quản lý thuê xe máy";
            this.Load += new System.EventHandler(this.frmChinh_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnlTittle.ResumeLayout(false);
            this.pnlTittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTittle;
        private System.Windows.Forms.Panel pnlNoiDung;
        private System.Windows.Forms.Label lblHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNN;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnBaoTri;
        private System.Windows.Forms.Button btnThueXe;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnTrangChu;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnXeMay;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timer1;
    }
}

