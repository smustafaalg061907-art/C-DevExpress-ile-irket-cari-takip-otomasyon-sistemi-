using System;
using System.Linq;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmBankaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        public frmBankaHareketleri()
        {
            InitializeComponent();
        }

        private void frmBankaHareketleri_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = VeritabaniMock.BankaHareketleri.ToList();
        }
    }
}
