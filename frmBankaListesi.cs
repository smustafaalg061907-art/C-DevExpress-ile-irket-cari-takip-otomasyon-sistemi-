using System;
using System.Linq;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmBankaListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmBankaListesi()
        {
            InitializeComponent();
        }

        private void frmBankaListesi_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = VeritabaniMock.Bankalar.ToList();
        }
    }
}
