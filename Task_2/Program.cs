﻿// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12


Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
string numbers = Convert.ToString(num);

Console.WriteLine($"Сумма всех чисел из числа {num} равна {SumNum(num)}");


int SumNum(int num)
{
    int result = 0; 
    while(num >0)
    {
        result += num % 10;
        num = num / 10;
    }
    return result;
}

