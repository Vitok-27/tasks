
Console.WriteLine("Введите чилсо");
int n = Convert.ToInt32 (Console.ReadLine());
int a = n;
int b = (0);
int c = (0);
int d = (0);
while ( n > 0 )
{
b = (n % 10); 
c = (n % 100 / 10); 
d = (n / 10); 
}
if ( n == a)
Console.WriteLine("YES");
else 
Console.WriteLine("NO");