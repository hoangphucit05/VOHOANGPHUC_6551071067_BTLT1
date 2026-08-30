using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 6551071067");

        double a, b;

        Console.Write("Nhap a: ");
        a = double.Parse(Console.ReadLine());
        Console.Write("Nhap b: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("Cong: " + (a + b));
        Console.WriteLine("Tru: " + (a - b));
        Console.WriteLine("Nhan: " + (a * b));
        Console.WriteLine("Chia: " + (a / b));
        Console.WriteLine("Chia lay phan nguyen: " + ((int)a / (int)b));
        Console.WriteLine("Chia lay phan du: " + ((int)a % (int)b));
        Console.WriteLine("Luy thua: " + Math.Pow(a, b));
    }
}