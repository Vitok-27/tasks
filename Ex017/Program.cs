// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] a = new double[3, 3];
Random random = new Random();
for (int m=0; m<3;m++)
{
    for (int n=0; n<3; n++)
    {
        a[m,n] = random.Next(10);
        Console.Write("{0,2}", a[m,n]);
    }
    Console.WriteLine();
    }