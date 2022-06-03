using System;
using System.Collections.Generic;

namespace DemoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Eagle eag = new Eagle("Brown");
            Pigeon pig = new Pigeon("White");
            Penguin pen = new Penguin("Black");
            Airplane mh370 = new Airplane("KL", "Void");

            List<Bird> birds = new List<Bird>();
            birds.Add(eag);
            birds.Add(pig);
            birds.Add(pen);

            List<IFlyable> flyingObjects = new List<IFlyable>();
            flyingObjects.Add(eag);
            flyingObjects.Add(pig);
            flyingObjects.Add(mh370);

            foreach (Bird bird in birds)
            {
                Console.WriteLine(bird);
            }

            foreach (IFlyable flyable in flyingObjects)
            {
                flyable.Fly();
            }
            pen.Swim();
        }
    }
}
