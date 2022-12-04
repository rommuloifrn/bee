using System;

class MainClass {
    public static void Main(string[] args) {

        // Declara uma variável de "tipo" Triangulo na memória
        Triangulo x; 
        // new instancia oobjeto, adiciona no espaço de memória
        x = new Triangulo();
        x.b = 10;
        x.h = 20;

        Console.WriteLine(x.CalcArea());
        Triangulo y = new Triangulo();
        y.b = 35;
        y.h = 26;
        Console.WriteLine(y.CalcArea());
    }
}

class Triangulo {
            public double b, h;
            public double CalcArea() {
                return b*h/2;
            }
        }