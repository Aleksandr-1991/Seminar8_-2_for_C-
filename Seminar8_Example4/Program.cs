﻿// Напишите программу, кот будет приним на вход 2 числа и выв, яв-ся ли 1е число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4.  16, 4 -> кратно.
Console.Write ("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
int o = n1 % n2;
if (o == 0)
{Console.Write ("Первое число кратно второму.");}
else 
{Console.Write ($"Не кратно, остаток от деления: {o}");}