// Напишите метод, которая принимает на вход число и выдаёт сумму цифр в числе.
int a = (34);
int sum=(0);
while (a>0)
{
int num= a % 10;
a = a / 10;
sum= sum + num;
}
Console.WriteLine(sum);