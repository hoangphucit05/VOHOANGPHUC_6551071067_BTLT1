using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("MSSV: 6551071067");

        decimal celsius;
        Console.Write("Nhap nhiet do Celsius: ");
        celsius = decimal.Parse(Console.ReadLine());
        decimal fahrenheit = celsius * 9 / 5 + 32;
        decimal kelvin = celsius + 273.15m;
        Console.WriteLine("Fahrenheit = {0:F2}", fahrenheit);
        Console.WriteLine("Kelvin = {0:F2}", kelvin);
    }
}