using System;

public class Program {

    public static void Main(string[] args) {

        Console.WriteLine("Digite o intervalo de tempo no formato \"HH:MM:SS\"");
        string[] tempo = Console.ReadLine().Split(':');
        
        long tempofinal = Convert.ToInt32(tempo[0])*60*60 + Convert.ToInt32(tempo[1])*60 + Convert.ToInt32(tempo[2]);
        long distancia = 300000*tempofinal;
        Console.WriteLine($"A luz percorreu {distancia} km nesse intervalo");

    }
}