// Напишите программу, которая будет принимать на ввод два числа
// и выводить, является ли первое число кратно второму.
// Если число 2 не является кратным 1, то программа выводит остаток от деления
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите число a:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int numberB = Convert.ToInt32(Console.ReadLine());

int mod = numberA % numberB;
if(mod == 0)
{
   Console.WriteLine("кратно");
}
else
{
   Console.WriteLine($"не кратно, остаток {mod}");
}
