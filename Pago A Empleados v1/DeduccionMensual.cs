using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePagoEmpleados
{
    class DeduccionMensual
    {
        public string mes;
        public double salarioBruto;
        public double isss;
        public double afp;
        public double salarioGravado;
        public double renta;
        public double salario;

        public string Mes
        {
            get { return mes; }
            set { mes = value; }
        }
        public double SalarioBruto
        {
            get { return salarioBruto; }
            set { salarioBruto = value; }
        }
        public double Isss
        {
            get { return isss; }
            set { isss = value; }
        }
        public double Afp
        {
            get { return afp; }
            set { afp = value; }
        }
        public double SalarioGravado
        {
            get { return salarioGravado; }
            set { salarioGravado = value; }
        }
        public double Renta
        {
            get { return renta; }
            set { renta = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
    }
}
