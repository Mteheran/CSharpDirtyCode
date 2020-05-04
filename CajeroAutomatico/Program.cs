using System;

namespace CajeroAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Program program = new Program();

            int deposito;
            int saldo = 5000;
            int retiro; // variable para guardar retiro de dinero

            do
            {
                program.menu();
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("______________________________________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("             INGRESE EL MONTO QUE DECEA DEPOSITAR  ");
                            Console.WriteLine("______________________________________________________________________");
                            Console.WriteLine("");
                            deposito = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("");
                            saldo = saldo + deposito;
                            Console.WriteLine("         TU MONTO DE DINERO SE AH GUARDADO CORRECTAMENTE");

                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine("");
                            Console.WriteLine("_______________________________________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("                     CONSULTA DE SALDO");
                            Console.WriteLine("_______________________________________________________________________");
                            Console.WriteLine("");

                            Console.WriteLine("        TU SALDO ACTUAL ES {0} ", saldo);
                            Console.WriteLine("");
                        }
                        break;
                    case 3:
                        {

                            Console.WriteLine("");
                            Console.WriteLine("________________________________________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("                     INGRESE EL MONTO QUE DECEE RETIRAR ");
                            Console.WriteLine("________________________________________________________________________");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            retiro = Convert.ToInt32(Console.ReadLine());
                            saldo = saldo - retiro;
                            Console.WriteLine("");
                            Console.WriteLine("     TU RETIRO DE {0} SE REALIZO CORRECTAMENTE ", retiro);
                            Console.WriteLine("");
                        }
                        break;
                    case 4:
                        {
                            //Mensaje de agradecimiento al final
                            Console.WriteLine("");
                            Console.WriteLine("           GRACIAS POR USAR EL SISTEMA DE CAJERO");
                            Console.WriteLine("             AUTOMATICO MANICH, BUELBA PRONTO");
                        }
                        break;
                }
                Console.ReadKey();
                a = op;

            } while (a != 4);

        }


        /// <summary>
        /// Pinta el menu de la aplicacion de consola
        /// </summary>
        public void menu()
        {
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("                                                                  ");
            Console.WriteLine("                   BIENBENIDO AL CAJERO AUTOMATICO");
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("      1.- DECEA DEPOSITAR");
            Console.WriteLine("      2.- DECEA CONSULTAR SU SALDO");
            Console.WriteLine("      3.- DECEA RETIRAR");
            Console.WriteLine("      4.- DECEA SALIR");
            Console.WriteLine("");
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("");
        }
    }
}
