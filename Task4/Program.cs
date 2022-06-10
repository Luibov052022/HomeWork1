//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
string numberstr = Console.ReadLine();
int number = int.Parse(numberstr);
int i = 1;
while(i < number + 1)
{
    if (i % 2 == 0)
    {
    Console.Write($"{i}, " );
    }
    i++;
}

