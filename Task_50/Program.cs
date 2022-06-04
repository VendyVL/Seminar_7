// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

// В задаче не сказаано, что за массив, откуда он берётся и какими числами заполнен. Можно задать готовый или взять случайный из прошлой задачи.
int[,] MakeArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(-10, 10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

Random rn = new Random(); // Мне кажется, должен быть способ записать это проще, но я его не придумала
int n = rn.Next(1,10);
Random rm = new Random();
int m = rm.Next(1,10);

int[,] array50 = MakeArray(m, n);

Console.WriteLine("Введите позицию элемента (номер строки и номер столбца через пробел)");
int[] place = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

if (place[0] > n || place[1] > m) Console.WriteLine("Какая незадача, нет такого элемента");
else Console.WriteLine($"Этот элемент: {array50[place[1],place[0]]}");

PrintArray(array50);