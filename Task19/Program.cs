// на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);

bool Palindrome(int num)
{
    if ((num / 10000 == num % 10) && (num / 1000 % 10 == num % 100 / 10)) return true;
    return false;
}

if (number > 9999 && number < 100000)
{
    bool result = Palindrome(number);
    Console.WriteLine(result);
}
else Console.WriteLine("Введенное число не является пятизначным");