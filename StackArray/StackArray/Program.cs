using System;

namespace stos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var tablica = new Stack();

            tablica.Push(1);   // Put item in stack on top
            tablica.Push(2);
            tablica.Push(3);
            tablica.Push(4);
            
            tablica.ShowStack();   // shows the whole stack list
            tablica.Pop();        // I'm getting the lowest item
            tablica.ShowStack();   // shows the whole stack list
            tablica.Push(5);    // I'm adding an item to the top
            tablica.ShowStack();   // shows the whole stack list
            tablica.Pop();        // I'm getting the lowest item
            tablica.ShowStack();   // shows the whole stack list
            
            Console.ReadKey();
        }
    }
}