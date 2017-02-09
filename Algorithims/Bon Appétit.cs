using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);
        int b = Convert.ToInt32(Console.ReadLine());
        
        // total cost of meal
        int totalCost = 0;
        
        for (int i = 0; i<n;i++) {
            totalCost = totalCost +c[i];
        }
        
        // deduct the k'th item
        int annasCost = (totalCost - c[k])/2;
        
        // if Brian charged Anna correctly
        if (annasCost == b) {
            Console.WriteLine("Bon Appetit");
        }
        // If Anna was not charged correctly
        else {
            Console.WriteLine(b - annasCost);
        }
    }
}