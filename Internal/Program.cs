using System;

namespace Internal
{
    /*
        The accessibility of the class members declared as
        internal is limited to the current assembly only, i.e.,
        they cannot be accessed from any other assembly in our
        code.
     */
    class Sports
    {
        internal int GamesCount;

        internal void Print()
        {
            Console.WriteLine(this.GamesCount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sports sports = new Sports();
            sports.GamesCount = 5;
            sports.Print();
        }
    }
}
