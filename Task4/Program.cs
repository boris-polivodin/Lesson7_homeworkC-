/*
Дополнительное:

Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/
class Program {
    public static void Main(string[] args) {
        int[,] matrix = GetArray();
        PrintMatrix(matrix);
        Console.Write("Сумма элементов главной диагонали: " + SumCalculater(matrix));
    }

    static int[,] GetArray() {
        Random rand = new Random();
        int[,] arr = new int[rand.Next(2, 11), rand.Next(2, 11)];
        FillArray(arr);
        return arr;
    }
    
    static void FillArray(int[,] arr) {
        Random rand = new Random();
        for (int i = 0; i < arr.GetLength(0); i++) {
            for (int j = 0; j < arr.GetLength(1); j++) {
                arr[i,j] = rand.Next(10);
            }
        }
    }

    static void PrintMatrix(int[,] array) {
        for (int i = 0; i < array.GetLength(0); i++) {
            for (int j = 0; j < array.GetLength(1); j++) {
                Console.Write(array[i,j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static string SumCalculater(int[,] array) {
        string result = string.Empty;
        double sum = 0;
        int lengthRow = array.GetLength(0);
        int lengthCol = array.GetLength(1);
        for (int i = 0; i < lengthRow && i < lengthCol; i++) {
           sum += array[i,i];
           result += array[i,i] + (i < lengthRow - 1 && i < lengthCol - 1 ? "+" : ""); 
        }

        result += " = " + sum;
        return result;
    }
}