using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace newRepoGonellaAlberto
{
    public class clsStampa
    {
        private PrintDocument prn = new PrintDocument();

        private PageSetupDialog dlgSetup = new PageSetupDialog();
        private PrintDialog dlgStampa = new PrintDialog();
        private PrintPreviewDialog dlgAnteprima = new PrintPreviewDialog();
        private string userText;
        private Font userFont;

        public RichTextBox rtb;

        public clsStampa()
        {
            #region Impostazioni predefinite
            prn.DefaultPageSettings.Margins.Left = 25;
            prn.DefaultPageSettings.Margins.Right = 25;
            prn.DefaultPageSettings.Margins.Top = 18;
            prn.DefaultPageSettings.Margins.Bottom = 18;

            prn.PrinterSettings.Copies = 1;
            #endregion

            dlgSetup.Document = prn;
            dlgAnteprima.Document = prn;
            dlgStampa.Document = prn;

            dlgSetup.EnableMetric = true;

            prn.PrintPage += new PrintPageEventHandler(prn_printPage);  
        }

        private void prn_printPage(object sender, PrintPageEventArgs e)
        {
            SolidBrush b = new SolidBrush(Color.Black);
            int x = prn.DefaultPageSettings.Margins.Left;
            int y = prn.DefaultPageSettings.Margins.Top;
            int w = prn.DefaultPageSettings.PaperSize.Width;
            int h = prn.DefaultPageSettings.PaperSize.Height;

            Rectangle rec = new Rectangle(x, y, w, h);

            float precX = 0;
            float printabile = prn.DefaultPageSettings.PrintableArea.Width - prn.DefaultPageSettings.Margins.Right;

            for (int i = 0; i < rtb.TextLength; i++)
            {
                rtb.Select(i, 1);
                string toPrint = rtb.SelectedText;
                b.Color = rtb.SelectionColor;
                if(toPrint != "\n")
                {
                    e.Graphics.DrawString(toPrint, rtb.SelectionFont, b, rec);

                    float spostamento = rtb.SelectionFont.Size;

                    e.Graphics.TranslateTransform(spostamento, 0);
                    precX += spostamento;
    
                    if(precX >= printabile)
                    {
                        e.Graphics.TranslateTransform(-precX, 20);
                        precX = 0;
                    }
                }
                else
                {
                    e.Graphics.TranslateTransform(-precX, 20);
                    precX = 0;
                }
            }
            Pen penna = new Pen(Color.Transparent, 0);
            e.Graphics.DrawRectangle(penna, rec);
        }

        public void impostaPagina()
        {
            dlgSetup.ShowDialog();
        }

        public void stampa()
        {
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
