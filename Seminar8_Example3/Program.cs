// Seminar8_Example3.  (Напишите программу, кот принимает на вход 2 числа 
// и проверяет, яв-ся ли одно число квадратом другого).
Console.Write ("Введите первое число (кроме 0 и 1): ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число (кроме 0 и 1): ");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 == n2 * n2)
{
    Console.WriteLine ($"Первое число {n1} является квадратом второго числа {n2}");
}
else if (n2 == n1 * n1)
{
    Console.WriteLine ($"Второе число {n2} является квадратом первого числа {n1}");
}
else {Console.WriteLine ("Ни одно из чисел не является квадратом другого.");
}