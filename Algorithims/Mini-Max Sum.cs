using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] arr_temp = Console.ReadLine().Split(' ');
        Int64[] arr = Array.ConvertAll(arr_temp,Int64.Parse);
        
        Int64 highest = arr[0];
        Int64 lowest = arr[0];
        
        for (int i = 0; i < arr.Length; i ++) {
            if (arr[i] > highest) {
                highest = arr[i];
            }
            if (arr[i] < lowest) {
                lowest = arr[i];
            }
        }
        
        Int64 highestSum = arr.Sum() - lowest;
        Int64 lowestSum = arr.Sum() - highest;
        
        Console.WriteLine(lowestSum + " " + highestSum);
        
        
    }
}