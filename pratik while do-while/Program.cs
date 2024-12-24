using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir limit değeri girin: ");
        int limit = int.Parse(Console.ReadLine());

        int sayac = 0;

        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac++;  
        } while (sayac <= limit);
    }
}









