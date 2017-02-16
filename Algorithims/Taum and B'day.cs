using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_b = Console.ReadLine().Split(' ');
            long b = Convert.ToInt64(tokens_b[0]); // number of black gifts needed
            long w = Convert.ToInt64(tokens_b[1]); // number of white gifts needed
            string[] tokens_x = Console.ReadLine().Split(' ');
            long x = Convert.ToInt64(tokens_x[0]); // cost of black gifts
            long y = Convert.ToInt64(tokens_x[1]); // cost of white gifts
            long z = Convert.ToInt64(tokens_x[2]); // cost of converting gifts
            
            long cost = 0; // cost
            
            // if buying + converting black to white is cheaper than buying white
            if (x + z < y) {
                cost = cost + ((x + z) * w);
            }
            // buy white outright
            else {
                cost = cost + (w * y);
            }
            
            // if buying + converting white to black is cheaper than buying black
            if (y + z < x) {
                cost = cost + ((y + z) * b);
            }
            // buy black outright
            else {
                cost = cost + (b * x);
            }
            
            // print the min cost
            Console.WriteLine(cost);
            
            
        }
    }
}
