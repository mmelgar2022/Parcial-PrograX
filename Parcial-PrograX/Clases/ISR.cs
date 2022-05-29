using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Parcial_PrograX.Interfaces.Ioperacion;

namespace Parcial_PrograX.Clases
{

    public class ISR : ICalcISR
    {
        public double calcularISR(Clientes cliente)
        {
            double ISR;

            if (cliente.sueldo <= 30000.00)
            {
                ISR = cliente.sueldo * 0.05;
            }
            else
            {
                ISR = cliente.sueldo * 0.07;
            }

            return ISR;
        }
    }
}
