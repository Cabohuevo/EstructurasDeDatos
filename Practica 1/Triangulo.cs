﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricalPictures
{
    public class Triangulo : Figura
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public override double Area()
        {
          
            double s = (lado1 + lado2 + lado3) / 2;
            double area = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));
            return area;
        }

        public override double Perimetro()
        {
            return lado1 + lado2 + lado3;
        }
    }
}