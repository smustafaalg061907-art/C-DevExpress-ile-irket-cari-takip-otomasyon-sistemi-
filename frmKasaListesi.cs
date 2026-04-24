using System;
using System.Linq;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmKasaListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmKasaListesi()
        {
            InitializeComponent();
        }

        private void frmKasaListesi_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = VeritabaniMock.Kasalar.ToList();
        }
    }
}
