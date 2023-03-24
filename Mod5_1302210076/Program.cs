// See https://aka.ms/new-console-template for more information

internal class program
{
    private static void Main(string[] args)

    {
        Penjumlahan<int> pen = new Penjumlahan<int>();
        pen.JumlahTigaAngka(13, 02, 21);

        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.AddNewData(13);
        data.AddNewData(02);
        data.AddNewData(21);
        data.PrintAllData();
    }
}

public class Penjumlahan<T>
{
    public void JumlahTigaAngka(T a, T b, T c)

    {
        dynamic aa = a;
        dynamic bb = b;
        dynamic cc = c;
        Console.WriteLine(aa + bb + cc);
    }
}

public class SimpleDataBase<T>
{
    List<T> storedData { get; set; }
    List<DateTime> inputDates { get; set; }

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now.Date);
    }

    public void PrintAllData()
    {
        for(int i = 0; i< storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData.ElementAt(i) + ", yang disimpan pada waktu " + inputDates.ElementAt(i));
        }
    }
}
