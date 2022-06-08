//Напишите программу, которая на вход принимает значение, а  на выходе показывает обратное значение.

Console.Write("Введите число: ");
string numberstr = Console.ReadLine();
double number = double.Parse(numberstr);
if (number == 0)
{
    Console.Write("на ноль делить нельзя" );
}
else
{
    Console.Write($"Обратное значение числа {number} равно {1/number}" );
}