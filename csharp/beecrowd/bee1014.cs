using System; 

class URI {

    static void Main(string[] args) { 

        int distance = Int32.Parse(Console.ReadLine());
        double fuelSpent = Double.Parse(Console.ReadLine());

        string consumption = String.Format("{0:.000}", (distance/fuelSpent));
        Console.WriteLine($"{consumption} km/l");

    }

}