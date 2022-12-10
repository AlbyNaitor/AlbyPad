using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace newRepoGonellaAlberto
{
    public class clsStampa
    {
        //oggetto principale per la gestione della classe
        private PrintDocument prn = new PrintDocument();
        //finestre di dialogo per la configurazione dell'oggetto printDialog

        private PageSetupDialog dlgSetup = new PageSetupDialog();
        private PrintDialog dlgStampa = new PrintDialog();
        private PrintPreviewDialog dlgAnteprima = new PrintPreviewDialog();
        //
        private string userText;
        private Font userFont;

        public clsStampa()
        {
            //parametri di default
            //1 unit = 1/100 di pollice = 0,254mm
            #region Impostazioni predefinite
            prn.DefaultPageSettings.Margins.Left = 79;
            prn.DefaultPageSettings.Margins.Right = 79;
            prn.DefaultPageSettings.Margins.Top = 100;
            prn.DefaultPageSettings.Margins.Bottom = 100;

            prn.PrinterSettings.Copies = 1;
            #endregion

            dlgSetup.Document = prn;
            dlgAnteprima.Document = prn;
            dlgStampa.Document = prn;

            dlgSetup.EnableMetric = true;

            //gestione
            prn.PrintPage += new PrintPageEventHandler(prn_printPage);  
        }

        private void prn_printPage(object sender, PrintPageEventArgs e)
        {
            //viene richiamato in corrispondenza di:
            //-metodo prn.Print()
            //-Ok sull'anteprima di stampa
            //la pagina i stampa è vista come un oggetto grafico sul quale pusso aggire con le GDI+

            SolidBrush b = new SolidBrush(Color.Black);
            int x = prn.DefaultPageSettings.Margins.Left;
            int y = prn.DefaultPageSettings.Margins.Top;
            int w = prn.DefaultPageSettings.PaperSize.Width;
            int h = prn.DefaultPageSettings.PaperSize.Height;

            Rectangle rec = new Rectangle(x, y, w, h);
            //metodo che esegue fisicamente la stampa

            e.Graphics.DrawString(userText, userFont, b, rec);
            //per disegnare il rettangolo

            Pen penna = new Pen(Color.Red, 2);
            e.Graphics.DrawRectangle(penna, rec);
        }

        //metodi pubblici

        public void impostaPagina()
        {
            dlgSetup.ShowDialog();
        }

        public void stampa(string testo, Font carattere)
        {
            userText = testo;
            userFont = carattere;

            DialogResult ris = dlgAnteprima.ShowDialog();
            if (ris == DialogResult.OK)
                prn.Print();
        }

        public void anteprima(string testo, Font carattere)
        {
            userText = testo;
            userFont = carattere;
            dlgAnteprima.ShowDialog();
        }
    }
}
