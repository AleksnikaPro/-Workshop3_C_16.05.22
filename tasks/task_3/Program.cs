// Определить количество цифр в числе

/*Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int count = 0;
int n = number;
while(n > 0)
{
    n = n / 10;
    count++;
}
Console.WriteLine($"Введеное число состоит из {count} цифр ");*/



Console.Clear();
Console.WriteLine("Определить количество цифр в числе");
Console.Write("Введите число: ");
long NumberA = long.Parse(Console.ReadLine() ?? "0");
int count = 0;
long NumberB = NumberA;
while (NumberA > 0)
{
    NumberA = NumberA/10;
    count++;
}
Console.WriteLine($"Число {NumberB} состоит из {count} цифр");