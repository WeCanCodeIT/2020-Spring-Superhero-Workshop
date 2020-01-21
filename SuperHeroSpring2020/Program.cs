using System;

namespace SuperHeroSpring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            SuperHero mySuper = new SuperHero();
            bool playing = true;

            Console.WriteLine("You have a new SuperHero");
            Console.WriteLine("Give him and name and make him go...fast!");

            do
            {
                Console.WriteLine("\nMAIN MENU");
                Console.WriteLine("1. Give your SuperHero a name");
                Console.WriteLine("2. View SuperHero info");
                Console.WriteLine("3. View SuperHero status");
                Console.WriteLine("4. Make your SuperHero go faster");
                Console.WriteLine("5. Exit");

                Console.Write("\nEnter a number: ");
                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case ("1"):
                        Console.Write("What would you like to name your SuperHero? ");
                        string superHeroName = Console.ReadLine();
                        mySuper.AssignName(superHeroName);
                        break;
                    case ("2"):
                        Console.WriteLine("\nSuperHero Name: " + mySuper.Name);
                        Console.WriteLine("SuperHero has cape: " + mySuper.HasCape);
                        break;
                    case ("3"):
                        Console.WriteLine("\nSuperHero Speed: " + mySuper.Speed);
                        break;
                    case ("4"):
                        Console.Write("\nHow much faster would you like your SuperHero to go? ");
                        string speedIncrease = Console.ReadLine();
                        mySuper.IncreaseSpeed(Convert.ToInt32(speedIncrease));
                        Console.WriteLine("Your SuperHero is now going " + mySuper.Speed + " mph!");
                        break;
                    case ("5"):
                        playing = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
            } while (playing);
        }
    }
}
