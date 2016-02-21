using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using MyNSpace;

namespace PDFHighlight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Start_Click(System.Object sender, System.EventArgs e)
        {
            lblStatus.Text = "Processing...";
            //Parameter1: Search Text (1 word or many) 
            //Parameter2: Case Sensitiveness
            //Parameter3: Source file with Path 
            //Parameter4: Destination File with Path

            StringComparison casetype = (chkIgnoreCase.Checked) ? StringComparison.CurrentCultureIgnoreCase 
                                                                    : StringComparison.CurrentCulture;
            PDFTextGetter(txtHighLightText.Text, casetype, txtSourcePDF.Text, txtOutputPDF.Text);
            lblStatus.Text = "Processing completed";
        }

        public void PDFTextGetter(string pSearch, StringComparison SC, string SourceFile, string DestinationFile)
        {
            iTextSharp.text.pdf.PdfStamper stamper = null;
            iTextSharp.text.pdf.PdfContentByte cb = null;

            this.Cursor = Cursors.WaitCursor;
            if (File.Exists(SourceFile))
            {
                PdfReader pReader = new PdfReader(SourceFile);

                stamper = new iTextSharp.text.pdf.PdfStamper(pReader, new System.IO.FileStream(DestinationFile, FileMode.Create));
                PB.Value = 0;
                PB.Maximum = pReader.NumberOfPages;
                for (int page = 1; page <= pReader.NumberOfPages; page++)
                {
                    myLocationTextExtractionStrategy strategy = new myLocationTextExtractionStrategy();
                    cb = stamper.GetUnderContent(page);

                    //Send some data contained in PdfContentByte, looks like the first is always cero for me and the second 100, but i'm not sure if this could change in some cases
                    strategy.UndercontentCharacterSpacing = cb.CharacterSpacing;
                    strategy.UndercontentHorizontalScaling = cb.HorizontalScaling;

                    //It's not really needed to get the text back, but we have to call this line ALWAYS, 
                    //because it triggers the process that will get all chunks from PDF into our strategy Object
                    string currentText = PdfTextExtractor.GetTextFromPage(pReader, page, strategy);

                    //The real getter process starts in the following line
                    List<iTextSharp.text.Rectangle> MatchesFound = strategy.GetTextLocations(pSearch, SC);

                    //Set the fill color of the shapes, I don't use a border because it would make the rect bigger
                    //but maybe using a thin border could be a solution if you see the currect rect is not big enough to cover all the text it should cover
                    cb.SetColorFill(BaseColor.PINK);

                    //MatchesFound contains all text with locations, so do whatever you want with it, this highlights them using PINK color:

                    foreach (iTextSharp.text.Rectangle rect in MatchesFound)
                    {
                        cb.Rectangle(rect.Left, rect.Bottom, rect.Width, rect.Height);
                    }
                    cb.Fill();

                    PB.Value = PB.Value + 1;

                }
                stamper.Close();
                pReader.Close();

            }
            this.Cursor = Cursors.Default;

        }

        public string ReadPdfFile(string fileName)
        {
            StringBuilder text = new StringBuilder();

            if (File.Exists(fileName))
            {
                PdfReader pdfReader = new PdfReader(fileName);

                for (int page = 0; page <= pdfReader.NumberOfPages; page++)
                {
                    myLocationTextExtractionStrategy strategy = new myLocationTextExtractionStrategy();
                    string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

                    currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));
                    text.Append(currentText);
                    pdfReader.Close();
                }
            }
            return text.ToString();
        }

        private void txtSourcePDF_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtSourcePDF.Text = openFileDialog1.FileName;
        }

        private void txtOutputPDF_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PDF Files|*.pdf";
            saveFileDialog1.ShowDialog();
            txtOutputPDF.Text = saveFileDialog1.FileName;

        }


    }
}
