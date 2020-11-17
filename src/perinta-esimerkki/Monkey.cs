using System;

namespace Perinta_esimerkki
{
    class Monkey : Animal
    {
        public Monkey(string animalName) : base(animalName)
        {
            Console.WriteLine("Created a monkey");
        }

        public Monkey() : base("default")
        {
            Console.WriteLine("Default");
        }

        public void Jump()
        {
            Console.WriteLine("The monkey is jumping");
        }

        public override string MakeNoise()
        {
            return "uh uh";
        }

        public virtual void Climb() // yksi variaatio virtual -metodista (tässä tapauksessa metodi käyttäytyy kuin mikä tahansa muu metodi)
        {
            Console.WriteLine("The monkey is climbing");
        }
    }
}
