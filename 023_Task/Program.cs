// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int ReadNatural() // Метод проверки соответствия вводимого числа условиям задачи
{
    while (true)
    {
        Console.WriteLine("Введите натуральное число (N>0): ");
        if (int.TryParse(Console.ReadLine(), out int natNumber) && natNumber >= 0)
        {
            return natNumber;
        }
        else Console.WriteLine("Введено нецелое или отрицательное число");
    }
}

void powFunction(int num, int deg) // Метод вычисления таблицы чисел и вывод в консоль
{
    int count = 1;
    Console.Write($"Таблица чисел {deg}-й степени от 1 до {num} -> {Math.Pow(count, deg)}");
    count++;
    while (count <= num)
    {
        Console.Write(", " + Math.Pow(count, deg));
        count++;
    }
    Console.WriteLine();
}

int degree = 3;             // Показатель степени
int n = ReadNatural();      // Ввод числа
powFunction(n, degree);     // Вычисление и вывод таблицы чисел