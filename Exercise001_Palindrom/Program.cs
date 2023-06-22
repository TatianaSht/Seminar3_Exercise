// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string strNumber = Console.ReadLine();

if (strNumber.Length < 5 | strNumber.Length > 5 )
{
    Console.WriteLine("Ошибка! Введено не пятизначное число, попробуйте еще раз.");
}
else if (strNumber[0] == strNumber[4] && strNumber[1] == strNumber[3])
{
    Console.WriteLine("Число палиндром");
}
else
{
     Console.WriteLine("Число не палиндром");
}
