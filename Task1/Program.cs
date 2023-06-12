/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
class Program {
  public static void Main(string[] args) {
    int rows = Prompt("Введите количество строк массива: ");
    int cols = Prompt("Введите количество колонок массива: ");
    double[,] matrix = GetArray(rows, cols);
    PrintMatrix(matrix);
  }

  static int Prompt(string message) {
    Console.Write(message);
    string readInput = Console.ReadLine() ?? "Null";
    int number;
    bool isNumber = int.TryParse(readInput, out number);
    return number;
  }

  static double[,] GetArray(int m, int n) {
    var lowerLimit = -10;
    var upperLimit = 10;
    double[,] arr = new double[m,n];
    FillArray(arr, lowerLimit, upperLimit);
    return arr;
  }
    
  static void FillArray(double[,] arr, int down, int up) {
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++) {
      for (int j = 0; j < arr.GetLength(1); j++) {
        arr[i,j] = Math.Round(rand.NextDouble() * (up - down) + down, 1);
      }
    }
  }

  static void PrintMatrix(double[,] array) {
    string separator;
    int lengthChar;
    for (int i = 0; i < array.GetLength(0); i++) {
      for (int j = 0; j < array.GetLength(1); j++) {
        lengthChar = array[i,j].ToString().Length;
        if (lengthChar == 1) separator = "      ";
        else if (lengthChar == 2) separator = "     ";
        else if (lengthChar == 3) separator = "    ";
        else separator = "   ";
        Console.Write(array[i,j] + separator);
      }
      Console.WriteLine();
    }
  }
}
