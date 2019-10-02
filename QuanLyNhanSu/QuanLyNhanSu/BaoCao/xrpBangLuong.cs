using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyNhanSu.BaoCao
{
    public partial class xrpBangLuong : DevExpress.XtraReports.UI.XtraReport
    {
        public xrpBangLuong()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            colHo.DataBindings.Add("Text", DataSource, "HoLot");
            colTen.DataBindings.Add("Text", DataSource, "Ten");
            colLoaiCong.DataBindings.Add("Text", DataSource, "TenLoaiCong");
            colHeSoLuong.DataBindings.Add("Text", DataSource, "HeSo");
            colSoNgayLam.DataBindings.Add("Text", DataSource, "SoNgayLam");
            colSoGioTangCa.DataBindings.Add("Text", DataSource, "SoGioLam");
            colLuong.DataBindings.Add("Text", DataSource, "Luong");
        }
    }
}
