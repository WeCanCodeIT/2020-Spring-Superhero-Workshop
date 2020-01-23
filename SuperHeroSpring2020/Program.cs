using System;

namespace SuperHeroSpring2020
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHero superman = new SuperHero();
            bool playing = true;

            Console.WriteLine("You have a new SuperHero");
            Console.WriteLine("Give them a name and make them go....fast!");

            do
            {
                Console.WriteLine("\nMAIN MENU");
                Console.WriteLine("1. Give your SuperHero a name");
                Console.WriteLine("2. View SuperHero info");
                Console.WriteLine("3. View SuperHero status");
                Console.WriteLine("4. Make your SuperHero go faster");
                Console.WriteLine("5. Add more Super Powers");
                Console.WriteLine("6. Exit");

                Console.Write("\nPlease enter a number: ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.Write("What would you like to name your SuperHero? ");
                        string superHeroName = Console.ReadLine();
                        superman.AssignName(superHeroName);
                        Console.WriteLine($"Great! Now your SuperHero's name is {superman.Name}");
                        // Console.WriteLine("Great! Now your SuperHero's name is {0}", superman.Name);
                        break;
                    case ("2"):
                        Console.WriteLine($"SuperHero Name: {superman.Name}");
                        Console.WriteLine($"SuperHero has cape: {superman.HasCape}");
                        Console.WriteLine("I don't know anything about your Super Powers");
                        break;
                    case ("3"):
                        Console.WriteLine($"SuperHero Speed: {superman.Speed}");
                        break;
                    case "4":
                        Console.Write($"How much faster would you like {superman.Name} to go? ");
                        int speedIncrease = Convert.ToInt32(Console.ReadLine());
                        superman.IncreaseSpeed(speedIncrease);
                        Console.WriteLine($"{superman.Name} is now going {superman.Speed} mph!");
                        break;
                    case ("5"):
                        Console.WriteLine("Tell me what Super Power you would like to add: ");
                        string newPower = Console.ReadLine();
                        break;
                    case ("6"):
                        playing = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number!");
                        break;
                }
            } while (playing);

        }
    }
}
