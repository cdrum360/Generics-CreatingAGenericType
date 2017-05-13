using System;

namespace Generics
{
    public class Program
    {
        private static void Main(string[] args)
        {
            UseTheMagicHat();

            Console.WriteLine("Ta Da!");
            Console.ReadLine();
        }

        private static void UseTheMagicHat()
        {
            MagicHat<Rabbit> rabbitHat = new MagicHat<Rabbit>(); // instaniate a MagicHat of Rabbit

            rabbitHat.Add(new Rabbit {Name = "Bugs"});
            rabbitHat.Add(new Rabbit {Name = "Roger"});
            rabbitHat.Add(new Rabbit {Name = "Thumper"});

            Rabbit firstRabbit = rabbitHat.Retrieve();  // pull rabbit
            Console.WriteLine(firstRabbit.Name);
        }
    }
}
