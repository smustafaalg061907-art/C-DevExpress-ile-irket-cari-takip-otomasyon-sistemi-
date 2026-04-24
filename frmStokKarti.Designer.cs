namespace StokProjesi
{
    partial class frmStokKarti
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.gcAnaStok = new DevExpress.XtraEditors.GroupControl();
            this.lblStokKodu = new DevExpress.XtraEditors.LabelControl();
            this.txtStokKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.lblStokAdi = new DevExpress.XtraEditors.LabelControl();
            this.txtStokAdi = new DevExpress.XtraEditors.TextEdit();
            this.peStokResmi = new DevExpress.XtraEditors.PictureEdit();

            this.gcGenelStok = new DevExpress.XtraEditors.GroupControl();
            
            this.gcGrupBilgileri = new DevExpress.XtraEditors.GroupControl();
            this.lblGrupKodu = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.lblGrupAdi = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupAdi = new DevExpress.XtraEditors.TextEdit();

            this.gcFiyatBilgileri = new DevExpress.XtraEditors.GroupControl();
            this.lblAlisFiyati = new DevExpress.XtraEditors.LabelControl();
            this.txtAlisFiyati = new DevExpress.XtraEditors.TextEdit();
            this.lblSatisFiyati = new DevExpress.XtraEditors.LabelControl();
            this.txtSatisFiyati = new DevExpress.XtraEditors.TextEdit();

            this.gcBarkodBirim = new DevExpress.XtraEditors.GroupControl();
            this.lblBirim = new DevExpress.XtraEditors.LabelControl();
            this.cmbBirim = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lblBarkod = new DevExpress.XtraEditors.LabelControl();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();

            this.gcKdvBilgileri = new DevExpress.XtraEditors.GroupControl();
            this.lblAlisKdv = new DevExpress.XtraEditors.LabelControl();
            this.txtAlisKdv = new DevExpress.XtraEditors.TextEdit();
            this.lblSatisKdv = new DevExpress.XtraEditors.LabelControl();
            this.txtSatisKdv = new DevExpress.XtraEditors.TextEdit();

            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();

            ((System.ComponentModel.ISupportInitialize)(this.gcAnaStok)).BeginInit();
            this.gcAnaStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peStokResmi.Properties)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.gcGenelStok)).BeginInit();
            this.gcGenelStok.SuspendLayout();
            
            ((System.ComponentModel.ISupportInitialize)(this.gcGrupBilgileri)).BeginInit();
            this.gcGrupBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).BeginInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.gcFiyatBilgileri)).BeginInit();
            this.gcFiyatBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyati.Properties)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.gcBarkodBirim)).BeginInit();
            this.gcBarkodBirim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.gcKdvBilgileri)).BeginInit();
            this.gcKdvBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisKdv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisKdv.Properties)).BeginInit();

            this.SuspendLayout();

            // gcAnaStok
            this.gcAnaStok.Controls.Add(this.lblStokKodu);
            this.gcAnaStok.Controls.Add(this.txtStokKodu);
            this.gcAnaStok.Controls.Add(this.lblStokAdi);
            this.gcAnaStok.Controls.Add(this.txtStokAdi);
            this.gcAnaStok.Controls.Add(this.peStokResmi);
            this.gcAnaStok.Location = new System.Drawing.Point(12, 12);
            this.gcAnaStok.Name = "gcAnaStok";
            this.gcAnaStok.Size = new System.Drawing.Size(560, 100);
            this.gcAnaStok.Text = "Ana Stok Bilgileri";

            // lblStokKodu
            this.lblStokKodu.Location = new System.Drawing.Point(15, 35);
            this.lblStokKodu.Text = "Stok Kodu :";
            // txtStokKodu
            this.txtStokKodu.Location = new System.Drawing.Point(85, 32);
            this.txtStokKodu.Size = new System.Drawing.Size(150, 20);
            this.txtStokKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)});
            this.txtStokKodu.Text = "0000002";
            // lblStokAdi
            this.lblStokAdi.Location = new System.Drawing.Point(15, 65);
            this.lblStokAdi.Text = "Stok Adı :";
            // txtStokAdi
            this.txtStokAdi.Location = new System.Drawing.Point(85, 62);
            this.txtStokAdi.Size = new System.Drawing.Size(150, 20);
            
            // peStokResmi
            this.peStokResmi.Location = new System.Drawing.Point(400, 30);
            this.peStokResmi.Size = new System.Drawing.Size(60, 60);
            this.peStokResmi.Properties.NullText = "Stok\nResmi\nSeç";
            this.peStokResmi.Properties.ShowMenu = true;

            // gcGenelStok
            this.gcGenelStok.Controls.Add(this.gcGrupBilgileri);
            this.gcGenelStok.Controls.Add(this.gcFiyatBilgileri);
            this.gcGenelStok.Controls.Add(this.gcBarkodBirim);
            this.gcGenelStok.Controls.Add(this.gcKdvBilgileri);
            this.gcGenelStok.Location = new System.Drawing.Point(12, 118);
            this.gcGenelStok.Name = "gcGenelStok";
            this.gcGenelStok.Size = new System.Drawing.Size(560, 250);
            this.gcGenelStok.Text = "Genel Stok Bilgileri";

            // gcGrupBilgileri
            this.gcGrupBilgileri.Controls.Add(this.lblGrupKodu);
            this.gcGrupBilgileri.Controls.Add(this.txtGrupKodu);
            this.gcGrupBilgileri.Controls.Add(this.lblGrupAdi);
            this.gcGrupBilgileri.Controls.Add(this.txtGrupAdi);
            this.gcGrupBilgileri.Location = new System.Drawing.Point(15, 30);
            this.gcGrupBilgileri.Size = new System.Drawing.Size(260, 100);
            this.gcGrupBilgileri.Text = "Grup Bilgileri";
            
            // lblGrupKodu
            this.lblGrupKodu.Location = new System.Drawing.Point(15, 35);
            this.lblGrupKodu.Text = "Grup Kodu :";
            // txtGrupKodu
            this.txtGrupKodu.Location = new System.Drawing.Point(85, 32);
            this.txtGrupKodu.Size = new System.Drawing.Size(150, 20);
            this.txtGrupKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)});
            // lblGrupAdi
            this.lblGrupAdi.Location = new System.Drawing.Point(15, 65);
            this.lblGrupAdi.Text = "Grup Adı :";
            // txtGrupAdi
            this.txtGrupAdi.Location = new System.Drawing.Point(85, 62);
            this.txtGrupAdi.Size = new System.Drawing.Size(150, 20);

            // gcFiyatBilgileri
            this.gcFiyatBilgileri.Controls.Add(this.lblAlisFiyati);
            this.gcFiyatBilgileri.Controls.Add(this.txtAlisFiyati);
            this.gcFiyatBilgileri.Controls.Add(this.lblSatisFiyati);
            this.gcFiyatBilgileri.Controls.Add(this.txtSatisFiyati);
            this.gcFiyatBilgileri.Location = new System.Drawing.Point(285, 30);
            this.gcFiyatBilgileri.Size = new System.Drawing.Size(260, 100);
            this.gcFiyatBilgileri.Text = "Fiyat Bilgileri";

            // lblAlisFiyati
            this.lblAlisFiyati.Location = new System.Drawing.Point(15, 35);
            this.lblAlisFiyati.Text = "Alış Fiyatı :";
            // txtAlisFiyati
            this.txtAlisFiyati.Location = new System.Drawing.Point(85, 32);
            this.txtAlisFiyati.Size = new System.Drawing.Size(150, 20);
            // lblSatisFiyati
            this.lblSatisFiyati.Location = new System.Drawing.Point(15, 65);
            this.lblSatisFiyati.Text = "Satış Fiyatı :";
            // txtSatisFiyati
            this.txtSatisFiyati.Location = new System.Drawing.Point(85, 62);
            this.txtSatisFiyati.Size = new System.Drawing.Size(150, 20);

            // gcBarkodBirim
            this.gcBarkodBirim.Controls.Add(this.lblBirim);
            this.gcBarkodBirim.Controls.Add(this.cmbBirim);
            this.gcBarkodBirim.Controls.Add(this.lblBarkod);
            this.gcBarkodBirim.Controls.Add(this.txtBarkod);
            this.gcBarkodBirim.Location = new System.Drawing.Point(15, 135);
            this.gcBarkodBirim.Size = new System.Drawing.Size(260, 100);
            this.gcBarkodBirim.Text = "Barkod ve Birim";

            // lblBirim
            this.lblBirim.Location = new System.Drawing.Point(15, 35);
            this.lblBirim.Text = "Birim :";
            // cmbBirim
            this.cmbBirim.Location = new System.Drawing.Point(85, 32);
            this.cmbBirim.Size = new System.Drawing.Size(150, 20);
            this.cmbBirim.Properties.Items.Add("ADET");
            this.cmbBirim.Text = "ADET";
            // lblBarkod
            this.lblBarkod.Location = new System.Drawing.Point(15, 65);
            this.lblBarkod.Text = "Barkod :";
            // txtBarkod
            this.txtBarkod.Location = new System.Drawing.Point(85, 62);
            this.txtBarkod.Size = new System.Drawing.Size(150, 20);

            // gcKdvBilgileri
            this.gcKdvBilgileri.Controls.Add(this.lblAlisKdv);
            this.gcKdvBilgileri.Controls.Add(this.txtAlisKdv);
            this.gcKdvBilgileri.Controls.Add(this.lblSatisKdv);
            this.gcKdvBilgileri.Controls.Add(this.txtSatisKdv);
            this.gcKdvBilgileri.Location = new System.Drawing.Point(285, 135);
            this.gcKdvBilgileri.Size = new System.Drawing.Size(260, 100);
            this.gcKdvBilgileri.Text = "KDV Bilgileri %";

            // lblAlisKdv
            this.lblAlisKdv.Location = new System.Drawing.Point(15, 35);
            this.lblAlisKdv.Text = "Alış KDV :";
            // txtAlisKdv
            this.txtAlisKdv.Location = new System.Drawing.Point(85, 32);
            this.txtAlisKdv.Size = new System.Drawing.Size(150, 20);
            // lblSatisKdv
            this.lblSatisKdv.Location = new System.Drawing.Point(15, 65);
            this.lblSatisKdv.Text = "Satış KDV :";
            // txtSatisKdv
            this.txtSatisKdv.Location = new System.Drawing.Point(85, 62);
            this.txtSatisKdv.Size = new System.Drawing.Size(150, 20);

            // btnKaydet
            this.btnKaydet.Location = new System.Drawing.Point(270, 380);
            this.btnKaydet.Size = new System.Drawing.Size(90, 40);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.ImageOptions.ImageUri.Uri = "apply";
            
            // btnSil
            this.btnSil.Location = new System.Drawing.Point(370, 380);
            this.btnSil.Size = new System.Drawing.Size(90, 40);
            this.btnSil.Text = "Sil";
            this.btnSil.ImageOptions.ImageUri.Uri = "cancel";

            // btnKapat
            this.btnKapat.Location = new System.Drawing.Point(470, 380);
            this.btnKapat.Size = new System.Drawing.Size(90, 40);
            this.btnKapat.Text = "Kapat";
            this.btnKapat.ImageOptions.ImageUri.Uri = "close";

            // frmStokKarti
            this.ClientSize = new System.Drawing.Size(584, 431);
            this.Controls.Add(this.gcAnaStok);
            this.Controls.Add(this.gcGenelStok);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKapat);
            this.Name = "frmStokKarti";
            this.Text = "Stok Açılış Kartı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.gcAnaStok)).EndInit();
            this.gcAnaStok.ResumeLayout(false);
            this.gcAnaStok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peStokResmi.Properties)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.gcGenelStok)).EndInit();
            this.gcGenelStok.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.gcGrupBilgileri)).EndInit();
            this.gcGrupBilgileri.ResumeLayout(false);
            this.gcGrupBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdi.Properties)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.gcFiyatBilgileri)).EndInit();
            this.gcFiyatBilgileri.ResumeLayout(false);
            this.gcFiyatBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisFiyati.Properties)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.gcBarkodBirim)).EndInit();
            this.gcBarkodBirim.ResumeLayout(false);
            this.gcBarkodBirim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.gcKdvBilgileri)).EndInit();
            this.gcKdvBilgileri.ResumeLayout(false);
            this.gcKdvBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlisKdv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisKdv.Properties)).EndInit();

            this.ResumeLayout(false);
        }

        private DevExpress.XtraEditors.GroupControl gcAnaStok;
        private DevExpress.XtraEditors.LabelControl lblStokKodu;
        private DevExpress.XtraEditors.ButtonEdit txtStokKodu;
        private DevExpress.XtraEditors.LabelControl lblStokAdi;
        private DevExpress.XtraEditors.TextEdit txtStokAdi;
        private DevExpress.XtraEditors.PictureEdit peStokResmi;

        private DevExpress.XtraEditors.GroupControl gcGenelStok;
        private DevExpress.XtraEditors.GroupControl gcGrupBilgileri;
        private DevExpress.XtraEditors.LabelControl lblGrupKodu;
        private DevExpress.XtraEditors.ButtonEdit txtGrupKodu;
        private DevExpress.XtraEditors.LabelControl lblGrupAdi;
        private DevExpress.XtraEditors.TextEdit txtGrupAdi;

        private DevExpress.XtraEditors.GroupControl gcFiyatBilgileri;
        private DevExpress.XtraEditors.LabelControl lblAlisFiyati;
        private DevExpress.XtraEditors.TextEdit txtAlisFiyati;
        private DevExpress.XtraEditors.LabelControl lblSatisFiyati;
        private DevExpress.XtraEditors.TextEdit txtSatisFiyati;

        private DevExpress.XtraEditors.GroupControl gcBarkodBirim;
        private DevExpress.XtraEditors.LabelControl lblBirim;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBirim;
        private DevExpress.XtraEditors.LabelControl lblBarkod;
        private DevExpress.XtraEditors.TextEdit txtBarkod;

        private DevExpress.XtraEditors.GroupControl gcKdvBilgileri;
        private DevExpress.XtraEditors.LabelControl lblAlisKdv;
        private DevExpress.XtraEditors.TextEdit txtAlisKdv;
        private DevExpress.XtraEditors.LabelControl lblSatisKdv;
        private DevExpress.XtraEditors.TextEdit txtSatisKdv;

        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}
