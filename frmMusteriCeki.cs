using System;
using System.Windows.Forms;

namespace StokProjesi
{
    public partial class frmMusteriCeki : DevExpress.XtraEditors.XtraForm
    {
        public frmMusteriCeki()
        {
            InitializeComponent();
            this.btnKapat.Click += (s, e) => this.Close();
        }
    }
}
