using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using QuanLyNhanSu.Menu;
using DTO;

namespace QuanLyNhanSu.ChucVu
{
    public partial class ucChucVu : UserControl
    {
        private List<ChucVuDTO> lstChucVu = new List<ChucVuDTO>();
        public ucChucVu()
        {
            InitializeComponent();
        }

        private void UcChucVu_Load(object sender, EventArgs e)
        {
            lstChucVu = ChucVuBUL.LoadSoLuongNhanVienTungChucVu();
            dgvChucVu.DataSource = lstChucVu;
            CustomDataGridViewChucVu();
        }

        private void DgvBoPhan_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvChucVu.SelectedRows[0];
            txtMaCV.Text = dgvRow.Cells[0].Value.ToString();
            txtTenCV.Text = dgvRow.Cells[1].Value.ToString();
        }

        private void BtnTroVe_Click(object sender, EventArgs e)
        {
            XoaTatUserControl();
            ucMenuChinh ucMC = new ucMenuChinh();
            ucMC.Dock = DockStyle.Fill;
            frmMain.getFrmMain.getMetroPanelContainer.Controls.Add(ucMC);
            frmMain.getFrmMain.getMetroPanelContainer.Controls["ucMenuChinh"].BringToFront();
        }

        private void BtnThemChucVu_Click(object sender, EventArgs e)
        {
            if (txtTenCV.Text != "")
            {
                ChucVuDTO cv = new ChucVuDTO();
                cv.TenChucVu = txtTenCV.Text;
                cv = ChucVuBUL.ThemChucVu(cv);
                if(cv != null)
                {
                    lstChucVu.Add(cv);
                    ReloadDataGridView();
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Tên bộ phận không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSuaChucVu_Click(object sender, EventArgs e)
        {
            if (txtTenCV.Text != "")
            {
                ChucVuDTO cv = new ChucVuDTO();
                cv.MaChucVu = int.Parse(txtMaCV.Text);
                cv.TenChucVu = txtTenCV.Text;
                cv = ChucVuBUL.SuaChucVu(cv);
                if(cv != null)
                {
                    ChucVuDTO cvResult = lstChucVu.SingleOrDefault(i => i.MaChucVu == cv.MaChucVu);
                    cvResult.TenChucVu = cv.TenChucVu;
                    ReloadDataGridView();
                    MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bộ phận nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnXoaChucVu_Click(object sender, EventArgs e)
        {
            if (txtTenCV.Text != "")
            {
                ChucVuDTO cvDTO = new ChucVuDTO() {MaChucVu = int.Parse(txtMaCV.Text), TenChucVu = txtTenCV.Text};
                if (ChucVuBUL.XoaChucVu(cvDTO) != null)
                {
                    ChucVuDTO cv = lstChucVu.SingleOrDefault(i => i.MaChucVu == cvDTO.MaChucVu);
                    lstChucVu.Remove(cv);
                    ReloadDataGridView();
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn bộ phận nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region TOOLS
        private void CustomDataGridViewChucVu()
        {
            dgvChucVu.Columns["MaChucVu"].HeaderText = "Mã chức vụ";
            dgvChucVu.Columns["TenChucVu"].HeaderText = "Tên chức vụ";
            dgvChucVu.Columns["SoLuong"].HeaderText = "Số lượng nhân viên";
        }

        private void XoaTatUserControl()
        {
            foreach (UserControl uc in frmMain.getFrmMain.getMetroPanelContainer.Controls.OfType<UserControl>())
            {
                frmMain.getFrmMain.getMetroPanelContainer.Controls.Remove(uc);
            }
        }

        private void ReloadDataGridView()
        {
            dgvChucVu.DataSource = typeof(List<ChucVuDTO>);
            dgvChucVu.DataSource = lstChucVu;
            CustomDataGridViewChucVu();
        }
        #endregion


    }
}
