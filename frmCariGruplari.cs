using System;
using System.Linq;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmCariGruplari : DevExpress.XtraEditors.XtraForm
    {
        public frmCariGruplari()
        {
            InitializeComponent();
        }

        private void frmCariGruplari_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = VeritabaniMock.CariGruplari.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGrupKodu.Text) || string.IsNullOrWhiteSpace(txtGrupAdi.Text))
            {
                MessageBox.Show("Lütfen Grup Kodu ve Grup Adı alanlarını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var grup = new CariGrupModel
            {
                GrupKodu = txtGrupKodu.Text,
                GrupAdi = txtGrupAdi.Text
            };

            if (grup.Save())
            {
                MessageBox.Show("Cari grup başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Grup kaydedilirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGrupKodu.Text))
            {
                MessageBox.Show("Lütfen silinecek Grup Kodunu giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bu cari grubunu silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CariGrupModel.Delete(txtGrupKodu.Text))
                {
                    MessageBox.Show("Cari grup başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGrupKodu.Text = "";
                    txtGrupAdi.Text = "";
                    RefreshGrid();
                }
                else
                {
                    MessageBox.Show("Grup silinirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (gridView1.GetFocusedRow() is CariGrupModel secilenGrup)
            {
                txtGrupKodu.Text = secilenGrup.GrupKodu;
                txtGrupAdi.Text = secilenGrup.GrupAdi;
            }
        }
    }
}
