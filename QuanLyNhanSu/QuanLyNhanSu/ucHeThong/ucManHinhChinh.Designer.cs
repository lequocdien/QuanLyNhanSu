namespace QuanLyNhanSu.ucHeThong
{
    partial class ucManHinhChinh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mpnManHinhChinh = new MetroFramework.Controls.MetroPanel();
            this.mpnContainer = new MetroFramework.Controls.MetroPanel();
            this.btnPhuCap = new MetroFramework.Controls.MetroTile();
            this.btnDanhMuc = new MetroFramework.Controls.MetroTile();
            this.btnTangCa = new MetroFramework.Controls.MetroTile();
            this.btnHopDong = new MetroFramework.Controls.MetroTile();
            this.btnBaoCao = new MetroFramework.Controls.MetroTile();
            this.btnNhanVien = new MetroFramework.Controls.MetroTile();
            this.btnQuanLyLuong = new MetroFramework.Controls.MetroTile();
            this.btnChamCong = new MetroFramework.Controls.MetroTile();
            this.btnHeThong = new MetroFramework.Controls.MetroTile();
            this.timerManHinhChinh = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.mpnManHinhChinh.SuspendLayout();
            this.mpnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mpnManHinhChinh, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1046, 665);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mpnManHinhChinh
            // 
            this.mpnManHinhChinh.Controls.Add(this.mpnContainer);
            this.mpnManHinhChinh.HorizontalScrollbarBarColor = true;
            this.mpnManHinhChinh.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnManHinhChinh.HorizontalScrollbarSize = 10;
            this.mpnManHinhChinh.Location = new System.Drawing.Point(123, 32);
            this.mpnManHinhChinh.Name = "mpnManHinhChinh";
            this.mpnManHinhChinh.Size = new System.Drawing.Size(800, 600);
            this.mpnManHinhChinh.TabIndex = 0;
            this.mpnManHinhChinh.VerticalScrollbarBarColor = true;
            this.mpnManHinhChinh.VerticalScrollbarHighlightOnWheel = false;
            this.mpnManHinhChinh.VerticalScrollbarSize = 10;
            // 
            // mpnContainer
            // 
            this.mpnContainer.Controls.Add(this.btnPhuCap);
            this.mpnContainer.Controls.Add(this.btnDanhMuc);
            this.mpnContainer.Controls.Add(this.btnTangCa);
            this.mpnContainer.Controls.Add(this.btnHopDong);
            this.mpnContainer.Controls.Add(this.btnBaoCao);
            this.mpnContainer.Controls.Add(this.btnNhanVien);
            this.mpnContainer.Controls.Add(this.btnQuanLyLuong);
            this.mpnContainer.Controls.Add(this.btnChamCong);
            this.mpnContainer.Controls.Add(this.btnHeThong);
            this.mpnContainer.HorizontalScrollbarBarColor = true;
            this.mpnContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnContainer.HorizontalScrollbarSize = 10;
            this.mpnContainer.Location = new System.Drawing.Point(18, 17);
            this.mpnContainer.Name = "mpnContainer";
            this.mpnContainer.Size = new System.Drawing.Size(766, 558);
            this.mpnContainer.TabIndex = 2;
            this.mpnContainer.VerticalScrollbarBarColor = true;
            this.mpnContainer.VerticalScrollbarHighlightOnWheel = false;
            this.mpnContainer.VerticalScrollbarSize = 10;
            // 
            // btnPhuCap
            // 
            this.btnPhuCap.Location = new System.Drawing.Point(413, 376);
            this.btnPhuCap.Name = "btnPhuCap";
            this.btnPhuCap.Size = new System.Drawing.Size(322, 150);
            this.btnPhuCap.TabIndex = 3;
            this.btnPhuCap.Text = "Phụ cấp";
            this.btnPhuCap.TileImage = global::QuanLyNhanSu.Properties.Resources.PhuCap;
            this.btnPhuCap.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPhuCap.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnPhuCap.UseTileImage = true;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Location = new System.Drawing.Point(32, 376);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(322, 150);
            this.btnDanhMuc.TabIndex = 4;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.TileImage = global::QuanLyNhanSu.Properties.Resources.DanhMuc;
            this.btnDanhMuc.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDanhMuc.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnDanhMuc.UseTileImage = true;
            // 
            // btnTangCa
            // 
            this.btnTangCa.Location = new System.Drawing.Point(585, 205);
            this.btnTangCa.Name = "btnTangCa";
            this.btnTangCa.Size = new System.Drawing.Size(150, 150);
            this.btnTangCa.TabIndex = 5;
            this.btnTangCa.Text = "Tăng ca";
            this.btnTangCa.TileImage = global::QuanLyNhanSu.Properties.Resources.TangCa;
            this.btnTangCa.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTangCa.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnTangCa.UseTileImage = true;
            // 
            // btnHopDong
            // 
            this.btnHopDong.Location = new System.Drawing.Point(204, 205);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Size = new System.Drawing.Size(150, 150);
            this.btnHopDong.TabIndex = 6;
            this.btnHopDong.Text = "Hợp đồng";
            this.btnHopDong.TileImage = global::QuanLyNhanSu.Properties.Resources.HopDong;
            this.btnHopDong.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHopDong.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnHopDong.UseTileImage = true;
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(585, 33);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(150, 150);
            this.btnBaoCao.TabIndex = 7;
            this.btnBaoCao.Text = "Báo cáo";
            this.btnBaoCao.TileImage = global::QuanLyNhanSu.Properties.Resources.BaoCaoTK;
            this.btnBaoCao.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBaoCao.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnBaoCao.UseTileImage = true;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(204, 33);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(150, 150);
            this.btnNhanVien.TabIndex = 8;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TileImage = global::QuanLyNhanSu.Properties.Resources.NhanVien;
            this.btnNhanVien.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhanVien.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnNhanVien.UseTileImage = true;
            this.btnNhanVien.Click += new System.EventHandler(this.button_Click);
            // 
            // btnQuanLyLuong
            // 
            this.btnQuanLyLuong.Location = new System.Drawing.Point(32, 205);
            this.btnQuanLyLuong.Name = "btnQuanLyLuong";
            this.btnQuanLyLuong.Size = new System.Drawing.Size(150, 150);
            this.btnQuanLyLuong.TabIndex = 9;
            this.btnQuanLyLuong.Text = "Quản lý lương";
            this.btnQuanLyLuong.TileImage = global::QuanLyNhanSu.Properties.Resources.Luong;
            this.btnQuanLyLuong.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnQuanLyLuong.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnQuanLyLuong.UseTileImage = true;
            // 
            // btnChamCong
            // 
            this.btnChamCong.Location = new System.Drawing.Point(413, 33);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(150, 322);
            this.btnChamCong.TabIndex = 10;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.TileImage = global::QuanLyNhanSu.Properties.Resources.ChamCong;
            this.btnChamCong.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChamCong.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnChamCong.UseTileImage = true;
            // 
            // btnHeThong
            // 
            this.btnHeThong.Location = new System.Drawing.Point(32, 33);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(150, 150);
            this.btnHeThong.TabIndex = 11;
            this.btnHeThong.Text = "Hệ thống";
            this.btnHeThong.TileImage = global::QuanLyNhanSu.Properties.Resources.HeThong;
            this.btnHeThong.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHeThong.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnHeThong.UseTileImage = true;
            // 
            // timerManHinhChinh
            // 
            this.timerManHinhChinh.Interval = 10;
            this.timerManHinhChinh.Tick += new System.EventHandler(this.timerManHinhChinh_Tick);
            // 
            // ucManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucManHinhChinh";
            this.Size = new System.Drawing.Size(1046, 665);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mpnManHinhChinh.ResumeLayout(false);
            this.mpnContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel mpnManHinhChinh;
        private MetroFramework.Controls.MetroPanel mpnContainer;
        private MetroFramework.Controls.MetroTile btnPhuCap;
        private MetroFramework.Controls.MetroTile btnDanhMuc;
        private MetroFramework.Controls.MetroTile btnTangCa;
        private MetroFramework.Controls.MetroTile btnHopDong;
        private MetroFramework.Controls.MetroTile btnBaoCao;
        private MetroFramework.Controls.MetroTile btnNhanVien;
        private MetroFramework.Controls.MetroTile btnQuanLyLuong;
        private MetroFramework.Controls.MetroTile btnChamCong;
        private MetroFramework.Controls.MetroTile btnHeThong;
        private System.Windows.Forms.Timer timerManHinhChinh;
    }
}
