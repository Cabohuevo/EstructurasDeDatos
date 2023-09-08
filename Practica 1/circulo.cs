using System.Text.RegularExpressions;
using System;
namespace GeometricalPictures
{
    public class Circulo : Figura
    {
        private double radio;

        public Circulo()
        {

        }

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public override double Area()
        {
            return Math.PI * (radio * radio);
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}