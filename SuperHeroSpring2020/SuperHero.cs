using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroSpring2020
{
    public class SuperHero
    {
        // Fields
        //private bool hasCape;
        //private int speed;
        //private string name;

        // Property Declaration using Getter and Setter Methods on the Private Fields
        //public bool HasCape
        //{
        //    get { return this.hasCape; }
        //    set { this.hasCape = value; }
        //}

        //public int Speed
        //{
        //    get { return this.speed; }
        //    set { this.speed = value; }
        //}

        //public string Name
        //{
        //    get { return this.name; }
        //    set { this.name = value; }
        //}

        // CLASS PROPERTIES
        // Or....Shorthand Property Declaration
        public bool HasCape { get; set; }
        public int Speed { get; set; }
        public string Name { get; set; }

        // CLASS CONSTRUCTORS
        // This is the default constructor
        //public SuperHero()
        //{

        //}

        public SuperHero()
        {
            Name = "My New SuperHero";
        }

        // CLASS METHODS
        public void AssignName(string nameThatWasPassedIn)
        {
            Name = nameThatWasPassedIn;
        }

        public void IncreaseSpeed(int increaseInSpeed)
        {
            Speed = Speed + increaseInSpeed;
        }

        public string GreetSuperHero()
        {
            return "Hello, my favorite fan!";
        }
    }
}
