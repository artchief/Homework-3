// Задача 19

// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число");

string str = Console.ReadLine();
int num = Convert.ToInt32(str);

if (num>9999&&num<100000)
{
     Console.WriteLine(num+ " это число является пятизначным ");
}
 else
 {
     Console.WriteLine(num+ " это число не является пятизначным ");
 }
if (str[0]==str[4]&&str[1]==str[3])
{
Console.WriteLine(num+ " это пятизначное число является палиндромом ");
}
else
{
   Console.WriteLine(num+ " это пятизначное число не является палиндромом ");  
}