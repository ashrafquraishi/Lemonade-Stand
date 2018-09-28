using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmS
{
    class Store
    {
        //Inventory and their pricing
        // member variables
        //
        public Double Lemons= 0.50;
        public int LemonsQuantity;
        // SugarCup= 6 cups of Lemonade
        public Double Sugar = 0.40;
        public int SugarCup;
        public Double Ice = 0.70;
        public int IceCubes;
        public Double PaperCups = 0.65;
        public int CupsQuantity; 
       public string SelectedItem

        public void IngredientsQuantity()
        {
            SugarCup = 2;
            IceCubes = 100;
            CupsQuantity = 10;
            LemonsQuantity = 6;

        }
        public void IngredientSelection()
        {
            string UserInput;
            Console.WriteLine("Do wish to buy ingredients(y/n)");
           UserInput = Console.ReadLine();   

            if (UserInput == "y")
            {
                Console.WriteLine("Please Enter Sugar,Icecubes,PaperCups,lemon to buy any of these ingredients");
              

               
                    Console.Write(IngredientSelection);
                    Console.Write("Enter how much Sugar you need for a Lemonade


            
                if (UserInput == "n")
                {



                }



            }
                
        }
         


    }

}
