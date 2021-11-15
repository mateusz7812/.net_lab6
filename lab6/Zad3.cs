using System;

static class Zad3{
    static public void PresentArrayModule(){
        int[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };
        Console.WriteLine("\nint[] myIntArray = new int[5] { 1, 2, 3, 4, 5 };\nPrintArray(myIntArray);");
        WriteArray(myIntArray);

        int index = System.Array.Find(myIntArray, (int x) => x == 3);
        Console.WriteLine("\nint index = System.Array.Find(myIntArray, (int x) => x == 3);\nConsole.WriteLine(index);");
        Console.WriteLine(index);

        Console.WriteLine("\nint[] secondArray = new int[4];\nSystem.Array.Copy(myIntArray, secondArray, 4);\nPrintArray(secondArray);");
        int[] secondArray = new int[4];
        System.Array.Copy(myIntArray, secondArray, 4);
        WriteArray(secondArray);

        Console.WriteLine("\nint[] keys = System.Array.ConvertAll(secondArray, (x) => x % 2);\nPrintArray(keys);");
        int[] keys = System.Array.ConvertAll(secondArray, (x) => x % 2);
        WriteArray(keys);

        Console.WriteLine("\nSystem.Array.Sort(keys, secondArray);\nPrintArray(secondArray); ");
        System.Array.Sort(keys, secondArray);
        WriteArray(secondArray);

        Console.WriteLine("\nSystem.Array.Fill(secondArray, 5);\nPrintArray(secondArray); ");
        System.Array.Fill(secondArray, 5);
        WriteArray(secondArray);
    }

    static void WriteArray(int[] array){
        System.Array.ForEach(array, (x) => Console.Write($"{x} "));
    }
}