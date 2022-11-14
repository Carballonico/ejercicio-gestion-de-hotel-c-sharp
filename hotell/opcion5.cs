using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotell;

namespace hotell
{
    internal class opcion5
    {
        public static void op5(string[,] array,string[,] cliente)
        {
            Console.WriteLine("Introduce un nif:");
            string nif = Console.ReadLine();
            string[,] clienteencontrado = funciones.buscar(cliente,nif,1);
            if (funciones.comprobaraux(clienteencontrado))
            {
                string[,] result = funciones.buscar(array, nif, 4);
                if (funciones.comprobaraux(result))
                {
                    funciones.mostrar(result, 5, funciones.mostrartipo.nif, funciones.mostrartipo.mostrarenunciado, cliente);
                }
                else
                {
                    Console.WriteLine("El cliente no tiene reservas");
                }
            }
            else
            {
                Console.WriteLine("No hay un cliente registrado bajo ese nif");
            }
            
            
        }

    }
}
