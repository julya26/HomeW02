// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введи трёхзначное число: ");
int abc = Convert.ToInt32(Console.ReadLine());
string b = Convert.ToString(abc);
Console.WriteLine("вторая цифра этого числа -> "+b[1]);
