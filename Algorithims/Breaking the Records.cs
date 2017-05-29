using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] getRecord(int[] s){
        // Complete this function
        int highest = s[0];
        int lowest = s[0];
        
        int highestPBs = 0;
        int lowestPBs = 0;
        
        for (int i = 0; i < s.Length; i++) {
            if (s[i] > highest) {
                highestPBs++;
                highest = s[i];
            } else if (s[i] < lowest) {
                lowestPBs++;
                lowest = s[i];
            }
        }
        
         int[] answer = {highestPBs, lowestPBs};
            
            return answer;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        int[] result = getRecord(s);
        Console.WriteLine(String.Join(" ", result));
    }
}