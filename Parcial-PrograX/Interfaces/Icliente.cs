using Parcial_PrograX.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_PrograX.Interfaces
{
    interface  Icliente
    {
        interface ICrearCliente
        {
            void crear(Clientes cliente);
        }
        interface IEditarCliente
        {
            void editar(Clientes cliente);
        }
        interface IEliminarCliente
        {
            void eliminar(Clientes cliente);
        }

       



    }
}
