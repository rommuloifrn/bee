using System; 

class URI {

    static void Main(string[] args) { 

        string[] num = Console.ReadLine().Split(' ');
        int a = Int32.Parse(num[0]);
        int b = Int32.Parse(num[1]);
        int c = Int32.Parse(num[2]);

        int x = (a+b+Math.Abs(a-b))/2;
        int result = (x+c+Math.Abs(x-c))/2;

        Console.WriteLine($"{result} eh o maior");

    }

}