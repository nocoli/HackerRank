using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        
        
        // while there are still sticks to be cut
        while (arr.Max() > 0) {
        
            // how many sticks are being cut
            int sticksCut = 0;

            // find the smallest stick
            int cutLength = arr.Max();
            for (int j = 0; j < arr.Length; j++) {
                if (arr[j] < cutLength && arr[j] > 0) {
                    cutLength = arr[j];
                }
            }

            // make cut
            for (int i = 0; i < arr.Length;i++) {
                if (arr[i] > 0) {
                    arr[i] = arr[i] - cutLength;
                    sticksCut++;
                    if (arr[i] < 0) {
                        arr[i] = 0;
                    }
                } 
            }

            // print how many sticks were cut
            Console.WriteLine(sticksCut);
        
        }
    }
}
