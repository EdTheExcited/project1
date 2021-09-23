using System.Collections.Generic;
using System;

namespace project1
{
    public class Tummygachi
    {
        private int hunger = 5;
        private int boredom = 5;
        private List<string> words = new List<string>() { "hej" };
        private bool isAlive = true;
        private Random generator = new Random();

        public string name;

        public void Feed()
        {
            hunger -= 3;
            if (hunger < 0)
            {
                hunger = 0;
            }
            if (hunger < 5)
            {
                System.Console.WriteLine("Nom, Nom, Nom \n Im nice and full now :D");
            }
            else if (hunger > 5)
            {
                System.Console.WriteLine("Munch, Munch \n So good! Give me more");
            }
            else
            {
                System.Console.WriteLine("Yummy!");
            }




        }

        public void Speak()
        {
            int i = generator.Next(0, words.Count);

            System.Console.WriteLine($"{words[i]}");

        }

        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();
            System.Console.WriteLine($"He He {word}");
        }
        public void Tick()
        {
            hunger++;
            boredom++;
            if (hunger >= 10 || boredom >= 10)
            {
                isAlive = false;

            }


        }
        public void PrintStats()
        {
            System.Console.WriteLine($"Hunger:{hunger} \n Boredom:{boredom} \n Is Alive:{isAlive}");

        }
        public bool GetAlive()
        {
            return isAlive;
        }

        private void ReduceBoredom()
        {
            boredom--;


        }



    }
}