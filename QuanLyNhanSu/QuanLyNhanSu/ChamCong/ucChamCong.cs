using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BUL;
using DTO;
using EF;
using QuanLyNhanSu.Menu;

namespace QuanLyNhanSu.ChamCong
{
    public partial class ucChamCong : UserControl
    {
        private List<TRANGTHAICHAMCONG> lstTrangThaiChamCong = new List<TRANGTHAICHAMCONG>();
        private List<ChamCongDTO> lstChamCong = new List<ChamCongDTO>();

        public ucChamCong()
        {
            InitializeComponent();
        }

        private void UcChamCong_Load(object sender, EventArgs e)
        {
            DataGridViewComboBoxColumn dgvCmbTrangThai = new DataGridViewComboBoxColumn();
            dgvCmbTrangThai.Name = "TrangThai";
            dgvCmbTrangThai.HeaderText = "Trạng thái";
            dgvCmbTrangThai.DataSource = TrangThaiChamCongBUL.Load();
            dgvCmbTrangThai.DisplayMember = "TenTrangThai";
            dgvCmbTrangThai.ValueMember = "MaTrangThai";

            DataGridViewTextBoxColumn dgvTxtSoGioTangCa = new DataGridViewTextBoxColumn();
            dgvTxtSoGioTangCa.Name = "TangCa";
            dgvTxtSoGioTangCa.HeaderText = "Số giờ tăng ca";

            dgvChamCong.Columns.Add(dgvCmbTrangThai);
            dgvChamCong.Columns.Add(dgvTxtSoGioTangCa);

            dateTimePicker1.Value = DateTime.Now;            
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lstChamCong = ChamCongBUL.LoadBangChamCongTheoNgay(dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
            
            ReloadDataGridView();

            for (int i = 0; i < dgvChamCong.Rows.Count; i++)
            {
                dgvChamCong.Rows[i].Cells["TrangThai"].Value = lstChamCong[i].MaTrangThai;
                dgvChamCong.Rows[i].Cells["TangCa"].Value = lstChamCong[i].SoGioTangCa;
            }
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

        private void ChkChamCongTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChamCongTatCa.Checked == true)
            {
                for (int i = 0; i < dgvChamCong.Rows.Count; i++)
                {
                    dgvChamCong.Rows[i].Cells["TrangThai"].Value = 1;
                }
            }
            else
            {
                for (int i = 0; i < dgvChamCong.Rows.Count; i++)
                {
                    dgvChamCong.Rows[i].Cells["TrangThai"].Value = 2;
                }
            }

        }

        private void ChkTangCaTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTangCaTatCa.Checked == true)
            {
                for (int i = 0; i < dgvChamCong.Rows.Count; i++)
                {
                    dgvChamCong.Rows[i].Cells["TangCa"].Value = 2;
                }
            }
            else
            {
                for (int i = 0; i < dgvChamCong.Rows.Count; i++)
                {
                    dgvChamCong.Rows[i].Cells["TangCa"].Value = 0;
                }
            }
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            List<CHAMCONG> lstChamCong = new List<CHAMCONG>();
            DateTime dt = dateTimePicker1.Value;
            for (int i = 0; i < dgvChamCong.Rows.Count; i++)
            {
                lstChamCong.Add(new CHAMCONG()
                {
                    MaNV = Convert.ToInt32(dgvChamCong.Rows[i].Cells["MaNV"].Value),
                    ThoiGian = dt,
                    MaTrangThai = Convert.ToInt32(dgvChamCong.Rows[i].Cells["TrangThai"].Value),
                    SoGioTangCa = Convert.ToInt32(dgvChamCong.Rows[i].Cells["TangCa"].Value),
                });
            }
            if (ChamCongBUL.ChamCongNhanVien(lstChamCong))
            {
                MessageBox.Show("Chấm công thành công");
            }
            else
            {
                MessageBox.Show("Chấm công thất bại");
            }
        }

        #region TOOLS
        private void CustomDataGridViewChamCong()
        {
            dgvChamCong.Columns["MaNV"].Visible = false;
            dgvChamCong.Columns["HoLot"].HeaderText = "Họ";
            dgvChamCong.Columns["Ten"].HeaderText = "Tên";
            dgvChamCong.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvChamCong.Columns["TenTrinhDo"].HeaderText = "Trình độ";
            dgvChamCong.Columns["TenBP"].HeaderText = "Bộ phận";
            dgvChamCong.Columns["TenChucVu"].HeaderText = "Chức vụ";
            dgvChamCong.Columns["MaTrangThai"].Visible = false;
            dgvChamCong.Columns["SoGioTangCa"].Visible = false;
        }

        private void ReloadDataGridView()
        {
            dgvChamCong.DataSource = typeof(List<ChamCongDTO>);
            dgvChamCong.DataSource = lstChamCong;
            CustomDataGridViewChamCong();
        }


        #endregion


    }
}
