using System.Security.Cryptography.X509Certificates;

namespace DSA_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            FibSeq();
        }

        public static void FibSeq()
        {
            int prevFib1 = 0;
            int prevFib2 = 1;

            for(int i = 0; i < 18; i++)
            {
                int newFib = prevFib1 + prevFib2;
                Console.WriteLine($"{newFib}");
                prevFib1 = prevFib2;
                prevFib2 = newFib;
                newFib = prevFib1 + prevFib2;
            }
        }
    }
}
/*
- Two variables to hold the previous two Fibonacci numbers
- A for loop that runs 18 times
- Create new Fibonacci numbers by adding the two previous ones
- Print the new Fibonacci number
- Update the variables that hold the previous two fibonacci numbers*/
