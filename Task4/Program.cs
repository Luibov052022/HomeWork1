//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
string numberstr = Console.ReadLine();
int number = int.Parse(numberstr);
while(number > 1)
{
    if (number % 2 == 0)
    {
    Console.Write($"{number}, " );
        }
    number = number - 1;
}

