// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число:");
string n = Console.ReadLine();
string reverse = "";

for (int i = n.Length - 1; i >= 0; i--)
{
    reverse += n[i];
}
if (string.Compare(reverse, n) == 0)
    Console.WriteLine($"{n} является палиндромом");
else
    Console.WriteLine($"{n} не является палиндромом");



