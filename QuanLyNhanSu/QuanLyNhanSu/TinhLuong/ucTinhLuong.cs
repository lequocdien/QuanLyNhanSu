using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BUL;
using DevExpress.XtraReports.UI;
using DTO;
using EF;
using QuanLyNhanSu.BaoCao;
using QuanLyNhanSu.Menu;

namespace QuanLyNhanSu.TinhLuong
{
    public partial class ucTinhLuong : UserControl
    {
        List<TinhLuongDTO> lstTinhLuong = new List<TinhLuongDTO>();
        public ucTinhLuong()
        {
            InitializeComponent();
        }

        private void BtnTroVe_Click(object sender, EventArgs e)
        {
            foreach (UserControl uc in frmMain.getFrmMain.getMetroPanelContainer.Controls.OfType<UserControl>())
            {
                frmMain.getFrmMain.getMetroPanelContainer.Controls.Remove(uc);
            }
            ucMenuChinh ucMC = new ucMenuChinh();
            ucMC.Dock = DockStyle.Fill;
            frmMain.getFrmMain.getMetroPanelContainer.Controls.Add(ucMC);
            frmMain.getFrmMain.getMetroPanelContainer.Controls["ucMenuChinh"].BringToFront();
        }

        private void UcTinhLuong_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            lstTinhLuong = TinhLuongBUL.TinhLuongTatCaNhanVien(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year, Convert.ToDouble(txtLuongCoBan.Text), Convert.ToDouble(txtLuongTangCa.Text));
            ReloadDataGridView();
        }

        private void BtnTinhLuong_Click(object sender, EventArgs e)
        {
            lstTinhLuong = TinhLuongBUL.TinhLuongTatCaNhanVien(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year, Convert.ToDouble(txtLuongCoBan.Text), Convert.ToDouble(txtLuongTangCa.Text));
            ReloadDataGridView();
        }

        private void BtnXuatBaoCao_Click(object sender, EventArgs e)
        {
            xrpBangLuong rpt = new xrpBangLuong();
            rpt.lblThang.Text = dateTimePicker1.Value.Month.ToString();
            rpt.lblNam.Text = dateTimePicker1.Value.Year.ToString();
            rpt.DataSource = TinhLuongBUL.TinhLuongTatCaNhanVien(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year, double.Parse(txtLuongCoBan.Text), double.Parse(txtLuongTangCa.Text));
            rpt.BindData();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        #region TOOLS
        private void CustomDataGridViewTinhLuong()
        {
            dgvTinhLuong.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvTinhLuong.Columns["HoLot"].HeaderText = "Họ";
            dgvTinhLuong.Columns["Ten"].HeaderText = "Tên";
            dgvTinhLuong.Columns["TenLoaiCong"].HeaderText = "Tên loại công";
            dgvTinhLuong.Columns["HeSo"].HeaderText = "Hệ số lương";
            dgvTinhLuong.Columns["SoNgayLam"].HeaderText = "Số ngày làm";
            dgvTinhLuong.Columns["SoGioLam"].HeaderText = "Số giờ tăng ca";
            dgvTinhLuong.Columns["Luong"].HeaderText = "Lương";
            dgvTinhLuong.Columns["Luong"].DefaultCellStyle.Format = "C0";
        }
        private void ReloadDataGridView()
        {
            dgvTinhLuong.DataSource = typeof(List<TinhLuongDTO>);
            dgvTinhLuong.DataSource = lstTinhLuong;
            CustomDataGridViewTinhLuong();
        }

        #endregion

        
    }
}
