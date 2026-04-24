using System.Windows.Forms;
using StokProjesi.Models;

namespace StokProjesi
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
            SqlHelper.CheckDatabase(); // Veritabanı ve tabloları kontrol et/oluştur
            InitEvents();
        }

        private void InitEvents()
        {
            // Stok
            btnStokKarti.ItemClick += (s, e) => OpenForm(new frmStokKarti());
            btnStokListesi.ItemClick += (s, e) => OpenForm(new frmStokListesi());
            btnStokGruplari.ItemClick += (s, e) => OpenForm(new frmStokGruplari());
            btnStokHareketleri.ItemClick += (s, e) => OpenForm(new frmStokHareketleri());

            // Cari
            btnCariKarti.ItemClick += (s, e) => OpenForm(new frmCariKarti());
            btnCariListesi.ItemClick += (s, e) => OpenForm(new frmCariListesi());
            btnCariGruplari.ItemClick += (s, e) => OpenForm(new frmCariGruplari());
            btnCariHareketleri.ItemClick += (s, e) => OpenForm(new frmCariHareketleri());

            // Banka
            btnBankaKarti.ItemClick += (s, e) => OpenForm(new frmBankaKarti());
            btnBankaListesi.ItemClick += (s, e) => OpenForm(new frmBankaListesi());
            btnBankaHareketleri.ItemClick += (s, e) => OpenForm(new frmBankaHareketleri());

            // Kasa
            btnKasaKarti.ItemClick += (s, e) => OpenForm(new frmKasaKarti());
            btnKasaListesi.ItemClick += (s, e) => OpenForm(new frmKasaListesi());
            btnKasaHareketleri.ItemClick += (s, e) => OpenForm(new frmKasaHareketleri());
            btnKasaDevirIslem.ItemClick += (s, e) => OpenForm(new frmKasaDevirIslem());
            btnKasaTahsilatOdeme.ItemClick += (s, e) => OpenForm(new frmKasaTahsilatOdeme());

            // Fatura
            btnFaturaKarti.ItemClick += (s, e) => OpenForm(new frmFaturaKarti());
            btnFaturaListesi.ItemClick += (s, e) => OpenForm(new frmFaturaListesi());

            // Çekler
            btnCekListesi.ItemClick += (s, e) => OpenForm(new frmCekListesi());
            btnMusteriCeki.ItemClick += (s, e) => OpenForm(new frmMusteriCeki());
            btnKendiCekimiz.ItemClick += (s, e) => OpenForm(new frmKendiCekimiz());
            btnBankayaCekCikisi.ItemClick += (s, e) => OpenForm(new frmBankayaCekCikisi());
            btnCariyeCekCikisi.ItemClick += (s, e) => OpenForm(new frmCariyeCekCikisi());
        }

        private void OpenForm(Form frm)
        {
            foreach (var child in MdiChildren)
            {
                if (child.GetType() == frm.GetType())
                {
                    child.Activate();
                    frm.Dispose();
                    return;
                }
            }
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
