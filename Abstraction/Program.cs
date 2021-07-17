using System;

namespace Abstraction
{
    /*
        Abstraction refers to exposing only the essential
        features of an object to the user and hiding the inner
        details to reduce complexity. It can be put this way:
        the user only has to know what an object does? rather
        than how it does it?.
     */

    abstract class EDM
    {
        public EDM()
        { 
            
        }

        public abstract void Transact();

        public void Dispense()
        {
            Console.WriteLine("{0} is dispensing the product!", this.GetType().Name);
        }
    }

    class CardVendingMachine : EDM
    {
        public override void Transact()
        {
            Console.WriteLine("I accept cards only!");
        }
    }

    class CashVendingMachine : EDM
    {
        public override void Transact()
        {
            Console.WriteLine("I accept cash only!");
        }
    }

    class HybridVendingMachine : EDM
    {
        public override void Transact()
        {
            Console.WriteLine("I accept both cards and cash!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EDM cardVendy = new CardVendingMachine();
            EDM cashVendy = new CashVendingMachine();
            EDM hybridVendy = new HybridVendingMachine();

            cardVendy.Dispense();
            cardVendy.Transact();

            Console.WriteLine();

            cashVendy.Dispense();
            cashVendy.Transact();

            Console.WriteLine();

            hybridVendy.Dispense();
            hybridVendy.Transact();
        }
    }
}
