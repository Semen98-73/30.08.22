// 1. Напишите программу, которая на вход принимает два
// числа 
// 2. и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int square = num2 * num2;
if (square == num1) {
    Console.WriteLine($"Число {num1} является квадратом {num2}");
}
else {
    Console.WriteLine($"Число {num1} не является квадратом {num2}");
}