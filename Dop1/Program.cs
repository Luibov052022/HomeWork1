//Напишите программу вычисления модуля числа.

Console.Write("Введите число: ");
string numberstr = Console.ReadLine();
int number = int.Parse(numberstr);

if (number > 0)
{
    Console.Write($"Модуль числа {number} равен {number}" );
}
else
{
    Console.Write($"Модуль числа {number} равен {-number}" );
}
