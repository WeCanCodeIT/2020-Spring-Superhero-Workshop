using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroSpring2020
{
    public class SuperHero
    {
        // private backing field
        // private bool hasCape;

        // getters and setters
        //public bool HasCape
        //{
        //    get { return this.hasCape; } //returns the value
        //    set { this.hasCape = value; } //sets the value
        //}

        public bool HasCape { get; set; }
        public int Speed { get; set; }
        public string Name { get; set; }

        public SuperHero()
        {
            HasCape = false;
            Name = "your SuperHero";
        }

        public SuperHero(string Name, string Type)
        {

        }

        public void IncreaseSpeed(int userSpeed)
        {
            Speed += userSpeed;
        }

        public void AssignName(string name)
        {
            Name = name;
        }
    }
}
