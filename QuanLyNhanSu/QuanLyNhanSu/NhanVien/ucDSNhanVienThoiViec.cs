using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUL;

namespace QuanLyNhanSu.NhanVien
{
    public partial class ucDSNhanVienThoiViec : UserControl
    {
        private List<NhanVienDTO> lstNhanVienDaThoiViec = new List<NhanVienDTO>();
        public ucDSNhanVienThoiViec()
        {
            InitializeComponent();
        }

        private void UcDSNhanVienThoiViec_Load(object sender, EventArgs e)
        {
            lstNhanVienDaThoiViec = NhanVienBUL.LoadNhanVienDaThoiViec();
            ReloadDataGridView();
        }

        #region TOOLS
        private void CustomDataGridViewNhanVien()
        {
            dgvDSNhanVienThoiViec.Columns["HoLot"].HeaderText = "Họ";
            dgvDSNhanVienThoiViec.Columns["Ten"].HeaderText = "Tên";
            dgvDSNhanVienThoiViec.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvDSNhanVienThoiViec.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvDSNhanVienThoiViec.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dgvDSNhanVienThoiViec.Columns["DienThoai"].HeaderText = "Điện thoại";
            dgvDSNhanVienThoiViec.Columns["TenBP"].HeaderText = "Bộ phận";
            dgvDSNhanVienThoiViec.Columns["TenChucVu"].HeaderText = "Chức vụ";
            dgvDSNhanVienThoiViec.Columns["DaThoiViec"].Visible = false;
            dgvDSNhanVienThoiViec.Columns["MaNV"].Visible = false;
            dgvDSNhanVienThoiViec.Columns["HinhAnh"].Visible = false;
            dgvDSNhanVienThoiViec.Columns["MaBP"].Visible = false;
            dgvDSNhanVienThoiViec.Columns["MaChucVu"].Visible = false;
        }

        private void ReloadDataGridView()
        {
            dgvDSNhanVienThoiViec.DataSource = typeof(List<NhanVienDTO>);
            dgvDSNhanVienThoiViec.DataSource = lstNhanVienDaThoiViec;
            CustomDataGridViewNhanVien();
        }
        #endregion
    }
}
