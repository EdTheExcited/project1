using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {

            Tummygachi tummy = new Tummygachi();

            System.Console.WriteLine("Welcome To My Tamagotchi Emulator! \n ------------------------------------- \n Oh! He is hatching already!!!\n (Press Enter To Move On)");
            Console.ReadLine();
            System.Console.WriteLine("What is the name of your new Friend?");
            tummy.name = Console.ReadLine();
            System.Console.WriteLine($"Oh! Welcome to the world {tummy.name}");
            Console.ReadLine();
            System.Console.WriteLine("Make sure you take care of your little friend, at any time you can type 'status' to see the level of hunger and boredom of your little friend ");
            Console.ReadLine();

            while (tummy.GetAlive())
            {
                System.Console.WriteLine("What would you like to do with your new friend? \n (Try: Status, Teach, Speak, Feed)");
                string action = Console.ReadLine();

                if (action.ToLower() == "speak")
                {
                    tummy.Speak();
                }
                else if (action.ToLower() == "status")
                {
                    tummy.PrintStats();
                }
                else if (action.ToLower() == "teach")
                {
                    System.Console.WriteLine($"Say the word you wish {tummy.name} to learn");
                    tummy.Teach(Console.ReadLine());

                }
                else if (action.ToLower() == "feed")
                {
                    tummy.Feed();
                }

                else
                {
                    System.Console.WriteLine($"{tummy.name} does not understand! Try 'Commands' \n (Invalid Input)");
                }
                tummy.Tick();
                if (tummy.GetAlive() == false)
                {
                    System.Console.WriteLine($"Oh no {tummy.name} has passed... LMAO HE DED, u suck never get a real pet... \n seriously please don't");
                }

                Console.ReadLine();


            }









        }
    }
}
