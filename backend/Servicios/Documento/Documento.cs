using backend.Servicios.Documento.Design;
using iTextSharp.text.pdf;
using iTextSharp.text;
using backend.Dominio;
using System.Xml.Linq;

namespace backend.Servicios.Documento
{
    public class Documento
    {
        private Proyecto proyecto;

        public Documento(Proyecto proyecto)
        {
            this.proyecto = proyecto;
        }

        public byte[] CrearPDF()
        {
            MemoryStream pdfData = new MemoryStream();
            Document document = new Document(PageSize.Letter, 50, 50, 90, 90);
            PdfWriter pdfWriter = PdfWriter.GetInstance(document, pdfData);
            pdfWriter.ViewerPreferences = PdfWriter.PageModeUseOutlines;
            PlantillaDocumento PageEventHandler = new();
            pdfWriter.PageEvent = PageEventHandler;
            PageEventHandler.Title = "Cotización Grupo Ingeniería";
            PageEventHandler.HeaderLeft = "Group";
            PageEventHandler.HeaderRight = "1";
            document.Open();
            pdfWriter.SetLinearPageMode();
            document.Add(Encabezado);
            document.Add(Conceptos);
            document.Add(Condiciones);
            document.Close();
            byte[] Archivo = pdfData.ToArray();
            string rutaArchivo = "Cotizacion.pdf";
            File.WriteAllBytes(rutaArchivo, Archivo);
            return Archivo;
        }

