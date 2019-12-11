using System;

namespace SomeStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = new SomeClassToBeTested().Hello(100);
            Console.WriteLine(result);
        }
    }

    public class SomeClassToBeTested
    {
        public bool Hello(int t)
        {
            if (t > 0)
                return true;
            else
                return false;
        }
    }
}
