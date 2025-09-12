using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer5(); //Lo declaramos (Paso 2)
            Console.ReadKey(); //realizando detenimiento de consola
        }
        static void ejer1() //Para hacer mas ejercicios en un solo programa (Paso 1)
        {
            string nombre, carrera;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido al Curso de Fundamentos de Algoritmos de la carrera {carrera}.");
        }

        static void ejer2()
        {
            Console.WriteLine("\"Gean\"");
        }

        static void ejer3()
        {
            Console.Write("Ingrese x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            double divi = (double)x / (double)y;

            Console.WriteLine("\nSuma: " +(x + y));
            Console.WriteLine("Resta: " +(x - y));
            Console.WriteLine("Multiplicación: " +(x * y));
            Console.WriteLine("División: " +divi);
        }
        static void ejer4()
        {
            Console.Write("Ingrese un número decimal: ");
            double num = double.Parse(Console.ReadLine());

            double raiz2 = Math.Sqrt(num);
            int redo = (int)Math.Round(num,0);
            double cubo = Math.Pow(num, 3);
            double raiz3 = Math.Pow(num, 1 / 3d);

            Console.WriteLine("raiz2: " + raiz2);
            Console.WriteLine("redondeado: " + redo);
            Console.WriteLine("Al cubo: " + cubo);
            Console.WriteLine("Raiz3: " + raiz3);
        }
        static void ejer5()
        {
            Console.Write("Ingrese un número: ");
            string num = Console.ReadLine();
            int entero = int.Parse(num);
            double deci = double.Parse(num);

            Console.WriteLine("resto: " + entero % 2);
            Console.WriteLine("divi 3: " + deci / 3);
        }
    }
}
