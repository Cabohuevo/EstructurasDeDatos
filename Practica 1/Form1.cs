namespace GeometricalPictures;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }
    //Validaciones
    private bool ValidarCuadrado(double lado)
    {
        return lado > 0;
    }

    private bool ValidarCirculo(double radio)
    {
        return radio > 0;
    }

    private bool ValidarRectangulo(double baseRectangulo, double alturaRectangulo)
    {
        return baseRectangulo > 0 && alturaRectangulo > 0;
    }

    private bool ValidarTriangulo(double lado1, double lado2, double lado3)
    {
        return (lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1) &&
            lado1 > 0 && lado2 > 0 && lado3 > 0;
    }


    //Validaciones


    //Activar el panel de circulo
    private void button1_Click(object sender, EventArgs e)
    {
        panel1.Enabled = true;
        panel2.Enabled = false;
        panel3.Enabled = false;
        panel4.Enabled = false;
        panel1.Visible = true;
        panel2.Visible = false;
        panel3.Visible = false;
        panel4.Visible = false;

        //Limpiar los demás campos
        numericUpDownL1Triangulo.Text = "";
        numericUpDownL2Triangulo.Text = "";
        numericUpDownL3Triangulo.Text = "";
        numericUpDownRBase.Text = "";
        numericUpDownRAltura.Text = "";
        numericUpDownCuLado.Text = "";
       

    }
    //Activar el panel de Rectangulo
    private void button2_Click(object sender, EventArgs e)
    {
        panel1.Enabled = false;
        panel2.Enabled = true;
        panel3.Enabled = false;
        panel4.Enabled = false;
        panel1.Visible = false;
        panel2.Visible = true;
        panel3.Visible = false;
        panel4.Visible = false;
        //Limpiar los demás campos
        numericUpDownL1Triangulo.Text = "";
        numericUpDownL2Triangulo.Text = "";
        numericUpDownL3Triangulo.Text = "";
        numericUpDownCRadio.Text = "";
        numericUpDownCuLado.Text = "";
    }
    //Calcular circulo
    private void BtnCCalcular_Click(object sender, EventArgs e)
    {
        // Obtén el radio desde el control numérico
        double radioCirculo = (double)numericUpDownCRadio.Value;

        if (!ValidarCirculo(radioCirculo))
        {
            MessageBox.Show("Valores inválidos para el circulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Crea una instancia de Circulo
        Circulo circulo = new Circulo
        {
            Radio = radioCirculo
        };

        // Calcula el área y el perímetro
        double areaCirculo = circulo.Area();
        double perimetroCirculo = circulo.Perimetro();

        // Muestra los resultados en etiquetas o donde desees
        LblCArea.Text = $"{areaCirculo}";
        LblCPerimetro.Text = $"{perimetroCirculo}";
    }
    //Calcular Rectangulo
    private void BtnRCalcular_Click(object sender, EventArgs e)
    {
        // Obtén la base y la altura desde los controles numericos
        double baseRectangulo = (double)numericUpDownRBase.Value;
        double alturaRectangulo = (double)numericUpDownRAltura.Value;

        if (!ValidarRectangulo(baseRectangulo,alturaRectangulo))
        {
            MessageBox.Show("Valores inválidos para el rectangulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Crea una instancia de Rectangulo
        Rectangulo rectangulo = new Rectangulo
        {
            Bases = baseRectangulo,
            Altura = alturaRectangulo
        };

        // Calcula el área y el perímetro
        double areaRectangulo = rectangulo.Area();
        double perimetroRectangulo = rectangulo.Perimetro();

        // Muestra los resultados en etiquetas o donde desees
        LblRArea.Text = $"{areaRectangulo}";
        LblRPerimetro.Text = $"{perimetroRectangulo}";
    }
    //Activar el panel de triangulo
    private void btn3_Click(object sender, EventArgs e)
    {
        panel1.Enabled = false;
        panel2.Enabled = false;
        panel3.Enabled = true;
        panel4.Enabled = false;
        panel1.Visible = false;
        panel2.Visible = false;
        panel3.Visible = true;
        panel4.Visible = false;

        //Limpiar los demás campos
        numericUpDownCRadio.Text = "";
        numericUpDownRBase.Text = "";
        numericUpDownRAltura.Text = "";
        numericUpDownCuLado.Text = "";
    }
    //Activar el panel de cuadrado
    private void button5_Click(object sender, EventArgs e)
    {
        panel1.Enabled = false;
        panel2.Enabled = false;
        panel3.Enabled = false;
        panel4.Enabled = true;
        panel1.Visible = false;
        panel2.Visible = false;
        panel3.Visible = false;
        panel4.Visible = true;
        //Limpiar los demás campos
        numericUpDownL1Triangulo.Text = "";
        numericUpDownL2Triangulo.Text = "";
        numericUpDownL3Triangulo.Text = "";
        numericUpDownCRadio.Text = "";
        numericUpDownRBase.Text = "";
        numericUpDownRAltura.Text = "";
    }

    private void BtnTCalcular_Click(object sender, EventArgs e)
    {
       
            // Obtén los valores de los lados desde los controles numéricos
            double lado1 = (double)numericUpDownL1Triangulo.Value;
            double lado2 = (double)numericUpDownL2Triangulo.Value;
            double lado3 = (double)numericUpDownL3Triangulo.Value;

            // Realiza las validaciones de los lados
            if (ValidarTriangulo(lado1, lado2, lado3))
            {
                // Verifica el tipo de triángulo en función de las longitudes de los lados
                string tipoTriangulo = "";
                if (lado1 == lado2 && lado2 == lado3)
                {
                    tipoTriangulo = "Equilátero";
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    tipoTriangulo = "Isósceles";
                }
                else
                {
                    tipoTriangulo = "Escaleno";
                }


            Triangulo triangulo = new Triangulo(lado1, lado2, lado3);

            // Calcula el área y el perímetro
            double areaTriangulo = triangulo.Area();
            double perimetroTriangulo = triangulo.Perimetro();

            // Muestra los resultados en etiquetas o donde desees
            LblTArea.Text = $"{areaTriangulo}";
            LblTPerimetro.Text = $"{perimetroTriangulo}";
            // Muestra el resultado en el Label LblTTipo
            LblTTipo.Text = $"{tipoTriangulo}";
        }
            else
            {
                MessageBox.Show("Valores inválidos para el triángulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }

    private void BtnCuCalcular_Click(object sender, EventArgs e)
    {
        // Obtén el valor del lado desde el control numérico
        double ladoCuadrado = (double)numericUpDownCuLado.Value;

        if (!ValidarCuadrado(ladoCuadrado))
        {
            MessageBox.Show("Valores inválidos para el cuadrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // Crea una instancia de Cuadrado
        Cuadrado cuadrado = new Cuadrado(ladoCuadrado);

        // Calcula el área y el perímetro
        double areaCuadrado = cuadrado.Area();
        double perimetroCuadrado = cuadrado.Perimetro();

        // Muestra los resultados en etiquetas o donde desees
        LblCuArea.Text = $"{areaCuadrado}";
        LblCuPerimetro.Text = $"{perimetroCuadrado}";
    }

    
}
