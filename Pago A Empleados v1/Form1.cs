using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDePagoEmpleados
{
    public partial class Form1 : Form
    {
        Deducciones desc = new Deducciones();
        double afp, renta, isss, salarioneto, totaldeduciones, boni;

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

            try
            {
                DocumentGenerator doc = new DocumentGenerator();
                if (validar())
                {
                    doc.generarBoleta(txtCargo.Text, cmbMes.Text, txtNombre.Text, Convert.ToDouble(txtSalarioBruto.Text), Math.Round(afp, 2), Math.Round(isss, 2), Math.Round(renta, 2), totaldeduciones, Math.Round(salarioneto, 2), desc.Observacion, boni);
                    MessageBox.Show("Archivo guardado con éxito en: " + doc.path, "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    System.Diagnostics.Process.Start(doc.path);
                }
                else
                {
                    MessageBox.Show("¡Recuerda que debes llenar todos los campos para generar la boleta!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Algo salió mal al intentar guardar el archivo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void txtSalarioBruto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
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

        private bool validar()
        {
            if (txtBonificaciones.Text == "")
                boni = 0;
            return cmbMes.SelectedIndex >= 0 && txtNombre.TextLength > 0 && txtCargo.TextLength > 0;
        }
    }
}
