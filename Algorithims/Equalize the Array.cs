using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */      
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, int.Parse);
        
        // the most occured
        int mostOccured = 0;
        
        // variable used to hold how many times an int has occured
        int timesOccured = 0;
        
        // temp int value holder
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
            
            // if new int has occured more times than the previous most occuring int
            // then set a new most occured
            if (timesOccured > mostOccured) {
                mostOccured = timesOccured;
            }
        }
        
        // print how many characters would need to be deleted to make all of the
        // ints in the array equal to the same value
        Console.WriteLine(a.Length - mostOccured);
    }
}