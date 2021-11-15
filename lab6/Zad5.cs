using System;

static class Zad5{
    static public void DrawCard(string name, string surname, char fill, int borderWeight, int width)
    {
        DrawHorizontalBorder(fill, borderWeight, width);
        WriteDataLine(name, fill, width, borderWeight);
        WriteDataLine(surname, fill, width, borderWeight);
        DrawHorizontalBorder(fill, borderWeight, width);
    }

    private static void WriteDataLine(string data, char fill, int width, int borderWeight)
    {
        int dataWidth = width - (2 * borderWeight);
        int leftPadding = (dataWidth - data.Length) / 2;
        int rightPadding = dataWidth - data.Length - leftPadding;

        Console.Write("".PadLeft(borderWeight, fill));
        Console.Write("".PadLeft(leftPadding));
        Console.Write(data);
        Console.Write("".PadLeft(rightPadding));
        Console.Write("".PadLeft(borderWeight, fill));
        Console.WriteLine();
    }


    private static void DrawHorizontalBorder(char fill, int borderWeight, int width)
    {
        for (int i = 0; i < borderWeight; i++)
        {
            Console.Write("".PadLeft(width, fill));
            Console.WriteLine();
        }
    }
}