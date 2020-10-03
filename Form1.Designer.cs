namespace Restaurant
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.UrunlerSayfasi = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flowUrunler = new System.Windows.Forms.FlowLayoutPanel();
            this.MasalarSayfasi = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.flowMasa = new System.Windows.Forms.FlowLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnOde = new DevExpress.XtraEditors.SimpleButton();
            this.txtToplam = new DevExpress.XtraEditors.CalcEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cUrunkodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cUrunadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cBirimi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.UrunlerSayfasi.SuspendLayout();
            this.MasalarSayfasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtToplam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // navigationPane1
            // 
            this.navigationPane1.Appearance.BackColor = System.Drawing.Color.White;
            this.navigationPane1.Appearance.Options.UseBackColor = true;
            this.navigationPane1.Controls.Add(this.UrunlerSayfasi);
            this.navigationPane1.Controls.Add(this.MasalarSayfasi);
            this.navigationPane1.Dock = System.Windows.Forms.DockStyle.Right;
            this.navigationPane1.Location = new System.Drawing.Point(926, 0);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowCollapseButton = false;
            this.navigationPane1.PageProperties.ShowExpandButton = false;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.UrunlerSayfasi,
            this.MasalarSayfasi});
            this.navigationPane1.RegularSize = new System.Drawing.Size(398, 798);
            this.navigationPane1.SelectedPage = this.UrunlerSayfasi;
            this.navigationPane1.Size = new System.Drawing.Size(398, 798);
            this.navigationPane1.TabIndex = 0;
            this.navigationPane1.Text = "navigationPane1";
            // 
            // UrunlerSayfasi
            // 
            this.UrunlerSayfasi.Caption = "Urunler";
            this.UrunlerSayfasi.Controls.Add(this.flowUrunler);
            this.UrunlerSayfasi.Name = "UrunlerSayfasi";
            this.UrunlerSayfasi.Size = new System.Drawing.Size(285, 718);
            // 
            // flowUrunler
            // 
            this.flowUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowUrunler.Location = new System.Drawing.Point(0, 0);
            this.flowUrunler.Name = "flowUrunler";
            this.flowUrunler.Size = new System.Drawing.Size(285, 718);
            this.flowUrunler.TabIndex = 1;
            // 
            // MasalarSayfasi
            // 
            this.MasalarSayfasi.Caption = "Masalar";
            this.MasalarSayfasi.Controls.Add(this.flowMasa);
            this.MasalarSayfasi.Controls.Add(this.groupControl1);
            this.MasalarSayfasi.Name = "MasalarSayfasi";
            this.MasalarSayfasi.Size = new System.Drawing.Size(285, 718);
            // 
            // flowMasa
            // 
            this.flowMasa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flowMasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowMasa.Font = new System.Drawing.Font("Arial Unicode MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flowMasa.Location = new System.Drawing.Point(0, 0);
            this.flowMasa.Name = "flowMasa";
            this.flowMasa.Size = new System.Drawing.Size(285, 549);
            this.flowMasa.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnOde);
            this.groupControl1.Controls.Add(this.txtToplam);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 549);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(285, 169);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "TOPLAM TUTAR";
            // 
            // btnOde
            // 
            this.btnOde.Appearance.BackColor = System.Drawing.Color.Teal;
            this.btnOde.Appearance.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOde.Appearance.Options.UseBackColor = true;
            this.btnOde.Appearance.Options.UseFont = true;
            this.btnOde.Location = new System.Drawing.Point(0, 91);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(285, 68);
            this.btnOde.TabIndex = 1;
            this.btnOde.Text = "ÖDE";
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // txtToplam
            // 
            this.txtToplam.Location = new System.Drawing.Point(0, 45);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Properties.Appearance.BackColor = System.Drawing.Color.Thistle;
            this.txtToplam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtToplam.Properties.Appearance.Options.UseBackColor = true;
            this.txtToplam.Properties.Appearance.Options.UseFont = true;
            this.txtToplam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtToplam.Size = new System.Drawing.Size(285, 40);
            this.txtToplam.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(926, 798);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cUrunkodu,
            this.cUrunadi,
            this.cBirimi,
            this.cMiktar,
            this.cFiyat,
            this.cToplam});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // cUrunkodu
            // 
            this.cUrunkodu.Caption = "Urun Kodu";
            this.cUrunkodu.FieldName = "UrunKodu";
            this.cUrunkodu.MinWidth = 25;
            this.cUrunkodu.Name = "cUrunkodu";
            this.cUrunkodu.OptionsColumn.AllowEdit = false;
            this.cUrunkodu.Visible = true;
            this.cUrunkodu.VisibleIndex = 0;
            this.cUrunkodu.Width = 94;
            // 
            // cUrunadi
            // 
            this.cUrunadi.Caption = "Urun Adi";
            this.cUrunadi.FieldName = "UrunAdi";
            this.cUrunadi.MinWidth = 25;
            this.cUrunadi.Name = "cUrunadi";
            this.cUrunadi.OptionsColumn.AllowEdit = false;
            this.cUrunadi.Visible = true;
            this.cUrunadi.VisibleIndex = 1;
            this.cUrunadi.Width = 94;
            // 
            // cBirimi
            // 
            this.cBirimi.Caption = "Birimi";
            this.cBirimi.FieldName = "Birimi";
            this.cBirimi.MinWidth = 25;
            this.cBirimi.Name = "cBirimi";
            this.cBirimi.OptionsColumn.AllowEdit = false;
            this.cBirimi.Visible = true;
            this.cBirimi.VisibleIndex = 2;
            this.cBirimi.Width = 94;
            // 
            // cMiktar
            // 
            this.cMiktar.Caption = "Miktarı";
            this.cMiktar.FieldName = "Miktar";
            this.cMiktar.MinWidth = 25;
            this.cMiktar.Name = "cMiktar";
            this.cMiktar.Visible = true;
            this.cMiktar.VisibleIndex = 3;
            this.cMiktar.Width = 94;
            // 
            // cFiyat
            // 
            this.cFiyat.Caption = "Birim Fiyatı";
            this.cFiyat.DisplayFormat.FormatString = "C2";
            this.cFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cFiyat.FieldName = "Fiyat";
            this.cFiyat.MinWidth = 25;
            this.cFiyat.Name = "cFiyat";
            this.cFiyat.OptionsColumn.AllowEdit = false;
            this.cFiyat.Visible = true;
            this.cFiyat.VisibleIndex = 4;
            this.cFiyat.Width = 94;
            // 
            // cToplam
            // 
            this.cToplam.Caption = "Toplam";
            this.cToplam.DisplayFormat.FormatString = "C2";
            this.cToplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cToplam.FieldName = "cToplam";
            this.cToplam.MinWidth = 25;
            this.cToplam.Name = "cToplam";
            this.cToplam.OptionsColumn.AllowEdit = false;
            this.cToplam.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "cToplam", "SUM={0:C2}")});
            this.cToplam.UnboundExpression = "[Fiyat] * [Miktar]";
            this.cToplam.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.cToplam.Visible = true;
            this.cToplam.VisibleIndex = 5;
            this.cToplam.Width = 94;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 798);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.navigationPane1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.UrunlerSayfasi.ResumeLayout(false);
            this.MasalarSayfasi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtToplam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage UrunlerSayfasi;
        private System.Windows.Forms.FlowLayoutPanel flowUrunler;
        private DevExpress.XtraBars.Navigation.NavigationPage MasalarSayfasi;
        private System.Windows.Forms.FlowLayoutPanel flowMasa;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn cUrunkodu;
        private DevExpress.XtraGrid.Columns.GridColumn cUrunadi;
        private DevExpress.XtraGrid.Columns.GridColumn cBirimi;
        private DevExpress.XtraGrid.Columns.GridColumn cMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn cFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn cToplam;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CalcEdit txtToplam;
        private DevExpress.XtraEditors.SimpleButton btnOde;
    }
}

