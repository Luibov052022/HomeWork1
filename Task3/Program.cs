//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
string numberstr1 = Console.ReadLine();
int number1 = int.Parse(numberstr1);

if (number1 % 2 == 0)
{
    Console.WriteLine($"Число {number1 } четное" );
}
else 
{
   Console.WriteLine($"Число {number1 } нечетное" );
}

