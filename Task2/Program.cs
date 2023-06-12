/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
class Program {
    public static void Main(string[] args) {
        int row = Prompt("Введите позицию строки массива: ");
        int column = Prompt("Введите позицию колонки массива: ");
        int[,] matrix = GetArray();
        PrintMatrix(matrix);
        SearchElement(matrix, row, column);
    }

    static int Prompt(string message) {
        Console.Write(message);
        string readInput = Console.ReadLine() ?? "Null";
        int number;
        bool isNumber = int.TryParse(readInput, out number);
        return number;
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
        Random rand = new Random();
        var maxValue = 10;
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

    static void SearchElement(int[,] arr, int numberRow, int numberCol) {
        if (numberRow < arr.GetLength(0) && numberCol < arr.GetLength(1)) {
           Console.WriteLine($"Значение элемента arr[{numberRow},{numberCol}] = {arr[numberRow,numberCol]}");
        }
        else
        {
            Console.WriteLine("Такого элемента в массиве нет.");
        }
    }
}