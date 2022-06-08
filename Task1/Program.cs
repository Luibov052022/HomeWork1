//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
string numberstr1 = Console.ReadLine();
int number1 = int.Parse(numberstr1);
Console.Write("Введите второе число: ");
string numberstr2 = Console.ReadLine();
int number2 = int.Parse(numberstr2);

if (number1 > number2)
{
    Console.WriteLine($"Число {number1} больше чем число {number2}" );
}
else 
{
    Console.WriteLine($"Число {number2} больше чем число {number1}" );
}