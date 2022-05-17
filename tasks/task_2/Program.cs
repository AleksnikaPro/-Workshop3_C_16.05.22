// Найти сумму чисел от 1 до А


/*Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine());
int i = 1;
int sum = 0;
while(i <= n)
{
    sum = sum + i;
    i++;
}
Console.WriteLine($"Сумма чисел от 1 до А: {sum}");*/


/*Console.WriteLine("Введите число a:");
int a = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= a; i++)
{
    sum = sum + i;
}
System.Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");*/

Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());
int sum = n*(n+1) / 2;
Console.WriteLine(sum);
