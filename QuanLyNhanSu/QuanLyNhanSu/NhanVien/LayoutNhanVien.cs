using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Threading;
using QuanLyNhanSu.Menu;
using MetroFramework.Drawing;

namespace QuanLyNhanSu.NhanVien
{
    public partial class LayoutNhanVien : UserControl
    {
        public LayoutNhanVien()
        {
            InitializeComponent();
        }

        string btnName = null;
        Thread threadLoadProgressBar;
        Thread threadLoadUserControl;
        ucHoSoNhanVien ucHSNV;
        ucProgressBar ucPB;

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            ucMenuChinh ucMC = new ucMenuChinh();
            ucMC.Dock = DockStyle.Fill;
            frmMain.getFrmMain.getMetroPanelContainer.Controls.Add(ucMC);
            frmMain.getFrmMain.getMetroPanelContainer.Controls["ucMenuChinh"].BringToFront();
            //foreach(_Layout lo in frmMain.FrmMain.MetroPanelContainer.Controls.OfType<_Layout>())
            //{
            //    frmMain.FrmMain.MetroPanelContainer.Controls.Remove(lo);
            //}
            this.Parent.Controls.Remove(this);
        }

        private void metroTile_MouseHover(object sender, EventArgs e)
        {
            MetroTile btn = (MetroTile)sender;
            btn.BackColor = Color.Aqua;
        }

        private void metroTile_MouseLeave(object sender, EventArgs e)
        {
            MetroTile btn = (MetroTile)sender;
            if (btn.Tag.ToString() == "1")
            {
                btn.BackColor = Color.Aqua;
            }
            else
            {
                btn.BackColor = Color.FromArgb(0, 174, 219);
            }
        }

        private void metroTile_Click(object sender, EventArgs e)
        {
            MetroTile btn = (MetroTile)sender;
            //Reset lại màu của button
            foreach (MetroTile item in btn.Parent.Controls.OfType<MetroTile>())
            {
                item.BackColor = Color.FromArgb(0, 174, 219);
                item.Tag = 0;
            }

            //Đổi màu button trạng thái Active
            btn.Tag = 1;
            btn.BackColor = Color.Aqua;

            //Lấy tên của btn đã click
            btnName = btn.Name;

            NoiDungUserControl(btnName);
        }


        private void NoiDungUserControl(string btnName)
        {
            foreach (UserControl uc in pnlNoiDung.Controls.OfType<UserControl>())
            {
                pnlNoiDung.Controls.Remove(uc);
            }
            ucPB = new ucProgressBar();
            ucPB.Dock = DockStyle.Fill;
            pnlNoiDung.Controls.Add(ucPB);
            pnlNoiDung.Controls["ucProgressBar"].BringToFront();

            LoadUserControl();
            //Thread Load
            //threadLoadUserControl = new Thread(new ThreadStart(LoadUserControl));
            //threadLoadUserControl.Start();

            //Thread Load ProgressBar
            //DONE
            //threadLoadProgressBar = new Thread(new ThreadStart(LoadProgressBar));
            //threadLoadProgressBar.Start();

        }

        #region Use them in ThreadStart

        //DONE
        //private void LoadProgressBar()
        //{
        //    ucPB.Invoke(new MethodInvoker(delegate
        //    {
        //        for (int i = 0; i <= 10000; i++)
        //        {
        //            ucPB.ProgressBar.Value = (i * 100) / 10000;
        //        }
        //    }));
        //    threadLoadUserControl.Resume();
        //}

