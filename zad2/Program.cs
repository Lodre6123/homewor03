/* Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double LineLength3D (double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xProjectionLength = x2 - x1;
    double yProjectionLength = y2 - y1;
    double zProjectionLength = z2 - z1;
    double result = Math.Sqrt(Math.Pow(xProjectionLength, 2) + Math.Pow(yProjectionLength, 2) + Math.Pow(zProjectionLength, 2));
    return result;
}
Console.Write("введите координату X первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координату Y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координату Z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координату X второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координату Y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("введите координату Z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Длинна равна " + Math.Round(LineLength3D(x1, y1, z1, x2, y2, z2), 2));