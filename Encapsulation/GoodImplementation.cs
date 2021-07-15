using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class GoodImplementation
    {
        private int moneyCollected;
        private int productPrice;
        private int insertedMoney;

        public GoodImplementation()
        {
            this.moneyCollected = 0;
            this.productPrice = 2;
            this.insertedMoney = 0;
        }

        public void AddMoney(int money)
        {
            this.insertedMoney = money;

            if (this.insertedMoney >= 0)
            {
                Console.WriteLine("You inserted {0}$", this.insertedMoney);
                this.Change(); // Call the change method to provide change
            }
            else
            {
                Console.WriteLine("Invalid Insertion");
            }
            this.insertedMoney = 0;
        }

        private void Change()
        {
            if (this.insertedMoney >= this.productPrice)
            { //check if any change
                int change = this.insertedMoney - this.productPrice; //calculate change
                this.moneyCollected += this.productPrice; // Add money to total collection
                Console.WriteLine("Your change is: {0}$", change);
            }
            else
            {
                Console.WriteLine("You didn't insert sufficient money!");
                // Return whatever the user entered
                Console.WriteLine("Your change is: {0}$", this.insertedMoney);
            }
        }

        public int GetMoneyCollected()
        {
            return this.moneyCollected;
        }
    }
}
