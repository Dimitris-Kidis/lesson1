// Hometask #3. 

// Open-Closed Principle
// Liskov Substitution
// Interface Segregation

// 1. 3 examples which violate the three principle
// 2. 3 examples which solve the problem

// 1.
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {

            IAnimal animal1 = new Lion();
            IAnimal animal2 = new Fish();
            IAnimal animal3 = new Cat();
            IAnimal animal4 = new Dog();

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);

            animals.ForEach(i => Console.Write("{0}\t", i));

            Console.WriteLine();
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i] is Lion)
                {
                    animals[i].makeSound();
                } else if (animals[i] is Fish)
                {
                    animals[i].makeSound();
                } else if (animals[i] is Cat)
                {
                    animals[i].makeSound();
                } else if (animals[i] is Dog)
                {
                    animals[i].makeSound();
                }

            }

        }
    }
}
interface IAnimal
{
    void makeSound();
    void canSwim();
    void canClimb();
}

class Fish : IAnimal
{
    public void makeSound()
    {
        Console.WriteLine("---");
    }

    public void canSwim()
    {
        Console.WriteLine("I can swim!");
    }

    public void canClimb()
    {
    }
}

class Dog : IAnimal
{
    public void makeSound()
    {
        Console.WriteLine("Bark!");
    }

    public void canSwim()
    {
        Console.WriteLine("I can swim!");
    }

    public void canClimb()
    {
    }
}
class Lion : IAnimal
{
    public void makeSound()
    {
        Console.WriteLine("Roar!");
    }

    public void canSwim()
    {
        Console.WriteLine("I can swim!");
    }
    public void canClimb()
    {
    }
}

class Cat : IAnimal
{
    public void makeSound()
    {
        Console.WriteLine("Meow");
    }

    public void canSwim()
    {
    }
    public void canClimb()
    {
        Console.WriteLine("I can climb a tree!");
    }
}



// ---------------------



// 2.
/*
using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {

            IAnimal animal1 = new Lion();
            IAnimal animal2 = new Fish();
            IAnimal animal3 = new Cat();
            IAnimal animal4 = new Dog();

            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(animal1);
            animals.Add(animal2);
            animals.Add(animal3);
            animals.Add(animal4);

            animals.ForEach(i => Console.Write("{0}\t", i));

            Console.WriteLine();
            for (int i = 0; i < animals.Count; i++)
            {
                animals[i].makeSound();
            }

        }
    }
}
interface IAnimal
{
    void makeSound();
}

interface ISwims
{
    void canSwim();
}

interface IClimbsTheTree
{
    void canClimb();
}
class Fish : IAnimal, ISwims
{
    public void makeSound()
    {
        Console.WriteLine("---");
    }

    public void canSwim()
    {
        Console.WriteLine("I can swim!");
    }
}

class Dog : IAnimal, ISwims
{
    public void makeSound()
    {
        Console.WriteLine("Bark!");
    }

    public void canSwim()
    {
        Console.WriteLine("I can swim!");
    }
}

class Lion : IAnimal, ISwims
{
    public void makeSound()
    {
        Console.WriteLine("Roar!");
    }

    public void canSwim()
    {
        Console.WriteLine("I can swim!");
    }
}

class Cat : IAnimal, IClimbsTheTree
{
    public void makeSound()
    {
        Console.WriteLine("Meow");
    }
    public void canClimb()
    {
        Console.WriteLine("I can climb a tree!");
    }
}

*/