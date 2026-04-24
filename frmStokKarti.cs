using System;
using System.Drawing;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmStokKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmStokKarti()
        {
            InitializeComponent();
            this.peStokResmi.Click += PeStokResmi_Click;
            this.btnKapat.Click += BtnKapat_Click;
            this.btnSil.Click += BtnSil_Click;
            this.btnKaydet.Click += BtnKaydet_Click;
            this.txtStokKodu.ButtonClick += TxtStokKodu_ButtonClick;
        }

        private void TxtStokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            // "..." butonuna tıklandığında stok listesini aç
            var frm = new frmStokListesi();
            frm.ShowDialog();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStokKodu.Text) || string.IsNullOrWhiteSpace(txtStokAdi.Text))
            {
                MessageBox.Show("Lütfen Stok Kodu ve Stok Adı alanlarını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var yeniStok = new StokModel
            {
                StokKodu = txtStokKodu.Text,
                StokAdi = txtStokAdi.Text,
                Barkod = txtBarkod.Text
            };
            
            if (yeniStok.Save())
            {
                MessageBox.Show("Stok başarıyla veritabanına kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Stok kaydedilirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            // Eğer arka planda açık bir stok listesi varsa onu da yenileyelim
            foreach (Form form in Application.OpenForms)
            {
                if (form is frmStokListesi listeForm)
                {
                    listeForm.RefreshGrid();
                }
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStokKodu.Text))
            {
                MessageBox.Show("Lütfen silinecek Stok Kodunu giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bu stok kartını silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (StokModel.Delete(txtStokKodu.Text))
                {
                    MessageBox.Show("Stok kartı başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    txtStokKodu.Text = "";
                    txtStokAdi.Text = "";
                    txtBarkod.Text = "";
                    
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form is frmStokListesi listeForm)
                        {
                            listeForm.RefreshGrid();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bu stok koduna ait bir kayıt bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PeStokResmi_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Stok Resmi Seç";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    peStokResmi.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
    }
}
