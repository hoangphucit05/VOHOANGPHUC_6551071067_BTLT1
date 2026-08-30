using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 6551071067");

        int[] mang = new int[10];

        for (int i = 0; i < mang.Length; i++)
        {
            Console.Write("Nhap phan tu thu " + i + ": ");
            mang[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Toan bo mang:");
        foreach (int x in mang)
        {
            Console.Write(x + " ");
        }

        long tong = 0;
        int lonNhat = mang[0];
        int nhoNhat = mang[0];
        int viTriLonNhat = 0;
        int viTriNhoNhat = 0;
        int soChan = 0;
        int soLe = 0;

        for (int i = 0; i < mang.Length; i++)
        {
            tong += mang[i];

            if (mang[i] > lonNhat)
            {
                lonNhat = mang[i];
                viTriLonNhat = i;
            }

            if (mang[i] < nhoNhat)
            {
                nhoNhat = mang[i];
                viTriNhoNhat = i;
            }

            if (mang[i] % 2 == 0)
                soChan++;
            else
                soLe++;
        }

        double trungBinh = (double)tong / mang.Length;
        Console.WriteLine();
        Console.WriteLine("Tong = " + tong);
        Console.WriteLine("Trung binh = " + trungBinh);
        Console.WriteLine("Gia tri lon nhat = " + lonNhat + ", vi tri = " + viTriLonNhat);
        Console.WriteLine("Gia tri nho nhat = " + nhoNhat + ", vi tri = " + viTriNhoNhat);
        Console.WriteLine("So luong phan tu chan = " + soChan);
        Console.WriteLine("So luong phan tu le = " + soLe);

        Console.WriteLine("Mang sau khi dao nguoc:");
        for (int i = mang.Length - 1; i >= 0; i--)
        {
            Console.Write(mang[i] + " ");
        }
    }
}