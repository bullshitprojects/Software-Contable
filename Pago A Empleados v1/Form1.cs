using System;
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
    public partial class Form1 : Form
    {
        Deducciones desc = new Deducciones();
        double afp, renta, isss, salarioneto, totaldeduciones;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtBonificaciones_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtBonificaciones.Text == "")
                {
                    txtTotalIngresos.Text = txtSalarioBruto.Text;
                }
                else
                {
                    txtTotalIngresos.Text = (double.Parse(txtSalarioBruto.Text) + double.Parse(txtBonificaciones.Text)).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error... Revisar Los Datos");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSalarioBruto_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtBonificaciones.Text=="")
                {
                    txtTotalIngresos.Text = txtSalarioBruto.Text;
                }
                else
                {
                    txtTotalIngresos.Text = (double.Parse(txtSalarioBruto.Text) + double.Parse(txtBonificaciones.Text)).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error... Revisar Los Datos");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAfp.Text = "";
            txtIsss.Text = "";
            txtRenta.Text = "";
            txtsalarioNeto.Text = "";
            txtDeducciones.Text = "";
            txtSalarioBruto.Text = "";
            txtNombre.Text = "";
            cmbMes.Text = "";
            txtBonificaciones.Text = "";
            txtTotalIngresos.Text = "";
            deducciones.Visible = false;
            resultado.Visible = false;
        }

        private void btnGenerarBoleta_Click(object sender, EventArgs e)
        {
            DocumentGenerator doc = new DocumentGenerator();
            MessageBox.Show("Archivo guardado con éxito en: " + doc.generarBoleta(), "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void txtSalarioBruto_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            afp = desc.CalcularAFP(Convert.ToDouble(txtTotalIngresos.Text));
            isss = desc.CalcularISSS(Convert.ToDouble(txtTotalIngresos.Text));
            renta = desc.CalcularRenta(Convert.ToDouble(txtTotalIngresos.Text));
            totaldeduciones = afp + isss + renta;
            salarioneto = Convert.ToDouble(txtTotalIngresos.Text) - totaldeduciones;

            txtAfp.Text = "$ " + Convert.ToString(Math.Round(afp, 2));
            txtIsss.Text = "$ " + Convert.ToString(Math.Round(isss, 2));
            txtRenta.Text = "$ " + Convert.ToString(Math.Round(renta, 2));
            txtsalarioNeto.Text = "$ " + Convert.ToString(Math.Round(salarioneto, 2));

            deducciones.Visible = true;
            resultado.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error... Revisar Los Datos");
            }
        }



        private void txtAfp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtDeducciones.Text = "$ " + Convert.ToString(Math.Round(totaldeduciones, 2));

            }
            catch (Exception)
            {
            }
        }

        private void txtIsss_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtDeducciones.Text = "$ " + Convert.ToString(Math.Round(totaldeduciones, 2));

            }
            catch (Exception)
            {
            }
        }

        private void txtRenta_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtDeducciones.Text = "$ " + Convert.ToString(Math.Round(totaldeduciones, 2));

            }
            catch (Exception)
            {
            }
        }
    }
}
