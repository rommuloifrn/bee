using System;

/* Um construtor é um método no objeto que, levando o nome
do próprio objeto, altera a forma como ele é declarado */
/* Um objeto pode ter vários construtores com quantidades
de atributos diferentes */

class MainClass {
    public static void Main(string[] args) {

        Triangulo x = new Triangulo();

        Triangulo y = new Triangulo(10, 30);
        Console.WriteLine(x.GetArea());
        Console.WriteLine(y.GetArea());
    /* ToString é um método padrão de todos os objetos.
    Por padrão, retorna a classe do objeto, nesse caso,
    Triangulo, mas pode ser alterada (vide métodos do objeto).
    */
        Console.WriteLine(x.ToString());
    }
}

class Triangulo {
    private double b, h;

    public Triangulo(double vb, double vh) {
        if (vb > 0) b = vb;
        if (vh > 0) h = vh;
    }
    /* Abaixo, caso não haja nenhum valor na declaração, o
    segundo construtor será considerado (nesse caso declarando
    valores nele próprio) */
    public Triangulo() {
        //b = 10;
        //h = 2400;
    }

    public double GetBase() {
        return b;
    }
    public double GetArea() {
        return b*h/2;
    }
    /* Por praticidade, se dá o mesmo nome para o parâmetro 
    de um método e a variável que ele vai modificar. Pra 
    diferenciar um do outro, a variável é referenciada
    usando this.variavel: */
    public void SetBase(double b) {
        this.b = b;
    }
    public override string ToString() {
        return $"Base = {b}, Altura = {h} ";
    }
    

}