// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[,]{
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4}
        };

PrintArray(GetAverage(array));

double[] GetAverage(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    double[] avr = new double[columns];
    for (int j = 0; j < columns; j++)
    {
        for (int i = 0; i < rows; i++)
        {
            avr[j] += array[i, j];
        }
        avr[j] /= rows;

    }
    return avr;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
            Console.Write("{0:f2}", array[i]);
            System.Console.Write("; ");
    }
      System.Console.WriteLine();
}
