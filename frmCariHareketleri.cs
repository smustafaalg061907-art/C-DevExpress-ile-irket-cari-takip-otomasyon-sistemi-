using System;
using System.Linq;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmCariHareketleri : DevExpress.XtraEditors.XtraForm
    {
        public frmCariHareketleri()
        {
            InitializeComponent();
        }

        private void frmCariHareketleri_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = VeritabaniMock.CariHareketleri.ToList();
        }
    }
}
