using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.NhanVien
{
    public partial class frmThongTinBaoHiem : MetroForm
    {
        public frmThongTinBaoHiem()
        {
            InitializeComponent();
        }

        public string SoBaoHiem
        {
            set
            {
                txtSoBaoHiem.Text = value;
            }
            get
            {
                return txtSoBaoHiem.Text;
            }
        }

        public DateTime NgayCap
        {
            set
            {
                dtpNgayCap.Value = value;
            }
            get
            {
                return dtpNgayCap.Value;
            }
        }

        public string NoiCap
        {

            set
            {
                txtNoiCap.Text = value;
            }
            get
            {
                return txtNoiCap.Text;
            }
        }

        public string NoiKhamBenh
        {
            set
            {
                txtNoiKhamBenh.Text = value;
            }
            get
            {
                return txtNoiKhamBenh.Text;
            }
        }

        public DateTime NgayHetHan
        {
            set
            {
                dtpNgayHetHan.Value = value;
            }
            get
            {
                return dtpNgayHetHan.Value;
            }
        }

        public Button btnBaoHiem_Sua
        {
            get
            {
                return this.btnSua;
            }
        }

        public Button btnBaoHiem_Xoa
        {
            get
            {
                return this.btnXoa;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
