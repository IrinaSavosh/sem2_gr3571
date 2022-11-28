// Напишите программу, которая принимает на вход два числа
// и проверяет является ли первое число квадратом другого.
// 5, 25- да
// -4, 16 - да
// 5, 16 - нет

Console.WriteLine("Введите число a:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int numberB = Convert.ToInt32(Console.ReadLine());


if(numberA * numberA == numberB || numberB * numberB == numberA)
{
   Console.WriteLine("да");
}
else
{
   Console.WriteLine("нет");
}