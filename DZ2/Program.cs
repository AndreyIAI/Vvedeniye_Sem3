//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
using static System.Console;
WriteLine("Введите координаты точки А");

double Coord((double x, double y, double z)a, (double x, double y, double z) b)
{
    return Math.Sqrt(Math.Pow((b.x-a.x),2)+Math.Pow((b.y-a.y),2)
        +Math.Pow((b.z-a.z),2));
}
(double x, double y, double z) GetPointCoord()
{
    (double x, double y, double z) point;
    Write("х= ");
    point.x = Convert.ToDouble(ReadLine());
    Write("y= ");
    point.y = Convert.ToDouble(ReadLine());
    Write("z= ");
    point.z = Convert.ToDouble(ReadLine());
    
    return point;
}

(double x, double y, double z) a = GetPointCoord();
WriteLine("  Введите  координаты точки Б ");
(double x, double y, double z) b = GetPointCoord();

double answer = Coord (a,b);
WriteLine(answer);