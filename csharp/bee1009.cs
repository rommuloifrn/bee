using System; 

class URI {

    static void Main(string[] args) { 

        string nome = Console.ReadLine();
        double salario = Convert.ToDouble(Console.ReadLine());
        double sold = Convert.ToDouble(Console.ReadLine());
        double comissao = sold*15/100;
        // string total = String.Format("{0:.00}", (salario + comissao) );
        double total = salario + comissao;

        Console.WriteLine($"TOTAL = R$ {String.Format("{0:.00}", (total))}");


    }

}