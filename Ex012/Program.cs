//Напишите метод(ы), которай задаёт массив из 8 элементов и выводит их на экран.
Console.Write("Введите количество элементов массива:");
int a= int.Parse(Console.ReadLine());
int [] array= new int [a];
for (int i=0; i<array.Length; i++)
{
Console.Write("Введите элемент массива под индексом {i}:");
array[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Вывод массива:");
for (int i=0; i<array.Length; i++)
{
    Console.WriteLine(array[i]);
}