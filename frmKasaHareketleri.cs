using System;
using System.Linq;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        public frmKasaHareketleri()
        {
            InitializeComponent();
        }

        private void frmKasaHareketleri_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = VeritabaniMock.KasaHareketleri.ToList();
        }
    }
}
