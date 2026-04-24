namespace StokProjesi
{
    partial class frmCariListesi
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControlArama = new DevExpress.XtraEditors.GroupControl();
            
            this.lblCariKodu = new DevExpress.XtraEditors.LabelControl();
            this.txtCariKodu = new DevExpress.XtraEditors.TextEdit();
            this.lblCariAdi = new DevExpress.XtraEditors.LabelControl();
            this.txtCariAdi = new DevExpress.XtraEditors.TextEdit();
            this.lblCariGrup = new DevExpress.XtraEditors.LabelControl();
            this.txtCariGrup = new DevExpress.XtraEditors.TextEdit();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();

            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCariKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCariGrup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiDairesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();

            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlArama)).BeginInit();
            this.groupControlArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariGrup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();

            // splitContainerControl1
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControlArama);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(800, 450);
            this.splitContainerControl1.SplitterPosition = 200;

            // groupControlArama
            this.groupControlArama.Text = "Arama";
            this.groupControlArama.Controls.Add(this.btnTemizle);
            this.groupControlArama.Controls.Add(this.btnAra);
            this.groupControlArama.Controls.Add(this.txtCariGrup);
            this.groupControlArama.Controls.Add(this.lblCariGrup);
            this.groupControlArama.Controls.Add(this.txtCariAdi);
            this.groupControlArama.Controls.Add(this.lblCariAdi);
            this.groupControlArama.Controls.Add(this.txtCariKodu);
            this.groupControlArama.Controls.Add(this.lblCariKodu);
            this.groupControlArama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlArama.Location = new System.Drawing.Point(0, 0);
            this.groupControlArama.Name = "groupControlArama";
            this.groupControlArama.Size = new System.Drawing.Size(200, 450);

            // lblCariKodu
            this.lblCariKodu.Location = new System.Drawing.Point(10, 35);
            this.lblCariKodu.Name = "lblCariKodu";
            this.lblCariKodu.Text = "Cari Kodu";

            // txtCariKodu
            this.txtCariKodu.Location = new System.Drawing.Point(10, 55);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.Size = new System.Drawing.Size(170, 20);

            // lblCariAdi
            this.lblCariAdi.Location = new System.Drawing.Point(10, 85);
            this.lblCariAdi.Name = "lblCariAdi";
            this.lblCariAdi.Text = "Cari Adı";

            // txtCariAdi
            this.txtCariAdi.Location = new System.Drawing.Point(10, 105);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(170, 20);

            // lblCariGrup
            this.lblCariGrup.Location = new System.Drawing.Point(10, 135);
            this.lblCariGrup.Name = "lblCariGrup";
            this.lblCariGrup.Text = "Cari Grup";

            // txtCariGrup
            this.txtCariGrup.Location = new System.Drawing.Point(10, 155);
            this.txtCariGrup.Name = "txtCariGrup";
            this.txtCariGrup.Size = new System.Drawing.Size(170, 20);

            // btnAra
            this.btnAra.Location = new System.Drawing.Point(10, 195);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(80, 30);
            this.btnAra.Text = "Ara";
            this.btnAra.ImageOptions.ImageUri.Uri = "zoom";
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);

            // btnTemizle
            this.btnTemizle.Location = new System.Drawing.Point(100, 195);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(80, 30);
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.ImageOptions.ImageUri.Uri = "clear";
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);

            // gridControl1
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(590, 450);
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});

            // gridView1
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCariKodu,
            this.colCariAdi,
            this.colCariGrup,
            this.colVergiDairesi,
            this.colVergiNo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;

            // colCariKodu
            this.colCariKodu.Caption = "CARİ KODU";
            this.colCariKodu.FieldName = "CariKodu";
            this.colCariKodu.Name = "colCariKodu";
            this.colCariKodu.Visible = true;
            this.colCariKodu.VisibleIndex = 0;

            // colCariAdi
            this.colCariAdi.Caption = "CARİ ADI";
            this.colCariAdi.FieldName = "CariAdi";
            this.colCariAdi.Name = "colCariAdi";
            this.colCariAdi.Visible = true;
            this.colCariAdi.VisibleIndex = 1;

            // colCariGrup
            this.colCariGrup.Caption = "CARİ GRUP";
            this.colCariGrup.FieldName = "CariGrup";
            this.colCariGrup.Name = "colCariGrup";
            this.colCariGrup.Visible = true;
            this.colCariGrup.VisibleIndex = 2;

            // colVergiDairesi
            this.colVergiDairesi.Caption = "VERGİ DAİRESİ";
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.Visible = true;
            this.colVergiDairesi.VisibleIndex = 3;

            // colVergiNo
            this.colVergiNo.Caption = "VERGİ NO";
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.Visible = true;
            this.colVergiNo.VisibleIndex = 4;

            // frmCariListesi
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmCariListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Listesi";
            this.Load += new System.EventHandler(this.frmCariListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlArama)).EndInit();
            this.groupControlArama.ResumeLayout(false);
            this.groupControlArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariGrup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControlArama;
        private DevExpress.XtraEditors.LabelControl lblCariKodu;
        private DevExpress.XtraEditors.TextEdit txtCariKodu;
        private DevExpress.XtraEditors.LabelControl lblCariAdi;
        private DevExpress.XtraEditors.TextEdit txtCariAdi;
        private DevExpress.XtraEditors.LabelControl lblCariGrup;
        private DevExpress.XtraEditors.TextEdit txtCariGrup;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCariKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colCariAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colCariGrup;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiNo;
    }
}
