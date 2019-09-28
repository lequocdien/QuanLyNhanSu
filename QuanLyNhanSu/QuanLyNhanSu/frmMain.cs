using MetroFramework.Controls;
using MetroFramework.Forms;
using QuanLyNhanSu.DangNhap;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmMain : MetroForm
    {
        private frmMain()
        {
            InitializeComponent();
        }

        #region Add by Me
        private static frmMain frm;

        public static frmMain getFrmMain
        {
            get
            {
                if (frm == null)
                {
                    frm = new frmMain();
                }
                return frm;
            }
        }

        public MetroPanel getMetroPanelContainer
        {
            get
            {
                return mpnContainer;
            }
        }
        #endregion

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            //_frmMain = this;
            ucDangNhap ucDN = new ucDangNhap();
            ucDN.Dock = DockStyle.Fill;
            //FrmMain.MetroPanelContainer.Controls.Add(ucDN);
            //FrmMain.MetroPanelContainer.Controls["ucDangNhap"].BringToFront();
            getFrmMain.getMetroPanelContainer.Controls.Add(ucDN);
            getFrmMain.getMetroPanelContainer.Controls["ucDangNhap"].BringToFront();
        }
    }
}
