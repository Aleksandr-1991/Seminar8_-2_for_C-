// Seminar8_Example2  (Зад 11. Работа в группах.)
// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.
Random rand = new Random();
int n = rand.Next(100, 1000);
Console.WriteLine(n);
// int a = new Random().Next(10, 1000); - эквивалентное выражение
int a = n / 100;
int b = n % 10;
Console.WriteLine($"{a}{b}");