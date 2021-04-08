using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clase1.Ejercicio2.ArchivoCSV
{
    class ArchivoCSV
    {
        private string[] lineas;

        public ArchivoCSV() { }

        public string[] lecturaArchivo()
        {
            lineas = File.ReadAllLines(@"C: \Users\Noelia\Documents\GitHub\pcyp.duarte.noelia.2021\PCyP.Ejercicios\Clase1.Ejercicio2.Vial");

            return lineas;
        }


        public void imprimir()
        {


            foreach (var i in lecturaArchivo())
            {
                var linea = i.Split(',');

                Console.WriteLine($"Número de hoja:{linea[0]}{"  "}\t Tipo de objeto:{ linea[1]}{"  "}\t Identificador de tramo:{linea[2]}{"  "}Tipo de camino:{linea[3]}{"  "}\t Longitud: {linea[4]}");
             
            }

        }

    }
}
