using System;
using System.Windows.Forms;

namespace StokProjesi
{
    public partial class frmKasaTahsilatOdeme : DevExpress.XtraEditors.XtraForm
    {
        public frmKasaTahsilatOdeme()
        {
            InitializeComponent();
            this.btnKapat.Click += (s, e) => this.Close();
        }
    }
}
