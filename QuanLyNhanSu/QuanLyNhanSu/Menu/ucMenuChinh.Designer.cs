namespace QuanLyNhanSu.Menu
{
    partial class ucMenuChinh
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
            this.timerManHinhChinh = new System.Windows.Forms.Timer(this.components);
            this.btnTrinhDo = new MetroFramework.Controls.MetroTile();
            this.btnTinhLuong = new MetroFramework.Controls.MetroTile();
            this.btnThuong = new MetroFramework.Controls.MetroTile();
            this.btnChucVu = new MetroFramework.Controls.MetroTile();
            this.btnBaoCao = new MetroFramework.Controls.MetroTile();
            this.btnNhanVien = new MetroFramework.Controls.MetroTile();
            this.btnBoPhan = new MetroFramework.Controls.MetroTile();
            this.btnChamCong = new MetroFramework.Controls.MetroTile();
            this.btnHeThong = new MetroFramework.Controls.MetroTile();
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1395, 818);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mpnManHinhChinh
            // 
            this.mpnManHinhChinh.BackColor = System.Drawing.Color.White;
            this.mpnManHinhChinh.Controls.Add(this.mpnContainer);
            this.mpnManHinhChinh.CustomBackground = true;
            this.mpnManHinhChinh.HorizontalScrollbarBarColor = true;
            this.mpnManHinhChinh.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnManHinhChinh.HorizontalScrollbarSize = 12;
            this.mpnManHinhChinh.Location = new System.Drawing.Point(164, 40);
            this.mpnManHinhChinh.Margin = new System.Windows.Forms.Padding(4);
            this.mpnManHinhChinh.Name = "mpnManHinhChinh";
            this.mpnManHinhChinh.Size = new System.Drawing.Size(1067, 738);
            this.mpnManHinhChinh.TabIndex = 0;
            this.mpnManHinhChinh.VerticalScrollbarBarColor = true;
            this.mpnManHinhChinh.VerticalScrollbarHighlightOnWheel = false;
            this.mpnManHinhChinh.VerticalScrollbarSize = 13;
            // 
            // mpnContainer
            // 
            this.mpnContainer.Controls.Add(this.btnTrinhDo);
            this.mpnContainer.Controls.Add(this.btnTinhLuong);
            this.mpnContainer.Controls.Add(this.btnThuong);
            this.mpnContainer.Controls.Add(this.btnChucVu);
            this.mpnContainer.Controls.Add(this.btnBaoCao);
            this.mpnContainer.Controls.Add(this.btnNhanVien);
            this.mpnContainer.Controls.Add(this.btnBoPhan);
            this.mpnContainer.Controls.Add(this.btnChamCong);
            this.mpnContainer.Controls.Add(this.btnHeThong);
            this.mpnContainer.HorizontalScrollbarBarColor = true;
            this.mpnContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.mpnContainer.HorizontalScrollbarSize = 12;
            this.mpnContainer.Location = new System.Drawing.Point(24, 21);
            this.mpnContainer.Margin = new System.Windows.Forms.Padding(4);
            this.mpnContainer.Name = "mpnContainer";
            this.mpnContainer.Size = new System.Drawing.Size(1021, 687);
            this.mpnContainer.TabIndex = 2;
            this.mpnContainer.VerticalScrollbarBarColor = true;
            this.mpnContainer.VerticalScrollbarHighlightOnWheel = false;
            this.mpnContainer.VerticalScrollbarSize = 13;
            // 
            // timerManHinhChinh
            // 
            this.timerManHinhChinh.Interval = 10;
            this.timerManHinhChinh.Tick += new System.EventHandler(this.timerManHinhChinh_Tick);
            // 
            // btnTrinhDo
            // 
            this.btnTrinhDo.Location = new System.Drawing.Point(272, 249);
            this.btnTrinhDo.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrinhDo.Name = "btnTrinhDo";
            this.btnTrinhDo.Size = new System.Drawing.Size(200, 185);
            this.btnTrinhDo.TabIndex = 3;
            this.btnTrinhDo.Text = "Trình độ";
            this.btnTrinhDo.TileImage = global::QuanLyNhanSu.Properties.Resources.PhuCap;
            this.btnTrinhDo.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTrinhDo.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnTrinhDo.UseTileImage = true;
            // 
            // btnTinhLuong
            // 
            this.btnTinhLuong.Location = new System.Drawing.Point(551, 460);
            this.btnTinhLuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnTinhLuong.Name = "btnTinhLuong";
            this.btnTinhLuong.Size = new System.Drawing.Size(429, 185);
            this.btnTinhLuong.TabIndex = 4;
            this.btnTinhLuong.Text = "Tính lương";
            this.btnTinhLuong.TileImage = global::QuanLyNhanSu.Properties.Resources.DanhMuc;
            this.btnTinhLuong.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTinhLuong.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnTinhLuong.UseTileImage = true;
            this.btnTinhLuong.Click += new System.EventHandler(this.button_Click);
            // 
            // btnThuong
            // 
            this.btnThuong.Location = new System.Drawing.Point(780, 249);
            this.btnThuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnThuong.Name = "btnThuong";
            this.btnThuong.Size = new System.Drawing.Size(200, 188);
            this.btnThuong.TabIndex = 5;
            this.btnThuong.Text = "Thưởng";
            this.btnThuong.TileImage = global::QuanLyNhanSu.Properties.Resources.TangCa;
            this.btnThuong.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThuong.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnThuong.UseTileImage = true;
            // 
            // btnChucVu
            // 
            this.btnChucVu.Location = new System.Drawing.Point(43, 249);
            this.btnChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.btnChucVu.Name = "btnChucVu";
            this.btnChucVu.Size = new System.Drawing.Size(200, 185);
            this.btnChucVu.TabIndex = 6;
            this.btnChucVu.Text = "Chức vụ";
            this.btnChucVu.TileImage = global::QuanLyNhanSu.Properties.Resources.HopDong;
            this.btnChucVu.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChucVu.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnChucVu.UseTileImage = true;
            this.btnChucVu.Click += new System.EventHandler(this.button_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(780, 41);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(200, 185);
            this.btnBaoCao.TabIndex = 7;
            this.btnBaoCao.Text = "Phụ cấp";
            this.btnBaoCao.TileImage = global::QuanLyNhanSu.Properties.Resources.BaoCaoTK;
            this.btnBaoCao.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBaoCao.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnBaoCao.UseTileImage = true;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(43, 460);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(429, 185);
            this.btnNhanVien.TabIndex = 8;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.TileImage = global::QuanLyNhanSu.Properties.Resources.NhanVien;
            this.btnNhanVien.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNhanVien.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnNhanVien.UseTileImage = true;
            this.btnNhanVien.Click += new System.EventHandler(this.button_Click);
            // 
            // btnBoPhan
            // 
            this.btnBoPhan.Location = new System.Drawing.Point(272, 41);
            this.btnBoPhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnBoPhan.Name = "btnBoPhan";
            this.btnBoPhan.Size = new System.Drawing.Size(200, 185);
            this.btnBoPhan.TabIndex = 9;
            this.btnBoPhan.Text = "Bộ phận";
            this.btnBoPhan.TileImage = global::QuanLyNhanSu.Properties.Resources.Luong;
            this.btnBoPhan.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBoPhan.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnBoPhan.UseTileImage = true;
            this.btnBoPhan.Click += new System.EventHandler(this.button_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.Location = new System.Drawing.Point(551, 41);
            this.btnChamCong.Margin = new System.Windows.Forms.Padding(4);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(200, 396);
            this.btnChamCong.TabIndex = 10;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.TileImage = global::QuanLyNhanSu.Properties.Resources.ChamCong;
            this.btnChamCong.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnChamCong.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnChamCong.UseTileImage = true;
            this.btnChamCong.Click += new System.EventHandler(this.button_Click);
            // 
            // btnHeThong
            // 
            this.btnHeThong.Location = new System.Drawing.Point(43, 41);
            this.btnHeThong.Margin = new System.Windows.Forms.Padding(4);
            this.btnHeThong.Name = "btnHeThong";
            this.btnHeThong.Size = new System.Drawing.Size(200, 185);
            this.btnHeThong.TabIndex = 11;
            this.btnHeThong.Text = "Hệ thống";
            this.btnHeThong.TileImage = global::QuanLyNhanSu.Properties.Resources.HeThong;
            this.btnHeThong.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHeThong.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnHeThong.UseTileImage = true;
            // 
            // ucMenuChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucMenuChinh";
            this.Size = new System.Drawing.Size(1395, 818);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.mpnManHinhChinh.ResumeLayout(false);
            this.mpnContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel mpnManHinhChinh;
        private MetroFramework.Controls.MetroPanel mpnContainer;
        private MetroFramework.Controls.MetroTile btnTrinhDo;
        private MetroFramework.Controls.MetroTile btnThuong;
        private MetroFramework.Controls.MetroTile btnChucVu;
        private MetroFramework.Controls.MetroTile btnBaoCao;
        private MetroFramework.Controls.MetroTile btnNhanVien;
        private MetroFramework.Controls.MetroTile btnBoPhan;
        private MetroFramework.Controls.MetroTile btnChamCong;
        private MetroFramework.Controls.MetroTile btnHeThong;
        private System.Windows.Forms.Timer timerManHinhChinh;
        private MetroFramework.Controls.MetroTile btnTinhLuong;
    }
}
