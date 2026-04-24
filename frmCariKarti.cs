using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmCariKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmCariKarti()
        {
            InitializeComponent();
            
            btnKapat.Click += BtnKapat_Click;
            btnKaydet.Click += BtnKaydet_Click;
            btnSil.Click += BtnSil_Click;
            this.txtCariKodu.ButtonClick += TxtCariKodu_ButtonClick;
            this.txtCariGrupKodu.ButtonClick += TxtCariGrupKodu_ButtonClick;
        }

        private void TxtCariGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frm = new frmCariGruplari();
            frm.ShowDialog();
        }

        private void TxtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var frm = new frmCariListesi();
            frm.ShowDialog();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCariKodu.Text) || string.IsNullOrWhiteSpace(txtCariAdi.Text))
            {
                MessageBox.Show("Lütfen Cari Kodu ve Cari Adı alanlarını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var yeniCari = new CariModel
            {
                CariKodu = txtCariKodu.Text,
                CariAdi = txtCariAdi.Text,
                VergiDairesi = txtVergiDairesi.Text,
                VergiNo = txtVergiNo.Text,
                GrupKodu = txtCariGrupKodu.Text
            };

            if (yeniCari.Save())
            {
                MessageBox.Show("Cari bilgileri başarıyla veritabanına kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cari kaydedilirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            foreach (Form form in Application.OpenForms)
            {
                if (form is frmCariListesi listeForm)
                {
                    listeForm.RefreshGrid();
                }
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCariKodu.Text))
            {
                MessageBox.Show("Lütfen silinecek Cari Kodunu giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bu cari kartını silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CariModel.Delete(txtCariKodu.Text))
                {
                    MessageBox.Show("Cari kart silme işlemi gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtCariKodu.Text = "";
                    txtCariAdi.Text = "";
                    txtVergiDairesi.Text = "";
                    txtVergiNo.Text = "";
                    
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is frmCariListesi listeForm)
                        {
                            listeForm.RefreshGrid();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bu cari koduna ait bir kayıt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
