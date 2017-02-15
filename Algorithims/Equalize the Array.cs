using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */      
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, int.Parse);
        
        int[] mostOccured = new int[2];
        
        int timesOccured = 0;
        
        int tempInt;
        
        // find most occuring number + how many times it occurs
        for (int i = 0; i < a.Length; i ++) {
            tempInt = a[i];
            timesOccured = 0;
            
            for (int j = 0; j < a.Length; j++) {
                if (a[j] == a[i]) {
                    timesOccured++;
                }
            }
            
            if (timesOccured > mostOccured[1]) {
                mostOccured[0] = tempInt;
                mostOccured[1] = timesOccured;
            }
        }
        
        Console.WriteLine(a.Length - mostOccured[1]);
    }
}