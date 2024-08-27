using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace DSA_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            FibSeq();
            
            string fibJSPath = "recursion.js";

            ProcessStartInfo runJSInCInfo = new();
            {
                FileName = "node";//Configures it to run script w/ node.js
                Arguments = fibJSPath;
                RedirectStandardOutput = true;//Captures recursion.js output so it can be read/displayed in console app
                //manage how process is executed and how its output is handled(?)
                UseShellExecute = false;
                CreateNoWindow = true;
            };

            using Process runJSInCProcess = new();
            runJSInCProcess.StartInfo = runJSInCInfo;
            runJSInCProcess.Start();

            //reads recursion.js output
            string recursionJSOutput = runJSInCProcess.StandardOutput.ReadToEnd();
            runJSInCProcess.WaitForExit();

            Console.WriteLine(recursionJSOutput);
        }

        public static void FibSeq()
        {
            int prevFib1 = 0;
            
            int prevFib2 = 1;

            for(int i = 0; i < 18; i++)
            {
                int newFib = prevFib1 + prevFib2;

                Console.Write($"{newFib} ");

                prevFib1 = prevFib2;
                prevFib2 = newFib;
                newFib = prevFib1 + prevFib2;
            }
        }
        
        private static string? FileName;
        private static string? Arguments;
        private static bool RedirectStandardOutput;
        private static bool UseShellExecute;
        private static bool CreateNoWindow;
    }
}
/*
- Two variables to hold the previous two Fibonacci numbers
- A for loop that runs 18 times
- Create new Fibonacci numbers by adding the two previous ones
- Print the new Fibonacci number
- Update the variables that hold the previous two fibonacci numbers
*/
