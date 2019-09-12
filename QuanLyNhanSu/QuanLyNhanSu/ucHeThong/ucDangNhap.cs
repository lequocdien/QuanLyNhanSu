using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace QuanLyNhanSu.ucHeThong
{
    public partial class ucDangNhap : UserControl
    {
        public ucDangNhap()
        {
            InitializeComponent();
        }

        private int positionY = 10;
        private int move = 10;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            tmrDangNhap.Start();
        }

        private void tmrDangNhap_Tick(object sender, EventArgs e)
        {
            if(Math.Abs(positionY) > Math.Abs(pnlDangNhapContainer.Size.Height))
            {
                tmrDangNhap.Stop();
                ucManHinhChinh ucMHC = new ucManHinhChinh();
                ucMHC.Dock = DockStyle.Fill;
                frmMain.FrmMain.MetroPanelContainer.Controls.Add(ucMHC);
                frmMain.FrmMain.MetroPanelContainer.Controls["ucManHinhChinh"].BringToFront();
                foreach (ucDangNhap uc in frmMain.FrmMain.MetroPanelContainer.Controls.OfType<ucDangNhap>())
                {
                    frmMain.FrmMain.MetroPanelContainer.Controls.Remove(uc);
                }
            }
            else
            {
                positionY = positionY - move;
                pnlDangNhapContainer.Location = new Point(10, positionY);
            }
        }
    }
}
