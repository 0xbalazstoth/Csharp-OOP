using System;

namespace Encapsulation
{
    /*
        In layman’s terms, data hiding refers to the concept of
        hiding the inner workings of a class and simply providing
        a public interface through which the outside world can
        interact with the class without knowing what’s going on
        inside.
     */

    /*
        Components of data hiding
        - Encapsulation
        - Abstraction
     */

    /*
        Advantages of Encapsulation
        - Classes are easier to change and maintain.
        - We can specify which data member we want to keep hidden or accessible.
        - We decide which variables can be read or written by the outside world (increases flexibility).
    */

    class Program
    {
        static void Main(string[] args)
        {
            #region Bad implementation
            BadImplementation bad = new BadImplementation();
            bad.AddMoney(2);
            bad.AddMoney(5);
            bad.AddMoney(7);

            // getting the collected as 3 products sold it should be 2*3 = 6
            Console.WriteLine("Total collection till now is: {0}$", bad.GetMoneyCollected());

            //Let's try to corrupt collection
            bad.moneyCollected = 20;
            Console.WriteLine("Total collection till now is: {0}$", bad.GetMoneyCollected());
            //The collection was public so we easily changed its value
            //THIS SHOULD NOT HAVE HAPPENED!
            #endregion
            #region Good implementation
            GoodImplementation good = new GoodImplementation();
            good.AddMoney(3);
            good.AddMoney(5);
            good.AddMoney(7);
            Console.WriteLine(good.GetMoneyCollected());
            #endregion
        }
    }
}
