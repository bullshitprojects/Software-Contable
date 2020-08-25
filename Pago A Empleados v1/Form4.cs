using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernGUI_V3
{
    public partial class Form4 : Form
    {
        Deducciones desc = new Deducciones();
        DeduccionMensual dedMensual = new DeduccionMensual();
        List<DeduccionMensual> dedAnual = new List<DeduccionMensual>();
        double totalAfp = 0, totalRenta = 0, totalIsss = 0, totalGravado = 0, totalSalario = 0,aguinaldo = 0, aguinaldoGravado = 0, aguinaldoNoGravado = 0;



        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
            dedAnual = new List<DeduccionMensual>();
            for (int i = 1; i < 13; i++)
                {
                    desc = new Deducciones();
                    dedMensual = new DeduccionMensual();
                    switch (i)
                    {
                        case 1:
                            dedMensual.mes = "Enero";
                            dedMensual.salarioBruto = Convert.ToDouble(txt1.Text);
                            break;
                        case 2:
                            dedMensual.mes = "Febrero";
                            dedMensual.salarioBruto = Convert.ToDouble(txt2.Text);
                            break;
                        case 3:
                            dedMensual.mes = "Marzo";
                            dedMensual.salarioBruto = Convert.ToDouble(txt3.Text);
                            break;
                        case 4:
                            dedMensual.mes = "Abril";
                            dedMensual.salarioBruto = Convert.ToDouble(txt4.Text);
                            break;
                        case 5:
                            dedMensual.mes = "Mayo";
                            dedMensual.salarioBruto = Convert.ToDouble(txt5.Text);
                            break;
                        case 6:
                            dedMensual.mes = "Junio";
                            dedMensual.salarioBruto = Convert.ToDouble(txt6.Text);
                            break;
                        case 7:
                            dedMensual.mes = "Julio";
                            dedMensual.salarioBruto = Convert.ToDouble(txt7.Text);
                            break;
                        case 8:
                            dedMensual.mes = "Agosto";
                            dedMensual.salarioBruto = Convert.ToDouble(txt8.Text);
                            break;
                        case 9:
                            dedMensual.mes = "Septiembre";
                            dedMensual.salarioBruto = Convert.ToDouble(txt9.Text);
                            break;
                        case 10:
                            dedMensual.mes = "Octubre";
                            dedMensual.salarioBruto = Convert.ToDouble(txt10.Text);
                            break;
                        case 11:
                            dedMensual.mes = "Noviembre";
                            dedMensual.salarioBruto = Convert.ToDouble(txt11.Text);
                            break;
                        case 12:
                            dedMensual.mes = "Diciembre";
                            dedMensual.salarioBruto = Convert.ToDouble(txt12.Text);
                            break;
                        default:

                            break;
                    }
                dedMensual.afp = desc.CalcularAFP(dedMensual.salarioBruto);
                dedMensual.isss = desc.CalcularISSS(dedMensual.salarioBruto);

                aguinaldo = Convert.ToDouble(txt13.Text);

                if (i==12 & aguinaldo > 600)
                {
                    aguinaldoNoGravado = 600;
                    aguinaldoGravado = aguinaldo - 600;
                    dedMensual.renta = desc.CalcularRentaAguinaldo(dedMensual.salarioBruto , aguinaldoGravado);
                }
                else if (i != 12 || aguinaldo <= 600)
                {
                    dedMensual.renta = desc.CalcularRenta(dedMensual.salarioBruto);
                    aguinaldoNoGravado = aguinaldo;
                    aguinaldoGravado = 0;
                    }
                else
                {
                    aguinaldoNoGravado = aguinaldo;
                    aguinaldoGravado = 0;
                }
             
                    dedMensual.salarioGravado = Convert.ToDouble(dedMensual.salarioBruto) - (dedMensual.afp + dedMensual.isss);
                    dedMensual.salario = Convert.ToDouble(dedMensual.salarioGravado - dedMensual.renta);
                    dedAnual.Add(dedMensual);
                }

                //Calculo de totales
                foreach (DeduccionMensual mensual in dedAnual)
                {
                    totalAfp += mensual.afp;
                    totalRenta += mensual.renta;
                    totalIsss += mensual.isss;
                    totalGravado += mensual.salarioGravado;
                    totalSalario += mensual.salarioBruto;
                }

                txtAfp.Text = Convert.ToString(Math.Round(totalAfp,2));
                txtIsss.Text=Convert.ToString(Math.Round(totalIsss, 2));
                txtRenta.Text = Convert.ToString(Math.Round(totalRenta, 2));
                txtAguinaldoNoGravado.Text = Convert.ToString(Math.Round(aguinaldoNoGravado, 2));
                txtMontoGravado.Text = Convert.ToString(Math.Round(totalGravado + aguinaldoGravado, 2));
                txtSalario.Text = Convert.ToString(Math.Round(totalSalario, 2));
                txtAguinaldoGravado.Text = Convert.ToString(Math.Round(aguinaldoGravado, 2));

                //llenado de tablas
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dedAnual;

                deducciones.Visible = true;
                dataGridView1.Visible = true;
            }
           catch (Exception)
            {
                MessageBox.Show("Error... Revisar Los Datos");
            }
        }
    }
}
