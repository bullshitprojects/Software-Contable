using System;
using System.Collections;
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
        // Calcular Renta aguinaldo
        public double CalcularRentaAguinaldo(double ingresos, double aguinaldoGravado)
        {
            double rentaImponible = (ingresos - (CalcularISSS(ingresos) + CalcularAFP(ingresos))+ aguinaldoGravado) ;

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

        //Metodo para recalculo de la Renta 
        public ArrayList Recalculo(double remuneracionGravada, int calculo)
        {
            double exceso = 0, porcentaje = 0, cuotaFija = 0, renta = 0;
            // Primer Recálculo Enero - Junio
            if (calculo == 1)
            {
                if (remuneracionGravada >= 0.01 & remuneracionGravada <= 2832)
                {                
                    exceso = 0;
                    porcentaje = 0;
                    cuotaFija = 0;
                }
                else if (remuneracionGravada >= 2832.01 & remuneracionGravada <= 5371.44)
                {
                    exceso = 2832;
                    porcentaje= 0.10;
                    cuotaFija= 106.20;
                    renta = ((remuneracionGravada - exceso) * porcentaje) + cuotaFija;
                }
                else if (remuneracionGravada >= 5371.45 & remuneracionGravada <= 12228.60)
                {
                    exceso = 5371.44;
                    porcentaje = 0.20;
                    cuotaFija = 360;
                    renta = ((remuneracionGravada - exceso) * porcentaje) + cuotaFija;
                }
                else if (remuneracionGravada >= 12228.61)
                {
                    exceso = 12228.60;
                    porcentaje = 0.30;
                    cuotaFija = 1731.42;
                    renta = ((remuneracionGravada - exceso) * porcentaje) + cuotaFija;
                }
                else
                {
                }
            }
            // Segundo Recálculo Enero - Diciembre
            else
            {

                if (remuneracionGravada >= 0.01 & remuneracionGravada <= 5664)
                {
                    exceso = 0;
                    porcentaje = 0;
                    cuotaFija = 0;
                }
                else if (remuneracionGravada >= 5664.01 & remuneracionGravada <= 10742.86)
                {
                    exceso = 5664;
                    porcentaje = 0.10;
                    cuotaFija = 212.12;
                    renta = ((remuneracionGravada - exceso) * porcentaje) + cuotaFija;
                }
                else if (remuneracionGravada >= 10742.87 & remuneracionGravada <= 24457.14)
                {
                    exceso = 10742.86;
                    porcentaje = 0.20;
                    cuotaFija = 720;
                    renta = ((remuneracionGravada - exceso) * porcentaje) + cuotaFija;
                }
                else if (remuneracionGravada >= 24457.15)
                {
                    exceso = 24457.14;
                    porcentaje = 0.30;
                    cuotaFija = 3462.86;
                    renta = ((remuneracionGravada - exceso) * porcentaje) + cuotaFija;
                }
                else
                {
                }
            }
            ArrayList recalculo = new ArrayList();
            recalculo.Add(exceso);
            recalculo.Add(remuneracionGravada - exceso);
            recalculo.Add((remuneracionGravada - exceso) * porcentaje);
            recalculo.Add(cuotaFija);
            recalculo.Add(renta);
            return recalculo;
        }
    }
}
