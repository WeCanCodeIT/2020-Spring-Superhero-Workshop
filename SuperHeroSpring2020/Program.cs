using System;
using System.Collections.Generic;

namespace SuperHeroSpring2020
{
    public class Program
    {
        static void Main(string[] args)
        {
            SuperHero superhero = new SuperHero("Bob");

            Console.WriteLine("My superhero's name is " + superhero.Name);

            superhero.Name = "George";

            Console.WriteLine("Now my superhero's name is " + superhero.Name);

            Console.WriteLine("What is the name of your superhero?");
            superhero.Name = Console.ReadLine();

            Console.WriteLine("My particular superhero's name is " + superhero.Name);
        }
    }
}
