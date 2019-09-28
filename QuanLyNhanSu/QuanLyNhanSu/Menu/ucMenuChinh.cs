using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyNhanSu.NhanVien;
using MetroFramework.Controls;
using QuanLyNhanSu.BoPhan;
using QuanLyNhanSu.ChucVu;
using QuanLyNhanSu.ChamCong;
using QuanLyNhanSu.TinhLuong;

namespace QuanLyNhanSu.Menu
{
    public partial class ucMenuChinh : UserControl
    {
        public ucMenuChinh()
        {
            InitializeComponent();
        }

        string btnName = "";
        int positionX = 0;
        int moveX = 50;

        private void button_Click(object sender, EventArgs e)
        {
            MetroTile btn = (MetroTile)sender;
            btnName = btn.Name;
            timerManHinhChinh.Start();
        }

        #region Hiệu ứng trợt màn hình chính
        private void timerManHinhChinh_Tick(object sender, EventArgs e)
        {
            if(positionX >= mpnContainer.Size.Width)
            {
                timerManHinhChinh.Stop();
                switch (btnName)
                {
                    case "btnNhanVien":
                        {
                            foreach (UserControl uc in frmMain.getFrmMain.getMetroPanelContainer.Controls.OfType<UserControl>())
                            {
                                frmMain.getFrmMain.getMetroPanelContainer.Controls.Remove(uc);
                            }
                            LayoutNhanVien lo = new LayoutNhanVien();
                            lo.Dock = DockStyle.Fill;
                            frmMain.getFrmMain.getMetroPanelContainer.Controls.Add(lo);
                            frmMain.getFrmMain.getMetroPanelContainer.Controls["LayoutNhanVien"].BringToFront();
                            break;
                        }
                    case "btnBoPhan":
                        {
                            foreach (UserControl uc in frmMain.getFrmMain.getMetroPanelContainer.Controls.OfType<UserControl>())
                            {
                                frmMain.getFrmMain.getMetroPanelContainer.Controls.Remove(uc);
                            }
                            ucBoPhan ucBP = new ucBoPhan();
                            ucBP.Dock = DockStyle.Fill;
                            frmMain.getFrmMain.getMetroPanelContainer.Controls.Add(ucBP);
                            frmMain.getFrmMain.getMetroPanelContainer.Controls["ucBoPhan"].BringToFront();
                            break;
                        }
                    case "btnChucVu":
                        {
                            foreach (UserControl uc in frmMain.getFrmMain.getMetroPanelContainer.Controls.OfType<UserControl>())
                            {
                                frmMain.getFrmMain.getMetroPanelContainer.Controls.Remove(uc);
                            }
                            ucChucVu ucCV = new ucChucVu();
                            ucCV.Dock = DockStyle.Fill;
                            frmMain.getFrmMain.getMetroPanelContainer.Controls.Add(ucCV);
                            frmMain.getFrmMain.getMetroPanelContainer.Controls["ucChucVu"].BringToFront();
                            break;
                        }
                    case "btnChamCong":
                        {
                            foreach (UserControl uc in frmMain.getFrmMain.getMetroPanelContainer.Controls.OfType<UserControl>())
                            {
                                frmMain.getFrmMain.getMetroPanelContainer.Controls.Remove(uc);
                            }
                            ucChamCong ucCC = new ucChamCong();
                            ucCC.Dock = DockStyle.Fill;
                            frmMain.getFrmMain.getMetroPanelContainer.Controls.Add(ucCC);
                            frmMain.getFrmMain.getMetroPanelContainer.Controls["ucChamCong"].BringToFront();
                            break;

                        }
                    case "btnTinhLuong":
                        {
                            foreach (UserControl uc in frmMain.getFrmMain.getMetroPanelContainer.Controls.OfType<UserControl>())
                            {
                                frmMain.getFrmMain.getMetroPanelContainer.Controls.Remove(uc);
                            }
                            ucTinhLuong ucTL = new ucTinhLuong();
                            ucTL.Dock = DockStyle.Fill;
                            frmMain.getFrmMain.getMetroPanelContainer.Controls.Add(ucTL);
                            frmMain.getFrmMain.getMetroPanelContainer.Controls["ucTinhLuong"].BringToFront();
                            break;
                        }
                }
                
            }
            else
            {
                positionX = positionX + moveX;
                mpnContainer.Location = new Point(positionX, mpnContainer.Location.Y);
            }

        }
        #endregion

    }
}
