// See https://aka.ms/new-console-template for more information
using Test;

internal class Program
{
    static void Main(String[] args)
    {
        Computer c = new Computer()
        {
            Id = 0,
            name = "san",
            flag = false

        };
        Console.WriteLine(c.flag);

        Console.WriteLine(c.name);
        Console.WriteLine(c.Id);

    }
}

// Console.WriteLine("Hello, World!!!");

// List<string> firstList = new List<string>();

// firstList.Add("Test");

// Console.WriteLine(firstList[0]);
// IEnumerable<string> Ilist = firstList;

// Console.WriteLine(Ilist.First());

