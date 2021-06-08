using System;

namespace LESSON2_ConstructorHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner momo = new Owner("Momo");
            Cat ownedCat = new Cat("Lennny", momo);
            Cat unownedCat = new Cat("Buddy");
        }
    }

    class Cat
    {
        public string Name { get; set; }
        public Owner Owner { get; set; }

        public Cat(string name)
        {
            Name = name;
            Console.WriteLine($"ADDED CAT: {Name}");
        }

        public Cat(string name, Owner owner)
        {
            Name = name;
            Owner = owner;
            Console.WriteLine($"ADDED CAT: {Name}, OWNER: {Owner.Name}");
        }
    }

    class Owner
    {
        public string Name { get; set; }

        public Owner(string name)
        {
            Name = name;
            Console.WriteLine($"ADDED OWNER: {Name}");
        }
    }
}
