// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа

Console.WriteLine("Ведите трехзначное число");
int number = int.Parse(Console.ReadLine());

int digit2 = (number /10) % 10; // поиск второго числа

Console.WriteLine($"Вторая цыфра числа {digit2}");
