﻿namespace CTQuanLyTiecCuoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đặtTiệcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuVàThanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchTiệcCướiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpBáoCáoThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtSảnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtLoạiSảnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtCaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtMónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 343);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(885, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Italic);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đặtTiệcToolStripMenuItem,
            this.traCứuVàThanhToánToolStripMenuItem,
            this.lậpBáoCáoThángToolStripMenuItem,
            this.cậpNhậtThôngTinToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(885, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // đặtTiệcToolStripMenuItem
            // 
            this.đặtTiệcToolStripMenuItem.Name = "đặtTiệcToolStripMenuItem";
            this.đặtTiệcToolStripMenuItem.Size = new System.Drawing.Size(149, 35);
            this.đặtTiệcToolStripMenuItem.Text = "Đặt tiệc cưới";
            this.đặtTiệcToolStripMenuItem.Click += new System.EventHandler(this.đặtTiệcToolStripMenuItem_Click);
            // 
            // traCứuVàThanhToánToolStripMenuItem
            // 
            this.traCứuVàThanhToánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchTiệcCướiToolStripMenuItem,
            this.danhSáchHóaĐơnToolStripMenuItem});
            this.traCứuVàThanhToánToolStripMenuItem.Name = "traCứuVàThanhToánToolStripMenuItem";
            this.traCứuVàThanhToánToolStripMenuItem.Size = new System.Drawing.Size(243, 35);
            this.traCứuVàThanhToánToolStripMenuItem.Text = "Tra cứu và thanh toán";
            // 
            // danhSáchTiệcCướiToolStripMenuItem
            // 
            this.danhSáchTiệcCướiToolStripMenuItem.Name = "danhSáchTiệcCướiToolStripMenuItem";
            this.danhSáchTiệcCướiToolStripMenuItem.Size = new System.Drawing.Size(280, 36);
            this.danhSáchTiệcCướiToolStripMenuItem.Text = "Danh sách tiệc cưới";
            this.danhSáchTiệcCướiToolStripMenuItem.Click += new System.EventHandler(this.danhSáchTiệcCướiToolStripMenuItem_Click);
            // 
            // danhSáchHóaĐơnToolStripMenuItem
            // 
            this.danhSáchHóaĐơnToolStripMenuItem.Name = "danhSáchHóaĐơnToolStripMenuItem";
            this.danhSáchHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(280, 36);
            this.danhSáchHóaĐơnToolStripMenuItem.Text = "Danh sách hóa đơn";
            this.danhSáchHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.danhSáchHóaĐơnToolStripMenuItem_Click);
            // 
            // lậpBáoCáoThángToolStripMenuItem
            // 
            this.lậpBáoCáoThángToolStripMenuItem.Name = "lậpBáoCáoThángToolStripMenuItem";
            this.lậpBáoCáoThángToolStripMenuItem.Size = new System.Drawing.Size(143, 35);
            this.lậpBáoCáoThángToolStripMenuItem.Text = "Lập báo cáo";
            this.lậpBáoCáoThángToolStripMenuItem.Click += new System.EventHandler(this.lậpBáoCáoThángToolStripMenuItem_Click);
            // 
            // cậpNhậtThôngTinToolStripMenuItem
            // 
            this.cậpNhậtThôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtSảnhToolStripMenuItem,
            this.cậpNhậtLoạiSảnhToolStripMenuItem,
            this.cậpNhậtCaToolStripMenuItem,
            this.cậpNhậtMónĂnToolStripMenuItem,
            this.cậpNhậtDịchVụToolStripMenuItem});
            this.cậpNhậtThôngTinToolStripMenuItem.Name = "cậpNhậtThôngTinToolStripMenuItem";
            this.cậpNhậtThôngTinToolStripMenuItem.Size = new System.Drawing.Size(211, 35);
            this.cậpNhậtThôngTinToolStripMenuItem.Text = "Cập nhật thông tin";
            // 
            // cậpNhậtSảnhToolStripMenuItem
            // 
            this.cậpNhậtSảnhToolStripMenuItem.Name = "cậpNhậtSảnhToolStripMenuItem";
            this.cậpNhậtSảnhToolStripMenuItem.Size = new System.Drawing.Size(273, 36);
            this.cậpNhậtSảnhToolStripMenuItem.Text = "Cập nhật sảnh";
            this.cậpNhậtSảnhToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtSảnhToolStripMenuItem_Click);
            // 
            // cậpNhậtLoạiSảnhToolStripMenuItem
            // 
            this.cậpNhậtLoạiSảnhToolStripMenuItem.Name = "cậpNhậtLoạiSảnhToolStripMenuItem";
            this.cậpNhậtLoạiSảnhToolStripMenuItem.Size = new System.Drawing.Size(273, 36);
            this.cậpNhậtLoạiSảnhToolStripMenuItem.Text = "Cập nhật loại sảnh";
            this.cậpNhậtLoạiSảnhToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtLoạiSảnhToolStripMenuItem_Click);
            // 
            // cậpNhậtCaToolStripMenuItem
            // 
            this.cậpNhậtCaToolStripMenuItem.Name = "cậpNhậtCaToolStripMenuItem";
            this.cậpNhậtCaToolStripMenuItem.Size = new System.Drawing.Size(273, 36);
            this.cậpNhậtCaToolStripMenuItem.Text = "Cập nhật ca";
            this.cậpNhậtCaToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtCaToolStripMenuItem_Click);
            // 
            // cậpNhậtMónĂnToolStripMenuItem
            // 
            this.cậpNhậtMónĂnToolStripMenuItem.Name = "cậpNhậtMónĂnToolStripMenuItem";
            this.cậpNhậtMónĂnToolStripMenuItem.Size = new System.Drawing.Size(273, 36);
            this.cậpNhậtMónĂnToolStripMenuItem.Text = "Cập nhật món ăn";
            this.cậpNhậtMónĂnToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtMónĂnToolStripMenuItem_Click);
            // 
            // cậpNhậtDịchVụToolStripMenuItem
            // 
            this.cậpNhậtDịchVụToolStripMenuItem.Name = "cậpNhậtDịchVụToolStripMenuItem";
            this.cậpNhậtDịchVụToolStripMenuItem.Size = new System.Drawing.Size(273, 36);
            this.cậpNhậtDịchVụToolStripMenuItem.Text = "Cập nhật dịch vụ";
            this.cậpNhậtDịchVụToolStripMenuItem.Click += new System.EventHandler(this.cậpNhậtDịchVụToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(200, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "NHÀ HÀNG TIỆC CƯỚI XIN CHÀO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinTàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 35);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(280, 36);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(280, 36);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(885, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Quản lý tiệc cưới";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đặtTiệcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuVàThanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchTiệcCướiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpBáoCáoThángToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtThôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtSảnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtLoạiSảnhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtCaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtMónĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtDịchVụToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}