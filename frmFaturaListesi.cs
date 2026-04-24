using System;
using System.Linq;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmFaturaListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmFaturaListesi()
        {
            InitializeComponent();
        }

        private void frmFaturaListesi_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = VeritabaniMock.Faturalar.ToList();
        }
    }
}
