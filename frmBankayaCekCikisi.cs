using System;
using System.Windows.Forms;

namespace StokProjesi
{
    public partial class frmBankayaCekCikisi : DevExpress.XtraEditors.XtraForm
    {
        public frmBankayaCekCikisi()
        {
            InitializeComponent();
            this.btnKapat.Click += (s, e) => this.Close();
        }
    }
}
