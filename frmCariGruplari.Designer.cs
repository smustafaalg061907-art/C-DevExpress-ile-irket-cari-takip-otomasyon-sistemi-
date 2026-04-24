namespace StokProjesi
{
    partial class frmCariGruplari
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
            groupControl1 = new DevExpress.XtraEditors.GroupControl();
            lblGrupKodu = new DevExpress.XtraEditors.LabelControl();
            txtGrupKodu = new DevExpress.XtraEditors.TextEdit();
            lblGrupAdi = new DevExpress.XtraEditors.LabelControl();
            txtGrupAdi = new DevExpress.XtraEditors.TextEdit();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            colGrupKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            colGrupAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControlBottom = new DevExpress.XtraEditors.PanelControl();
            btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            btnSil = new DevExpress.XtraEditors.SimpleButton();
            btnKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)groupControl1).BeginInit();
            groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtGrupKodu.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtGrupAdi.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControlBottom).BeginInit();
            panelControlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // groupControl1
            // 
            groupControl1.Controls.Add(lblGrupKodu);
            groupControl1.Controls.Add(txtGrupKodu);
            groupControl1.Controls.Add(lblGrupAdi);
            groupControl1.Controls.Add(txtGrupAdi);
            groupControl1.Dock = DockStyle.Top;
            groupControl1.Location = new Point(0, 0);
            groupControl1.Margin = new Padding(4, 4, 4, 4);
            groupControl1.Name = "groupControl1";
            groupControl1.Size = new Size(358, 123);
            groupControl1.TabIndex = 2;
            groupControl1.Text = "Grup Bilgisi";
            // 
            // lblGrupKodu
            // 
            lblGrupKodu.Location = new Point(18, 43);
            lblGrupKodu.Margin = new Padding(4, 4, 4, 4);
            lblGrupKodu.Name = "lblGrupKodu";
            lblGrupKodu.Size = new Size(68, 16);
            lblGrupKodu.TabIndex = 0;
            lblGrupKodu.Text = "Grup Kodu :";
            // 
            // txtGrupKodu
            // 
            txtGrupKodu.Location = new Point(111, 39);
            txtGrupKodu.Margin = new Padding(4, 4, 4, 4);
            txtGrupKodu.Name = "txtGrupKodu";
            txtGrupKodu.Size = new Size(233, 22);
            txtGrupKodu.TabIndex = 1;
            // 
            // lblGrupAdi
            // 
            lblGrupAdi.Location = new Point(18, 80);
            lblGrupAdi.Margin = new Padding(4, 4, 4, 4);
            lblGrupAdi.Name = "lblGrupAdi";
            lblGrupAdi.Size = new Size(58, 16);
            lblGrupAdi.TabIndex = 2;
            lblGrupAdi.Text = "Grup Adı :";
            // 
            // txtGrupAdi
            // 
            txtGrupAdi.Location = new Point(111, 76);
            txtGrupAdi.Margin = new Padding(4, 4, 4, 4);
            txtGrupAdi.Name = "txtGrupAdi";
            txtGrupAdi.Size = new Size(233, 22);
            txtGrupAdi.TabIndex = 3;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.EmbeddedNavigator.Margin = new Padding(4, 4, 4, 4);
            gridControl1.Location = new Point(0, 123);
            gridControl1.MainView = gridView1;
            gridControl1.Margin = new Padding(4, 4, 4, 4);
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(358, 250);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colGrupKodu, colGrupAdi });
            gridView1.DetailHeight = 431;
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.FocusedRowChanged += gridView1_FocusedRowChanged;
            // 
            // colGrupKodu
            // 
            colGrupKodu.Caption = "GRUP KODU";
            colGrupKodu.FieldName = "GrupKodu";
            colGrupKodu.MinWidth = 23;
            colGrupKodu.Name = "colGrupKodu";
            colGrupKodu.Visible = true;
            colGrupKodu.VisibleIndex = 0;
            colGrupKodu.Width = 87;
            // 
            // colGrupAdi
            // 
            colGrupAdi.Caption = "GRUP ADI";
            colGrupAdi.FieldName = "GrupAdi";
            colGrupAdi.MinWidth = 23;
            colGrupAdi.Name = "colGrupAdi";
            colGrupAdi.Visible = true;
            colGrupAdi.VisibleIndex = 1;
            colGrupAdi.Width = 87;
            // 
            // panelControlBottom
            // 
            panelControlBottom.Controls.Add(btnKaydet);
            panelControlBottom.Controls.Add(btnSil);
            panelControlBottom.Controls.Add(btnKapat);
            panelControlBottom.Dock = DockStyle.Bottom;
            panelControlBottom.Location = new Point(0, 373);
            panelControlBottom.Margin = new Padding(4, 4, 4, 4);
            panelControlBottom.Name = "panelControlBottom";
            panelControlBottom.Size = new Size(358, 62);
            panelControlBottom.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.ImageOptions.ImageUri.Uri = "apply";
            btnKaydet.Location = new Point(41, 12);
            btnKaydet.Margin = new Padding(4, 4, 4, 4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(93, 37);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.ImageOptions.ImageUri.Uri = "cancel";
            btnSil.Location = new Point(146, 12);
            btnSil.Margin = new Padding(4, 4, 4, 4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(93, 37);
            btnSil.TabIndex = 1;
            btnSil.Text = "Sil";
            btnSil.Click += btnSil_Click;
            // 
            // btnKapat
            // 
            btnKapat.ImageOptions.ImageUri.Uri = "close";
            btnKapat.Location = new Point(251, 12);
            btnKapat.Margin = new Padding(4, 4, 4, 4);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(93, 37);
            btnKapat.TabIndex = 2;
            btnKapat.Text = "Kapat";
            btnKapat.Click += btnKapat_Click;
            // 
            // frmCariGruplari
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 435);
            Controls.Add(gridControl1);
            Controls.Add(panelControlBottom);
            Controls.Add(groupControl1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmCariGruplari";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cari Grupları";
            Load += frmCariGruplari_Load;
            ((System.ComponentModel.ISupportInitialize)groupControl1).EndInit();
            groupControl1.ResumeLayout(false);
            groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtGrupKodu.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtGrupAdi.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControlBottom).EndInit();
            panelControlBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblGrupKodu;
        private DevExpress.XtraEditors.TextEdit txtGrupKodu;
        private DevExpress.XtraEditors.LabelControl lblGrupAdi;
        private DevExpress.XtraEditors.TextEdit txtGrupAdi;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAdi;
        private DevExpress.XtraEditors.PanelControl panelControlBottom;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}
