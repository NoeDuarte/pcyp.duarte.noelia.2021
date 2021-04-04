using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1.Ejercicio1.Figuras
{
    class Triangulo:Figura
    {
        private double base1, altura, lado;

        public Triangulo()
        {
            base1 = 0;
            altura = 0;
            lado = 0;
        }

        public double getBase()
        {
            return base1;
        }

        public void setBase(double base1)
        {
            this.base1 = base1;
        }

        public double getAltura()
        {
            return altura;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public double getLado()
        {
            return lado;
        }

        public void setLado(double lado)
        {
            this.lado = lado;
        }

        public double calcularArea()
        {
            return (base1 * altura) / 2;
        }

        public double calcularPerimetro()
        {
            return base1 + (lado*2);
        }
    }
}
