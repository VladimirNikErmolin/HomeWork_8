// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int height = EnterInt("Введите количество строк в массиве: ");
int width = EnterInt("Введиту количество столбцов в массиве: ");

int[,] numbers = new int[height, width];
Console.WriteLine("Ваш массив:");
Fill2DArray(numbers);
Print2DArray(numbers);
Console.WriteLine("Упорядоченный массив по убыванию элементов каждой строки:");
SortEveryRow(numbers);
Print2DArray(numbers);

int EnterInt(string hint)
{
    Console.Write(hint);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 10);
        }
    }
}

void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void SortEveryRow(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(1) - 1; k++)
            {
                if (numbers[i, k] < numbers[i, k + 1])
                {
                    int temp = numbers[i, k + 1];
                    numbers[i, k + 1] = numbers[i, k];
                    numbers[i, k] = temp;
                }
            }
        }
    }
}
