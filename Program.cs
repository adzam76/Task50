// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



// int rows = ReadInt("Введите индекс строки: ");
// int colums = ReadInt("Введите индекс столбца: ");
// int[,] numbers = new int[6, 8];
// FillArray2D(numbers);
// PrintArray2D(numbers);

// if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
// else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");


// // Заполнение массива рандомными числами от 1 до 9
// void FillArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// //  Функция вывода массива в терминал
// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // Функция ввода 
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }



Console.Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] tab = new int[n, m];

void FillArray(int[,] coll)
{
    for (int rows = 0; rows < coll.GetLength(0); rows++)
    {
        for (int columns = 0; columns < coll.GetLength(1); columns++)
        {
            coll[rows, columns] = new Random().Next(1, 10);
            Console.Write($"{coll[rows, columns],3}");
        }
        Console.WriteLine();
    }
}
void SearchArray(int[,] coll)
{
    Console.WriteLine("Искомый столбик ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Искомая строчка  ");
    int b = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    for (int rows = 0; rows < coll.GetLength(0); rows++)
    {
        for (int columns = 0; columns < coll.GetLength(1); columns++)
        {
            if (rows == a & columns == b)
            {
                result = coll[rows, columns];
            }
        }
    }
    if (result == 0) 

    {
        Console.WriteLine("В массиве нет такого элемента");
    }

else

    {
        Console.WriteLine($"Число {result} ");
    }
}
FillArray(tab);
SearchArray(tab);




