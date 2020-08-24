using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Geom;

namespace ModernGUI_V3
{
    class DocumentGenerator
    {
        public String generarBoleta(string nombreEmp="", string mes="")
        {
            var exportFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var exportFile = System.IO.Path.Combine(exportFolder, "Boleta de pago - " + mes + ".pdf");
            using (var writer = new PdfWriter(exportFile))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf, PageSize.A4.Rotate());
                    doc.SetMargins(35, 35, 35, 35);
                    doc.Add(new Paragraph("Hola macizo"));
                    doc.Close();
                }
            }
            return exportFile.ToString();
        }
    }
}
