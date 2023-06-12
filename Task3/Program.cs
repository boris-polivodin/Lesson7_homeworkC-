/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
class Program {
    public static void Main(string[] args) {
        int[,] matrix = GetArray();
        PrintMatrix(matrix);
        Console.Write("Среднее арифметическое каждого столбца: " + SearchAverage(matrix));
    }

    static int[,] GetArray() {
        var lowerLmit = 2;
        var upperLimit = 11;
        Random rand = new Random();
        int[,] arr = new int[rand.Next(lowerLmit, upperLimit), rand.Next(lowerLmit, upperLimit)];
        FillArray(arr);
        return arr;
    }
    
    static void FillArray(int[,] arr) {
        var maxValue = 10;
        Random rand = new Random();
        for (int i = 0; i < arr.GetLength(0); i++) {
            for (int j = 0; j < arr.GetLength(1); j++) {
                arr[i,j] = rand.Next(maxValue);
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

    static string SearchAverage(int[,] array) {
        string result = string.Empty;
        double sum = 0;
        int lengthRow = array.GetLength(0);
        int lengthCol = array.GetLength(1);
        for (int j = 0; j < lengthCol; j++) {
            sum = 0;
            for (int i = 0; i < lengthRow; i++) {
                sum += array[i,j];
            }
            result += Math.Round(sum/lengthRow,1) + (j < lengthCol - 1 ? "; " : ".");
        }
        return result;
    }
}