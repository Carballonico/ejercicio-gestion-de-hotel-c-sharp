using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotell;

namespace hotell
{
    internal class opcion6
    {
        public static void op6(string[,]array, string[,] clientes)
        {
            
            Console.WriteLine("Nif:");
            string nif = Console.ReadLine();                        
            string[,] client = funciones.buscar(clientes, nif, 1);
            if (funciones.comprobaraux(client))
            {
                string[,] factura = funciones.buscar(array, nif, 4);
                if (funciones.comprobaraux(factura))
                {

                    funciones.crearFactura(factura, nif, clientes);
                }
                else
                {
                    Console.WriteLine("El cliente no tiene rervas");
                }
            }
            else
            {
                Console.WriteLine("No hay un cliente registrado bajo ese nif");
            }           
            
        }
    }
}
