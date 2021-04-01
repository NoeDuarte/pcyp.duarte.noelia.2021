﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Menu
    {
        public void menu()
        {
            int opcion = 0;


            Console.WriteLine("Elija una figura geometrica");
            Console.WriteLine("1.Calcular area y perimetro de Cuadrado");
            Console.WriteLine("2.Calcular area y perimetro de Rectangulo");
            Console.WriteLine("3.Calcular area y perimetro de Triangulo");
            Console.WriteLine("4.Salir");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Cálculo de área y perímetro de un cuadrado");
                    Cuadrado cua = new Cuadrado();
                    Console.Write("Ingrese la longitud de los lados del cuadrado: ");
                    cua.setLado(double.Parse(Console.ReadLine()));
                    Console.WriteLine("El area del cuadrado es: {0}", cua.calcularArea());
                    Console.WriteLine("El perímetro del cuadrado es: {0}", cua.calcularPerimetro());
                    Console.ReadLine();

                    break;

                case 2:
                    Console.WriteLine("Cálculo de área y perímetro de un rectángulo");
                    Rectangulo rect = new Rectangulo();
                    Console.Write("Ingrese la longitud de la base del rectangulo: ");
                    rect.setBase(double.Parse(Console.ReadLine()));
                    rect.setAltura(rect.getBase() / 2);
                    Console.WriteLine("La altura del rectángulo es la mitad de la longitud de la base ({0})", rect.getAltura());
                    Console.WriteLine("El area del rectangulo es: {0}", rect.calcularArea());
                    Console.WriteLine("El perímetro del rectangulo es: {0}", rect.calcularPerimetro());
                    Console.ReadLine();

                    break;

                case 3:
                    Console.WriteLine("Cálculo de área y perímetro de un triángulo");
                    Triangulo tri = new Triangulo();
                    Console.Write("Ingrese la longitud de los lados del triángulo: ");
                    tri.setBase(double.Parse(Console.ReadLine()));
                    Console.Write("Ingrese la altura del triángulo: ");
                    tri.setAltura(double.Parse(Console.ReadLine()));
                    Console.WriteLine("El area del triangulo es: {0}", tri.calcularArea());
                    Console.WriteLine("El perímetro del triangulo es: {0}", tri.calcularPerimetro());
                    Console.ReadLine();
                    break;

                case 4:
                    Console.WriteLine("Hasta Luego!!");
                    break;
            }

            Console.ReadLine();
            Console.Clear();
        }
        
    }
}
