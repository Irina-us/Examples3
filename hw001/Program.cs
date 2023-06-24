// ВСЁ делаем через функции!

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. Math.Pow юзать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
System.Console.WriteLine("Введите целое число1");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое число2");
int num2 = Convert.ToInt32(Console.ReadLine());

int result = 1;
for (int i=1; i<=num2; i++)
result = result * num1;
System.Console.WriteLine($"{num1} в степени {num2} = {result}");
