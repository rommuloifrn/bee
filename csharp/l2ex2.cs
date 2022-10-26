using System; 

public class Program {

    public static void Main(string[] args) {
        Console.WriteLine("Digite seu nome completo:");
        string x = Console.ReadLine();
        string[] xs = x.Split(' ');
        Console.WriteLine($"Bem vindo ao C#, {xs[0]}");
    }
}