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

namespace newRepoGonellaAlberto
{
    public partial class frmAlbyPad : Form
    {
        clsFile fileManager;

        public frmAlbyPad()
        {
            InitializeComponent();
            fileManager = new clsFile();
        }

        #region richiami funzioni

        private void apriToolStripMenuItem_Click(object sender, EventArgs e) => apri();
        private void apriToolStripButton_Click(object sender, EventArgs e) => apri();
        private void rtb_TextChanged(object sender, EventArgs e) => fileManager.Modificato = true;
        private void salvaToolStripButton_Click(object sender, EventArgs e) => salva();
        private void salvaToolStripMenuItem_Click(object sender, EventArgs e) => salva();
        private void salvaconnomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileManager.Modificato)
                salvaConNome();
        }
        private void frmAlbyPad_FormClosing(object sender, FormClosingEventArgs e) 
        {
            if (fileManager.Modificato)
                if (salvaPrimaDi("chiudere"))
                    salva();
        }
        private void nuovoToolStripButton_Click(object sender, EventArgs e) => nuovo();
        private void nuovoToolStripMenuItem_Click(object sender, EventArgs e) => nuovo();
        private void esciToolStripMenuItem_Click(object sender, EventArgs e) => esci();

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

        #endregion
    }
}
