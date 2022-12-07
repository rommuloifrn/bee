using System;

using System.Globalization;
using System.Threading;

/*  */

class MainClass {
    public static void Main(string[] args) {
        CultureInfo ci = new CultureInfo("pt-BR");
        Thread.CurrentThread.CurrentCulture = ci;

        DateTime dt = DateTime.Now;
        Console.WriteLine(dt);
        Console.WriteLine($"Dia é {dt.DayOfWeek}!");
        Console.WriteLine($"É o {dt.DayOfYear}º dia do ano!");
        Console.WriteLine($"Formatado em string: {dt.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Formatado novamente: {dt.ToString("ddd, dd MMM, yyyy")}");

        Classe x = Classe.Colosso;
        Console.WriteLine(x);
        Role y = (Role) 3;
        // typecast abaixo
        Console.WriteLine($"{y} ({(byte)y})\n\n\n");

        

    }
}
enum Classe {
    Colosso, Ladino, Atirador, Mago
}
enum Role : byte {
    Toplaner = 1, Jungler = 2, Midlaner = 3, AttackDamageCarry = 4, Suporte = 5
}

class Pessoa {
    private string nome;
    private DateTime nasc;
    public Pessoa (string nome, DateTime nasc) {
        this.nome = nome;
        this.nasc = nasc;
    }
    public DayOfWeek DiaNascimento() {
        return nasc.DayOfWeek;
    }
    public TimeSpan DiasVividos() {
        return DateTime.Today - Nasc;
    }
}