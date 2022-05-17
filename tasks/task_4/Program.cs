/// Написать программу вычисления произведения чисел от 1 до N
/*Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int number1 = 1;
int product = 1;
Console.Write($"Product numbers from 1 to {number}: ");
while (number1 <= number) 
{
    product = product * number1;
    number1++;
}
Console.WriteLine($"{product} ");*/


Console.Write("Введите число n:");
int n = int.Parse(Console.ReadLine());
int p = 1;
for (int i = 1; i <= n; i++)
{
    p = p*i;
}
Console.WriteLine($"Произведение чисел от 1 до {n} = {p}");


