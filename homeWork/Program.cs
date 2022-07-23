// Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами, округлёнными до одного знака.

//Zadacha47();
//Zadacha50();
Zadacha52();

void Zadacha47()
{
    Console.WriteLine("Введите количество строк в массиве");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве");
    int columns = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];
    FillArray(array);
    PrintArray(array);

}

void FillArray(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round (random.NextDouble() * 10, 1);
        }
    }
}

void PrintArray(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    
}

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

void Zadacha50()
{

    Random random = new Random();
    int rows = random.Next(5, 9);
    int columns = random.Next(6, 10);

    Console.WriteLine("Введите  позицию элемента в строке");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите  позицию элемента в столбце");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int [rows, columns];
    FillArrayint(array);
    PrintArrayint(array);
    Return(row, column);



void Return(int row, int column)
{
  if (row >= 1 && row < rows && column >= 1 && column <= columns)
  {
      Console.WriteLine($"Искомый элемент массива - {array[row, column]}");
  } 
  else 
  {
      Console.WriteLine("Такого элемента нет");
  }
}

void FillArrayint(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArrayint(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
    
}

//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

void Zadacha52()
{
    Random random = new Random();
    int rows = random.Next(5, 9);
    int columns = random.Next(6, 10);

    int[,] array = new int[rows, columns];
    FillArrayint2(array);
    PrintArrayint2(array);
    Average(rows, columns);


void Average(int rows, int columns)
{
   for (int j = 0; j < columns; j++)
   {
     double sum = 0;
       for (int i = 0; i < rows; i++)
       {
           sum = sum + array[i, j];
       }
       Console.WriteLine(sum/rows + "\t");
   }
   Console.WriteLine();
}

void FillArrayint2(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
}

void PrintArrayint2(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


}