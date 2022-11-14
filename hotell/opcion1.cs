using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotell;

namespace hotell
{
    internal class op1
    {//Mostrar Hotel
        public static void opcion1(string[,] array) 
        {
            funciones.mostrar(array, 5, hotell.funciones.mostrartipo.nif,hotell.funciones.mostrartipo.mostrarenunciado,array);
        }
    }
}
