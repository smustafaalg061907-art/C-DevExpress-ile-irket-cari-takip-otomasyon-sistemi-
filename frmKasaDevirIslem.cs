using System;
using System.Windows.Forms;

namespace StokProjesi
{
    public partial class frmKasaDevirIslem : DevExpress.XtraEditors.XtraForm
    {
        public frmKasaDevirIslem()
        {
            InitializeComponent();
            this.btnKapat.Click += (s, e) => this.Close();
        }
    }
}
