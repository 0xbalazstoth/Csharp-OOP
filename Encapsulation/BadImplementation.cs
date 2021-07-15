using System;

namespace Encapsulation
{
    /*
        Reason: Not hiding data, so anybody can change the values outside. 
    */
    class BadImplementation
    {
        public int moneyCollected;
        public int productPrice;
        public int insertedMoney;

        public BadImplementation()
        {
            this.moneyCollected = 0;
            this.productPrice = 2; // Let's fix the product price to 2$
            this.insertedMoney = 0;
        }

        public void AddMoney(int money) // Method to add money to collection
        {
            this.insertedMoney = money;
            if (this.insertedMoney >= 0)
            {
                Console.WriteLine("You inserted {0}$", this.insertedMoney);
                this.Change(); // Call the change method to provide change
            }
            else Console.WriteLine("Invalid Insertion");

            this.insertedMoney = 0;
        }

        public void Change()
        { //method to provide change
            if (this.insertedMoney >= this.productPrice)
            { //check if any change
                int change = this.insertedMoney - this.productPrice; //calculate change
                                                                     // product sold so add its price to collected money
                this.moneyCollected += this.productPrice;
                Console.WriteLine("Your change is: {0}$", change);
            }
            else
            {
                Console.WriteLine("You didn't insert sufficient money!");
                // the transaction was not successfull so return back the money
                Console.WriteLine("Your change is: {0}$", this.insertedMoney);
            }
        }

        public int GetMoneyCollected()
        { // Getter to moneyCollected
            return this.moneyCollected;
        }
    }
}
