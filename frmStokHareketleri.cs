using System;
using System.Linq;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmStokHareketleri : DevExpress.XtraEditors.XtraForm
    {
        public frmStokHareketleri()
        {
            InitializeComponent();
        }

        private void frmStokHareketleri_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = VeritabaniMock.StokHareketleri.ToList();
        }
    }
}
