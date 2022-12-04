using System;

public class Program {

    public static void Main(string[] args) {
    
        Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int media = ( (n1*2) + (n2*3) ) / 5;

        Console.WriteLine($"Média parcial = {media}");
    }
}