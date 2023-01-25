// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Point point1 = new Point(7,-5, 0);
point1.Print();
Point point2 = new Point(1,-1,9);
point2.Print();
    
double distance = Math.Round(Math.Sqrt(Math.Pow(point2.XCoordinates - point1.XCoordinates, 2) + Math.Pow(point2.YCoordinates - point1.YCoordinates, 2) + Math.Pow(point2.ZCoordinates - point1.ZCoordinates, 2)), 2);
Console.WriteLine("Расстояние между первой и второй точками равно " + distance + " ед.");

class Point
{
    public int xCoordinates;
    public int XCoordinates 
    {
        get {return xCoordinates;} 
        set {xCoordinates = value;}
    }
    public int yCoordinates;
    public int YCoordinates 
    {
        get {return yCoordinates;} 
        set {yCoordinates = value;}
    }
    public int zCoordinates;
    public int ZCoordinates 
    {
        get {return zCoordinates;} 
        set {zCoordinates = value;}
    }
    public Point(int xCoordinates, int yCoordinates, int zCoordinates) // Конструктор, создающий точку с заданными координатами
    {
        this.xCoordinates = xCoordinates;
        this.yCoordinates = yCoordinates;
        this.zCoordinates = zCoordinates;
    }
    public void Print() // Метод выведения координаты точки на экран
    {
        Console.WriteLine("Координаты точки = ({0};{1};{2})", xCoordinates, yCoordinates, zCoordinates);
    }
}
