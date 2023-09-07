using System;

namespace Tarea
{
    public class Cuadrado : Figura
    {
        private double lado;

        public Cuadrado()
        {

        }

        public double Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public override double area()
        {
            return lado * lado;
        }

        public override double perimetro()
        {
            return 4 * lado;
        }
    }
}
