// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Введите пожалуйста количество строк массива m: ");
string m = Console.ReadLine()!;
Console.WriteLine("Введите пожалуста количество столбцов массива n: ");
string n = Console.ReadLine()!;

void ArrayFilling()
{
    double[,] matrix = new double[int.Parse(m), int.Parse(n)];
    Random matrixX = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = matrixX.Next(-1000, 1000);
            Console.Write($"{(matrix[i, j]/10)} ");
        }
        Console.WriteLine();
    }
}
ArrayFilling();