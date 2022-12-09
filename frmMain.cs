using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using DevExpress.LookAndFeel;
using DevExpress.Office.Crypto;
using DevExpress.XtraBars.Objects;
using DevExpress.XtraBars.Ribbon;

namespace newRepoGonellaAlberto
{
    public partial class frmAlbyPad : Form
    {
        clsFile fileManager;

        public frmAlbyPad()
        {
            InitializeComponent();
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.WXICompact);
            rbn.ToolbarLocation = RibbonQuickAccessToolbarLocation.Hidden;
            fileManager = new clsFile();
        }

        #region richiami funzioni

        private void bvbNuovo_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e) => nuovo();
        private void bvbApri_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e) => apri();
        private void bvbSalva_ItemClick_1(object sender, BackstageViewItemEventArgs e) => salva();
        private void bvbSalvaConNome_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            if (fileManager.Modificato)
                salvaConNome();
        }

        private void rtb_TextChanged_1(object sender, EventArgs e) => fileManager.Modificato = true;
        private void frmAlbyPad_FormClosing(object sender, FormClosingEventArgs e) 
        {
            if (fileManager.Modificato)
                if (salvaPrimaDi("chiudere"))
                    salva();
        }
        private void barButtonEsci_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => esci();

        private void bbiIncolla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => incolla();
        private void bbiCopia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => copia();
        private void bbiTaglia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => taglia();


        #endregion

        #region implementazione funzioni

        private void apri()
        {
            if(salvaPrimaDi("creare un nuovo file"))
                if (fileManager.chiediSalvaConNome())           
                    salva();
            fileManager.apri();
            if(!string.IsNullOrEmpty(fileManager.FilePath))
                rtb.LoadFile(fileManager.FilePath);
        }

        private void salva()
        {
            if (fileManager.Modificato)
                if (!string.IsNullOrEmpty(fileManager.FilePath))
                    rtb.SaveFile(fileManager.FilePath);
                else
                    salvaConNome();                     
        }

        private void salvaConNome()
        {
            if (fileManager.chiediSalvaConNome())
                rtb.SaveFile(fileManager.FilePath);
        }

        private void nuovo()
        {
            if (fileManager.Modificato)
            {
                DialogResult dr = MessageBox.Show("Vuoi salvare prima di creare un nuovo file?", "Salvare", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr != DialogResult.Cancel)
                {
                    if (dr == DialogResult.Yes)
                    {
                        if (fileManager.chiediSalvaConNome())
                            rtb.SaveFile(fileManager.FilePath);
                    }
                    fileManager.Modificato = false;
                    fileManager.FilePath = "";
                    rtb.Clear();
                }
            }
        }

        private void esci() => Close();

        private bool salvaPrimaDi(string domanda) => MessageBox.Show($"Vuoi salvare prima di {domanda}?",
                    "Salvataggio", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes;

        private void taglia() => rtb.Cut();

        private void incolla() => rtb.Paste();

        private void copia() => rtb.Copy();

        #endregion
    }
}
