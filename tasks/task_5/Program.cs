// Задать массив из 8 элементов и вывести его на экран

/*int []array = {1, 2, 3, 4, 5, 6, 7, 8};
for(int i = 0; i < array.Length; i++)
{
    Console.Write((array[i]));
}
*/

/*int []array = {1, 2, 5, 14, 10, 6, 7, 8};
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}");
}
*/


/*Console.WriteLine("Задать массив из 8 элементов и вывести его на экран ");
Console.Write("Введите размер массива:");
int arrSize = int.Parse(Console.ReadLine());
int[] array = new int[arrSize];

for(int i = 0; i < arrSize; i++)
    array[i] = new Random().Next(0,100);

int count = 1;

foreach(int k in array)
{
    Console.WriteLine($"{count} элемент массива - {k}");
    count++;
}
*/

Console.WriteLine("Введите 8 элементов");
for(int i = 1; i <= 8; i++)
{
    Console.Write($"Введите элемент номер {i}: \n");
    array[i-1] = int.Parse(Console.ReadLine());
}
Console.WriteLine();
PrintArray(array);

void PrintArray(int[] array) // функция вывода массива на экран
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}


