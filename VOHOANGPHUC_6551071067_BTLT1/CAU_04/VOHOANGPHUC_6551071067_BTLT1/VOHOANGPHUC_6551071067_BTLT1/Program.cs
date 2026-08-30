using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 6551071067");

        int so;
        Console.Write("Nhap so nguyen: ");
        so = int.Parse(Console.ReadLine());

        if (so > 0)
            Console.WriteLine("So do la so duong");
        else if (so < 0)
            Console.WriteLine("So do la so am");
        else
            Console.WriteLine("So do bang 0");

        if (so % 2 == 0)
            Console.WriteLine("So do la so chan");
        else
            Console.WriteLine("So do la so le");

        if (so % 3 == 0)
            Console.WriteLine("So do chia het cho 3");
        else
            Console.WriteLine("So do khong chia het cho 3");

        if (so % 2 == 0 && so % 3 == 0)
            Console.WriteLine("So do chia het cho ca 2 va 3");
        else
            Console.WriteLine("So do khong chia het cho ca 2 va 3");
    }
}