using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_a0[0]);  // elements in array
        int d = Convert.ToInt32(tokens_a0[1]);  // beautiful difference
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);    // number set
        
        int beautiful = 0;  // how many sequences are beautiful
        
        // loop through array
        for (int i = 0; i < n-2; i++) {     
            int pos = Array.IndexOf(a, a[i] + d);
            int pos2 = Array.IndexOf(a, a[i] + d + d);
            if (pos > -1 && pos2 > -1)
            {
               beautiful++;
            }
            
        }
        
        Console.WriteLine(beautiful);
    }
}