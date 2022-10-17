// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] generateArray(int height, int width)
{
    int[,] generatedArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            generatedArray[i,j] = new Random().Next(1, 10);
        }
    }
    return generatedArray;
}

void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(data);
    Console.ResetColor();
}

void showArray(int[,] inputArray)
{
    printColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        printColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        printColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i,j]}\t");
        }
        Console.WriteLine();        
    }
}

  
int[,] generateArrayC(int[,] inputArrayA, int[,] inputArrayB)
{
    int[,] generatedArrayC = new int[inputArrayA.GetLength(0), inputArrayB.GetLength(1)];
    for (int i = 0; i < inputArrayA.GetLength(0); i++)
    {
        for (int j = 0; j < inputArrayB.GetLength(1); j++)
        {
            for (int k = 0; k < inputArrayA.GetLength(1); k++)
           {
               generatedArrayC[i, j] += inputArrayA[i, k] * inputArrayB[k, j];
           }
        }
    }
    return generatedArrayC;
}
Console.Write("Введите количество строк матрицы А: ");
int userHeightA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы А: ");
int userWidthA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество строк матрицы B: ");
int userHeightB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы B: ");
int userWidthB = Convert.ToInt32(Console.ReadLine());



Console.Write("Матрица А: ");
Console.WriteLine();
int[,] generatedArrayA = generateArray(userHeightA,userWidthA);
showArray(generatedArrayA);

Console.Write("Матрица B: ");
Console.WriteLine();
int[,] generatedArrayB = generateArray(userHeightB,userWidthB);
showArray(generatedArrayB);

if(userHeightA != userWidthB)
{
    Console.WriteLine ("Решения нет: количество строк матрицы А должно совпадать с количеством столбцов матрицы В");
}
else 
{
Console.Write("Матрица C - произведение матриц А и В: ");
Console.WriteLine();
int[,] generatedArrayC = generateArrayC(generatedArrayA, generatedArrayB);
showArray(generatedArrayC);
}