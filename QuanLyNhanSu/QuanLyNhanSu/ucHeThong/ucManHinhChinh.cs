using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.ucNhanVien;
using MetroFramework.Controls;

namespace QuanLyNhanSu.ucHeThong
{
    public partial class ucManHinhChinh : UserControl
    {
        public ucManHinhChinh()
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
                            _Layout lo = new _Layout();
                            lo.Dock = DockStyle.Fill;
                            frmMain.FrmMain.MetroPanelContainer.Controls.Add(lo);
                            frmMain.FrmMain.MetroPanelContainer.Controls["_Layout"].BringToFront();
                            foreach (ucManHinhChinh uc in frmMain.FrmMain.MetroPanelContainer.Controls.OfType<ucManHinhChinh>())
                            {
                                frmMain.FrmMain.MetroPanelContainer.Controls.Remove(uc);
                            }
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
