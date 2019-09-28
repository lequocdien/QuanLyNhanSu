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

namespace QuanLyNhanSu.BoPhan
{
    public partial class ucBoPhan : UserControl
    {
        private List<BoPhanDTO> lstBoPhan = new List<BoPhanDTO>();
        public ucBoPhan()
        {
            InitializeComponent();
        }

        private void UcBoPhan_Load(object sender, EventArgs e)
        {
            lstBoPhan = BoPhanBUL.LoadSoLuongNhanVienTungBoPhan();
            dgvBoPhan.DataSource = lstBoPhan;
            CustomDataGridViewBoPhan();
        }

        private void DgvBoPhan_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvBoPhan.SelectedRows[0];
            txtMaBoPhan.Text = dgvRow.Cells[0].Value.ToString();
            txtTenBoPhan.Text = dgvRow.Cells[1].Value.ToString();
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

        private void BtnThemBoPhan_Click(object sender, EventArgs e)
        {
            if(txtTenBoPhan.Text != "")
            {
                BoPhanDTO bp = new BoPhanDTO();
                bp.TenBP = txtTenBoPhan.Text;
                bp = BoPhanBUL.ThemBoPhan(bp);
                if (bp != null)
                {
                    lstBoPhan.Add(bp);
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
                MessageBox.Show("Bạn chưa chọn bộ phận nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void BtnSuaBoPhan_Click(object sender, EventArgs e)
        {
            if(txtMaBoPhan.Text != "")
            {
                BoPhanDTO bp = new BoPhanDTO();
                bp.MaBP = int.Parse(txtMaBoPhan.Text);
                bp.TenBP = txtTenBoPhan.Text;
                bp = BoPhanBUL.SuaBoPhan(bp);
                if(bp != null)
                {
                    BoPhanDTO boPhan = lstBoPhan.SingleOrDefault(i => i.MaBP == bp.MaBP);
                    boPhan.TenBP = bp.TenBP;
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

        private void BtnXoaBoPhan_Click(object sender, EventArgs e)
        {
            if (txtMaBoPhan.Text != "")
            {
                if (BoPhanBUL.XoaBoPhan(int.Parse(txtMaBoPhan.Text)) == true)
                {
                    BoPhanDTO bp = lstBoPhan.SingleOrDefault(i => i.MaBP == int.Parse(txtMaBoPhan.Text));
                    lstBoPhan.Remove(bp);
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
        private void CustomDataGridViewBoPhan()
        {
            dgvBoPhan.Columns["MaBP"].HeaderText = "Mã bộ phận";
            dgvBoPhan.Columns["TenBP"].HeaderText = "Tên bộ phận";
            dgvBoPhan.Columns["SoLuong"].HeaderText = "Số lượng nhân viên";
        }

        private void ReloadDataGridView()
        {
            dgvBoPhan.DataSource = typeof(List<BoPhanDTO>);
            dgvBoPhan.DataSource = lstBoPhan;
            CustomDataGridViewBoPhan();
        }
        #endregion


    }
}
