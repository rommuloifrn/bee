using System;

public class Program {

    public static void Main(string[] args) {

        Console.WriteLine("Digite a base e a altura do retâgulo:");
        double baase = Convert.ToDouble(Console.ReadLine());
        double altura = Convert.ToDouble(Console.ReadLine());

        double area = baase * altura;
        double perimetro = altura*2 + baase*2;
        double diagonal = Math.Sqrt(Math.Pow(baase,2) + Math.Pow(altura, 2));

        Console.WriteLine($"Área = {area} - Perímetro = {perimetro} - Diagonal = {diagonal}");
        

    }
}