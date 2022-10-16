//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] generateArray(int height, int width, int deviation)
{
    int[,] generatedArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            generatedArray[i,j] = new Random().Next(-deviation, deviation +1);
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

int[,] swopRows(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)//счетчик столбцов(элементов в строке)
        {
           for (int k = j + 1; k < inputArray.GetLength(1); k++)
           {
              if(inputArray[i, j] <= inputArray[i, k])
              {
                int temp = inputArray[i, j];
                inputArray[i, j] = inputArray[i, k];
                inputArray[i, k] = temp;
              }
           }
           
        }
    }
    return inputArray;
}

Console.Write("Исходный массив: ");
Console.WriteLine();
int[,] generatedArray = generateArray(5,6,10);
showArray(generatedArray);
Console.Write("Массив с отсортированными строками: ");
Console.WriteLine();
int[,] swopedArray = swopRows(generatedArray);
showArray(swopedArray);