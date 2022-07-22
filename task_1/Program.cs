// Задача 1: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int Prompt(string messege)
{
    System.Console.WriteLine(messege);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int m, int n)
{
    int[,] answer = new int[m, n];
    for (int i = 0; i < answer.GetLength(0); i++)
    {
        for (int j = 0; j < answer.GetLength(1); j++)
        {
            answer[i, j] = new Random().Next(0, 10);
        }
    }
    return answer;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

void MaxMinArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i+1; j < array.GetLength(1); j++)
        {
            for (int r = 0; r < array.GetLength(1) - 1; r++)
            {
                if (array[r, i] > array[r, j])
                {
                    int temp = array[r, i];
                    array[r, i] = array[r, j];
                    array[r, j] = temp;

                }
            }
        }
    }
}


System.Console.WriteLine($"Изначальный массив: ");
int[,] NewArray = GenerateArray(3, 3);

PrintArray(NewArray);

System.Console.WriteLine($"Массив по возрастанию в строке: ");

MaxMinArray(NewArray);

PrintArray(NewArray);
