using System;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Zad1.CreateAndPrintTouple();
            //Zad2.CreateVariableNamedClassAndPrint();
            //Zad3.PresentArrayModule();
            //Zad4.CreateAndPrintTouple();
            //Zad5.DrawCard("Ryszard", "Rys", 'X', 2, 20);
            Console.WriteLine(Zad6.CountMyTypes("a", 9.6, 1, true, 1.0, 2, 3.0, 5, "testowy", -4.0, new object(), -2, (float)1.8, 0.5));
        }




    }
}
