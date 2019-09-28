using QuanLyNhanSu.Menu;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace QuanLyNhanSu.DangNhap
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
            //Xóa tất cả các UserControl
            foreach (UserControl uc in frmMain.getFrmMain.getMetroPanelContainer.Controls.OfType<UserControl>())
            {
                frmMain.getFrmMain.getMetroPanelContainer.Controls.Remove(uc);
            }
            tmrDangNhap.Start();
        }

        private void tmrDangNhap_Tick(object sender, EventArgs e)
        {
            if(Math.Abs(positionY) > Math.Abs(pnlDangNhapContainer.Size.Height))
            {
                tmrDangNhap.Stop();
                ucMenuChinh ucMC = new ucMenuChinh();
                ucMC.Dock = DockStyle.Fill;
                frmMain.getFrmMain.getMetroPanelContainer.Controls.Add(ucMC);
                frmMain.getFrmMain.getMetroPanelContainer.Controls["ucMenuChinh"].BringToFront();
            }
            else
            {
                positionY = positionY - move;
                pnlDangNhapContainer.Location = new Point(10, positionY);
            }
        }
    }
}
