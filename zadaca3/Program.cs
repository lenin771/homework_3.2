// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели");
int number = int.Parse(Console.ReadLine());

if (number <= 0 || number > 7)
{
    Console.WriteLine("Не корректное число");
    Console.WriteLine("Попробуйте еще раз");
}
else if (number == 6 || number == 7)
{
    Console.WriteLine("Введенный день недели выходной ");
}
else
{
    Console.WriteLine("Введенный день недели рабочий");
}
