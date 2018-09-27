using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmS
{
    class Inventory
    {
        //Inventory and their pricing
        // member variables
        //
        public Double LemonPrice = 0.50;
        public int Lemons;
        // SugarCup= 6 cups of Lemonade
        public Double Sugar = 0.40;
        public int SugarCup;
        public Double Ice = 0.70;
        public int IceCubes;
        public Double PaperCups = 0.65;
        public int CupsQuantity; 
        public int Budget = 20;

        public void IngredientsQuantity()
        {
            SugarCup = 2;
            IceCubes = 100;
            CupsQuantity = 10;
            Lemons = 6;

        }
        public void IngredientSelection()
        {
            string UserInput;
            Console.WriteLine("Do wish to buy ingredients(y/n)");
           UserInput = Console.ReadLine();

            if (UserInput == "y")
            {
                List<string> IngredientSelection = new List<string> {"Sugar","Lemons","Ice","PaperCups",  };
                foreach(string Inventory in IngredientSelection)
                {
                    Console.Write(IngredientSelection);



                }
                if (UserInput== "n")
                {





                }






            }
                
        }
         


    }

}
