// See https://aka.ms/new-console-template for more information
using System.Numerics;

public class Penjumlahan<T>
{
    public T JumlahTigaAngka<T>(T data1, T data2, T data3) where T : IAdditionOperators<T, T, T>
    {
        return data1 + data2 + data3;
    }
}

public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputData;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputData = new List<DateTime>();
    }

    public void AddNewData(T input)
    {
        storedData.Add(input);
        inputData.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++) {
            Console.WriteLine("Data " + i + "berisi: " + storedData[i] + ", yang disimpan pada waktu " + inputData[i]);
        }
    }
}

class main ()
{
    static void Main(string[] args)
    {
        Penjumlahan<double> test = new Penjumlahan<double>();
        double a = 13;
        double b = 2;
        double c = 22;
        Console.WriteLine(test.JumlahTigaAngka(a, b, c));


    }
}