        private void LoadUserControl()
        {
            //threadLoadUserControl.Suspend();
            //Nếu không bỏ khối lệnh switch trong invoke thì xảy ra lỗi Cross-thread (Xung đột tiến trình)
            pnlNoiDung.Invoke(new MethodInvoker(delegate
            {
                switch (btnName)
                {
                    case "btnHoSoNhanVien":
                        {

                            //foreach (UserControl uc in pnlNoiDung.Controls.OfType<UserControl>())
                            //{
                            //    pnlNoiDung.Controls.Remove(uc);
                            //}
                            //ucHSNV = new ucHoSoNhanVien();
                            //ucHSNV.Dock = DockStyle.Fill;
                            //pnlNoiDung.Controls.Add(ucHSNV);
                            //pnlNoiDung.Controls["ucHoSoNhanVien"].BringToFront();
                            //break;





                            //for (int i = 0; i <= 100; i++)
                            //{
                            //    ucPB.ProgressBar.Value = i;
                            //    if (i == 100)
                            //    {
                            //        foreach (UserControl uc in pnlNoiDung.Controls.OfType<UserControl>())
                            //        {
                            //            pnlNoiDung.Controls.Remove(uc);
                            //        }
                            //        ucHSNV = new ucHoSoNhanVien();
                            //        ucHSNV.Dock = DockStyle.Fill;
                            //        pnlNoiDung.Controls.Add(ucHSNV);
                            //        pnlNoiDung.Controls["ucHoSoNhanVien"].BringToFront();
                            //    }
                            //}



                            

                            backgroundWorkerHoSoNhanVien.RunWorkerAsync();
                            break;
                        }
                    case "btnNhapXuatNV":
                        {
                            foreach (UserControl uc in pnlNoiDung.Controls.OfType<UserControl>())
                            {
                                pnlNoiDung.Controls.Remove(uc);
                            }
                            ucNhapXuatNV ucNXNV = new ucNhapXuatNV();
                            ucNXNV.Dock = DockStyle.Fill;
                            pnlNoiDung.Controls.Add(ucNXNV);
                            pnlNoiDung.Controls["ucNhapXuatNV"].BringToFront();


                            break;
                        }
                    case "btnNhanVienThoiViec":
                        {
                            foreach (UserControl uc in pnlNoiDung.Controls.OfType<UserControl>())
                            {
                                pnlNoiDung.Controls.Remove(uc);
                            }
                            ucDSNhanVienThoiViec ucDSNVTV = new ucDSNhanVienThoiViec();
                            ucDSNVTV.Dock = DockStyle.Fill;
                            pnlNoiDung.Controls.Add(ucDSNVTV);
                            pnlNoiDung.Controls["ucDSNhanVienThoiViec"].BringToFront();
                            break;
                        }
                    case "btnHopDongNV":
                        {
                            foreach (UserControl uc in pnlNoiDung.Controls.OfType<UserControl>())
                            {
                                pnlNoiDung.Controls.Remove(uc);
                            }
                            ucHopDongNhanVien ucHDNV = new ucHopDongNhanVien();
                            ucHDNV.Dock = DockStyle.Fill;
                            pnlNoiDung.Controls.Add(ucHDNV);
                            pnlNoiDung.Controls["ucHopDongNhanVien"].BringToFront();
                            break;
                        }
                }

            }));
        }
        #endregion

        private void backgroundWorkerHoSoNhanVien_DoWork(object sender, DoWorkEventArgs e)
        {
            pnlNoiDung.Invoke(new MethodInvoker(() => {
                ucPB = new ucProgressBar();
                ucPB.Dock = DockStyle.Fill;
                foreach (UserControl uc in pnlNoiDung.Controls.OfType<UserControl>())
                {
                    pnlNoiDung.Controls.Remove(uc);
                }
                pnlNoiDung.Controls.Add(ucPB);
                pnlNoiDung.Controls["ucProgressBar"].BringToFront();
                ucPB.ProgressBar.Value = 90;

                ucHSNV = new ucHoSoNhanVien();
                ucHSNV.Dock = DockStyle.Fill;

                ucPB.Invoke(new MethodInvoker(() => {
                    ucPB.ProgressBar.Value = 100;
                }));
            }));
        }

        private void backgroundWorkerHoSoNhanVien_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pnlNoiDung.Invoke(new MethodInvoker(delegate ()
            {
                foreach (UserControl uc in pnlNoiDung.Controls.OfType<UserControl>())
                {
                    pnlNoiDung.Controls.Remove(uc);
                }
                pnlNoiDung.Controls.Add(ucHSNV);
                pnlNoiDung.Controls["ucHoSoNhanVien"].BringToFront();
            }));
            
        }
    }
}
