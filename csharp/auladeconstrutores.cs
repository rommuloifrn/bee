using System;

/* Um construtor é um método no objeto que, levando o nome
do próprio objeto, altera a forma como ele é declarado */

class MainClass {
    public static void Main(string[] args) {
        Triangulo x = new Triangulo();

        Console.WriteLine(x.GetBase(10, 20));
    }
}

class Triangulo {
    private double b, h;
    public Triangulo(double vb, double vh) {
        if (vb > 0) b = vb;
        if (vh > 0) h = vh;
    }
    public double GetBase() {
        return b;
    }

}