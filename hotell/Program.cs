using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotell;

namespace hotell
{
    internal class Program
    {

        static void Main(string[] args)
        {

            String[,] hotel = new string[18, 5] {
                { "101", "1", "2", "100", null},
                { "102", "1", "2", "100", null},
                { "103", "1", "2", "100", "12547896f"},
                { "104", "1", "3", "130", null},
                { "105", "1", "3", "130", null},
                { "106", "1", "1", "75", null},
                { "201", "2", "2", "100", null},
                { "202", "2", "2", "100", null},
                { "203", "2", "2", "100", null},
                { "204", "2", "3", "130", "36528947g"},
                { "205", "2", "3", "130", null},
                { "206", "2", "1", "75", null},
                { "301", "3", "2", "100", null},
                { "302", "3", "2", "100", null},
                { "303", "3", "2", "100", "36528947g"},
                { "304", "3", "3", "130", null},
                { "305", "3", "3", "130", null},
                { "306", "3", "1", "75", null}
            };
            string[,] clientes = new string[12, 2] { { "Juan Carlos", "12547896f" }, { "Alberto Perez", "36528947g" }, { "Sergio Nuñez", "59716482f" }, { "Susana Gimenez", "12345678l" }, { "Alejandra Hernandez", "98745632j" }, { "Maria Carballo", "20605487g" }, { null, null }, { "", "" }, { "", "" }, { "", "" }, { "", "" }, { "", "" } };

            Boolean salir = false;

            
            do
            {
                funciones.menu();
                try
                {
                    int opcion = int.Parse(Console.ReadLine());


                    switch (opcion)
                    {
                        case 1:
                            op1.opcion1(hotel);
                            break;
                        case 2:
                            opcion2.op2(hotel);
                            break;
                        case 3:
                            opcion3.op3(hotel, clientes);
                            break;
                        case 4:
                            opcion4.op4(hotel, clientes);
                            break;
                        case 5:
                            opcion5.op5(hotel, clientes);
                            break;
                        case 6:
                            opcion6.op6(hotel, clientes);
                            break;
                        case 7:
                            opcion7.op7(hotel, clientes);
                            break;
                        case 8:
                            salir = true;
                            break;
                        default: Console.WriteLine("introduce un numero del 1 al 8 porfavor"); break;


                    }
                }
                catch 
                {
                    Console.WriteLine("introduce numeros por favor");
                }
            } while (!salir);









































            /*
            Console.WriteLine("mostrar hotel:");
            hotell.funciones.mostrar(hotel, 5);
            Console.WriteLine("\n\n\n\n\n");
                      

            //Console.WriteLine("buscar cliente 59716482f:");
            //hotell.funciones.buscar(clientes, "59716482f", 1, 2);
            Console.WriteLine("\n\n\n\n\n");


            //actualizar(string[,] array, string[,] cliente, string nif, string nombre, string opcioncama, int cantidadhabitaciones, int reserva)
            Console.WriteLine("actualizar reserva cliente alberto:");
            hotell.funciones.actualizar(hotel, clientes, "36528947g", "Alberto Perez", "3", 2, 0);
            hotell.funciones.mostrar(hotel, 5);
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("buscar cliente reservas de 36528947g:");          
            string[,] busqueda1 = hotell.funciones.buscar(hotel, "36528947g", 4);
            Console.WriteLine("mostrar resultado:");
            hotell.funciones.mostrar(busqueda1,5);

            Console.WriteLine("actualizar cancelar reserva cliente 36528947g");
            hotell.funciones.actualizar(hotel, clientes, "36528947g", "", "", 2, 1);
            hotell.funciones.mostrar(hotel, 5);
            Console.WriteLine("Nueva funcion con retorno");
            string[,] resultado = hotell.funciones.buscar(hotel, "36528947g", 4);
            Console.WriteLine("mostrar resultado:");
            hotell.funciones.mostrar(resultado,5);
            Console.WriteLine("\n\n\n\n\n");
            string[,] busquedaclient = hotell.funciones.buscar(clientes, "36528947g", 1);
            hotell.funciones.mostrar(busquedaclient,2);


            */



        }
    }
}
