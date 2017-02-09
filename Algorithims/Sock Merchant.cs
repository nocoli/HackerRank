using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);
        var listOfSocks = new List<int>();
        
        // how many pairs we can find in the pile
        int pairs = 0;
        
        // check each sock against each other sock, if a pair is found
        // set both socks in the pair to the value 0 (they will not be checked
        // further against other socks)
        for (int i = 0; i < n; i++) {
                        
            for (int j = i+1; j < n;j++) {
                
                if (c[i] == c[j] && c[i]!= 0) {
                    pairs = pairs + 1;
                    c[i] = 0;
                    c[j] = 0;
                }
                
            }
                        
        }
        
        // Display the number of pairs of socks found in the pile
        Console.WriteLine(pairs);
        
    }
}