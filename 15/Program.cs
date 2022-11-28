// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// ​
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите число от 1 до 7, чтобы узнать, какой это день недели:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 || number < 8)
{
   if (number == 1)
   {
      Console.WriteLine("Понедельник");
   }
   if (number == 2)
   {
      Console.WriteLine("Вторник");
   }
   if (number == 3)
   {
      Console.WriteLine("Среда");
   }
   if (number == 4)
   {
      Console.WriteLine("Четверг");
   }
   if (number == 5)
   {
      Console.WriteLine("Пятница");
   }
   if (number == 6)
   {
      Console.WriteLine("Суббота");
   }
   if (number == 7)
   {
      Console.WriteLine("Воскресенье");
   }

   if (number == 6 || number == 7)
   {
      Console.WriteLine("Это выходной день");
   }
   if (number < 6)
   {
      Console.WriteLine("Это будний день");
   }

}
if (number < 1 || number > 7)
{
   Console.WriteLine("Упс... Нет, нет такого дня недели");
}
