using Parcial_PrograX.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_PrograX.Interfaces
{
    interface  Ioperacion
    {
        interface IAhorro
        {
            double calAhorro(Clientes cliente);
        }
        interface ICalcISR
        {
            double calcularISR(Clientes cliente);
        }

        interface ICalcIVA
        {
            double calcIVA(Clientes cliente);
        }


    }
}
