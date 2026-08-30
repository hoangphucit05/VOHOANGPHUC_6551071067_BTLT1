using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 6551071067");
        int n;
        do
        {
            Console.Write("Nhap n (1-9): ");
            n = int.Parse(Console.ReadLine());

            if (n < 1 || n > 9)
                Console.WriteLine("So khong hop le! Vui long nhap lai.");
        }
        while (n < 1 || n > 9);

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
    }
}