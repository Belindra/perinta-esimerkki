using System;
using System.Drawing;

namespace Perinta_esimerkki
{
    class Program
    {
        static void Main(string[] args)
        {
            var myMonkey = new Monkey("Bob")
            {
                Color = Color.Black
            };
            myMonkey.Climb();
            myMonkey.Jump();

            var myBird = new Bird("Eugene")
            {
               Color = Color.Red
            };
            myBird.Sing();

            Console.WriteLine(myMonkey);
            Console.WriteLine(myBird);
            Console.ReadKey();
        }
    }
}