        public IElement Encabezado {
            get
            {
                PdfPTable tabla = new PdfPTable(12);
                tabla.WidthPercentage = 100;
                FuncionesPdf.celda(tabla, 6, 1, false, false, false, false, 16f, "", PdfCell.ALIGN_LEFT, PdfCell.ALIGN_CENTER, $"Cliente: {proyecto.Cliente.Empresa}", 10, "N", Font.NORMAL);
                FuncionesPdf.celda(tabla, 6, 1, false, false, false, false, 16, "", PdfCell.ALIGN_RIGHT, PdfCell.ALIGN_CENTER, $"Fecha: {proyecto.Fecha.ToString("dd-MM-yyyy")}", 10, "N", Font.NORMAL);
                FuncionesPdf.celda(tabla, 6, 1, false, false, false, false, 16f, "", PdfCell.ALIGN_LEFT, PdfCell.ALIGN_CENTER, $"Contacto: {proyecto.Cliente.Contacto.Nombre}", 10, "N", Font.NORMAL);
                FuncionesPdf.celda(tabla, 6, 1, false, false, false, false, 16f, "", PdfCell.ALIGN_RIGHT, PdfCell.ALIGN_CENTER, $"Cotizacion:{proyecto.Id}", 10, "N", Font.NORMAL);
                FuncionesPdf.celda(tabla, 6, 1, false, false, false, false, 16f, "", PdfCell.ALIGN_LEFT, PdfCell.ALIGN_CENTER, $"Email: {proyecto.Cliente.Contacto.Correo}", 10, "N", Font.NORMAL);
                FuncionesPdf.celda(tabla, 6, 1, false, false, false, false, 16f, "", PdfCell.ALIGN_RIGHT, PdfCell.ALIGN_CENTER, "", 10, "N", Font.NORMAL);
                FuncionesPdf.celda(tabla, 12, 1, false, false, false, false, 16f, "", PdfCell.ALIGN_RIGHT, PdfCell.ALIGN_CENTER, "", 10, "N", Font.NORMAL);
                FuncionesPdf.celda(tabla, 12, 1, false, false, false, false, 16f, "", PdfCell.ALIGN_LEFT, PdfCell.ALIGN_CENTER, "Conforme a su solicitud, me permito presentar a usted la siguiente:", 10, "N", Font.NORMAL);
                FuncionesPdf.celda(tabla, 12, 1, false, false, false, false, 16f, "", PdfCell.ALIGN_JUSTIFIED_ALL, PdfCell.ALIGN_CENTER, "", 10, "N", Font.NORMAL);
                FuncionesPdf.celda(tabla, 12, 1, false, false, false, false, 16f, "G", PdfCell.ALIGN_CENTER, PdfCell.ALIGN_MIDDLE, "COTIZACION", 10, "N", Font.NORMAL);
                return tabla;
            }
        }
        public IElement Conceptos { get { 
            PdfPTable tabla = new PdfPTable(20);
            tabla.WidthPercentage = 100;
            FuncionesPdf.celda(tabla, 1, 1, true, true, true, true, 18f, "", PdfCell.ALIGN_CENTER, PdfCell.ALIGN_CENTER, "Part.", 8, "N", Font.BOLD);
            FuncionesPdf.celda(tabla, 11, 1, true, true, true, true, 18f, "", PdfCell.ALIGN_CENTER, PdfCell.ALIGN_CENTER, "Concepto", 8, "N", Font.BOLD);
            FuncionesPdf.celda(tabla, 2, 1, true, true, true, true, 18f, "", PdfCell.ALIGN_CENTER, PdfCell.ALIGN_CENTER, "Unidad", 8, "N", Font.BOLD);
            FuncionesPdf.celda(tabla, 2, 1, true, true, true, true, 18f, "", PdfCell.ALIGN_CENTER, PdfCell.ALIGN_CENTER, "Cantidad", 8, "N", Font.BOLD);
            FuncionesPdf.celda(tabla, 2, 1, true, true, true, true, 18f, "", PdfCell.ALIGN_CENTER, PdfCell.ALIGN_CENTER, "Unitario", 8, "N", Font.BOLD);
            FuncionesPdf.celda(tabla, 2, 1, true, true, true, true, 18f, "", PdfCell.ALIGN_CENTER, PdfCell.ALIGN_CENTER, "Importe", 8, "N", Font.BOLD);
            int i = 1;
            foreach (var concepto in proyecto.ConceptosCotizacion) {
                string unidad = "";
                if (concepto.ClasificacionCosto.Equals("Materiales"))
                    unidad = ((Material) concepto).Unidad;
                FuncionesPdf.celda(tabla, 1, 1, true, true, true, true, 22f, "", PdfCell.ALIGN_CENTER, PdfCell.ALIGN_MIDDLE, $"{i++}", 8, "N", Font.NORMAL);
                FuncionesPdf.celda(tabla, 11, 1, true, true, true, true, 22f, "", PdfCell.ALIGN_LEFT, PdfCell.ALIGN_MIDDLE, $"{concepto.Concepto}", 8, "N", Font.NORMAL);
                FuncionesPdf.celda(tabla, 2, 1, true, true, true, true, 22f, "", PdfCell.ALIGN_CENTER, PdfCell.ALIGN_MIDDLE, $"{unidad}", 8, "N", Font.NORMAL);
                FuncionesPdf.celda(tabla, 2, 1, true, true, true, true, 22f, "", PdfCell.ALIGN_CENTER, PdfCell.ALIGN_MIDDLE, $"{concepto.Cantidad}", 8, "N", Font.NORMAL);
                FuncionesPdf.celda(tabla, 2, 1, true, true, true, true, 22f, "", PdfCell.ALIGN_CENTER, PdfCell.ALIGN_MIDDLE, $"{concepto.VentaUnitario.ToString("C")}", 8, "N", Font.NORMAL);
                FuncionesPdf.celda(tabla, 2, 1, true, true, true, true, 22f, "", PdfCell.ALIGN_CENTER, PdfCell.ALIGN_MIDDLE, $"{concepto.TotalConcepto.ToString("C")}", 8, "N", Font.NORMAL);
            }
            return tabla;
            }
        }
        public IElement Condiciones {
            get
            {
                PdfPTable tabla = new PdfPTable(16);
                tabla.WidthPercentage = 100;
                FuncionesPdf.celda(tabla, 1, 1, true, true, false, true, 12f, "", PdfCell.ALIGN_CENTER, PdfCell.ALIGN_CENTER, "---", 8, "N", Font.NORMAL);
                return tabla;
            }
        }
    }
}
