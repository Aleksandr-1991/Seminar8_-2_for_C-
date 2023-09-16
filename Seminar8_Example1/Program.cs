// Напис прогу, выв случ-ч. из отр. [10, 99] и показ наиб цифру числа.
Random rand = new Random();
int n = rand.Next(10, 100);
Console.WriteLine(n);
// int a = new Random().Next(10, 100); - эквивалентное выражение
int a = n / 10;
int b = n % 10;
if (a > b)
{
    Console.WriteLine("Максимальное число а = " + a);
}
else if (b > a)
{
    Console.WriteLine("Максимальное число b = {0}", b, a);
}
else
{
    Console.WriteLine($"Все числа равны {a} = {b}");
}