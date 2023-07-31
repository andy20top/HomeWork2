// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введи трехзначное число, программа покажет вторую цифру этого числа");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

if (num > 99 && num < 1000) 
{
    int res = num / 10;
    res = res % 10;
    Console.WriteLine(res);
}
else 
{
     Console.WriteLine("Это не трехзначное число");
}


// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать массив
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введи число, программа покажет третью цифру этого числа");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

if (num > 99)
{
    while (num > 999)
    {
        num /= 10;
    }
    int res = num % 10;
    Console.WriteLine(res);
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введи цифру, обозначающую день недели.");
Console.WriteLine("Проверим, выходной ли этот день");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

if (num == 6 || num == 7) Console.WriteLine("Кайф, завтра выходной");
else if (num >= 1 && num <= 5) Console.WriteLine("Это будний день");
else Console.WriteLine("Такого дня нет");