using System;
using System.Linq;

namespace tendencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elija el ejercicio:");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Ejercio 5- opcion [A]");
            Console.WriteLine("Ejercio 21- opcion [B]");
            Console.WriteLine("---------------------------");
            Console.Write("Elija :");
            string opciones=Console.ReadLine();

            switch (opciones)
            {
                case "a":
                    Console.WriteLine("Introducir palabra1 :");
                    string alfalett = Console.ReadLine();
                    char[] val1 = alfalett.ToCharArray();
                    val1[0] = char.ToUpper(val1[0]);



                    Console.WriteLine();
                    Console.WriteLine("Introducir palabra2 :");
                    string omegalett = Console.ReadLine();
                    char[] val2 = omegalett.ToCharArray();
                    val2[0] = char.ToUpper(val2[0]);

                    Console.Write(val1);
                    Console.Write(val2);
                    Console.WriteLine();
                    break;
                case "b":

                    int[] tablita = { 1, 2, 3, 3, 4, 5, 6, 7, 7 };

                    Console.WriteLine("primera tabla");

                    foreach (var item in tablita)
                    {
                        Console.Write(item);

                    }
                    int[] tablitamod = tablita.Distinct().ToArray();

                    Console.WriteLine();
                    Console.WriteLine("segunda tabla");

                    foreach (var item in tablitamod)
                    {
                        Console.Write(item);
                    }
                    break;
                default:
                    Console.WriteLine("Error_solo_opciones_ a & b");
                    break;
            }

            Console.ReadKey();
        }
    }
}
