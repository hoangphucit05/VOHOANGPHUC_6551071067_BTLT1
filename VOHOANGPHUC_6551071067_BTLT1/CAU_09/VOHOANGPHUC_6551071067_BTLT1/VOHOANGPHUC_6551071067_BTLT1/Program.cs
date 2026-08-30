using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 6551071067");

        string hoTen;

        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine();

        Console.WriteLine("Do dai chuoi = " + hoTen.Length);
        Console.WriteLine("Chuoi chu HOA = " + hoTen.ToUpper());
        Console.WriteLine("Chuoi chu thuong = " + hoTen.ToLower());
        string chuoiTrim = hoTen.Trim();
        Console.WriteLine("Chuoi sau khi Trim = " + chuoiTrim);
        if (chuoiTrim.Contains("Nguyen"))
            Console.WriteLine("Chuoi co chua tu Nguyen");
        else
            Console.WriteLine("Chuoi khong chua tu Nguyen");
        string[] cacTu = chuoiTrim.Split(' ');
        Console.WriteLine("Tung tu:");
        foreach (string tu in cacTu)
        {
            if (tu != "")
                Console.WriteLine(tu);
        }
        string chuoiGhep = String.Join("-", cacTu);
        Console.WriteLine("Chuoi sau khi ghep = " + chuoiGhep);
    }
}