using System;

namespace CajeroAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {

            string buildTitle(string title)
            {

                return  @$"
______________________________________________________________________
                 
                {title}  
______________________________________________________________________ 
                 
                
                    ";

            }
          
            int saldo = ProgramConsts.InitialAmount;
            int operationSelected;

            do
            {
                Console.WriteLine(ProgramConsts.MenuString);
                int operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        {
                            Console.WriteLine(buildTitle("INGRESE EL MONTO QUE DESEA DEPOSITAR"));
                            saldo = saldo + Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("         TU MONTO DE DINERO SE HA GUARDADO CORRECTAMENTE");

                        }
                        break;

                    case 2:
                        {
                            Console.WriteLine(buildTitle("CONSULTA DE SALDO"));
                            Console.WriteLine("        TU SALDO ACTUAL ES {0} ", saldo);
                            Console.WriteLine("");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine(buildTitle("INGRESE EL MONTO QUE DESEA RETIRAR"));
                            int retiro = Convert.ToInt32(Console.ReadLine());
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
                operationSelected = operation;

            } while (operationSelected != 4);

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
