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
       
        public string PlayerInventory;
        public double Recipe;
        public double DayProfit;
        public double DayLoss;

        public void WalletExpenses(double demandCost)
        { 
            wallet -= demandCost;
            Console.WriteLine("You have remaining:" + wallet);


        }


    }
     
}
