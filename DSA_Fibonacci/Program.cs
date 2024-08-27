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

            ProcessStartInfo runJSInCInfo = new ProcessStartInfo()
            {
                FileName = "node", //Configures it to run script w/ node.js
                Arguments = fibJSPath,
                RedirectStandardOutput = true,//Captures recursion.js output so it can be read/displayed in console app
                //manage how process is executed and how its output is handled(?)
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using Process runJSInCProcess = new Process();
            runJSInCProcess.StartInfo = runJSInCInfo;
            runJSInCProcess.Start();

            //reads recursion.js output
            string recursionJSOutput = runJSInCProcess.StandardOutput.ReadToEnd();
            runJSInCProcess.WaitForExit();

            Console.WriteLine(recursionJSOutput);
        }

        public static void FibSeq()
        {
            int prev1 = 0;
            
            int prev2 = 1;

            Console.WriteLine($"{prev1}\n{prev2}");

            for(int i = 0; i < 18; i++)
            {
                int newFib = prev1 + prev2;

                Console.WriteLine($"{newFib}");

                prev1 = prev2;
                prev2 = newFib;
            }

            Console.WriteLine();
        }
    }
}
/*
- Two variables to hold the previous two Fibonacci numbers
- A for loop that runs 18 times
- Create new Fibonacci numbers by adding the two previous ones
- Print the new Fibonacci number
- Update the variables that hold the previous two fibonacci numbers
*/
