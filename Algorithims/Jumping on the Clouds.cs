using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);
        
        int jumps = 0;
        int pos = 0;
        
        // while position is less than the final cloud
        while (pos < (n-1)) {
               
            // if single jump reaches the end cloud
            if (pos+1 == n-1) {
                jumps++;
                pos++;
            } 
            // if double jump reaches the end cloud
            else if (pos+2 == n-1) {
                jumps++;
                pos = pos+2;
            } 
            // if double jump lands on thunder cloud
            else if (c[pos+2] == 1) {
                // do single jump
                jumps++;
                pos = pos + 1;
                // do double jump
                jumps++;
                pos = pos + 2;
            }
            // if safe to double jump than do so
            else {
                jumps++;
                pos = pos + 2;
            }
        }
        
        Console.WriteLine(jumps);
    }
}