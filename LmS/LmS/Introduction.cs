﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmS
{
    public  class Introduction
    {
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Lemonade Stand");
        }
       public List<string> AddIntroduction()
        {
            List<string> gameIntroduction = new List<string>();
            gameIntroduction.Add("You have 7 days to make as much money as possible, and you’ve decided to open a lemonade stand! You’ll have complete control over your business, including pricing, quality control, inventory control, and purchasing supplies. Buy your ingredients, set your recipe, and start selling!");
            gameIntroduction.Add("The first thing you’ll have to worry about is your recipe. At first, go with the default recipe, but try to experiment a little bit and see if you can find a better one. Make sure you buy enough of all your ingredients, or you won’t be able to sell!");
            gameIntroduction.Add("You’ll also have to deal with the weather, which will play a big part when customers are deciding whether or not to buy your lemonade. Read the weather report every day! When the temperature drops, or the weather turns bad (overcast, cloudy, rain), don’t expect them to buy nearly as much as they would on a hot, hazy day, so buy accordingly. Feel free to set your prices higher on those hot, muggy days too, as you’ll make more profit, even if you sell a bit less lemonade.");
            return gameIntroduction;
        }
        public void DisplayIntroduction(List<string> Introductions)
        {
            AddIntroduction();
            foreach (string Introduction in Introductions)
            {
                Console.WriteLine(Introduction);
                Console.ReadLine();
            }
        }
    }
}
