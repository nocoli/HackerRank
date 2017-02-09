using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);   // number of clouds
        int k = Convert.ToInt32(tokens_n[1]);   // jump distance
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse); // cloud values
        
        int energy = 100; // initial energy
        int cloud = 0; // starting cloud
        
        // complete all jumps
        for (int i = 0; i < n; i+=k) {
            
            // jump by cloud distance
            cloud = cloud + k;
            // evvery jump deduct 1 energy
            energy = energy - 1;
            
            
            // first cloud = 0 = last cloud
            if (cloud == n) {
                cloud = 0;
            }
            // if landed on thunder cloud deduct 2 energy
            if (c[cloud] == 1) {
                energy = energy - 2;
            }
        }
        // print the remaining energy
        Console.WriteLine(energy);
    }
}
