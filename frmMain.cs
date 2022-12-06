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
                if (MessageBox.Show("Vuoi salvare prima di uscire?",
                    "Salvataggio", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    salva();
                }
        }

        #endregion

        #region implementazione funzioni

        private void apri()
        {
            fileManager.apri();
            rtb.LoadFile(fileManager.FilePath);
        }

        private void salva()
        {
            if (fileManager.Modificato)
                if (fileManager.FilePath != "")
                    rtb.SaveFile(fileManager.FilePath);
                else
                    salvaConNome();                     
        }

        private void salvaConNome()
        {
            if (fileManager.chiediSalvaConNome())
                rtb.SaveFile(fileManager.FilePath);
        }

        #endregion
    }
}
