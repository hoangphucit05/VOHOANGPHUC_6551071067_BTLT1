using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 6551071067");

        try
        {
            Console.Write("Nhap n: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0 || n > 1000)
            {
                Console.WriteLine("n khong hop le!");
                return;
            }

            int soLuong = 0;

            Console.WriteLine("Cac so nguyen to tu 2 den " + n + ":");

            for (int i = 2; i <= n; i++)
            {
                bool laSoNguyenTo = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        laSoNguyenTo = false;
                        break;
                    }
                }

                if (laSoNguyenTo)
                {
                    Console.Write(i + " ");
                    soLuong++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("So luong so nguyen to = " + soLuong);
        }
        catch (FormatException)
        {
            Console.WriteLine("Du lieu nhap vao khong phai la so!");
        }
    }
}