using System;
using System.Linq;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmKasaKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmKasaKarti()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKasaKodu.Text) || string.IsNullOrWhiteSpace(txtKasaAdi.Text))
            {
                MessageBox.Show("Lütfen Kasa Kodu ve Adı alanlarını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kasa = new KasaModel
            {
                KasaKodu = txtKasaKodu.Text,
                KasaAdi = txtKasaAdi.Text
            };

            if (kasa.Save())
            {
                MessageBox.Show("Kasa bilgileri başarıyla veritabanına kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kasa kaydedilirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKasaKodu.Text)) return;
            if (MessageBox.Show("Bu kasayı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (KasaModel.Delete(txtKasaKodu.Text))
                {
                    MessageBox.Show("Kasa başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kasa silinirken bir hata oluştu veya kayıt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
