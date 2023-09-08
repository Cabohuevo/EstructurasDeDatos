namespace GeometricalPictures;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownCRadio = new System.Windows.Forms.NumericUpDown();
            this.LblCArea = new System.Windows.Forms.Label();
            this.LblCPerimetro = new System.Windows.Forms.Label();
            this.BtnCCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDownRAltura = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRBase = new System.Windows.Forms.NumericUpDown();
            this.LblRArea = new System.Windows.Forms.Label();
            this.LblRPerimetro = new System.Windows.Forms.Label();
            this.BtnRCalcular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDownCuLado = new System.Windows.Forms.NumericUpDown();
            this.LblCuArea = new System.Windows.Forms.Label();
            this.LblCuPerimetro = new System.Windows.Forms.Label();
            this.BtnCuCalcular = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblTTipo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownL3Triangulo = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownL2Triangulo = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.numericUpDownL1Triangulo = new System.Windows.Forms.NumericUpDown();
            this.LblTArea = new System.Windows.Forms.Label();
            this.LblTPerimetro = new System.Windows.Forms.Label();
            this.BtnTCalcular = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCRadio)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRBase)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCuLado)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL3Triangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL2Triangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL1Triangulo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Circulo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Rectangulo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDownCRadio);
            this.panel1.Controls.Add(this.LblCArea);
            this.panel1.Controls.Add(this.LblCPerimetro);
            this.panel1.Controls.Add(this.BtnCCalcular);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(68, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 218);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // numericUpDownCRadio
            // 
            this.numericUpDownCRadio.DecimalPlaces = 2;
            this.numericUpDownCRadio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownCRadio.Location = new System.Drawing.Point(21, 50);
            this.numericUpDownCRadio.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownCRadio.Name = "numericUpDownCRadio";
            this.numericUpDownCRadio.Size = new System.Drawing.Size(158, 23);
            this.numericUpDownCRadio.TabIndex = 7;
            this.numericUpDownCRadio.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // LblCArea
            // 
            this.LblCArea.AutoSize = true;
            this.LblCArea.Location = new System.Drawing.Point(122, 119);
            this.LblCArea.Name = "LblCArea";
            this.LblCArea.Size = new System.Drawing.Size(10, 15);
            this.LblCArea.TabIndex = 6;
            this.LblCArea.Text = ".";
            // 
            // LblCPerimetro
            // 
            this.LblCPerimetro.AutoSize = true;
            this.LblCPerimetro.Location = new System.Drawing.Point(19, 119);
            this.LblCPerimetro.Name = "LblCPerimetro";
            this.LblCPerimetro.Size = new System.Drawing.Size(10, 15);
            this.LblCPerimetro.TabIndex = 5;
            this.LblCPerimetro.Text = ".";
            // 
            // BtnCCalcular
            // 
            this.BtnCCalcular.Location = new System.Drawing.Point(19, 155);
            this.BtnCCalcular.Name = "BtnCCalcular";
            this.BtnCCalcular.Size = new System.Drawing.Size(88, 48);
            this.BtnCCalcular.TabIndex = 4;
            this.BtnCCalcular.Text = "Calcular";
            this.BtnCCalcular.UseVisualStyleBackColor = true;
            this.BtnCCalcular.Click += new System.EventHandler(this.BtnCCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Perimetro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radio";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericUpDownRAltura);
            this.panel2.Controls.Add(this.numericUpDownRBase);
            this.panel2.Controls.Add(this.LblRArea);
            this.panel2.Controls.Add(this.LblRPerimetro);
            this.panel2.Controls.Add(this.BtnRCalcular);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(68, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 218);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // numericUpDownRAltura
            // 
            this.numericUpDownRAltura.DecimalPlaces = 2;
            this.numericUpDownRAltura.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownRAltura.Location = new System.Drawing.Point(135, 50);
            this.numericUpDownRAltura.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRAltura.Name = "numericUpDownRAltura";
            this.numericUpDownRAltura.Size = new System.Drawing.Size(86, 23);
            this.numericUpDownRAltura.TabIndex = 9;
            this.numericUpDownRAltura.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numericUpDownRBase
            // 
            this.numericUpDownRBase.DecimalPlaces = 2;
            this.numericUpDownRBase.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownRBase.Location = new System.Drawing.Point(16, 50);
            this.numericUpDownRBase.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRBase.Name = "numericUpDownRBase";
            this.numericUpDownRBase.Size = new System.Drawing.Size(86, 23);
            this.numericUpDownRBase.TabIndex = 8;
            this.numericUpDownRBase.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // LblRArea
            // 
            this.LblRArea.AutoSize = true;
            this.LblRArea.Location = new System.Drawing.Point(147, 119);
            this.LblRArea.Name = "LblRArea";
            this.LblRArea.Size = new System.Drawing.Size(10, 15);
            this.LblRArea.TabIndex = 8;
            this.LblRArea.Text = ".";
            // 
            // LblRPerimetro
            // 
            this.LblRPerimetro.AutoSize = true;
            this.LblRPerimetro.Location = new System.Drawing.Point(22, 119);
            this.LblRPerimetro.Name = "LblRPerimetro";
            this.LblRPerimetro.Size = new System.Drawing.Size(10, 15);
            this.LblRPerimetro.TabIndex = 7;
            this.LblRPerimetro.Text = ".";
            // 
            // BtnRCalcular
            // 
            this.BtnRCalcular.Location = new System.Drawing.Point(16, 155);
            this.BtnRCalcular.Name = "BtnRCalcular";
            this.BtnRCalcular.Size = new System.Drawing.Size(95, 48);
            this.BtnRCalcular.TabIndex = 6;
            this.BtnRCalcular.Text = "Calcular";
            this.BtnRCalcular.UseVisualStyleBackColor = true;
            this.BtnRCalcular.Click += new System.EventHandler(this.BtnRCalcular_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Area";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Perimetro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Base";
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(129, 12);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(91, 40);
            this.btn3.TabIndex = 4;
            this.btn3.Text = "Triangulo";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numericUpDownCuLado);
            this.panel4.Controls.Add(this.LblCuArea);
            this.panel4.Controls.Add(this.LblCuPerimetro);
            this.panel4.Controls.Add(this.BtnCuCalcular);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Enabled = false;
            this.panel4.Location = new System.Drawing.Point(58, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 201);
            this.panel4.TabIndex = 11;
            this.panel4.Visible = false;
            // 
            // numericUpDownCuLado
            // 
            this.numericUpDownCuLado.DecimalPlaces = 2;
            this.numericUpDownCuLado.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownCuLado.Location = new System.Drawing.Point(16, 50);
            this.numericUpDownCuLado.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownCuLado.Name = "numericUpDownCuLado";
            this.numericUpDownCuLado.Size = new System.Drawing.Size(184, 23);
            this.numericUpDownCuLado.TabIndex = 8;
            this.numericUpDownCuLado.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // LblCuArea
            // 
            this.LblCuArea.AutoSize = true;
            this.LblCuArea.Location = new System.Drawing.Point(147, 119);
            this.LblCuArea.Name = "LblCuArea";
            this.LblCuArea.Size = new System.Drawing.Size(10, 15);
            this.LblCuArea.TabIndex = 8;
            this.LblCuArea.Text = ".";
            // 
            // LblCuPerimetro
            // 
            this.LblCuPerimetro.AutoSize = true;
            this.LblCuPerimetro.Location = new System.Drawing.Point(22, 119);
            this.LblCuPerimetro.Name = "LblCuPerimetro";
            this.LblCuPerimetro.Size = new System.Drawing.Size(10, 15);
            this.LblCuPerimetro.TabIndex = 7;
            this.LblCuPerimetro.Text = ".";
            // 
            // BtnCuCalcular
            // 
            this.BtnCuCalcular.Location = new System.Drawing.Point(16, 148);
            this.BtnCuCalcular.Name = "BtnCuCalcular";
            this.BtnCuCalcular.Size = new System.Drawing.Size(95, 48);
            this.BtnCuCalcular.TabIndex = 6;
            this.BtnCuCalcular.Text = "Calcular";
            this.BtnCuCalcular.UseVisualStyleBackColor = true;
            this.BtnCuCalcular.Click += new System.EventHandler(this.BtnCuCalcular_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(147, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "Area";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "Perimetro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Lado";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LblTTipo);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.numericUpDownL3Triangulo);
            this.panel3.Controls.Add(this.numericUpDownL2Triangulo);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.numericUpDownL1Triangulo);
            this.panel3.Controls.Add(this.LblTArea);
            this.panel3.Controls.Add(this.LblTPerimetro);
            this.panel3.Controls.Add(this.BtnTCalcular);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(68, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(321, 201);
            this.panel3.TabIndex = 10;
            this.panel3.Visible = false;
            // 
            // LblTTipo
            // 
            this.LblTTipo.AutoSize = true;
            this.LblTTipo.Location = new System.Drawing.Point(208, 117);
            this.LblTTipo.Name = "LblTTipo";
            this.LblTTipo.Size = new System.Drawing.Size(10, 15);
            this.LblTTipo.TabIndex = 13;
            this.LblTTipo.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tipo";
            // 
            // numericUpDownL3Triangulo
            // 
            this.numericUpDownL3Triangulo.DecimalPlaces = 2;
            this.numericUpDownL3Triangulo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownL3Triangulo.Location = new System.Drawing.Point(216, 50);
            this.numericUpDownL3Triangulo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownL3Triangulo.Name = "numericUpDownL3Triangulo";
            this.numericUpDownL3Triangulo.Size = new System.Drawing.Size(83, 23);
            this.numericUpDownL3Triangulo.TabIndex = 11;
            this.numericUpDownL3Triangulo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // numericUpDownL2Triangulo
            // 
            this.numericUpDownL2Triangulo.DecimalPlaces = 2;
            this.numericUpDownL2Triangulo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownL2Triangulo.Location = new System.Drawing.Point(122, 50);
            this.numericUpDownL2Triangulo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownL2Triangulo.Name = "numericUpDownL2Triangulo";
            this.numericUpDownL2Triangulo.Size = new System.Drawing.Size(83, 23);
            this.numericUpDownL2Triangulo.TabIndex = 10;
            this.numericUpDownL2Triangulo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(235, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 15);
            this.label20.TabIndex = 9;
            this.label20.Text = "Lado3";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(140, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 15);
            this.label19.TabIndex = 8;
            this.label19.Text = "Lado2";
            // 
            // numericUpDownL1Triangulo
            // 
            this.numericUpDownL1Triangulo.DecimalPlaces = 2;
            this.numericUpDownL1Triangulo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownL1Triangulo.Location = new System.Drawing.Point(19, 50);
            this.numericUpDownL1Triangulo.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownL1Triangulo.Name = "numericUpDownL1Triangulo";
            this.numericUpDownL1Triangulo.Size = new System.Drawing.Size(88, 23);
            this.numericUpDownL1Triangulo.TabIndex = 7;
            this.numericUpDownL1Triangulo.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // LblTArea
            // 
            this.LblTArea.AutoSize = true;
            this.LblTArea.Location = new System.Drawing.Point(122, 119);
            this.LblTArea.Name = "LblTArea";
            this.LblTArea.Size = new System.Drawing.Size(10, 15);
            this.LblTArea.TabIndex = 6;
            this.LblTArea.Text = ".";
            // 
            // LblTPerimetro
            // 
            this.LblTPerimetro.AutoSize = true;
            this.LblTPerimetro.Location = new System.Drawing.Point(19, 119);
            this.LblTPerimetro.Name = "LblTPerimetro";
            this.LblTPerimetro.Size = new System.Drawing.Size(10, 15);
            this.LblTPerimetro.TabIndex = 5;
            this.LblTPerimetro.Text = ".";
            // 
            // BtnTCalcular
            // 
            this.BtnTCalcular.Location = new System.Drawing.Point(19, 148);
            this.BtnTCalcular.Name = "BtnTCalcular";
            this.BtnTCalcular.Size = new System.Drawing.Size(88, 48);
            this.BtnTCalcular.TabIndex = 4;
            this.BtnTCalcular.Text = "Calcular";
            this.BtnTCalcular.UseVisualStyleBackColor = true;
            this.BtnTCalcular.Click += new System.EventHandler(this.BtnTCalcular_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(122, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 15);
            this.label16.TabIndex = 3;
            this.label16.Text = "Area";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 15);
            this.label17.TabIndex = 2;
            this.label17.Text = "Perimetro";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(39, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "Lado1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(349, 15);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 37);
            this.button5.TabIndex = 12;
            this.button5.Text = "Cuadrado";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 290);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Formas";
           
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCRadio)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRBase)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCuLado)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL3Triangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL2Triangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownL1Triangulo)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private Button button1;
    private Button button2;
    private Panel panel1;
    private Button BtnCCalcular;
    private Label label3;
    private Label label2;
    private Label label1;
    private Panel panel2;
    private Button BtnRCalcular;
    private Label label7;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label LblCArea;
    private Label LblCPerimetro;
    private Label LblRArea;
    private Label LblRPerimetro;
    private Button btn3;
    private NumericUpDown numericUpDownCRadio;
    private NumericUpDown numericUpDownRAltura;
    private NumericUpDown numericUpDownRBase;
    private Panel panel3;
    private NumericUpDown numericUpDownCuLado;
    private Label LblCuArea;
    private Label LblCuPerimetro;
    private Button BtnCuCalcular;
    private Label label10;
    private Label label11;
    private Label label13;
    private Panel panel4;
    private NumericUpDown numericUpDownL1Triangulo;
    private Label LblTArea;
    private Label LblTPerimetro;
    private Button BtnTCalcular;
    private Label label16;
    private Label label17;
    private Label label18;
    private Button button5;
    private NumericUpDown numericUpDownL3Triangulo;
    private NumericUpDown numericUpDownL2Triangulo;
    private Label label20;
    private Label label19;
    private Label LblTTipo;
    private Label label8;
}
