﻿// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int iteration = 0;

while (iteration < N) {
    int number = iteration + 1;
    if (number % 2 == 0) {
        Console.WriteLine(number);
    }
    iteration++;
}