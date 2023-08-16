// Напишите программу, кот на вход принимает 3-значное число и на выходе показывает 2ю цифру этого числа.
Console.Write ("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n/100 == 0 || n/1000 != 0)
{
    Console.Write ("Данное число не является трёхзначным!");
}
else
{
    Console.Write ("Число действительно трёхзначное. ");
    int SecondNumber = n / 10;
    SecondNumber = SecondNumber % 10;
    if (SecondNumber > 0)
        {Console.Write ($"Вторая цифра данного числа: {SecondNumber}");}
        else
        {
            SecondNumber = SecondNumber * (-1);
            Console.Write ($"Вторая цифра данного числа: {SecondNumber}");
        }
}