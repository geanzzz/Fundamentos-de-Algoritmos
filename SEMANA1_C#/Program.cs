﻿using System;
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
            ejer3(); //Lo declaramos (Paso 2)
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
    }
}
