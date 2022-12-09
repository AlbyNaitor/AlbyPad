namespace newRepoGonellaAlberto
{
    partial class frmAlbyPad
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlbyPad));
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.homePage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.modificaSection = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiIncolla = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCopia = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTaglia = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonNew = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonOpen = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSave = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSaveAs = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.rbn = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.backstageViewControl1 = new DevExpress.XtraBars.Ribbon.BackstageViewControl();
            this.bvbNuovo = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.bvbApri = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.bvbSalva = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.bvbSalvaConNome = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemZoomTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar();
            this.barButtonEsci = new DevExpress.XtraBars.BarButtonItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.skinDropDownButtonItem2 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.bv = new DevExpress.XtraBars.Ribbon.BackstageViewButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.rbn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb
            // 
            this.rtb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtb.BackColor = System.Drawing.Color.White;
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb.Location = new System.Drawing.Point(163, 272);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(1388, 821);
            this.rtb.TabIndex = 2;
            this.rtb.Text = "";
            this.rtb.TextChanged += new System.EventHandler(this.rtb_TextChanged_1);
            // 
            // homePage
            // 
            this.homePage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.modificaSection});
            this.homePage.Name = "homePage";
            this.homePage.Text = "Home";
            // 
            // modificaSection
            // 
            this.modificaSection.ItemLinks.Add(this.barButtonItem1);
            this.modificaSection.ItemLinks.Add(this.bbiIncolla);
            this.modificaSection.ItemLinks.Add(this.bbiCopia);
            this.modificaSection.ItemLinks.Add(this.bbiTaglia);
            this.modificaSection.Name = "modificaSection";
            this.modificaSection.Text = "Modifica";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 238;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bbiIncolla
            // 
            this.bbiIncolla.Caption = "Incolla";
            this.bbiIncolla.Id = 239;
            this.bbiIncolla.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiIncolla.ImageOptions.SvgImage")));
            this.bbiIncolla.Name = "bbiIncolla";
            this.bbiIncolla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiIncolla_ItemClick);
            // 
            // bbiCopia
            // 
            this.bbiCopia.Caption = "Copia";
            this.bbiCopia.Id = 237;
            this.bbiCopia.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiCopia.ImageOptions.SvgImage")));
            this.bbiCopia.Name = "bbiCopia";
            this.bbiCopia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCopia_ItemClick);
            // 
            // bbiTaglia
            // 
            this.bbiTaglia.Caption = "Taglia";
            this.bbiTaglia.Id = 240;
            this.bbiTaglia.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiTaglia.ImageOptions.SvgImage")));
            this.bbiTaglia.Name = "bbiTaglia";
            this.bbiTaglia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTaglia_ItemClick);
            // 
            // barButtonNew
            // 
            this.barButtonNew.Name = "barButtonNew";
            // 
            // barButtonOpen
            // 
            this.barButtonOpen.Name = "barButtonOpen";
            // 
            // barButtonSave
            // 
            this.barButtonSave.Name = "barButtonSave";
            // 
            // barButtonSaveAs
            // 
            this.barButtonSaveAs.Name = "barButtonSaveAs";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // rbn
            // 
            this.rbn.ApplicationButtonDropDownControl = this.backstageViewControl1;
            this.rbn.ApplicationButtonText = "File";
            this.rbn.AutoHideEmptyItems = true;
            this.rbn.AutoSizeItems = true;
            this.rbn.ExpandCollapseItem.Id = 0;
            this.rbn.ForeColor = System.Drawing.Color.Transparent;
            this.rbn.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.rbn.ExpandCollapseItem,
            this.rbn.SearchEditItem,
            this.barButtonItem1,
            this.barEditItem1,
            this.bbiCopia,
            this.bbiIncolla,
            this.bbiTaglia});
            this.rbn.Location = new System.Drawing.Point(0, 0);
            this.rbn.MaxItemId = 241;
            this.rbn.Name = "rbn";
            this.rbn.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homePage});
            this.rbn.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemZoomTrackBar1});
            this.rbn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019;
            this.rbn.ShowItemCaptionsInCaptionBar = true;
            this.rbn.ShowItemCaptionsInPageHeader = true;
            this.rbn.ShowQatLocationSelector = false;
            this.rbn.Size = new System.Drawing.Size(1712, 219);
            this.rbn.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // backstageViewControl1
            // 
            this.backstageViewControl1.Items.Add(this.bvbNuovo);
            this.backstageViewControl1.Items.Add(this.bvbApri);
            this.backstageViewControl1.Items.Add(this.bvbSalva);
            this.backstageViewControl1.Items.Add(this.bvbSalvaConNome);
            this.backstageViewControl1.Location = new System.Drawing.Point(410, 352);
            this.backstageViewControl1.Name = "backstageViewControl1";
            this.backstageViewControl1.OwnerControl = this.rbn;
            this.backstageViewControl1.Size = new System.Drawing.Size(611, 605);
            this.backstageViewControl1.TabIndex = 4;
            this.backstageViewControl1.VisibleInDesignTime = true;
            // 
            // bvbNuovo
            // 
            this.bvbNuovo.Caption = "Nuovo";
            this.bvbNuovo.Name = "bvbNuovo";
            this.bvbNuovo.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvbNuovo_ItemClick);
            // 
            // bvbApri
            // 
            this.bvbApri.Caption = "Apri";
            this.bvbApri.Name = "bvbApri";
            this.bvbApri.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvbApri_ItemClick);
            // 
            // bvbSalva
            // 
            this.bvbSalva.Caption = "Salva";
            this.bvbSalva.Name = "bvbSalva";
            this.bvbSalva.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvbSalva_ItemClick_1);
            // 
            // bvbSalvaConNome
            // 
            this.bvbSalvaConNome.Caption = "Salva con nome";
            this.bvbSalvaConNome.Name = "bvbSalvaConNome";
            this.bvbSalvaConNome.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvbSalvaConNome_ItemClick);
            // 
            // barEditItem1
            // 
            this.barEditItem1.Edit = null;
            this.barEditItem1.Id = 236;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemZoomTrackBar1
            // 
            this.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1";
            // 
            // barButtonEsci
            // 
            this.barButtonEsci.Name = "barButtonEsci";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // skinDropDownButtonItem2
            // 
            this.skinDropDownButtonItem2.Name = "skinDropDownButtonItem2";
            // 
            // bv
            // 
            this.bv.Name = "bv";
            // 
            // frmAlbyPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1712, 1114);
            this.Controls.Add(this.backstageViewControl1);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.rbn);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAlbyPad";
            this.Text = "AlbyPad ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAlbyPad_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.rbn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backstageViewControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemZoomTrackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Utils.ToolTipController toolTipController1;
        private System.Windows.Forms.RichTextBox rtb;
        private DevExpress.XtraBars.Ribbon.RibbonPage homePage;
        private DevExpress.XtraBars.BarButtonItem barButtonNew;
        private DevExpress.XtraBars.BarButtonItem barButtonOpen;
        private DevExpress.XtraBars.BarButtonItem barButtonSave;
        private DevExpress.XtraBars.BarButtonItem barButtonSaveAs;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonControl rbn;
        private DevExpress.XtraBars.BarButtonItem barButtonEsci;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup modificaSection;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.BackstageViewControl backstageViewControl1;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvbNuovo;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvbApri;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvbSalvaConNome;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar repositoryItemZoomTrackBar1;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bv;
        private DevExpress.XtraBars.Ribbon.BackstageViewButtonItem bvbSalva;
        private DevExpress.XtraBars.BarButtonItem bbiCopia;
        private DevExpress.XtraBars.BarButtonItem bbiIncolla;
        private DevExpress.XtraBars.BarButtonItem bbiTaglia;
    }
}

