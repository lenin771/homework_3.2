// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine());

if ((number >= 1) && (number <= 7 ))
    {
    Console.WriteLine("Вы ввели допустимое значение");
    }
else
    {
        Console.WriteLine("Вы ввели не допустимое значение");
        Console.WriteLine("Попропуйте еще раз");
        return;
    }
if (number == 6) 
    {
        Console.WriteLine("Введеный день недели выходной");
    }
else if (number == 7)
    {
        Console.WriteLine("Введеный день недели выходной");
    }
else
    {
        Console.WriteLine("Введеный день недели рабочий");
    }
