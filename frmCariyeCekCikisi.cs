using System;
using System.Windows.Forms;

namespace StokProjesi
{
    public partial class frmCariyeCekCikisi : DevExpress.XtraEditors.XtraForm
    {
        public frmCariyeCekCikisi()
        {
            InitializeComponent();
            this.btnKapat.Click += (s, e) => this.Close();
        }
    }
}
