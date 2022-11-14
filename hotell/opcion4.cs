using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotell;

namespace hotell
{
    internal class opcion4
    {//entrar reserva:
        // actualizar(string[,] array, string[,] cliente, string nif, string nombre, string opcioncama, int cantidadhabitaciones, int reserva)
        public static void op4(string[,] array, string[,] cliente)
        {
            bool salir = false;
            do
            {
                try
                {
                    Console.WriteLine("Cuantas habitaciones?");
                    int canthabitaciones = int.Parse(Console.ReadLine());
                    Console.WriteLine("1 individuales\t2 doble\t3 triple");
                    int opcioncama = int.Parse(Console.ReadLine());
                    Console.WriteLine("introduce tu nif");
                    string nif = Console.ReadLine();
                    funciones.actualizar(array, cliente, nif, opcioncama, canthabitaciones, 0);
                    string[,] result = funciones.buscar(array, nif, 4);
                    funciones.mostrar(result, 5, funciones.mostrartipo.nif, funciones.mostrartipo.mostrarenunciado, cliente);
                    salir = true;
                }
                catch
                {
                    Console.WriteLine("introduce los datos correctamente por favor");
                }

            } while (!salir);
            
            
        }
    }
}
