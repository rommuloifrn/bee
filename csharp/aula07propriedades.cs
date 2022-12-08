using System;

/*  */

class MainClass {
    public static void Main(string[] args) {

        Triangulo x = new Triangulo();
        Triangulo y = new Triangulo(10, 30);
        Console.WriteLine(x.GetArea());
        Console.WriteLine(y.GetArea());

        x.Base = 100;
        x.Altura = 200;
    
        Console.WriteLine(x.ToString());
        Console.WriteLine(x.Area);
    }
}

class Triangulo {
    private double b, h;

    public Triangulo(double vb, double vh) {
        if (vb > 0) b = vb;
        if (vh > 0) h = vh;
    }
   
    public Triangulo() {
        //b = 10;
        //h = 2400;
    }
    
    public double Base {
        get { return b; }
        set { if (value > 0) b = value;}
    }
    public double Altura {
        get { return h; }
        set { if (value > 0) h = value;}
    }
    public double Area {
        get { return b*h/2; }
    }
    public double GetBase() {
        return b;
    }
    public void SetBase(double b) {
        this.b = b;
    }
    public double GetArea() {
        return b*h/2;
    }

    public override string ToString() {
        return $"Base = {b}, Altura = {h} ";
    }
}