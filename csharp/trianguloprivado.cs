using System;

class MainClass {
    public static void Main(string[] args) {

        // Declara uma variável de "tipo" Triangulo na memória
        Triangulo x; 
        // new instancia oobjeto, adiciona no espaço de memória
        x = new Triangulo();
        x.SetBase(10);
        x.SetAltura(20);
        Console.WriteLine(x.CalcArea());

    }
}

class Triangulo {
            private double b, h;

            public void SetBase(double entrada){
                if (entrada > 0) {
                    b = entrada;
                }
            }

            public void SetAltura(double entrada){
                if (entrada > 0) {
                    h = entrada;
                }
            }

            public double GetBase(){
                return b;
            }
            public double GetAltura(){
                return h;
            }
            public double CalcArea() {
                return b * h / 2;
            }
        }