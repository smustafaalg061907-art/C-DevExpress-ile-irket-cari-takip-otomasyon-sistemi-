using System;
using System.Linq;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmCekListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmCekListesi()
        {
            InitializeComponent();
        }

        private void frmCekListesi_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            gridControl1.DataSource = VeritabaniMock.Cekler.ToList();
        }
    }
}
