/* ПЕРВАЯ ЗАДАЧА через элемент массива
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
string str = number.ToString();
Console.WriteLine($">{str[1]}");




/* ПЕРВАЯ ЗАДАЧА через деление с остатком/без
 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int twoDigitNum = number / 10;
int finNum = twoDigitNum % 10;
Console.WriteLine(finNum);



/* ВТОРАЯ ЗАДАЧА
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


/*  ТРЕТЬЯ ЗАДАЧА
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите число от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());
if(day == 6 || day == 7)
{
    Console.WriteLine("Да");
}
    else Console.WriteLine("Нет");
