using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace backend.Servicios.Documento.Design
{
    public class PlantillaDocumento: PdfPageEventHelper
    {
        private int totalPages;
        protected int counter = 0;
        protected List<PageIndex> toc = new List<PageIndex>();
        PdfContentByte cb;
        PdfTemplate template;
        DateTime PrintTime = DateTime.Now;
        BaseFont bf = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
        public string Title { get; set; }
        public string HeaderLeft { get; set; }
        public string HeaderRight { get; set; }
        public Font HeaderFont { get; set; }
        public Font FooterFont { get; set; }
        public string Seccion { get; set; }
        public int TotalPages
        {
            get
            {
                return totalPages;
            }
        }
        public override void OnGenericTag(PdfWriter writer, Document document, Rectangle rect, string text)
        {
            String name = "dest" + (counter++);
            int page = writer.PageNumber;
            toc.Add(new PageIndex() { Text = text, Name = name, Page = page });
            writer.DirectContent.LocalDestination(name, new PdfDestination(PdfDestination.FITH, rect.GetTop(0)));
        }
        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            try
            {
                PrintTime = DateTime.Now;
                cb = writer.DirectContent;
                template = cb.CreateTemplate(10, 50);
            }
            catch (DocumentException de)
            {
                throw de;
            }
            catch (System.IO.IOException e)
            {
                throw e;
            }
        }
        public override void OnStartPage(PdfWriter writer, Document document)
        {
            base.OnStartPage(writer, document);
            PdfContentByte canvas = writer.DirectContent;
            PdfImportedPage page;
            PdfReader pdfReader = new PdfReader(FuncionesPdf.AppPath() + @"\Plantilla\PlantillaCotizacion.pdf");
            for (int i = 1; i <= pdfReader.NumberOfPages; i++)
            {
                page = writer.GetImportedPage(pdfReader, i);
                canvas.AddTemplate(page, 1f, 0, 0, 1f, 0, 0);
            }
        }

        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            base.OnCloseDocument(writer, document);
            template.BeginText();
            template.SetFontAndSize(bf, 8);
            template.SetTextMatrix(0, 0);
            template.ShowText("");
            template.EndText();
        }

        public List<PageIndex> getTOC()
        {
            return toc;
        }
    }
    public class PageIndex
    {
        public string Text { get; set; }
        public string Name { get; set; }
        public int Page { get; set; }
    }
}
