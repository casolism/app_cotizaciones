using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace backend.Servicios.Documento.Design
{
    public class FuncionesPdf{
        public static void celda(PdfPTable table, int colspan, int rowspan, bool LeftBorder, bool RightBorder, bool TopBorder, bool BottomBorder, float altoCelda, string ColorDeCelda, int alinearH, int alinearV,
string text, int fontSize, string ColorDeTexto, int estilo = Font.NORMAL){

            TextInfo TextoTipoOracion = CultureInfo.CurrentCulture.TextInfo;
            BaseColor col = ColorDeTexto == "N" ? new BaseColor(106, 106, 106) : ColorDeTexto == "B" ? new BaseColor(255, 255, 255) : ColorDeTexto == "V" ? new BaseColor(49, 108, 157) : ColorDeTexto == "A" ? new BaseColor(0, 255, 255) : new BaseColor(106, 106, 106);
            Font Fuente = new Font(FontFactory.GetFont(BaseFont.HELVETICA, fontSize, estilo, col));
            PdfPCell celda = new PdfPCell(
                new Phrase((text), Fuente)){
                Rowspan = rowspan,
                Colspan = colspan,
                HorizontalAlignment = alinearH,
                FixedHeight = altoCelda,
                VerticalAlignment = alinearV,
                BorderWidthTop = TopBorder ? 0.5f : 0,
                BorderWidthLeft = LeftBorder ? 0.5f : 0,
                BorderWidthRight = RightBorder ? 0.5f : 0,
                BorderWidthBottom = BottomBorder ? 0.5f : 0,
                BorderColor = new BaseColor(106, 106, 106)
            };
            if (ColorDeCelda != "")
                celda.BackgroundColor = ColorDeCelda == "V" ? new BaseColor(0, 140, 149) : ColorDeCelda == "G" ? new BaseColor(242, 242, 242) : ColorDeCelda == "O" ? new BaseColor(83, 86, 90) : new BaseColor(255, 255, 255);
            table.AddCell(celda);
        }

        public static void celda(PdfPTable table, int colspan, int rowspan, bool Border, float altoCelda, string ColorDeCelda, int alinearH, int alinearV,
            string text, int fontSize, string ColorDeTexto, int estilo = Font.NORMAL) {
            celda(table, colspan, rowspan, Border, Border, Border, Border, altoCelda, ColorDeCelda, alinearH, alinearV, text, fontSize, ColorDeTexto, estilo);
        }

        public static void AgregarTabla(PdfPTable tabla, IElement tablaAInsertar, int colspan, int rowspan, bool LeftBorder, bool RightBorder, bool TopBorder, bool BottomBorder, float altoCelda, float ancho, int alinearH, int alinearV)
        {
            TextInfo TextoTipoOracion = CultureInfo.CurrentCulture.TextInfo;
            PdfPCell cell = new PdfPCell()
            {
                Rowspan = rowspan,
                Colspan = colspan,
                HorizontalAlignment = alinearH,
                FixedHeight = altoCelda,
                VerticalAlignment = alinearV,
                BorderWidthTop = TopBorder ? 1 : 0,
                BorderWidthLeft = LeftBorder ? 1 : 0,
                BorderWidthRight = RightBorder ? 1 : 0,
                BorderWidthBottom = BottomBorder ? 1 : 0,
                BorderColor = new BaseColor(106, 106, 106)
            };
            cell.AddElement(tablaAInsertar);
            tabla.AddCell(cell);
        }

        public static void AgregarTabla(PdfPTable tabla, IElement tablaAInsertar, int colspan, int rowspan, bool Border, float altoCelda, float ancho, int alinearH, int alinearV)
        {
            AgregarTabla(tabla, tablaAInsertar, colspan, rowspan, Border, Border, Border, Border, altoCelda, ancho, alinearH, alinearV);
        }
        public static byte[] Paginar(byte[] pdfIn,Font font) {
            using (MemoryStream stream = new MemoryStream())
            {
                PdfReader reader = new PdfReader(pdfIn);
                using (PdfStamper stamper = new (reader, stream))
                {
                    int pages = reader.NumberOfPages;
                    for (int i = 1; i <= pages; i++)
                        ColumnText.ShowTextAligned(stamper.GetOverContent(i), Element.ALIGN_RIGHT, new Phrase($"Hoja {i} de {pages}", font), 560f, 705f, 0);
                }
                return stream.ToArray();
            }
        }
        public static string AppPath()
        {
            string path = System.IO.Path.GetDirectoryName(
               System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            return path.Replace("file:\\", "");
        }
    }
}
