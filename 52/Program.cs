// Задача 52. 
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateArrayRandomNumbers (int a, int b)
{
int[,] result = new int [a , b];
var random = new Random();
for (var i = 0; i < result.GetLength(0); i++)
for (var j = 0; j < result.GetLength(1); j++)
result[i, j] = random.Next(1, 10);
return result;
}
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++) 
        Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
    
Console.Write("Введите пожалуйста число строк (a) ");
if(!int.TryParse(Console.ReadLine()!, out var a))
{
    Console.WriteLine("Ошибка");
}
    Console.WriteLine("Введите пожалуйста число столбцов (b) ");
if(!int.TryParse(Console.ReadLine()!, out var b))
{
    Console.WriteLine("Ошибка");
}
int[,] array = CreateArrayRandomNumbers (a,b);

Console.Write($"\nМассив: \n");
PrintArray(array);

Console.Write($"\nСреднее арифметическое каждого столбца: ");
for (int i = 0; i < b; i++)
{
    double average = 0;
    for (int j = 0; j < b; j++)
    {
        average += array[j, i];
    }
    average = Math.Round(average / a, 1);
    Console.Write($"{average}; ");
    }
