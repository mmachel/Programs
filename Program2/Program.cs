using System;
using System.Collections;
using System.Collections.Generic;

namespace Pets
{
    interface IStrokeable
    {
        void Strocke();
    }
    public abstract class Pet
    {
        public string Name { get; set; }
        public readonly string Besitzer;
        public Pet(string Besitzer)
        {
            this.Besitzer = Besitzer;
        }
        public abstract void Attend();
    }
    public abstract class Mammal : Pet, IStrokeable
    {
        public Mammal(string Besitzer) : base(Besitzer) { }
        public abstract void Move();

        public void Strocke() => System.Console.WriteLine("Stroooking....");
    }
    public abstract class Fish : Pet
    {
        public Fish(string Besitzer) : base(Besitzer) { }
        public abstract void Swim();
        public override void Attend()
        {
            System.Console.WriteLine("Changing water from aquarium.");
        }
    }
    public class Cat : Mammal
    {
        public Cat(string Name) : base(null)
        {
            this.Name = Name;
        }

        public override void Attend()
        {
            Console.WriteLine($"Brushing {typeof(Cat).Name}");
        }

        public override void Move()
        {
            Console.WriteLine($"Sneak...");
        }
        public new void Strocke()
        {
            var random = new Random();
            int rand = random.Next(0, 5);
            if (rand == 0)
            {
                Console.WriteLine("Miau...rhuurhuu");
            }
            Console.WriteLine("Stroook...");
        }
        public override string ToString()
        {
            return string.Format($"Art: {typeof(Cat).Name}, Name: {Name}, Besitzer: {Besitzer}");
        }
    }
    class Rabbit : Mammal
    {
        public Rabbit(string Name, string Besitzer) : base(Besitzer)
        {
            this.Name = Name;
        }

        public override void Attend() => Console.WriteLine($"Muck out the stable");

        public override void Move() => System.Console.WriteLine($"Hop...Hop...Hop");
        public override string ToString()
        {
            return string.Format($"Art: {typeof(Rabbit).Name}, Name: {Name}, Besitzer: {Besitzer}");
        }
    }
    class Dog : Mammal
    {
        public Dog(string Name, string Besitzer) : base(Besitzer)
        {
            this.Name = Name;
        }

        public override void Attend()
        {
            Console.WriteLine("Attending Dog");
        }

        public override void Move()
        {
            Console.WriteLine("Running...");
        }
        public override string ToString()
        {
            return string.Format($"Name: {Name}, Besitzer: {Besitzer}");
        }
    }
    public class Goldfish : Fish, IStrokeable
    {
        public Goldfish(string Name, string Besitzer) : base(Besitzer)
        {
            this.Name = Name;
        }
        public void Strocke()
        {
            if (Besitzer == null)
            {
                Console.WriteLine("Swimming away...");
            }
            else
            {
                Console.WriteLine("Strooo....");
            }
        }

        public override void Swim()
        {
            Console.WriteLine("Circle Swimming...");
        }
        public override string ToString()
        {
            return string.Format($"Art: {typeof(Goldfish).Name}, Name: {Name}, Besitzer: {Besitzer}");
        }
    }
    class Guppy : Fish
    {
        public Guppy(string Name, string Besitzer) : base(Besitzer)
        {
            this.Name = Name;
        }
        public override void Swim()
        {
            Console.WriteLine("Front-back Swimming....");
        }
        public override string ToString()
        {
            return string.Format($"Art: {typeof(Guppy).Name}, Name: {Name}, Besitzer: {Besitzer}");
        }
    }
    class Program
    {
        static void Main()
        {
            var cat1 = new Cat("Miuwa");
            var cat2 = new Cat("Gatinho");
            var dog = new Dog("Bock", "OtherOne");
            var rab1 = new Rabbit("Runner", "Someone");
            var rab2 = new Rabbit("Coelho", "Someone");
            var gold1 = new Goldfish("Gluglu", "TheOne");
            var gold2 = new Goldfish("Lalola", "TheOne");
            var gup1 = new Guppy("Gupo", "TheOne");
            var gup2 = new Guppy("Gup", "TheOne");



            var garden = new List<Mammal>();
            garden.Add(cat1);
            garden.Add(cat2);
            garden.Add(rab1);
            garden.Add(rab2);
            var aquarium = new List<Fish>();
            aquarium.Add(gold1);
            aquarium.Add(gold2);
            aquarium.Add(gup1);
            aquarium.Add(gup2);
            foreach (var mamal in garden)
            {
                Console.WriteLine(mamal);
                mamal.Move();
            }
            foreach (var fish in aquarium)
            {
                Console.WriteLine(fish);
                fish.Swim();
            }

            //List<Pet> zoo = new List<Pet>();
            //zoo.AddRange(garden);
            List<Pet> zoo = new List<Pet>(garden);
            zoo.AddRange(aquarium);
            foreach (var z in zoo)
            {
                z.Attend();
                var istr = z as IStrokeable;
                if (istr != null)
                {
                    istr.Strocke();
                }
            }
            // var istr = z as IStrokeable;
        }
    }
}
