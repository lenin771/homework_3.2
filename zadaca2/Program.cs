// Напишите программу, которая выводит третью цифру заданного числа  
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
if (number >= 100)
    {
        Console.WriteLine($"Третья цифра чиcла равна {number % 10}");
    }
else
    {
        Console.WriteLine($"Число состоить менье чем из трех цифр");
    }
