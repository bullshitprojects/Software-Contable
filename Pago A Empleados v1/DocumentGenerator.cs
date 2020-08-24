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
using System.Drawing;
using iText.Kernel.Colors;
using System.Windows.Forms;

namespace ModernGUI_V3
{
    class DocumentGenerator
    {
        //Creando un diccionario de estilos
        Dictionary<int, Style> estilos = new Dictionary<int, Style>
        { 
            //head
            {1, new Style().SetFontColor(ColorConstants.WHITE).SetFontSize(25).SetBackgroundColor(ColorConstants.DARK_GRAY)},
            //text
            {2, new Style().SetFontSize(14).SetFontColor(ColorConstants.BLACK)}
        };

        public String generarBoleta()
        {
            var exportFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var exportFile = System.IO.Path.Combine(exportFolder, "Boleta de pago - " + "AQUI VA EL MES" + ".pdf");
            //incluir fecha en el reporte
            using (var writer = new PdfWriter(exportFile))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf, PageSize.A4.Rotate());
                    doc.SetMargins(35, 35, 35, 35);
                    doc.Add(new Paragraph("Boleta de empleado").AddStyle(estilos[1]));
                    doc.Close();
                }
            }
            return exportFile.ToString();//Texto que contiene la ruta en donde se ha guardado el archivo
        }

        public String generarConstancia()
        {
            return "";
        }
    }
}
