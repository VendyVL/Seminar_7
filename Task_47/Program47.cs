// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] MakeArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(rand.Next(100)/3.0);//Ограничила сотней просто для красоты. А при делении на 3 чаще получаются длинные бесконечные дроби
            array[i, j] = Math.Round(array[i, j], 2);
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  |  "); //Дробные числа через пробел немного сливаются. Через черточку их лучше видно
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите размер массива");
Console.Write("по горизонтали ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("по вертикали ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] array47 = MakeArray(m, n);
PrintArray(array47);