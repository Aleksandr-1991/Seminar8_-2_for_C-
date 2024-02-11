// Задача 10. Прога приним трёхзначное число и выв 2ю цифру этого числа.
Console.Write ("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n/100 == 0 || n/1000 != 0)
{
    Console.Write ("Данное число не является трёхзначным!");
}
else
{
    Console.Write ("Число действительно трёхзначное. ");
    int SecondDigit = n / 10 % 10;
    SecondDigit = (SecondDigit >= 0) ? SecondDigit : -SecondDigit;
    Console.Write ($"Вторая цифра данного числа: {SecondDigit}");
}