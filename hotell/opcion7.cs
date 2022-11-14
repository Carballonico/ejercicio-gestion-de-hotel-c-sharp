using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotell;

namespace hotell
{
    internal class opcion7
    {
        public static void op7(string[,] array , string[,] clientes)
        {            
            // actualizar(string[,] array, string[,] cliente, string nif, string nombre, string opcioncama, int cantidadhabitaciones, int reserva)
           
                Console.WriteLine("introduce tu nif");
                string nif = Console.ReadLine();                
                string[,] result = funciones.buscar(clientes, nif, 1);
                if (funciones.comprobaraux(result))
                {
                    string[,] busqueda = funciones.buscar(array, nif, 4);
                    if (funciones.comprobaraux(busqueda))
                    {
                        funciones.actualizar(array, clientes, nif, 1, 0, 1);

                        Console.WriteLine("Las reservas se han anulado correctamente");                       
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
