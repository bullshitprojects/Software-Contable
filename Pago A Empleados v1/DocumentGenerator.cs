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
using iText.Kernel.Font;
using iText.IO.Font;

namespace SistemaDePagoEmpleados
{
    class DocumentGenerator
    {
        static iText.Kernel.Colors.Color subNavy = new DeviceRgb(209, 224, 235);
        static iText.Kernel.Colors.Color navy = new DeviceRgb(44, 59, 84);
        static iText.Kernel.Colors.Color light = new DeviceRgb(237, 237, 237);
        static PdfFont normal = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA);
        static PdfFont bold = PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.HELVETICA_BOLD);
        public String path;

        static Dictionary<int, string> meses = new Dictionary<int, string>
        {
            {1, "Enero" },
            {2, "Febrero" },
            {3, "Marzo" },
            {4, "Abril" },
            {5, "Mayo" },
            {6, "Junio" },
            {7, "Julio" },
            {8, "Agosto" },
            {9, "Septiembre" },
            {10, "Octubre" },
            {11, "Noviembre" },
            {12, "Diciembre" }
        };
        //Creando un diccionario de estilos
        Dictionary<int, Style> estilos = new Dictionary<int, Style>
        {
            //Boleta de pago
            //Titulo
            { 1, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontSize(14).SetTextAlignment(TextAlignment.CENTER) },
            //fondo azul oscuro alineamiento derecha
            {2, new Style().SetBackgroundColor(navy).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.WHITE).SetFontSize(12).SetTextAlignment(TextAlignment.RIGHT) },
            //fondo gris claro alineamiento izquierda
            {3, new Style().SetBackgroundColor(light).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT) },
            //fondo gris claro alineamiento derecha
            {4, new Style().SetBackgroundColor(light).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetTextAlignment(TextAlignment.RIGHT) },
            //fondo azul claro alineamiento izquierda
            {5, new Style().SetBackgroundColor(subNavy).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT) },
            //fondo azul claro alineamiento derecha
            {6, new Style().SetBackgroundColor(subNavy).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetTextAlignment(TextAlignment.RIGHT) },
            //fondo azul claro alineamiento centro
            {7, new Style().SetBackgroundColor(subNavy).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetTextAlignment(TextAlignment.RIGHT) },          
            //fondo gris alineamiento izquierda
            {8, new Style().SetBackgroundColor(ColorConstants.LIGHT_GRAY).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT) },
            //fondo gris alineamiento derecha
            {9, new Style().SetBackgroundColor(ColorConstants.LIGHT_GRAY).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetTextAlignment(TextAlignment.RIGHT) },
            //sección de firmas
            { 10, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER).SetFontColor(ColorConstants.BLACK) },
            //fecha
            {11, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontSize(8).SetFontColor(ColorConstants.BLACK).SetTextAlignment(TextAlignment.LEFT) },
            //original - Copia
            {12, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontSize(8).SetFontColor(ColorConstants.BLACK).SetTextAlignment(TextAlignment.RIGHT) },
            //espacios
            {13, new Style().SetBorder(Border.NO_BORDER).SetBackgroundColor(ColorConstants.WHITE).SetTextAlignment(TextAlignment.CENTER).SetFontSize(14) },
            //fondo azul oscuro alineamiento derecha
            {14, new Style().SetBackgroundColor(navy).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.WHITE).SetFontSize(12).SetTextAlignment(TextAlignment.LEFT) },
            //DEFINICION DE ESTILOS PARA LA CONSTANCIA
            //TITULO CENTRADO
            {100, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetFont(normal).SetTextAlignment(TextAlignment.CENTER) },
            //TEXTO NORMAL JUSTIFICADO
            {101, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetFont(normal).SetTextAlignment(TextAlignment.JUSTIFIED) },
            //TEXTO NORMAL ALINEAMIENTO IZQUIERDA
            {102, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetFont(normal).SetTextAlignment(TextAlignment.LEFT) },
            //TEXTO NEGRITA ALINEAMIENTO IZQUIERDA
            {103, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetFont(bold).SetTextAlignment(TextAlignment.LEFT) },
            //TEXTO NEGRITA ALINEAMIENTO DERECHA
            {104, new Style().SetBackgroundColor(ColorConstants.WHITE).SetBorder(Border.NO_BORDER).SetFontColor(ColorConstants.BLACK).SetFontSize(12).SetFont(bold).SetTextAlignment(TextAlignment.RIGHT) }

        };

        public void generarBoleta(String cargo, String mes, String emp, double salario, double afp, double isss, double renta, double tdedudc, double salarioN, String tramo, double boni = 0)
        {

            var exportFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = System.IO.Path.Combine(exportFolder, "Boleta de pago - " + emp + " - " + mes + ".pdf");

            using (var writer = new PdfWriter(path))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf, PageSize.A4.Rotate());
                    doc.SetMargins(35, 35, 35, 35);
                    double subtotal = salario + boni;
                    double subtotal2 = isss + afp + renta;
                    Table tabla = new Table(new float[7]).UseAllAvailableWidth();
                    Cell head = new Cell(1, 3).Add(new Paragraph("Boleta de pago")).AddStyle(estilos[1]);
                    tabla.AddCell(head);
                    head = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(head);
                    Cell head2 = new Cell(1, 3).Add(new Paragraph("Boleta de pago")).AddStyle(estilos[1]);
                    tabla.AddCell(head2);
                    head = new Cell(1, 7).Add(new Paragraph("\n")).AddStyle(estilos[13]);
                    tabla.AddCell(head);
                    Cell contenido = new Cell(1, 1).Add(new Paragraph("Mes:")).AddStyle(estilos[2]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph(mes)).AddStyle(estilos[4]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph("Mes:")).AddStyle(estilos[2]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph(mes)).AddStyle(estilos[4]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Empleado:")).AddStyle(estilos[2]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph(emp)).AddStyle(estilos[4]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph("Empleado:")).AddStyle(estilos[2]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph(emp)).AddStyle(estilos[4]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Cargo:")).AddStyle(estilos[2]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph(cargo)).AddStyle(estilos[4]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph("Cargo:")).AddStyle(estilos[2]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph(cargo)).AddStyle(estilos[4]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("Salario Mensual:")).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + salario)).AddStyle(estilos[6]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 2).Add(new Paragraph("Salario Mensual:")).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + salario)).AddStyle(estilos[6]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Bonificación:")).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("$ " + boni)).AddStyle(estilos[6]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph("Bonificación:")).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("$ " + boni)).AddStyle(estilos[6]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 3).Add(new Paragraph("\n")).AddStyle(estilos[3]);
                    tabla.AddCell(head);
                    head = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 3).Add(new Paragraph("\n")).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[8]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Sub Total")).AddStyle(estilos[8]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + subtotal)).AddStyle(estilos[9]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[8]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Sub Total")).AddStyle(estilos[8]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + subtotal)).AddStyle(estilos[9]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 3).Add(new Paragraph("Deducciones (-)")).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 3).Add(new Paragraph("Deducciones (-)")).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("AFP")).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + afp)).AddStyle(estilos[4]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("AFP")).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + afp)).AddStyle(estilos[4]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("ISSS")).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + isss)).AddStyle(estilos[4]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("ISSS")).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + isss)).AddStyle(estilos[4]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Renta")).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + renta)).AddStyle(estilos[4]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Renta")).AddStyle(estilos[3]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + renta)).AddStyle(estilos[4]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[8]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Sub Total")).AddStyle(estilos[8]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + subtotal2)).AddStyle(estilos[9]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[8]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Sub Total")).AddStyle(estilos[8]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + subtotal2)).AddStyle(estilos[9]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 7).Add(new Paragraph("\n")).AddStyle(estilos[13]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[14]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Total a Pagar")).AddStyle(estilos[14]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + salarioN)).AddStyle(estilos[2]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[14]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Total a Pagar")).AddStyle(estilos[14]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + salarioN)).AddStyle(estilos[2]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Observaciones:")).AddStyle(estilos[7]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph(tramo)).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Observaciones:")).AddStyle(estilos[7]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph(tramo)).AddStyle(estilos[5]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 7).Add(new Paragraph("\n")).AddStyle(estilos[13]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 1).Add(new Paragraph("_____________")).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("_____________")).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("_____________")).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("_____________")).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("_____________")).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("_____________")).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Elaboró")).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Autorizado")).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Recibe Conforme")).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Elaboró")).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Autorizado")).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Recibe Conforme")).AddStyle(estilos[10]);
                    tabla.AddCell(contenido);
                    head = new Cell(1, 7).Add(new Paragraph("\n")).AddStyle(estilos[13]);
                    tabla.AddCell(head);
                    contenido = new Cell(1, 2).Add(new Paragraph("Fecha de impresión: " + DateTime.Now.ToString("dd-MM-yyyy"))).AddStyle(estilos[11]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Original")).AddStyle(estilos[12]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[13]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("Fecha de impresión: " + DateTime.Now.ToString("dd-MM-yyyy"))).AddStyle(estilos[11]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Copia - Empleado")).AddStyle(estilos[12]);
                    tabla.AddCell(contenido);
                    doc.Add(tabla);
                    doc.Close();
                }
            }
        }

        public void generarConstancia(String emp, String nit, double totalSalario, double aguinaldo, double totalSalarioGravado, double afp, double isss, double aguinaldoNgravado, double montoGravado, double renta)
        {
            var exportFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path = System.IO.Path.Combine(exportFolder, "Constancia - " + emp + " - " + DateTime.Now.Year.ToString() + ".pdf");
            using (var writer = new PdfWriter(path))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf, PageSize.A4);
                    doc.SetMargins(70, 50, 70, 50);
                    Table tabla = new Table(new float[5]).UseAllAvailableWidth();
                    Cell contenido = new Cell(1, 5).Add(new Paragraph("Sistema Pago A Cuenta S.A de C.V.")).AddStyle(estilos[100]);//Aquí iría el titulo de la sociedad                   
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 5).Add(new Paragraph("\n")).AddStyle(estilos[100]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 5).Add(new Paragraph("\n")).AddStyle(estilos[100]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 5).Add(new Paragraph("El infrascrito agente de retención hace constar que " +
                        emp + " con NIT. " + nit + " en su calidad de empleado de esta empresa, devengó durante el período comprendido entre el 01/01/" + DateTime.Now.Year
                        + " al 31/12/" + DateTime.Now.Year + ", lo siguiente")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 5).Add(new Paragraph("\n")).AddStyle(estilos[100]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 5).Add(new Paragraph("\n")).AddStyle(estilos[100]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 4).Add(new Paragraph("DETALLE")).AddStyle(estilos[103]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 5).Add(new Paragraph("\n")).AddStyle(estilos[100]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("Ingresos gravados/devengado")).AddStyle(estilos[102]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + totalSalario)).AddStyle(estilos[102]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("Aguinaldo")).AddStyle(estilos[102]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + aguinaldo)).AddStyle(estilos[102]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Total, Ingresos Gravados")).AddStyle(estilos[104]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + totalSalarioGravado)).AddStyle(estilos[103]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("Cotización AFP")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("-$ " + afp)).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("Cotización ISSS")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("-$ " + isss)).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("Aguinaldo no Gravado")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("-$ " + aguinaldoNgravado)).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("Monto Gravado")).AddStyle(estilos[104]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + montoGravado)).AddStyle(estilos[103]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 5).Add(new Paragraph("\n")).AddStyle(estilos[100]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 2).Add(new Paragraph("Impuesto sobre la renta")).AddStyle(estilos[104]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph("$ " + renta)).AddStyle(estilos[103]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 1).Add(new Paragraph(" ")).AddStyle(estilos[101]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 5).Add(new Paragraph("\n")).AddStyle(estilos[100]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 5).Add(new Paragraph("\n")).AddStyle(estilos[100]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 5).Add(new Paragraph("Se extiende la presente en la ciudad de San Salvador el  "
                        + DateTime.Now.Day + " de " +  meses[DateTime.Now.Month] + " de "+ DateTime.Now.Year)).AddStyle(estilos[102]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 5).Add(new Paragraph("\n")).AddStyle(estilos[100]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 5).Add(new Paragraph("\n")).AddStyle(estilos[100]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 5).Add(new Paragraph("\n")).AddStyle(estilos[100]);
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 5).Add(new Paragraph("____________________________")).AddStyle(estilos[100]);                   
                    tabla.AddCell(contenido);
                    contenido = new Cell(1, 5).Add(new Paragraph("Departamento Contable")).AddStyle(estilos[100]);
                    tabla.AddCell(contenido);
                    doc.Add(tabla);
                    doc.Close();
                }
            }
        }
    }
}
