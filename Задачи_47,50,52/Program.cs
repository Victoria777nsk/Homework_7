Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("47) Задача 47: Задайте двумерный массив размером m х n, заполненный случайными вещественными числами.");
        Console.WriteLine("50) Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
        Console.WriteLine("52) Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
        Console.WriteLine("0) Выход.");

        Console.Write("Введите номер задачи: ");
        int taskNumber = Convert.ToInt32(Console.ReadLine());

        switch (taskNumber)
        {
            case 0: return;
            case 47: GetArray(); break;
            case 50: SearchElement(); break;
            case 52: Average(); break;
            default: Console.WriteLine("ERROR"); break;
        }
    }
}

// Задача 47: Задайте двумерный массив размером m х n, заполненный случайными вещественными числами.

double[,] GetArray()
{   
    Console.Write("Введите количество строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(-9,10) + new Random().NextDouble();
            array[i, j] = Math.Round (array[i, j], 2);
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
    return array;
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void SearchElement()
{
    int[,] array = new int[5, 5]; // для примера взят массив размером 5х5
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            array[i, j] = new Random().Next(-9,10);
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }

    Console.Write("Введите строку элемента: ");
    int rowIndex = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите столбец элемента: ");
    int columnIndex = Convert.ToInt32(Console.ReadLine());

    if (rowIndex > array.GetLength(0) || columnIndex > array.GetLength(1))
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {
        Console.WriteLine($"Значение элемента [{rowIndex}; {columnIndex}] = {array[rowIndex-1, columnIndex-1]}");
    }
}

// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Average()
{
    Console.Write("Введите количество строк массива: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int columns = Convert.ToInt32(Console.ReadLine());
        
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(-9,10);
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }

    double average = 0;
    int count = -1; // индексы принято считать с 0, при первом for будет взят столбец 0 (номинально первый);
    // (можно взять count = 0, тогда при выводе результата столбцы будут считаться с 1-го).

    for (int j = 0; j < array.GetLength(1); j++)
    {
        count++;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            average += array[i, j];
        }
        average /= rows;
        Console.WriteLine($"Среднее арифметическое столбца {count} = {average:f1}");
    }
}