/*
Задача 49: Задайте двумерный массивю Найдите элементы, 
у которых оба индекса четные, и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    bool isCorrect = false;
    int result = 0;
    while (isCorrect)
        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
            Console.WriteLine("Введено не число. Повторите ввод");
        return result;
}

int[,] InitArray(int m, int n)
{
    int[,] newArray = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArray[i, j] = rnd.Next(2, 10);
        }
    }
    return newArray;
}

int[,] FindEven(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ((i + 1) % 2 == 0 && (j + 1) % 2 == 0)
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j];
            }
        }
        
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int row = GetNumber("Введите количество строк: ");
int column = GetNumber("Введите количество столбцов: ");
int[,] matrix = InitArray(row, column);
PrintMatrix(matrix);
int[,] newMatrix = FindEven(matrix);
Console.WriteLine();
PrintMatrix(newMatrix);