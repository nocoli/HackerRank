using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        
		// If is odd
        if (IsOdd(N)) {
            Console.WriteLine("Weird");
        }
		// Else if between but != to 1 and 6
        else if (N > 1 && N < 6) {
            Console.WriteLine("Not Weird");
        }
		// Else if N between but != 5 and 21
        else if (N > 5 && N < 21) {
            Console.WriteLine("Weird");
        }
		// Else if greater than 20
        else if (N > 20) {
            Console.WriteLine("Not Weird");
        }
            
    }
    
	// Return true if value is odd
    public static bool IsOdd(int value)
    {
        return value % 2 != 0;
    }
}