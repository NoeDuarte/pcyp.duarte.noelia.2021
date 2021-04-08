using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio1.ManejoBasicoDeDiccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Diccionario diccionario = new Diccionario();

            diccionario.buscarLLave("Juan");

            Console.WriteLine(diccionario.obtenerLlave("Pedro"));

            diccionario.imprmir();

            diccionario.alterarValor("Mariana", "58251425");

            Console.ReadLine();
        }
    }
}
