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
using iText.Layout.Properties;
using iText.Layout.Borders;
using Common.Logging.Factory;

namespace ModernGUI_V3
{
    class DocumentGenerator
    {
        static iText.Kernel.Colors.Color subNavy = new DeviceRgb(209, 224, 235);
        static iText.Kernel.Colors.Color navy = new DeviceRgb(44, 59, 84);
        static iText.Kernel.Colors.Color light = new DeviceRgb(237, 237, 237);
        //Creando un diccionario de estilos
        Dictionary<int, Style> estilos = new Dictionary<int, Style>
        { 
            //head
            {1, new Style().SetFontColor(ColorConstants.BLACK).SetFontSize(14).SetTextAlignment(TextAlignment.CENTER)},
            //text
            {2, new Style().SetFontSize(12).SetFontColor(ColorConstants.BLACK)},
            //cell style
            {3, new Style().SetBackgroundColor(navy).SetTextAlignment(TextAlignment.RIGHT).SetBorder(Border.NO_BORDER)},
            //white text 
            {4, new Style().SetFontColor(ColorConstants.WHITE).SetFontSize(12)},
            //cell style 2
            {5, new Style().SetBorder(Border.NO_BORDER).SetBackgroundColor(light).SetTextAlignment(TextAlignment.RIGHT)},
            //cell style 3
            {6, new Style().SetBorder(Border.NO_BORDER).SetBackgroundColor(subNavy).SetTextAlignment(TextAlignment.RIGHT) },
            //cell style 4
            {7, new Style().SetBorder(Border.NO_BORDER).SetBackgroundColor(subNavy).SetTextAlignment(TextAlignment.LEFT)},
            //black text center
            {8, new Style().SetFontColor(ColorConstants.BLACK).SetTextAlignment(TextAlignment.CENTER).SetFontSize(12) },
            //texto derecha
            {9, new Style().SetFontColor(ColorConstants.BLACK).SetTextAlignment(TextAlignment.CENTER).SetFontSize(12) },
            //fila blanca vacia
            {10, new Style().SetBorder(Border.NO_BORDER).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER) },
            //subtotales
            {11, new Style().SetBorder(Border.NO_BORDER).SetBackgroundColor(ColorConstants.LIGHT_GRAY).SetTextAlignment(TextAlignment.LEFT)},
            //subtotales R
            {12, new Style().SetBorder(Border.NO_BORDER).SetBackgroundColor(ColorConstants.LIGHT_GRAY).SetTextAlignment(TextAlignment.RIGHT)},
            //light left
            {13, new Style().SetBorder(Border.NO_BORDER).SetBackgroundColor(light).SetTextAlignment(TextAlignment.LEFT)},
            //navy left
            {14, new Style().SetBackgroundColor(navy).SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER)},
            //fecha
            {15, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontSize(8).SetFontColor(ColorConstants.BLACK).SetTextAlignment(TextAlignment.LEFT) },
            //cell style 4
            {16, new Style().SetBorder(Border.NO_BORDER).SetBackgroundColor(subNavy).SetTextAlignment(TextAlignment.CENTER)},
            {17, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontSize(8).SetFontColor(ColorConstants.BLACK).SetTextAlignment(TextAlignment.RIGHT) },

        };

        public String generarBoleta()
        {
            //String cargo, String mes, String emp, double salario, double boni, double afp, double isss, double renta, double tdedudc, double salarioN
            var exportFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var exportFile = System.IO.Path.Combine(exportFolder, "Boleta de pago - " + "gg" + ".pdf");
            //incluir fecha en el reporte
            using (var writer = new PdfWriter(exportFile))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf, PageSize.A4.Rotate());
                    doc.SetMargins(35, 35, 35, 35);

                    Table tabla = new Table(new float[7]).UseAllAvailableWidth();
                    Cell head = new Cell(1, 3).Add(new Paragraph("Boleta de pago").AddStyle(estilos[1])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    head = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    Cell head2 = new Cell(1, 3).Add(new Paragraph("Boleta de pago").AddStyle(estilos[1])).AddStyle(estilos[10]);
                    tabla.AddCell(head2);
                    head = new Cell(1, 7).Add(new Paragraph("\n").AddStyle(estilos[1])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    Cell contenido = new Cell(1, 1).Add(new Paragraph("Mes:").AddStyle(estilos[4])).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("Enero").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[1])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph("Mes:").AddStyle(estilos[4])).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("Febrero").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Empleado:").AddStyle(estilos[4])).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("Nombre").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[1])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph("Empleado:").AddStyle(estilos[4])).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("Nombre").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Cargo:").AddStyle(estilos[4])).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("Nombre C").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[1])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph("Cargo:").AddStyle(estilos[4])).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("NombreC").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Salario Mensual:").AddStyle(estilos[2])).AddStyle(estilos[7]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("$" + "333").AddStyle(estilos[2])).AddStyle(estilos[6]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[1])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph("Salario Mensual:").AddStyle(estilos[2])).AddStyle(estilos[7]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("$" + "333").AddStyle(estilos[2])).AddStyle(estilos[6]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 3).Add(new Paragraph("\n").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[1])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 3).Add(new Paragraph("\n").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[11]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Sub Total").AddStyle(estilos[2])).AddStyle(estilos[11]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("dinero$").AddStyle(estilos[2])).AddStyle(estilos[12]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[1])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[11]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Sub Total").AddStyle(estilos[2])).AddStyle(estilos[11]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("dinero$").AddStyle(estilos[2])).AddStyle(estilos[12]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 3).Add(new Paragraph("Deducciones (-)").AddStyle(estilos[2])).AddStyle(estilos[7]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 3).Add(new Paragraph("Deducciones (-)").AddStyle(estilos[2])).AddStyle(estilos[7]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("AFP").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Dinero$").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("AFP").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Dinero$").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("ISSS").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Dinero$").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("ISSS").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Dinero$").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Renta").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Dinero$").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Renta").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Dinero$").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Minutos tarde").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Dinero$").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Minutos tarde").AddStyle(estilos[2])).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Dinero$").AddStyle(estilos[2])).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[11]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Sub Total").AddStyle(estilos[2])).AddStyle(estilos[11]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("dinero$").AddStyle(estilos[2])).AddStyle(estilos[12]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[1])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[11]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Sub Total").AddStyle(estilos[2])).AddStyle(estilos[11]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("dinero$").AddStyle(estilos[2])).AddStyle(estilos[12]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 7).Add(new Paragraph("\n").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[14]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Total a Pagar").AddStyle(estilos[4])).AddStyle(estilos[14]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("money$$").AddStyle(estilos[4])).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[1])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[2])).AddStyle(estilos[14]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Total a Pagar").AddStyle(estilos[4])).AddStyle(estilos[14]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("money$$").AddStyle(estilos[4])).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Observaciones:").AddStyle(estilos[2])).AddStyle(estilos[16]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("Aplica el tramoxdxdxd").AddStyle(estilos[2])).AddStyle(estilos[7]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[1])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph("Observaciones:").AddStyle(estilos[2])).AddStyle(estilos[16]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("Aplica el tramoxdxdxd").AddStyle(estilos[2])).AddStyle(estilos[7]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 7).Add(new Paragraph("\n").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph("_____________").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("_____________").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("_____________").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[1])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph("_____________").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("_____________").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("_____________").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Elaboró").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Autorizado").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Recibe Conforme").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[1])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph("Elaboró").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Autorizado").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Recibe Conforme").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 7).Add(new Paragraph("\n").AddStyle(estilos[2])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 2).Add(new Paragraph("Fecha de impresión: " + DateTime.Now.ToString("dd-MM-yyyy"))).AddStyle(estilos[15]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Original")).AddStyle(estilos[17]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ").AddStyle(estilos[1])).AddStyle(estilos[10]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 2).Add(new Paragraph("Fecha de impresión: " + DateTime.Now.ToString("dd-MM-yyyy"))).AddStyle(estilos[15]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Copia - Empleado")).AddStyle(estilos[17]);
                    tabla.AddCell(contenido);
                    doc.Add(tabla);
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
