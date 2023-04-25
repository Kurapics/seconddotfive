using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите символы: ");
        string str = Console.ReadLine();
        char[] mas = str.ToCharArray();
        for (int i = 0; i < mas.Length; i++)
            if (mas[i] >= '0' && mas[i] <= '9') Console.Write(mas[i]);
        
    }
}