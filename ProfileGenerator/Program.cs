using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProfileGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
            sam.SetHobbies(new string[] { "listening to music", "cooking", "reading" });
            Console.WriteLine(sam.ViewProfile());

        }
    }
}

