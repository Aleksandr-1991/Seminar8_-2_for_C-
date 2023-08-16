// Напишите программу, кот выводит 3-юю цифру заданного числа 
// или сообщает, что 3ей цифры нет.
Console.Write ("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n/100 == 0)
{
    Console.Write ("Третьей цифры нет.");
}
else
{
    while (n > 999 || n < (-999))               // if (n/1000 != 0)
        {
        n = n/10;
        }
    int digit3 = n % 10;
    if (digit3 > 0)
    {
        Console.Write ($"Третяя цифра данного числа: {digit3}");
    }     
    else
    {
        digit3 = digit3 * (-1);
        Console.Write ($"Третяя цифра данного числа: {digit3}");
    }
}