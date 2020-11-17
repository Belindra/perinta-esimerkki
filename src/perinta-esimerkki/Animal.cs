using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Perinta_esimerkki
{
    abstract class Animal
    {
        public Color Color;
        public string Name;

        public Animal(string animalName)
        {
            Name = animalName;
            Console.WriteLine("Created a new animal named: " + Name);
        }

        public override string ToString()
        {
            return Name + " " + Color;
        }

        public abstract string MakeNoise();

       public virtual void Reproduce()
        {
            Console.WriteLine("Stuff happens and then there are more animals");
        }
    }
}
