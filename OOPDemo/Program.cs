using System;
using System.Collections.Generic;

namespace OOPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var petShop = new List<Animal>();

            var mammal = new Mammal(4);
            Console.WriteLine(mammal);
            mammal.Talk();

            Console.WriteLine();

            //Animal m = new Mammal(2);
            //Console.WriteLine(m);
            //m.Talk();

            petShop.Add(new Cat("Tom", 5));
            petShop.Add(new Cat("Leo", 4, "angora"));
            petShop.Add(new Dog(12));

            foreach (var animal in petShop)
            {
                Console.WriteLine(animal);
                animal.Talk();

                //var dog = animal as Dog;
                //if (dog != null) dog.Talk();

                if (animal is Dog dog) dog.Talk();

                Console.WriteLine();
            }

            List<IFlying> flyers = new List<IFlying>() {
                new Bat(1),
                new Bird()
            };

            foreach (var flyer in flyers)
            {
                Console.WriteLine(flyer);
                (flyer as Animal).Talk();
                flyer.Fly();
                Console.WriteLine(flyer);
                flyer.Land();
                Console.WriteLine(flyer);
                Console.WriteLine();

            }
        }
    }
}
