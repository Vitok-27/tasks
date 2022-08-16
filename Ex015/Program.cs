//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Write("Введите колличество чисел: ");
int n = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    int a = int.Parse(Console.ReadLine());
    if (a > 0)
        count++;
}
Console.WriteLine($" чисел больше 0: {count}");
