using System;

namespace Test
{
    public class Computer
    {
        public int Id { get; set; }
        public string name { get; set; } = "";

        public bool flag { get; set; }

        public Computer()
        {
            if (Id >= 1)
            {
                Id = 1001;
            }
        }
    }

    // internal class Program
    // {
    //     static void main(String[] args)
    //     {
    //         Computer c = new Computer()
    //         {
    //             Id=0,
    //             name="san",
    //             flag = false

    //         };
    //         Console.WriteLine(c.flag);
    //         Console.WriteLine(c.name);
    //         Console.WriteLine(c.Id);

    //     }
    // }
}