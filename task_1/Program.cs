// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// а = 5; b = 7 -> max 7
// а = 2; b = 10 -> max 10
// а = -9; b = -3 -> max -3


Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2) {
    int max = number1;
    Console.WriteLine("Первое число больше: " + max);
} else if (number2 > number1) {
    int max = number2;
    Console.WriteLine("Второе число больше: " + max);
} else {
    Console.WriteLine("Они равны");
}