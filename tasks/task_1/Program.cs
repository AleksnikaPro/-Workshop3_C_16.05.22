// Показать таблицу квадратов чисел от 1 до N

/*Console.WriteLine("Ввведите число n:");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.Write($"{i * i} ");
}                                      
*/


/*Console.WriteLine("Ввведите число n:");
int n = int.Parse(Console.ReadLine());                                                      
int count = 1;
while (count <= n)
{
    Console.WriteLine(count * count);
    count++;
}                                                                                                                                                                                                                                                                                           
*/

/*Console.WriteLine("Ввведите число n:");
int n = int.Parse(Console.ReadLine());                                                     
int count = 0;
while (count < n)
{
    int digit = count + 1;
    Console.WriteLine($"Список квадратов чисел от 1 до {n} {digit * digit}");
    count++;
} 
 */


Console.WriteLine("Показать таблицу квадратов чмсел от 1 до N");
Console.Write("Ввведите число:");
int number = int.Parse(Console.ReadLine()); 

int i = 1;
int SqrN = 0;
while (i <= number)
{
   Console.Write($"{i}"); 
   i++;
}                                                                                                  Console.WriteLine(" ");
i = 1; 
while (i <= number)
{
   SqrN = i * i;
   Console.Write($"{SqrN}");
   i++;
}                                                                                                                                                    