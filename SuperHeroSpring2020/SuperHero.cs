using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroSpring2020
{
    public class SuperHero
    {
        // constructors

        // private bool HasCostume;



        // Properties

        // get {return this.hasCostume;} returns the value
        // set {this.hasCostume = value} sets the value 
        public bool HasCostume { get; set; }
        public string SuperPower { get; set; }
        public string Name { get; set; }
        public string SideKick { get; set; }
        public int NumberOfSideKicks { get; set; }
        public string Location { get; set; }
        public string Transportation { get; set; }


        public SuperHero(bool hasCostume, string superPower, string name, string sideKick, int numberOfSideKicks, string location, string transportation)
        {
            HasCostume = hasCostume;
            SuperPower = superPower;
            Name = name;
            SideKick = sideKick;
            NumberOfSideKicks = numberOfSideKicks;
            Location = location;
            Transportation = transportation;

        }


        // Methods

        public void AssignName(string name)
        {
        }












}
}
