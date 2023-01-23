// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
int ReadCoorditates() // Метод проверки соответствия вводимого числа условиям задачи
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            return number;
        }
        else Console.WriteLine("Не удалось распознать требуемое число, попробуйте еще раз.");
    }
}
double DetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
    return distance;
}

{
    Console.Write("Введите координату X первой точки: ");
    int x1 = ReadCoorditates();
    Console.Write("Введите координату Y первой точки: ");
    int y1 = ReadCoorditates();
    Console.Write("Введите координату Z первой точки: ");
    int z1 = ReadCoorditates();
    Console.WriteLine();
    Console.Write("Введите координаты X второй точки: ");
    int x2 = ReadCoorditates();
    Console.Write("Введите координаты Y второй точки: ");
    int y2 = ReadCoorditates();
    Console.Write("Введите координаты Z второй точки: ");
    int z2 = ReadCoorditates();

    Console.WriteLine("Расстояние между первой и второй точками равно " + DetDistance(x1, y1, z1, x2, y2, z2) + " ед.");
}