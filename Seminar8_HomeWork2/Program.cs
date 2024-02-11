// Зад 13. Прога выводит 3-юю цифру заданного числа или сообщает, что 3ей цифры нет.

Console.Write ("Введите число (можно и отрицательное): ");
int n = Convert.ToInt32(Console.ReadLine());
if (n/100 == 0)  Console.Write ("Третьей цифры нет.");
else
{
    while (n/1000 != 0)         // if (n > 999 || n < -999)
        {
        n = n/10;
        }
    int digit3 = n % 10;
    digit3 = (digit3 >= 0) ? digit3 : -digit3;
//  if (digit3 < 0) digit3 *= -1;
    Console.Write ($"Третяя цифра данного числа: {digit3}");
}