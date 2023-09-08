using System;

namespace GeometricalPictures;

public class Rectangulo : Figura
{

    double bases;
    double altura;

    public Rectangulo()
    {
      
    }

    public double Bases
    {
        get => bases;
        set => bases = value;
    }

    public double Altura
    {
        get => altura;
        set => altura = value;
    }

    public override double Area()
    {
        return (Bases * Altura) / 2;
    }

    public override double Perimetro()
    {
        return (Bases * 2 + Altura * 2);
    }
}
