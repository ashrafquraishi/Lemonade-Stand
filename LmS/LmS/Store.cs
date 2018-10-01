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
        public Double SugarPrice = 0.40; 
        public int SugarCup;
        public Double IcePrice = 0.70;
        public int IceCubes;
        public Double PaperCups = 0.65;
        public int CupsQuantity;
        public string SelectedItem;
        public int Demand;
        
        public void IngrmembeedientsQuantity()
        {
                  SugarCup = 2;
                  IceCubes = 100;
              CupsQuantity = 10;
            LemonsQuantity = 6;

        }
        public void IngredientSelection(Player player)
        {
            string UserInput;
            Console.WriteLine("Do wish to buy ingredients(y/n)");
           UserInput = Console.ReadLine();   

            if (UserInput == "y")
            {
                Console.WriteLine("Please Enter Sugar or Icecubes or PaperCups or lemon to buy any of these ingredients or Enter done to start making your recipe");
                SelectedItem = Console.ReadLine();
                 if (SelectedItem=="Sugar")
                {
                    Console.WriteLine("Enter how many number of Sugar Bags would you like to have","Sugar Cost=", SugarPrice, "Quantity=",SugarCup);
                    Demand = Convert.ToInt32(Console.ReadLine());
                    double demandCost = SugarPrice * Demand;
                    player.WalletExpenses(demandCost);
                 }
                 if(SelectedItem=="Icecubes")
                 {
                    Console.WriteLine("Enter how many number of Ice bags would you like to have","Ice bags=",IcePrice);
                     }
                 
               
                  
            
                if (UserInput == "n")
                {



                }



            }
                
        }
         


    }

}
