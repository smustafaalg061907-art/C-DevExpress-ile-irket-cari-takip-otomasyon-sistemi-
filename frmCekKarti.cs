using System;
using System.Linq;
using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class frmCekKarti : DevExpress.XtraEditors.XtraForm
    {
        public frmCekKarti()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCekNo.Text)) return;

            VeritabaniMock.Cekler.Add(new CekModel
            {
                CekNo = txtCekNo.Text,
                BankaAdi = txtBanka.Text,
                Tutar = decimal.TryParse(txtTutar.Text, out decimal res) ? res : 0
            });

            MessageBox.Show("Çek kaydedildi.");
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
