// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.


Console.WriteLine("введите первое число: ");
int  number1 = Convert.ToInt32(Console.ReadLine());

void recurs (int number1)
{
    if (number1 > 0 )
    {
    Console.Write($"{number1} ");
    number1--;
    recurs(number1);
    }
    
}
recurs(number1);
Console.WriteLine();