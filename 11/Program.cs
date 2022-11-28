// Напишите программу, которая вводит случайное трехзначное число и 
// удаляет вторую цифру этого числа
// Например
// 456 -> 46
// 752 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int digit2 = number % 10;
int digit1 = number / 100;
// Для проверки:
Console.WriteLine($"Первая цифра = {digit1}, вторая цифра = {digit2}");

Console.WriteLine($"Первая и третья цифра числом {digit1 * 10 + digit2}");
// 2 вариант решения: 
// if (digit1 > digit2)
// {
//    Console.WriteLine(digit1);
// }
// else
// {
//    Console.WriteLine(digit2);
// }
