using System;

static public class Zad4{
    static public void CreateAndPrintTouple()
    {
        var data = new {name = "Adam", surname = "Kowalski", age = 35, salary = 4500.00};
        PrintTouple(data);
    }

    static void PrintTouple(object data)
    {
        Console.WriteLine($"Dane: {data}");

        foreach (var property in data.GetType().GetProperties())
        {
            Console.Write($"{property.Name}: {property.GetValue(data)} ");
        }
        Console.WriteLine();

        Console.WriteLine($"Imię: {data.GetType().GetProperty("name").GetValue(data)}, nazwisko: {data.GetType().GetProperty("surname").GetValue(data)}, wiek: {data.GetType().GetProperty("age").GetValue(data)}, płaca: {data.GetType().GetProperty("salary").GetValue(data)}.");
    }
}