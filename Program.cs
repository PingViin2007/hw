// //  Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if ((num > 99 && num <= 999)||(num < -99 && num >= -999)) 
// {
//     if (num > 0)
//     {
//         int third = num / 10 % 10;
//         Console.WriteLine("Третья цифра этого числа: " + third);
//     }
//     else
//     {
//         int third = (num * -1) / 10 % 10;
//         Console.WriteLine("Третья цифра этого числа: " + third);
//     }
// }
// else
// {
//     Console.WriteLine("Введено не трёхзначное число!");









// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Write("Введите число, имеющее три или более цифр: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 0)
// {
//     num = num * -1;
// }

// if (num > 99 || num < -99) 
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     } 
//     int third = num % 10;
//     Console.WriteLine("Третья цифра этого числа: " + third);
// }
// else
// {
//     Console.WriteLine("Третьей цифры нет!");
// }









// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите порядковый номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 && day <= 7)
{
    if (day == 6 || day == 7)
    {
        Console.WriteLine(day + " день недели - выходной!)");
    }
    else
    {
        Console.WriteLine(day + " день недели - рабочий(");
    }
}
else
{
    Console.WriteLine("Такого дня недели нет!");
}
