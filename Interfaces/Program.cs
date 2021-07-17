using System;

namespace Interfaces
{
    /*
        An interface is just like an abstract class but
        only specifies the behavior that a class must
        implement.
     */

    /*
        Interface can only have:
        - Properties
        - Methods
        - Events
        - Indexers
     */

    abstract class EDM
    {
        public EDM()
        {

        }

        public abstract void Transact(bool successful);

        public void Dispense()
        {
            Console.WriteLine("{0} is dispensing the product!", this.GetType().Name);
        }
    }

    interface ICanPrint
    {
        void PrintReceipt();
    }

    class CashVendingMachine : EDM, ICanPrint
    {
        public override void Transact(bool successful)
        {
            if (successful)
            {
                Console.WriteLine("The transaction was successfully completed!");
                PrintReceipt();
            }
            else Console.WriteLine("The transaction was unsuccessful!");
        }

        public void PrintReceipt()
        {
            Console.WriteLine("Printing your receipt...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EDM cashVendy = new CashVendingMachine();

            cashVendy.Dispense();
            cashVendy.Transact(true);

            cashVendy.Dispense();
            cashVendy.Transact(false);
        }
    }
}
