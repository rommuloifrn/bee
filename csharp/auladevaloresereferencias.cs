using System;

/* As variáveis no C# são armazenadas das memórias stack e heap. Variáveis locais e
parâmetros ficam na memória stack (no código, bx, hx e x) enquanto instâncias de classes ficam na
heap (no código, objeto Triangulo) */
// Então tudo da Main fica na stack e tudo dos objetos fica na heap?
/* Aparentemente, há uma stack pra cada classe. Nesse sentido, a stack de Triangulo 
guarda as referências de seus valores na heap. */

class MainClass {
    public static void Main(string[] args) {
        double bx = 10;
        double hx = 20;
        string cx = "Azul";

        Triangulo x = new Triangulo(bx, hx, cx);
        Console.WriteLine($"Triangulo x é criado e sua base é {x.GetBase()}");
        Triangulo y = x;
        Console.WriteLine($"Triangulo y é criado, copiado de x");
        y.SetBase(3);
        Console.WriteLine("Base de y é setada em 3");
        Console.WriteLine($"Base de x: {x.GetBase()}");
    }
}
class Triangulo {
    private double b, h;
    private string c;

    public Triangulo(double b, double h, string c) {
        this.b = b;
        this.h = h;
        this.c = c;
    }
    public double GetBase() {
        return b;
    }
    public void SetBase(double b) {
        this.b = b;
    }
}
