//на вход число (N)
//выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

void Cube(int num)
{
    int count = 1;
    while (count <= num)
    {
        double cube = Math.Pow(count, 3);
        Console.WriteLine($"{count,4} | {cube,4}");
        count++;
    }
}

if (number > 0)
    Cube(number);
else Console.WriteLine("Число не является натуральным");