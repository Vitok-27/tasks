﻿//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Введите строку:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец:");
int columns = Convert.ToInt32(Console.ReadLine());
int n = 3;
int m = 4; 
Random random = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Исходный массив:");
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
arr[i, j] = random.Next(10, 99);
Console.Write("{0} ", arr[i, j]);
}
Console.WriteLine();
}
if (rows< 0 | rows> arr.GetLength(0)|columns<0| columns>arr.GetLength(1))
{
Console.WriteLine("Не существует");
}
else
{
Console.WriteLine("Значение элемента массива = {0}", arr[rows,columns]);
}
Console.ReadLine();
        
