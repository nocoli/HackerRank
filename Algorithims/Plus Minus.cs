using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        float positive = 0;
        float negative = 0;
        float zeros = 0;
        
        //int arrLen = arr.Length();
        
        for (int i = 0; i < n; i++) {
            if (arr[i] > 0) {
                positive++;
            }
            else if (arr[i] < 0) {
                negative++;
            }
            else {
                zeros++;
            }
        }
        
        Console.WriteLine(positive/n);
        Console.WriteLine(negative/n);
        Console.WriteLine(zeros/n);
    }
}