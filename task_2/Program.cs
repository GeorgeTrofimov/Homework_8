// Задача 2: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int Prompt(string messege)
{
    System.Console.WriteLine(messege);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int rows, int columns, int min, int max)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(min, max + 1);
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

void SumMinR(int[,] array)
{
    int sum1 = 0;
    int sum2=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum1 += array[i, j];    
        }
        Console.WriteLine();
        Console.WriteLine("Сумма " + (i+1) + " строки равна " + sum1);     
    }
}

int rows = Prompt("Введите количество сторок > ");

int columns = Prompt("Введите количество столбцов > ");

int[,] MyArray = GenerateArray(rows, columns, 0, 10);

PrintArray(MyArray);

int SumMin = 0, RowsMin = 0;

SumMinR(MyArray);



