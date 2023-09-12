using System;

namespace Tarea
{
    //La clase Triangulo hereda de la clase base Figura. 
    //Esto representa el concepto de herencia, donde Triangulo adquiere las propiedades y métodos de la clase base
    //y los puede modificar según sus necesidades específicas.
    public class Triangulo : Figura
    {
        private double baseTriangulo;
        private double altura;
        private double lado1;
        private double lado2;
        private double lado3;

        public Triangulo()
        {

        }

        public double BaseTriangulo
        {
            get { return baseTriangulo; }
            set { baseTriangulo = value; }
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }

        public double Lado1
        {
            get { return lado1; }
            set { lado1 = value; }
        }

        public double Lado2
        {
            get { return lado2; }
            set { lado2 = value; }
        }

        public double Lado3
        {
            get { return lado3; }
            set { lado3 = value; }
        }

        public override double area()
        {
            double s = (lado1 + lado2 + lado3) / 2;
            return Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
        }

        public override double perimetro()
        {
            return lado1 + lado2 + lado3;
        }
    }
}
