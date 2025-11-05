namespace QuanLyKhachSan
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbmenu = new System.Windows.Forms.Label();
            this.lbBOLOCPHONG = new System.Windows.Forms.Label();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.cboLoaiPhong = new System.Windows.Forms.ComboBox();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnHuyLoc = new System.Windows.Forms.Button();
            this.lbSoDoPhong = new System.Windows.Forms.Label();
            this.flpRoomLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.cboLoaiGiuong = new System.Windows.Forms.ComboBox();
            this.lbLoaiGiuong = new System.Windows.Forms.Label();
            this.contextMenuPhong = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.itemThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.itemThemDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemChuyenPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDaDonXong = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuPhong.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(45, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 22);
            this.panel1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(228, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýPhòngToolStripMenuItem,
            this.quảnLýDịchVụToolStripMenuItem,
            this.quảnLýTàiKhoảnToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // lbmenu
            // 
            this.lbmenu.AutoSize = true;
            this.lbmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmenu.Location = new System.Drawing.Point(1, 1);
            this.lbmenu.Name = "lbmenu";
            this.lbmenu.Size = new System.Drawing.Size(53, 16);
            this.lbmenu.TabIndex = 2;
            this.lbmenu.Text = "MENU: ";
            this.lbmenu.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbBOLOCPHONG
            // 
            this.lbBOLOCPHONG.AutoSize = true;
            this.lbBOLOCPHONG.Location = new System.Drawing.Point(13, 49);
            this.lbBOLOCPHONG.Name = "lbBOLOCPHONG";
            this.lbBOLOCPHONG.Size = new System.Drawing.Size(94, 13);
            this.lbBOLOCPHONG.TabIndex = 3;
            this.lbBOLOCPHONG.Text = "BỘ LỌC PHÒNG: ";
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.AutoSize = true;
            this.lbLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiPhong.Location = new System.Drawing.Point(13, 76);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(81, 16);
            this.lbLoaiPhong.TabIndex = 4;
            this.lbLoaiPhong.Text = "Loại Phòng: ";
            // 
            // cboLoaiPhong
            // 
            this.cboLoaiPhong.FormattingEnabled = true;
            this.cboLoaiPhong.Location = new System.Drawing.Point(101, 76);
            this.cboLoaiPhong.Name = "cboLoaiPhong";
            this.cboLoaiPhong.Size = new System.Drawing.Size(103, 21);
            this.cboLoaiPhong.TabIndex = 5;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.Location = new System.Drawing.Point(301, 78);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(79, 16);
            this.lbTrangThai.TabIndex = 7;
            this.lbTrangThai.Text = "Trạng Thái: ";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(386, 78);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(101, 21);
            this.cboTrangThai.TabIndex = 8;
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(274, 112);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLoc.Size = new System.Drawing.Size(94, 30);
            this.btnLoc.TabIndex = 9;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnHuyLoc
            // 
            this.btnHuyLoc.Location = new System.Drawing.Point(450, 112);
            this.btnHuyLoc.Name = "btnHuyLoc";
            this.btnHuyLoc.Size = new System.Drawing.Size(91, 30);
            this.btnHuyLoc.TabIndex = 10;
            this.btnHuyLoc.Text = "Hủy Lọc";
            this.btnHuyLoc.UseVisualStyleBackColor = true;
            this.btnHuyLoc.Click += new System.EventHandler(this.btnHuyLoc_Click);
            // 
            // lbSoDoPhong
            // 
            this.lbSoDoPhong.AutoSize = true;
            this.lbSoDoPhong.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoDoPhong.Location = new System.Drawing.Point(341, 162);
            this.lbSoDoPhong.Name = "lbSoDoPhong";
            this.lbSoDoPhong.Size = new System.Drawing.Size(117, 19);
            this.lbSoDoPhong.TabIndex = 11;
            this.lbSoDoPhong.Text = "SƠ ĐỒ PHÒNG";
            // 
            // flpRoomLayout
            // 
            this.flpRoomLayout.Location = new System.Drawing.Point(44, 184);
            this.flpRoomLayout.Name = "flpRoomLayout";
            this.flpRoomLayout.Size = new System.Drawing.Size(721, 175);
            this.flpRoomLayout.TabIndex = 12;
            // 
            // cboLoaiGiuong
            // 
            this.cboLoaiGiuong.FormattingEnabled = true;
            this.cboLoaiGiuong.Location = new System.Drawing.Point(640, 76);
            this.cboLoaiGiuong.Name = "cboLoaiGiuong";
            this.cboLoaiGiuong.Size = new System.Drawing.Size(101, 21);
            this.cboLoaiGiuong.TabIndex = 14;
            // 
            // lbLoaiGiuong
            // 
            this.lbLoaiGiuong.AutoSize = true;
            this.lbLoaiGiuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoaiGiuong.Location = new System.Drawing.Point(549, 77);
            this.lbLoaiGiuong.Name = "lbLoaiGiuong";
            this.lbLoaiGiuong.Size = new System.Drawing.Size(85, 16);
            this.lbLoaiGiuong.TabIndex = 13;
            this.lbLoaiGiuong.Text = "Loại Giường: ";
            // 
            // contextMenuPhong
            // 
            this.contextMenuPhong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCheckIn,
            this.itemThanhToan,
            this.itemThemDichVu,
            this.itemChuyenPhong,
            this.itemDaDonXong});
            this.contextMenuPhong.Name = "contextMenuPhong";
            this.contextMenuPhong.Size = new System.Drawing.Size(193, 114);
            this.contextMenuPhong.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuPhong_Opening);
            // 
            // itemCheckIn
            // 
            this.itemCheckIn.Name = "itemCheckIn";
            this.itemCheckIn.Size = new System.Drawing.Size(192, 22);
            this.itemCheckIn.Text = "Check-in";
            this.itemCheckIn.Click += new System.EventHandler(this.itemCheckIn_Click);
            // 
            // itemThanhToan
            // 
            this.itemThanhToan.Name = "itemThanhToan";
            this.itemThanhToan.Size = new System.Drawing.Size(192, 22);
            this.itemThanhToan.Text = "Thanh toán";
            this.itemThanhToan.Click += new System.EventHandler(this.itemThanhToan_Click);
            // 
            // itemThemDichVu
            // 
            this.itemThemDichVu.Name = "itemThemDichVu";
            this.itemThemDichVu.Size = new System.Drawing.Size(192, 22);
            this.itemThemDichVu.Text = "Thêm dịch vụ";
            this.itemThemDichVu.Click += new System.EventHandler(this.itemThemDichVu_Click);
            // 
            // itemChuyenPhong
            // 
            this.itemChuyenPhong.Name = "itemChuyenPhong";
            this.itemChuyenPhong.Size = new System.Drawing.Size(192, 22);
            this.itemChuyenPhong.Text = "Chuyển phòng";
            this.itemChuyenPhong.Click += new System.EventHandler(this.itemChuyenPhong_Click);
            // 
            // itemDaDonXong
            // 
            this.itemDaDonXong.Name = "itemDaDonXong";
            this.itemDaDonXong.Size = new System.Drawing.Size(192, 22);
            this.itemDaDonXong.Text = "Xác nhận đã dọn xong";
            this.itemDaDonXong.Click += new System.EventHandler(this.itemDaDonXong_Click);
            // 
            // quảnLýPhòngToolStripMenuItem
            // 
            this.quảnLýPhòngToolStripMenuItem.Name = "quảnLýPhòngToolStripMenuItem";
            this.quảnLýPhòngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýPhòngToolStripMenuItem.Text = "Quản lý phòng";
            this.quảnLýPhòngToolStripMenuItem.Click += new System.EventHandler(this.quảnLýPhòngToolStripMenuItem_Click);
            // 
            // quảnLýDịchVụToolStripMenuItem
            // 
            this.quảnLýDịchVụToolStripMenuItem.Name = "quảnLýDịchVụToolStripMenuItem";
            this.quảnLýDịchVụToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýDịchVụToolStripMenuItem.Text = "Quản lý dịch vụ";
            this.quảnLýDịchVụToolStripMenuItem.Click += new System.EventHandler(this.quảnLýDịchVụToolStripMenuItem_Click);
            // 
            // quảnLýTàiKhoảnToolStripMenuItem
            // 
            this.quảnLýTàiKhoảnToolStripMenuItem.Name = "quảnLýTàiKhoảnToolStripMenuItem";
            this.quảnLýTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýTàiKhoảnToolStripMenuItem.Text = "Quản lý tài khoản";
            this.quảnLýTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.quảnLýTàiKhoảnToolStripMenuItem_Click);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doanhThuToolStripMenuItem.Text = "Doanh thu";
            this.doanhThuToolStripMenuItem.Click += new System.EventHandler(this.doanhThuToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboLoaiGiuong);
            this.Controls.Add(this.lbLoaiGiuong);
            this.Controls.Add(this.flpRoomLayout);
            this.Controls.Add(this.lbSoDoPhong);
            this.Controls.Add(this.btnHuyLoc);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.cboLoaiPhong);
            this.Controls.Add(this.lbLoaiPhong);
            this.Controls.Add(this.lbBOLOCPHONG);
            this.Controls.Add(this.lbmenu);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuPhong.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.Label lbmenu;
        private System.Windows.Forms.Label lbBOLOCPHONG;
        private System.Windows.Forms.Label lbLoaiPhong;
        private System.Windows.Forms.ComboBox cboLoaiPhong;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnHuyLoc;
        private System.Windows.Forms.Label lbSoDoPhong;
        private System.Windows.Forms.FlowLayoutPanel flpRoomLayout;
        private System.Windows.Forms.ComboBox cboLoaiGiuong;
        private System.Windows.Forms.Label lbLoaiGiuong;
        private System.Windows.Forms.ContextMenuStrip contextMenuPhong;
        private System.Windows.Forms.ToolStripMenuItem itemCheckIn;
        private System.Windows.Forms.ToolStripMenuItem itemThanhToan;
        private System.Windows.Forms.ToolStripMenuItem itemThemDichVu;
        private System.Windows.Forms.ToolStripMenuItem itemChuyenPhong;
        private System.Windows.Forms.ToolStripMenuItem itemDaDonXong;
        private System.Windows.Forms.ToolStripMenuItem quảnLýPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}