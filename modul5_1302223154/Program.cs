// See https://aka.ms/new-console-template for more information
using System.Numerics;

public class Penjumlahan<T>
{
    public T JumlahTigaAngka<T>(T data1, T data2, T data3) where T : IAdditionOperators<T, T, T>
    {
        return data1 + data2 + data3;
    }
}

class main ()
{
    static void Main(string[] args)
    {
        Penjumlahan<double> test = new Penjumlahan<double>();
        double a = 3.1;
        double b = 3.2;
        double c = 3.7;
        Console.WriteLine(test.JumlahTigaAngka(a, b, c));
    }
}