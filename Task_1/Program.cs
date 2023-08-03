// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {num1} возведённое в степерь {num2} будет равно {sum(num1)}");
int sum(int num1)
{
    // int count = 0;
    int sum = 1;
    for (int count = 1; count <= num2; count++)
    {
        sum *=num1;
    }
    return sum;
}