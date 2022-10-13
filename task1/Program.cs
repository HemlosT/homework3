/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();

int first = int.Parse(number[0].ToString());
int last = int.Parse(number[number.Length - 1].ToString());
int second = int.Parse(number[1].ToString());
int fourth = int.Parse(number[number.Length - 2].ToString());

if (first == last)
{
    if(second == fourth)
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}