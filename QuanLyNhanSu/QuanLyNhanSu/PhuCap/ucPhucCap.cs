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

namespace QuanLyNhanSu.PhuCap
{
    public partial class ucPhuCap : UserControl
    {
        private List<BoPhanDTO> lstBoPhan = new List<BoPhanDTO>();
        public ucPhuCap()
        {
            InitializeComponent();
        }

        private void UcBoPhan_Load(object sender, EventArgs e)
        {
            lstBoPhan = BoPhanBUL.LoadSoLuongNhanVienTungBoPhan();
            dgvPhuCap.DataSource = lstBoPhan;
            CustomDataGridViewBoPhan();
        }

        private void DgvBoPhan_Click(object sender, EventArgs e)
        {
            DataGridViewRow dgvRow = dgvPhuCap.SelectedRows[0];
            txtMaPhuCap.Text = dgvRow.Cells[0].Value.ToString();
            txtTenPhuCap.Text = dgvRow.Cells[1].Value.ToString();
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
            if(txtTenPhuCap.Text != "")
            {
                BoPhanDTO bp = new BoPhanDTO();
                bp.TenBP = txtTenPhuCap.Text;
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
            if(txtMaPhuCap.Text != "")
            {
                BoPhanDTO bp = new BoPhanDTO();
                bp.MaBP = int.Parse(txtMaPhuCap.Text);
                bp.TenBP = txtTenPhuCap.Text;
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
            if (txtMaPhuCap.Text != "")
            {
                if (BoPhanBUL.XoaBoPhan(int.Parse(txtMaPhuCap.Text)) == true)
                {
                    BoPhanDTO bp = lstBoPhan.SingleOrDefault(i => i.MaBP == int.Parse(txtMaPhuCap.Text));
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
            dgvPhuCap.Columns["MaBP"].HeaderText = "Mã bộ phận";
            dgvPhuCap.Columns["TenBP"].HeaderText = "Tên bộ phận";
            dgvPhuCap.Columns["SoLuong"].HeaderText = "Số lượng nhân viên";
        }

        private void ReloadDataGridView()
        {
            dgvPhuCap.DataSource = typeof(List<BoPhanDTO>);
            dgvPhuCap.DataSource = lstBoPhan;
            CustomDataGridViewBoPhan();
        }
        #endregion


    }
}
