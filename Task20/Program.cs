// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки");
Console.Write("X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");
Console.Write("X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xb, int yb, int xc, int yc)
{
    return Math.Sqrt((xc - xb) * (xc - xb) + (yc - yb) * (yc - yb));

}
double res = Math.Round(Distance(x1, y1, x2, y2), 2, MidpointRounding.ToZero);
Console.WriteLine(res);