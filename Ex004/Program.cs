// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int a = (254);
int b = (a % 100 / 10) ;
Console.WriteLine(b);

//Вриант 2
int num= (256);
string NumberText = Convert.ToString(num);
if (NumberText.Length > 2){
  Console.WriteLine("вторая цифра " + NumberText[1]);
}
