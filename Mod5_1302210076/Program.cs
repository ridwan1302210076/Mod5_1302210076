// See https://aka.ms/new-console-template for more information

internal class program
{
    private static void Main(string[] args)

    {
        Penjumlahan<int> pen = new Penjumlahan<int>();
        pen.JumlahTigaAngka(13, 02, 21);
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
