using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < t; i++) {
            string[] tokens = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens[0]); // number of prisoners
            int m = Convert.ToInt32(tokens[1]); // number of sweets
            int s = Convert.ToInt32(tokens[2]); // pris start id
            
            int poisioned = poisonedPris(n,m,s);
            Console.WriteLine(poisioned);    
        }
 
    }
    
    static int poisonedPris(int noP, int noS, int sPos) {
        return ((sPos + noS - 2) % noP + 1);
    }
}