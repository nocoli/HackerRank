using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] A_temp = Console.ReadLine().Split(' ');
        int[] A = Array.ConvertAll(A_temp,Int32.Parse);
        
        int minDistance = 1001;
        
        // loop through array
        for (int i = 0; i < A.Length; i++) {
            // check each element further along in the array
            // after A[i]
            for (int j = i+1; j < A.Length; j++) {
                // if the two elements match
                if (A[i] == A[j]) {
                    // if minDistance between a previous pair is greater
                    if (minDistance > j - i) {
                        // set new minDistance
                        minDistance = j - i;
                    }
                }
            }
        }
        
        // if minDistance still orignial value
        // (no matching pairs found in array)
        if (minDistance == 1001) {
            minDistance = -1;
        }
        
        // print out result
        Console.WriteLine(minDistance);
    }
}
