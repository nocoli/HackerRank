using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(factorial(N));

    }
    
    // Recursive function
    static int factorial (int x) {
            // Base case
            if (x <= 1) {
                return 1;
            }
        
            // recurisve Case
            else {
                return x * factorial(x-1);
            }
        }
}