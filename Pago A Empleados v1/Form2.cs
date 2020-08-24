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
    public partial class Form2 : Form
    {
        double sueldos, medicos, colegio, neta, pc, total, computado;

        private void button1_Click_1(object sender, EventArgs e)
        {
            sueldos = Convert.ToDouble(txtSueldos.Text);
            medicos = Convert.ToDouble(textMedicos.Text);
            colegio = Convert.ToDouble(textColegio.Text);
            neta = sueldos - medicos - colegio;
            pc = Convert.ToDouble(textPagoCuenta.Text);
           
           

            textNeta.Text = "$ " + Convert.ToString(Math.Round(neta, 2));

            if (neta < 4064)
            {
                MessageBox.Show(Convert.ToString("No es necesario declarar"));
            }
            else if(neta >= 4064.01 & neta <= 9142.86  )
            {
                computado = ((neta - 4064) * 0.10) + 212.12;
            }
            else if (neta >= 9142.87 & neta <= 22857.14)
            {
                computado = ((neta - 9142.86) * 0.20) + 720;
            }
            else if (neta >= 22857.15)
            {
                computado = ((neta - 22857.14) * 0.30) + 3462.86;
            }

            total = computado - pc;
            textComputado.Text = "$ " + Convert.ToString(Math.Round(computado, 2));
            textResult.Text = "$ " + Convert.ToString(Math.Round(total, 2));

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textComputado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSueldos.Text = "";
            textResult.Text = "";
            textMedicos.Text = "";
            textColegio.Text = "";
            textPagoCuenta.Text= "";
            textNeta.Text = "";
            textComputado.Text = "";
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
