// Напишите программу, кот на вход принимает 3-значное число и на выходе показывает 2ю цифру этого числа.
Console.Write ("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int SecondNumber = n / 10;
SecondNumber = SecondNumber % 10;
{
    Console.Write ($"Вторая цифра: {SecondNumber}");
}