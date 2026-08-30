using System;

class Program
{
    static void Main(string[] args)
    {
        string hoTen;
        int tuoi;
        double chieuCao;
        float canNang;
        bool daTotNghiep;

        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();
        Console.Write("Nhap tuoi: ");
        tuoi = int.Parse(Console.ReadLine());
        Console.Write("Nhap chieu cao (m): ");
        chieuCao = double.Parse(Console.ReadLine());
        Console.Write("Nhap can nang (kg): ");
        canNang = float.Parse(Console.ReadLine());
        Console.Write("Da tot nghiep (True/False): ");
        daTotNghiep = bool.Parse(Console.ReadLine());
        Console.WriteLine("Ho ten: " + hoTen);
        Console.WriteLine("Tuoi: " + tuoi);
        Console.WriteLine("Chieu cao: " + chieuCao + " m");
        Console.WriteLine("Can nang: " + canNang + " kg");
        Console.WriteLine("Da tot nghiep: " + daTotNghiep);
    }
}