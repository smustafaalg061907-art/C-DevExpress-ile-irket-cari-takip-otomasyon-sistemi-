using System;
using System.Drawing;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmStokListesi : DevExpress.XtraEditors.XtraForm
    {
        public frmStokListesi()
        {
            InitializeComponent();
        }

        private void frmStokListesi_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = VeritabaniMock.Stoklar;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            // Basit bir arama filtrelemesi simülasyonu
            var view = gridView1;
            string filter = "";
            
            if (!string.IsNullOrEmpty(txtStokKodu.Text))
                filter += $"[StokKodu] LIKE '%{txtStokKodu.Text}%'";
                
            if (!string.IsNullOrEmpty(txtStokAdi.Text))
            {
                if (filter.Length > 0) filter += " AND ";
                filter += $"[StokAdi] LIKE '%{txtStokAdi.Text}%'";
            }
                
            if (!string.IsNullOrEmpty(txtBarkod.Text))
            {
                if (filter.Length > 0) filter += " AND ";
                filter += $"[Barkod] LIKE '%{txtBarkod.Text}%'";
            }

            view.ActiveFilterString = filter;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtStokKodu.Text = "";
            txtStokAdi.Text = "";
            txtBarkod.Text = "";
            gridView1.ActiveFilterString = "";
        }
    }
}
