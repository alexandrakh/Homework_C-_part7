// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] array = new int[,]{
        {1, 4, 7, 2},
        {5, 9, 2, 3},
        {8, 4, 2, 4}
        };

int k = DataEntry("Введите номер строки элемента: ");
int l = DataEntry("Введите номер столбца элемента: ");

if (k > array.GetLength(0)-1 || l > array.GetLength(1)-1)
    System.Console.WriteLine("Такого числа нет в массиве");
else
    System.Console.WriteLine($"Значение элемента [{k},{l}] массива равно: {GetValueArray(array, k, l)}");

int DataEntry(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetValueArray(int[,] array, int k, int l)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == array[k, l])
                array[k, l] = array[i, j];
        }
    }
    return array[k, l];
}



