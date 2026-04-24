using System;
using System.Linq;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmStokGruplari : DevExpress.XtraEditors.XtraForm
    {
        public frmStokGruplari()
        {
            InitializeComponent();
        }

        private void frmStokGruplari_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        public void RefreshGrid()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = VeritabaniMock.StokGruplari.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGrupKodu.Text) || string.IsNullOrWhiteSpace(txtGrupAdi.Text))
            {
                MessageBox.Show("Lütfen Grup Kodu ve Grup Adı alanlarını doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var grup = new StokGrupModel
            {
                GrupKodu = txtGrupKodu.Text,
                GrupAdi = txtGrupAdi.Text
            };

            if (grup.Save())
            {
                MessageBox.Show("Stok grubu başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Grup kaydedilirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGrupKodu.Text)) return;

            if (MessageBox.Show("Seçili grubu silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (StokGrupModel.Delete(txtGrupKodu.Text))
                {
                    MessageBox.Show("Grup başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (gridView1.GetFocusedRow() is StokGrupModel grup)
            {
                txtGrupKodu.Text = grup.GrupKodu;
                txtGrupAdi.Text = grup.GrupAdi;
            }
        }
    }
}
