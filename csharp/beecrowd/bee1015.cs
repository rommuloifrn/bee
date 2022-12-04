using System; 

class URI {

    static void Main(string[] args) { 

        string[] point1 = Console.ReadLine().Split(' ');
        double x1 = Double.Parse(point1[0]);
        double y1 = Double.Parse(point1[1]);
        string[] point2 = Console.ReadLine().Split(' ');
        double x2 = Double.Parse(point2[0]);
        double y2 = Double.Parse(point2[1]);

        // Falar com Gilbert sobre legibilidade do código, quanta função!
        string distance = String.Format("{0:.0000}", Math.Sqrt(Math.Pow(x2 - x1, 2)+Math.Pow(y2 - y1, 2)) );
        Console.WriteLine($"{distance}");

    }

}