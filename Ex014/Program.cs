// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double min=double.MaxValue;
double max=double.MinValue;
double a;
for(int i=0;i<2;i++)
{
    Console.Write("Введите число: ");
    a=double.Parse(Console.ReadLine());
    if (a>max)
    max=a;
    if(a<min)
    min=a;
}
Console.WriteLine(max-min);
Console.ReadKey();