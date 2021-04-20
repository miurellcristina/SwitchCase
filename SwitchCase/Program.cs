using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opciones
            Console.WriteLine("Elige una opcion\n" +
                "\n1.- Suma" + "\n2.- Resta" +
                "\n3.- Multiplicación" +
                "\n4.- División" +
                "\n5.- Salir");

                string s1 = null;
            s1 = Console.ReadLine();

            switch (s1)
            {
                case "1":
                    Console.WriteLine("Se seleccionó la suma");
                break;

                case "2":
                    Console.WriteLine("Se seleccionó la resta");
                break;

                case "3":
                    Console.WriteLine("Se seleccionó la multiplicación");
                break;

                case "4":
                    Console.WriteLine("Se seleccionó la división");
                break;

                case "5":
                    Console.WriteLine("Desea Salir?");
                break;

                default:
                    Console.WriteLine("Opción incorrecta");
                    break;

            }
            Console.ReadKey();
        }
    }
}
