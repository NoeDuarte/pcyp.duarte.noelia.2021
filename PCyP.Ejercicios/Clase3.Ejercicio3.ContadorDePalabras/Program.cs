using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio3.ContadorDePalabras
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Ingrese un parrafo");

                ContadorPalabra contador = new ContadorPalabra();

                string parrafo = Console.ReadLine();

            
            contador.ingresarParrafo(parrafo);
            
            contador.imprimir();

            }
    }
}
