//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
string numberstr1 = Console.ReadLine();
int number1 = int.Parse(numberstr1);
Console.Write("Введите второе число: ");
string numberstr2 = Console.ReadLine();
int number2 = int.Parse(numberstr2);
Console.Write("Введите третье число: ");
string numberstr3 = Console.ReadLine();
int number3 = int.Parse(numberstr3);
int max = number1;
if (max < number2)
{
    max = number2;
}
if (max < number3)
{
    max = number3;
}

Console.WriteLine($"Максимальное из трех чисел - {max} " );
