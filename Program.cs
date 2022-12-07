/*
 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string str = num.ToString();
if(num / 100 != 0 )
{
    Console.WriteLine(str[2]);
}
else Console.WriteLine("В числе нет третьей цифры");
