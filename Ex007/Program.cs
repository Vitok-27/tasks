// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Не могу разобраться, почемц цикл не работает.
Console.WriteLine("Введите чилсо");
int a = Convert.ToInt32 (Console.ReadLine());
int b = 0;
int c= 0;
while (a>0) 
{
c = c*10;
b = a%10; 
c = c+b; 
a = a/10; 
}

if (a==c)
Console.WriteLine("Это палиндром");
else 
Console.WriteLine("Это не палиндром");
