using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernGUI_V3
{
    class Deducciones
    {
              
        //Metodo para calcular el AFP
        public double CalcularAFP (double ingresos)
        {  
            double afp = ingresos * 0.0725;
            return afp;
        }

        //Metodo para calcular el ISSS
        public double CalcularISSS(double ingresos)
        {
            if (ingresos < 1000)
            {
                double isss = ingresos * 0.03;
                return isss;
            }
            else
            {
                return 30;
            }
        }

        //Metodo para calcular la Renta
        public double CalcularRenta(double ingresos)
        {
            double rentaImponible = ingresos - (CalcularISSS(ingresos) + CalcularAFP(ingresos));

            if (rentaImponible > 0.01 & rentaImponible <= 472)
            {
                return 0;
            }
            else if (rentaImponible > 472 & rentaImponible <= 895.24)
            {
                double renta = ((rentaImponible - 472) * 0.10) + 17.67;
                return renta;
            }
            else if (rentaImponible > 895.25 & rentaImponible <= 2038.10)
            {
                double renta = ((rentaImponible - 895.24) * 0.20) + 60;
                return renta;
            }
            else if (rentaImponible > 2038.11)
            {
                double renta = ((rentaImponible - 2038.10) * 0.30) + 288.57;
                return renta;
            }
            else
            {
                return 0;
            }
        }
    }
}
