using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 6551071067");

        int n;

        Console.Write("Nhap n: ");
        n = int.Parse(Console.ReadLine());

        long tong = 0;
        long tongChan = 0;
        long tongLe = 0;

        for (int i = 1; i <= n; i++)
        {
            tong += i;

            if (i % 2 == 0)
                tongChan += i;
            else
                tongLe += i;
        }

        long giaiThua = 1;
        int j = 1;

        while (j <= n)
        {
            giaiThua *= j;
            j++;
        }

        Console.WriteLine("Tong 1 + 2 + ... + n = " + tong);
        Console.WriteLine("Tong cac so chan = " + tongChan);
        Console.WriteLine("Tong cac so le = " + tongLe);
        Console.WriteLine("Giai thua n! = " + giaiThua);
    }
}