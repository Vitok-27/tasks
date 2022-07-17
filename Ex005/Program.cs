// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int num= (456);
string NumberText = Convert.ToString(num);
if (NumberText.Length > 2){
  Console.WriteLine("третья цифра " + NumberText[2]);
}
else {
  Console.WriteLine("третьей цифры нет");
}
