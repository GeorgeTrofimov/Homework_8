// Задача 3: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.

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

int [,] NewArray1 = GenerateArray(2,2);

int [,] NewArray2 = GenerateArray (2,2);

int [,] ResultArray = new int [2,2];

System.Console.WriteLine($"Матрица 1: ");
PrintArray(NewArray1);
System.Console.WriteLine($"Матрица 2: ");
PrintArray(NewArray2);

void Array (int [,] NewArray1,int [,] NewArray2, int [,] ResultArray)
{
    for (int i = 0; i < ResultArray.GetLength(0); i++)
    {
        for (int j = 0; j < ResultArray.GetLength(1); j++)
        {
         int summ=0;
         for (int l = 0; l < NewArray1.GetLength(1); l++)
         {
            summ += NewArray1[i,l] * NewArray2[l,j];
         }   
         ResultArray[i,j]=summ;
        }
    }
}

Array(NewArray1,NewArray2,ResultArray);

Console.WriteLine($"Произведение матриц равно:");

PrintArray(ResultArray);