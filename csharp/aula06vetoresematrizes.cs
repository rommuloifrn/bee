using System;

/*  */

class MainClass {
    public static void Main(string[] args) {
        
        // int[] meuvetor = new int[QuantidadeDeValores];
        int[] meuvetor = {1, 3, 4, 5, 7};
        Console.WriteLine(meuvetor[1]);

        Console.WriteLine($"A quantidade de elementos é: {meuvetor.Length}");
        Console.WriteLine($"A quantidade de dimensões é: {meuvetor.Rank}");

        int[] meusegundovetor = new int[4];
        Array.Copy(meuvetor, meusegundovetor, 3);

        foreach(int i in meusegundovetor) {
            Console.WriteLine($"{i} ");
        }

        int[] meuterceirovetor;
        meuterceirovetor = (int[]) meuvetor.Clone();

        foreach(int i in meuterceirovetor) {
            Console.WriteLine($"{i} ");
        }

        // Matrizes

        Console.WriteLine("aqui começamos matrizes >:)");
        int[,] x = {{1,2,3},{6,7,8}};
        int[,] y = new int[3,4];

        CorreMatriz(x);
        

    }
//  errinho!!!
    public static void CorreMatriz(int[,] matriz) {
        Console.WriteLine("Minha matrix:");
            for (int i = 0; i < matriz.GetLength(0)-1; i++){
                for (int j = 0; i < matriz.GetLength(1)-1; i++) {
                    Console.WriteLine(matriz[i, j]);
                }
            } 
    }
}