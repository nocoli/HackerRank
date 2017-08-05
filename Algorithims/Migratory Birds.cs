using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int migratoryBirds(int n, int[] ar) {
        // Complete this function
        int[] typeCount = new int[] {0,0,0,0,0};
        foreach (int bird in ar) {
            typeCount[bird-1]++;
        }

        // check the highest int and how often it occurs
        int highestCount = 0;
        foreach (int id in typeCount) {
            if (highestCount < id) {
                highestCount = id;
            }

        }

        // loop through array, return first bird ID that matches the highest type count
        bool birdTypeFound = false;
        int birdID = 99;
        int j = 0;
        while (!birdTypeFound) {
            if (typeCount[j] == highestCount) {
                birdID = j+1;
                birdTypeFound = true;
            }
            j++;
        }
        return birdID;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = migratoryBirds(n, ar);
        Console.WriteLine(result);
    }
}
