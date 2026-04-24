using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmFaturaKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmFaturaKarti()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFaturaNo.Text))
            {
                MessageBox.Show("Fatura No boş olamaz!");
                return;
            }

            var fatura = new FaturaModel
            {
                FaturaNo = txtFaturaNo.Text,
                CariKodu = txtCariKodu.Text,
                Tarih = DateTime.Now,
                ToplamTutar = 0 // Gerçek uygulamada satırlardan toplanır
            };

            VeritabaniMock.Faturalar.Add(fatura);
            MessageBox.Show("Fatura başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
