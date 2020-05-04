using System;
using System.Collections.Generic;

namespace CSharpDirtyCode
{
    class Program
    {
        static void Main(string[] args)
        {
            const string saludo = "Bienvenido a mi aplicación";
            var año = DateTime.Now.Year;
            double numeroPi = 3.14;
            int[] vectorEnteros = { 1, 2, 3, 4, 5 }; //new int[5];
            vectorEnteros[0] = new Random().Next(100);
            vectorEnteros[1] = new Random().Next(100);
            vectorEnteros[2] = new Random().Next(100);
            vectorEnteros[3] = new Random().Next(100);
            vectorEnteros[4] = new Random().Next(100);

            Console.WriteLine(saludo);

            while (1 > 0)
            {
                Console.WriteLine("1=Mostrar año actual, 2=Valor del número pi, 3=Contador, 4=Vector, 5=Diccionario");
                var numeroSeleccionado = Console.ReadLine();
                Menu menu = Menu.Ninguna;

                try
                {
                    menu = Enum.Parse<Menu>(numeroSeleccionado);
                }
                catch (FormatException)
                {
                    Console.WriteLine("El dato ingresado no es válido");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Excepción:" + ex.Message);
                }

                if (menu == Menu.Año)
                {
                    Console.WriteLine(año);
                }
                else if (menu == Menu.PI)
                {
                    Console.WriteLine("Número pi:" + numeroPi);
                }
                else if (menu == Menu.Contador)
                {
                    Console.WriteLine("Ingrese el limite del contador");
                    var limiteContador = Console.ReadLine();
                    int intLimiteContador = 0;
                    int.TryParse(limiteContador, out intLimiteContador);

                    for (int i = 1; i <= intLimiteContador; i++)
                    {
                        Console.WriteLine(i);
                        i++;
                    }
                }
                else if (menu == Menu.Vector)
                {
                    for (var i = 0; i < vectorEnteros.Length; i++)
                    {
                        Console.WriteLine(vectorEnteros[i]);
                    }
                }
                else if (menu == Menu.Diccionario)
                {
                    Console.WriteLine("Por favor ingrese los numeros para el diccionario y finalize con .");
                    string numeroIngresado = "";
                    Dictionary<int, int> diccionario = new Dictionary<int, int>();
                    int keyValue = 1;
                    while (!numeroIngresado.Equals("."))
                    {
                        numeroIngresado = Console.ReadLine();

                        try
                        {
                            int intnumeroIngresado = int.Parse(numeroIngresado);
                            diccionario.Add(keyValue, intnumeroIngresado);
                            keyValue++;
                        }
                        catch
                        {

                        }
                    }

                    foreach (var item in diccionario)
                    {
                        Console.WriteLine("Clave:" + item.Key + " - Valor:" + item.Value);
                    }
                }
                else
                {
                    Console.WriteLine("No ha seleccionado un valor válido");
                }
            }
        }
    }

    public enum Menu
    {
        Ninguna,
        Año = 1,
        PI = 2,
        Contador = 3,
        Vector = 4,
        Diccionario = 5
    }
}
