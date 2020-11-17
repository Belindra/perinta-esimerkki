using System;
using System.Collections.Generic;
using System.Text;

namespace Perinta_esimerkki
{
    class Bird : Animal
    {
        public Bird(string animalName) : base(animalName)
        {
            Console.WriteLine("Created a bird");
        }

        public void Sing()
        {
            Console.WriteLine("The bird is singing");
        }

        public override string MakeNoise()
        {
            return "kvaak";
        }

        public override void Reproduce()
        {
            base.Reproduce();
            Console.WriteLine("Birds doing bird business");
        }
    }
}
