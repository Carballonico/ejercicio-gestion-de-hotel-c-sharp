using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotell;

namespace hotell
{
    internal class opcion3
    {//Mostrar habitacions ocupades amb el nom
        
        public static void op3(string[,] array, string[,]clientes)
        {
            string[,] opcion3 = funciones.buscar(array, "not null", 4);
            funciones.mostrar(opcion3, 5, funciones.mostrartipo.nombre, funciones.mostrartipo.mostrarenunciado, clientes);
        }
    }
}
