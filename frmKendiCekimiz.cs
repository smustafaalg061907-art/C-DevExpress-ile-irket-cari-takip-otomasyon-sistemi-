using System;
using System.Windows.Forms;

namespace StokProjesi
{
    public partial class frmKendiCekimiz : DevExpress.XtraEditors.XtraForm
    {
        public frmKendiCekimiz()
        {
            InitializeComponent();
            this.btnKapat.Click += (s, e) => this.Close();
        }
    }
}
