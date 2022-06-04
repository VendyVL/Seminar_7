// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

int[,] array52 = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

double[] AverageArrayColumns(int[,] array)
{
    int length = array.GetLength(1);
    double[] averageColumns = new double[length];
    double columnLength = array.GetLength(0);
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double a = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            a = a + array[i, j];
        }
        double average = a / columnLength;
        averageColumns[j] = Math.Round(average, 2);
    }
    return averageColumns;
}

double[] averageCol = AverageArrayColumns(array52);
for (int i = 0; i < averageCol.Length; i++)
{
    Console.Write(averageCol[i] + "   ");
}
