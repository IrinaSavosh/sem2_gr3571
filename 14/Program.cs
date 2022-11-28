// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23
// 14 - нет
// 46 - нет
// 161 - да

Console.WriteLine("Введите число a:");
int numberA = Convert.ToInt32(Console.ReadLine());

int mod = numberA % 7;
int dom = numberA % 23;
if(mod == 0 && dom == 0)
{
   Console.WriteLine("кратно");
}
else
{
   Console.WriteLine("не кратно");
}