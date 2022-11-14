using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotell;

namespace hotell
{
    internal class opcion2
    {
        public static void op2(string[,] array)
        {//Mostrar habitacions lliures
            bool salir = false;
            string[,] cliente = null;
            do
            {
                string[,] opcion2 = funciones.buscar(array, null, 4);
                if (funciones.comprobaraux(opcion2))
                {
                    funciones.mostrar(opcion2, 3, funciones.mostrartipo.nif, funciones.mostrartipo.mostrarenunciado, array);
                    salir = true;
                }
                else
                {
                    Console.WriteLine("No hay habitaciones libres");
                    salir = true;
                }               
            } while (!salir);
            
        }
    }
}
