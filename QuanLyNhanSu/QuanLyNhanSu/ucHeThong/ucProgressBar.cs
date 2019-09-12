using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.ucHeThong
{
    public partial class ucProgressBar : UserControl
    {
        public ucProgressBar()
        {
            InitializeComponent();
        }

        public ProgressBar ProgressBar
        {
            get
            {
                return this.progressBar;
            }
        }
    }
}
