using System;
using System.Linq;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmCariListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmCariListesi()
        {
            InitializeComponent();
        }

        private void frmCariListesi_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            // Grid'i güncelle
            gridControl1.DataSource = null;
            gridControl1.DataSource = VeritabaniMock.Cariler.ToList();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var filtrelenmisListe = VeritabaniMock.Cariler.Where(c => 
                (string.IsNullOrEmpty(txtCariKodu.Text) || c.CariKodu.Contains(txtCariKodu.Text)) &&
                (string.IsNullOrEmpty(txtCariAdi.Text) || c.CariAdi.Contains(txtCariAdi.Text)) &&
                (string.IsNullOrEmpty(txtCariGrup.Text) || c.CariGrup.Contains(txtCariGrup.Text))
            ).ToList();

            gridControl1.DataSource = null;
            gridControl1.DataSource = filtrelenmisListe;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtCariKodu.Text = "";
            txtCariAdi.Text = "";
            txtCariGrup.Text = "";
            RefreshGrid();
        }
    }
}
