// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int height = EnterInt("Введите количество строк в массиве: ");
int width = EnterInt("Введиту количество столбцов в массиве: ");
int depth = EnterInt("Введиту количество страниц в массиве: ");

int[,,] numbers = new int[height, width, depth];
int[] uniqueNumbers = GenerateUniqueNumber(numbers);

Fill3dArray(numbers, uniqueNumbers);
Print3dArray(numbers);

int EnterInt(string hint)
{
    Console.Write(hint);
    return int.Parse(Console.ReadLine()!);
}

int[] GenerateUniqueNumber(int[,,] array)  //генерируем массив неповторяющихся двухзначных чисел 
{
    int[] randomNumbers = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    if (randomNumbers.Length > 90)
    {
        throw new Exception("Нет больше не повторяющихся двузначных чисел");
    }
    for (int i = 0; i < randomNumbers.Length; i++)
    {
        Random r = new Random();
        randomNumbers[i] = r.Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            while (randomNumbers[i] == randomNumbers[j])
            {
                randomNumbers[i] = r.Next(10, 100);
                j = 0;
            }
        }
    }
    return randomNumbers;
}

void Fill3dArray(int[,,] array, int[] fill)
{
    int l = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = fill[l++];
            }
        }
    }
}

void Print3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k],3} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
