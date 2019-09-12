using MetroFramework.Controls;
using MetroFramework.Forms;
using QuanLyNhanSu.ucHeThong;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmMain : MetroForm
    {
        private static frmMain _frmMain;

        private frmMain()
        {
            InitializeComponent();
        }

        public static frmMain FrmMain
        {
            get
            {
                if (_frmMain == null)
                {
                    _frmMain = new frmMain();
                }
                return _frmMain;
            }
            set
            {
                _frmMain = value;
            }
        }

        public MetroPanel MetroPanelContainer
        {
            get
            {
                return this.mpnContainer;
            }
            set
            {
                this.mpnContainer = value;
            }
        }        

        private void frmMain_Load(object sender, System.EventArgs e)
        {
            _frmMain = this;
            ucDangNhap ucDN = new ucDangNhap();
            ucDN.Dock = DockStyle.Fill;
            FrmMain.MetroPanelContainer.Controls.Add(ucDN);
            FrmMain.MetroPanelContainer.Controls["ucDangNhap"].BringToFront();
        }
    }
}
