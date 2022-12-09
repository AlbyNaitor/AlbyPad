using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.IO;
using System.Windows.Forms; // per le finestre di dialogo

namespace newRepoGonellaAlberto
{
    class clsFile
    {
        private string filePath;
        private bool modificato;

        //property

        public string FilePath
        {
            get => filePath;
            set => filePath = value;
        }
        public bool Modificato
        {
            get => modificato;
            set => modificato = value;
        }

        //costruttore

        public clsFile()
        {
            FilePath = "";
            Modificato = false;
        }

        //metodi pubblici

        public void apri()
        {
            OpenFileDialog dlgApri = new OpenFileDialog();
            dlgApri.Filter = "Documento|*.rtf|Tutti i file|*.*";
            dlgApri.Title = "AlbyPad - Apri";
            dlgApri.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dlgApri.ShowDialog() == DialogResult.OK)           
                FilePath = dlgApri.FileName;
        }

        public bool chiediSalvaConNome()
        {
            bool isOk;

            SaveFileDialog dlgSalva = new SaveFileDialog();

            dlgSalva.Filter = "Documento|*.rtf;|Tutti i file|*.*";
            dlgSalva.AddExtension = true;
            dlgSalva.Title = "AlbyPad - Salva";
            dlgSalva.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (dlgSalva.ShowDialog() == DialogResult.OK)
            {
                FilePath = dlgSalva.FileName;
                isOk = true;
            }
            else
                isOk = false;

            return isOk;
        }
        
        public string getFileName()
        {
            //ritorna percorso completo
            string s = "";

            if (!string.IsNullOrEmpty(FilePath))          
                s = Path.GetFileName(FilePath);
      
            return filePath == "" ? "Senza nome" : s;
        }
    }
}
