# Week27_Day01_Fibonacci

Create a repo.

In it, implement the Fibonacci Sequence 2 times. Once, via loops and again via recursion. Do this in either a single .js file or a C# Console Application.

In your repo's readme, describe:

* The Fibonacci Sequence
a series of numbers where each number is the sum of the previous two numbers

* The difference in the loop and recursion model
Loop 
    - more efficient in terms of time and space complexity; since it's used for repetitive tasks, it's good for cycling through a large amount of data, which is helpful for when a program or app's performance is critical
    - only has to reserve the necessary memory once; simply updates values @ the same location in memory every iteration                                       

Recursion 
    - multi-dmensional; breaks down a problem into subproblems 
    - takes up more memory since it has to allocated for the problem and each of its subproblems
    - good for extensive computations               

* The Big O Notation for this algorithm and how you arrive at that conclusion
Time Complexity = T(33) ---> used this equation  T(n) = T(n-1) + T(n-2) 
Reference: <https://www.w3schools.com/dsa/dsa_algo_simple.php>
