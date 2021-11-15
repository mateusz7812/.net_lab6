using System;

static public class Zad1{
    static public void CreateAndPrintTouple()
    {
        var data = ("Adam", "Kowalski", 35, 4500.00);
        PrintTouple(data);
    }

    static void PrintTouple((string, string, int, double) data)
    {
        Console.WriteLine($"Dane: {data}");

        Console.WriteLine($"Imię: {data.Item1}, nazwisko: {data.Item2}, wiek: {data.Item3}, płaca: {data.Item4}.");

        var (name, surname, age, salary) = data;
        Console.WriteLine($"Imię: {name}, nazwisko: {surname}, wiek: {age}, płaca: {salary}.");

    }
}