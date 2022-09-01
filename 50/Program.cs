// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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
        for (var j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
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

Console.WriteLine("Введите координаты элемента в массиве: ");
Console.WriteLine("Введите пожалуйста номер строки элемента (первая строка 0, вторая строк 1, и.т.д.): ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите пожалуйста номер столбца элемента (первый столбец 0, второй столбец 1, и.т.д.):");
int Y = Convert.ToInt32(Console.ReadLine());
if (X > a && Y > b)
{
    Console.WriteLine("Такого элемента в массиве нет.");
}
else
{
    object? Z = array.GetValue(X, Y);
    Console.WriteLine("Значение искомого элемента: " + Z + ".");
}