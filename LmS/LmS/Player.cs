using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LmS
{
    class Player
    {

        public double wallet = 20;

        public int Jug = 12;
        public double Recipe;
        public double DayProfit;
        public double DayLoss;
        public int SugarRecipe;
        public int IceRecipe;
        public int LemonRecipe;
        public double LemonadePrice;
        public void WalletExpenses(double demandCost)
        { 
            wallet -= demandCost;

            Console.WriteLine("You have remaining:" + wallet);
          


        }

        public void FillingSugarInventory(int SugarInventory)
        {
            Console.WriteLine("Sugarbags=", SugarInventory);
            SugarInventory = Convert.ToInt32(Console.ReadLine());


        }
        public void FillingLemonInventory(int LemonInventory)
        {
            Console.WriteLine("Lemons=", LemonInventory);
            LemonInventory = Convert.ToInt32(Console.ReadLine());


        }

        public void FillingIceInventory(int IceInventory)
        {
            Console.WriteLine("Ice=", IceInventory);
           IceInventory = Convert.ToInt32(Console.ReadLine());


        }
        public void FillingCupsInventory(int CupsInventory)
        {
            Console.WriteLine("Cups=", CupsInventory);
            CupsInventory = Convert.ToInt32(Console.ReadLine());


        }

        public void PreparingRecipe()
        {
            Console.WriteLine("Please Enter the price of one Lemonade Cup");
           LemonadePrice= Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("Please Enter How many Sugarbags would like to use per Jug= ",Jug);
            SugarRecipe= Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Please Enter how many IceCubes would like to use per Cup");
             IceRecipe= Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Please Enter how many Lemon would like to use per jug=", Jug);

        }
        
    }
     
}
