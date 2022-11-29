using System;

namespace hotell
{
    internal class funciones
    {
        public static void menu()
        {
            Console.WriteLine("1. Mostrar Hotel\r\n2. Mostrar habitacions lliures\r\n3. Mostrar habitacions ocupades amb el nom\r\n4. Entrar reserva\r\n5. Llista reserves a partir d'un Nif\r\n6. Factura de la reserva a partir d'un Nif\r\n7. Anul·lar reserva\r\n8. Salir");
        }
        
       
        public static bool comprobaraux(string[,] array)
        {
            
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if (array[i, j] != null)
                        {
                            return true;
                        }

                    }
                }
                return false;            

        }
        public static void crearFactura(string[,] array, string nif, string[,] listaClientes)
        {
            string[,] clienteencontrado = buscar(listaClientes, nif, 1);
            Console.Write("Factura del client amb nif ");
            mostrar(clienteencontrado, 2, mostrartipo.nif, mostrartipo.nomostrarenunciado, listaClientes);
            int totalreserva = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 3] != null)
                {
                    totalreserva += int.Parse(array[i, 3]);
                }

            }
            mostrar(array, 4, mostrartipo.nif, mostrartipo.mostrarenunciado,listaClientes);
            Console.WriteLine("L'import de la factura de la reserva es:{0}", totalreserva);
        }

        public static void actualizar(string[,] array, string[,] cliente, string nif, int opcioncama, int cantidadhabitaciones, int reserva)
        {
            string nombre = "";
            int i = 0;
            Boolean salir = false;
            Boolean opcioncamacorrecta = false;
            int countcama = 0;
            Boolean countcamacorrecta = false;
            do
            {
                if (opcioncama == 1)
                {
                    opcioncamacorrecta = true;
                }
                else if (opcioncama == 2)
                {
                    opcioncamacorrecta = true;

                }
                else if (opcioncama == 3)
                {
                    opcioncamacorrecta = true;

                }
                else
                {
                    Console.WriteLine("nuestras habitaciones cuentan con un maximo de 3 camas, indica cuantas camas quieres:");
                    opcioncama = int.Parse(Console.ReadLine());
                }
            } while (!opcioncamacorrecta);
            do
            {
                int countcamaaux = 0;
                for (i = 0; i < array.GetLength(0); i++)
                {
                    if (int.Parse(array[i, 2]) == opcioncama & array[i, 4] == null)
                    {
                        countcamaaux++;
                    }
                }

                if (countcamaaux >= cantidadhabitaciones)
                {
                    countcamacorrecta = true;
                }
                else
                {
                    Console.WriteLine("No hay suficientes habitaciones, la cantidad de habitaciones disponibles son: " + countcamaaux);
                    Console.WriteLine("Cuantas habitaciones?:");
                    cantidadhabitaciones = int.Parse(Console.ReadLine());
                }
            } while (!countcamacorrecta);
            i = 0;
            do
            {
                if (cliente[i, 1] == nif)
                {
                    Console.WriteLine("Biembenido Sr/Sra {0}", cliente[i, 0]);
                    salir = true;
                }
                i++;
                if (i == cliente.GetLength(0))
                {
                    Console.WriteLine("Introduce un nombre:");
                    nombre = Console.ReadLine();
                    Boolean salir2 = false;
                    i = 0;
                    while (!salir2)
                    {

                        if (cliente[i, 1] == null)
                        {
                            cliente[i, 0] = nombre;
                            cliente[i, 1] = nif;
                            salir2 = true;
                        }
                        i++;
                    }
                    salir = true;
                }
            } while (!salir);
            salir = false;
            i = 0;
            if (reserva == 0)
            {
                do
                {

                    if (int.Parse(array[i, 2]) == opcioncama & array[i, 4] == null)
                    {
                        array[i, 4] = nif;
                        countcama++;
                    }

                    i++;
                    if (i == array.GetLength(0) | countcama == cantidadhabitaciones)
                    {

                        salir = true;
                    }

                } while (!salir);
            }
            if (reserva == 1)
            {
                for (int o = 0; o < array.GetLength(0); o++)
                {
                    if (array[o, 4] == nif)
                    {
                        array[o, 4] = null;
                    }
                }

            }

        }
        
        public static string[,] buscar(string[,] array, string dato, int columna)
        {
            string[,] auxhab = new string[array.GetLength(0), array.GetLength(1)];
            string[,] auxclient = new string[array.GetLength(0), array.GetLength(1)];

            string not = "not null";
            int coordenadanif;
            Boolean salir = false;
            int i = 0;
            /*
            string[,] enunciado = new string[5, 2] { { "Num.Hab\t", "=======\t" }, { "Pis\t", "===\t" }, { "Llits\t", "=====\t" }, { "Preu\t", "====\t" }, { "Lliure/Nif\n", "==========" } };
            int ñ = 0;
            if (array.GetLength(1) > 2)
            {
                while (ñ < enunciado.GetLength(1))
                {
                    for (int j = 0; j < columna; j++)
                    {

                        //Console.Write("{0}", enunciado[j, ñ]);
                        if (j == columna - 1)
                        {
                            ñ++;

                        }
                    }
                    //Console.Write("\n");
                }
            }
            else
            {
                Console.Write("Bienvenido\tsr/sra:\n");               
            }
            */

            if (array.GetLength(1) > 2)
            {
                do
                {
                    if (dato == not & array[i, columna] != null)
                    {

                        for (int n = 0; n < array.GetLength(1); n++)
                        {

                            auxhab[i, n] = array[i, n];

                        }

                    }
                    if (array[i, columna] == dato)
                    {

                        for (int n = 0; n < array.GetLength(1); n++)
                        {
                            auxhab[i, n] = array[i, n];
                        }

                    }
                    i++;
                    if (i == array.GetLength(0))
                    {
                        salir = true;
                    }
                } while (!salir);
            }
            else
            {
                do
                {
                    if (array[i, 1] == dato)
                    {
                        for (int n = 0; n < array.GetLength(1); n++)
                        {
                            auxclient[i, n] = array[i, n];

                        }
                        coordenadanif = i;
                        salir = true;
                    }
                    i++;
                    if (i == array.GetLength(0))
                    {
                        salir = true;
                    }
                } while (!salir);
            }

         
            if (array.GetLength(1) > 2)
            {
                return auxhab;
            }
            else
            {
                return auxclient;
            }



        }
        public enum mostrartipo : int
        {
            nombre = 2,
            nif = 1,
            mostrarenunciado = 1,
            nomostrarenunciado = 0
        }
        public static void mostrar(string[,] array, int columna, mostrartipo mostrarnombre , mostrartipo mostrarenunciado, string[,] clientes)
        {
            if (mostrarenunciado == mostrartipo.mostrarenunciado)
            {
                string[,] enunciado = new string[5, 2] { { "Num.Hab\t", "=======\t" }, { "Pis\t", "===\t" }, { "Llits\t", "=====\t" }, { "Preu\t", "====\t" }, { "Lliure/Nif", "==========" } };
                int ñ = 0;
                if (array.GetLength(1) > 2)
                {
                    while (ñ < enunciado.GetLength(1))
                    {
                        for (int j = 0; j < columna; j++)
                        {

                            Console.Write("{0}", enunciado[j, ñ]);
                            if (j == columna - 1)
                            {
                                ñ++;
                            }
                        }
                        Console.Write("\n");
                    }
                }
                else
                {
                    Console.Write("Nombre\t\tNif\n======\t\t===\n");
                }
            }

            for (int j = 0; j < array.GetLength(0); j++)
            {

                for (int n = 0; n < columna; n++)
                {

                    if (array[j, 0] != null)
                    {
                        if (n > 2)
                        {
                            if (array[j, 4] == null & n == 4 & mostrarnombre != mostrartipo.nombre)
                            {
                                Console.Write("Lliure\t");
                            }
                            else if (array[j, 4] != null & n == 4 & mostrarnombre == mostrartipo.nombre)
                            {
                                string[,] auxmostrarclient = buscar(clientes, array[j, 4], 1);
                                for (int s = 0; s < auxmostrarclient.GetLength(0); s++)
                                {
                                    Console.Write(auxmostrarclient[s, 0]);
                                }
                            }
                            else
                            {
                                Console.Write("{0}\t", array[j, n]);
                            }
                        }
                        else if (mostrarenunciado == 0)
                        {
                            Console.Write("{0}\t", array[j, 1]);
                            break;
                        }
                        else
                        {
                            Console.Write("{0}\t", array[j, n]);
                        }
                    }
                }
                if (array[j, 0] != null)
                {

                    Console.Write("\n");
                }

            }
        }
    }
}
