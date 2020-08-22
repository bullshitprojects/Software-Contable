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
    public partial class Form3 : Form
    {
        Deducciones ded = new Deducciones();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double remuneracionGravada;
                ArrayList recalculo = new ArrayList();
                if (radioButton1.Checked)
                {
                    remuneracionGravada = (Convert.ToDouble(txt1.Text) + Convert.ToDouble(txt2.Text) + Convert.ToDouble(txt3.Text) + Convert.ToDouble(txt4.Text) +
                                                  Convert.ToDouble(txt5.Text) + Convert.ToDouble(txt6.Text));
                    recalculo= ded.Recalculo(remuneracionGravada, 1);

                }
                else
                {
                    remuneracionGravada = (Convert.ToDouble(txt1.Text) + Convert.ToDouble(txt2.Text) + Convert.ToDouble(txt3.Text) + Convert.ToDouble(txt4.Text) +
                                                Convert.ToDouble(txt5.Text) + Convert.ToDouble(txt6.Text) + Convert.ToDouble(txt7.Text) + Convert.ToDouble(txt8.Text) +
                                                Convert.ToDouble(txt9.Text) + Convert.ToDouble(txt10.Text) + Convert.ToDouble(txt11.Text) + Convert.ToDouble(txt12.Text));
                    recalculo= ded.Recalculo(remuneracionGravada, 2);
                }
                deducciones.Visible = true;
                txtTotalRemuneraciones.Text= "$ " + Convert.ToString(Math.Round(remuneracionGravada, 2));
                txtExceso.Text = "$ " + Convert.ToString(Math.Round(Convert.ToDouble(recalculo[0]), 2));
                txtSubTotal.Text = "$ " + Convert.ToString(Math.Round(Convert.ToDouble(recalculo[1]), 2));
                txtPorcentaje.Text = "$ " + Convert.ToString(Math.Round(Convert.ToDouble(recalculo[2]), 2));
                txtCuotaFija.Text = "$ " + Convert.ToString(Math.Round(Convert.ToDouble(recalculo[3]), 2));
                txtTotalRetencion.Text = "$ " + Convert.ToString(Math.Round(Convert.ToDouble(recalculo[4]), 2));
            }
            catch (Exception)
            {
                MessageBox.Show(Convert.ToString("Ingresa Todos Los campos requeridos"));
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            semestre2.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";
            txt10.Text = "";
            txt11.Text = "";
            txt12.Text = "";
            semestre2.Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";
            txt10.Text = "";
            txt11.Text = "";
            txt12.Text = "";
            txtTotalRemuneraciones.Text = "";
            txtExceso.Text = "";
            txtSubTotal.Text = "";
            txtPorcentaje.Text = "";
            txtCuotaFija.Text = "";
            txtTotalRetencion.Text = "";
            deducciones.Visible = false;
        }
    }
}
