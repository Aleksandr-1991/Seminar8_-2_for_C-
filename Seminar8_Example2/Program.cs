// Seminar8_Example2.  Зад 11.
// Прога выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int n = new Random().Next(100, 1000);
Console.WriteLine(n);
int a = n / 100;
int b = n % 10;
Console.Write($"{a}{b}");