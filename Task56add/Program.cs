// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка

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


void SumOfStrings(int[,] inputArray)
{

    int firstStringSum = 0;
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {     
       firstStringSum = firstStringSum + inputArray[0, j];
    }
    int minSum = firstStringSum;
    int indexMinString = 0;
    for (int i = 1; i < inputArray.GetLength(0); i++)
    {
        int stringSum = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
           stringSum = stringSum + inputArray[i, j];   
        }
        if(stringSum < firstStringSum)
        {
            minSum = stringSum;
            indexMinString = i;
        }
    }
    Console.WriteLine ($"Минимальная сумма элементов в строке с индексом {indexMinString}");
}

Console.Write("Исходный массив: ");
Console.WriteLine();
int[,] generatedArray = generateArray(3,2);
showArray(generatedArray);
SumOfStrings(generatedArray);