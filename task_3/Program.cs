// Задача 6. Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится на 2 без остатка). 
// 4 -> да
// -3 -> нет
// 7 -> нет 

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int lastDigit = number % 2;
if (lastDigit == 0) {
    Console.WriteLine("число четное");
} else {
    Console.WriteLine("число нечетное");
}