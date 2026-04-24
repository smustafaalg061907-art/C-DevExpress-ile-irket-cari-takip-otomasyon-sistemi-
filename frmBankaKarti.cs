using System;
using System.Linq;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmBankaKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmBankaKarti()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBankaKodu.Text) || string.IsNullOrWhiteSpace(txtBankaAdi.Text))
            {
                MessageBox.Show("Lütfen Banka Kodu ve Adı alanlarını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var banka = new BankaModel
            {
                BankaKodu = txtBankaKodu.Text,
                BankaAdi = txtBankaAdi.Text,
                SubeAdi = txtSube.Text,
                HesapNo = txtHesapNo.Text,
                IBAN = txtIBAN.Text
            };

            if (banka.Save())
            {
                MessageBox.Show("Banka bilgileri başarıyla veritabanına kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Banka kaydedilirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBankaKodu.Text)) return;
            if (MessageBox.Show("Bu banka hesabını silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (BankaModel.Delete(txtBankaKodu.Text))
                {
                    MessageBox.Show("Banka hesabı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Banka silinirken bir hata oluştu veya kayıt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
