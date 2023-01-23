// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом (НЕ использовать число как строку, то есть сравнения типа number[0] == number[4] делать НЕЛЬЗЯ. Используем операторы % и /).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
int ReadNumber() // Метод проверки соответствия вводимого числа условиям задачи
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int number) && number > 9999 && number < 100000)
        {
            return number;
        }
        else Console.WriteLine("Не удалось распознать требуемое число, попробуйте еще раз.");
    }
}
void DetPalindrome(int n)
{
    int firstDigit = n / 10000;
    int twoDigit = (n / 1000) % 10;
    int threeDigit = (n / 10) % 10;
    int fiveDigit = n % 10;
    if (firstDigit == fiveDigit && twoDigit == threeDigit) Console.WriteLine("Это палиндром!");
    else Console.WriteLine("Это непалиндром.");
}

Console.WriteLine("Введите натуральное пятизначное число: ");
int num = ReadNumber();
Console.Write($"Вы ввели число {num}. ");
DetPalindrome(num);