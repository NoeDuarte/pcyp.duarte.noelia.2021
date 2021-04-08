using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.ManejoBasicoDeListas
{
    class Program
    {
        static void Main(string[] args)
        {

            ManejoDeListas mL = new ManejoDeListas();

            Console.WriteLine("List:");

            mL.cargarColores();
            mL.ColoresARemover();
            mL.imprimir();
            Console.WriteLine($"\nTamaño = {mL.tamanioListColores()} ; Capacidad = {mL.capacidadTotal()}");
            mL.existeColor("BLUE");

            Console.WriteLine("");
            Console.WriteLine("List después de llamar a RemueveColores:");
            mL.remuveColores();
            mL.imprimir();
            Console.WriteLine($"\nTamaño = {mL.tamanioListColores()} ; Capacidad = {mL.capacidadTotal()}");
            mL.existeColor("BLUE");

            Console.ReadLine();
        }
    }
}
