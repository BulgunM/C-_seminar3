// принимает на вход число (N)
// выдаёт таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

void Squares(int num)
{
    int count = 1;
    while (count <= num)
    {
        int square = count * count;
        Console.WriteLine($"{count,4} {square,4}");
        count++;
    }
}

if (number > 0)
    Squares(number);
else Console.WriteLine("Число не является натуральным");