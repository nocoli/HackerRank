using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int solve(int n, int[] s, int d, int m){
        // Complete this function
        // n = length of the chocolate bar                                  1
        // s = array of the numbers on each piece in the chocolate bar      [4]
        // d = rons birth day (total of pieces)                             4
        // m = rons birth month (num of pieces)                             1
        
        // variable to hold the number of combinations
        int combinations = 0;
        
        // check every index in the chocolate bar up until the "Length of the bar MINUS # of chocolate pieces in a sequence PLUS 1
        for (int i = 0; i < n-m+1; i++) {
            
            int temp = 0;
            
            // From i (index in chocolate bar), calculate m pieces
            for (int j = 0; j < m;j++) {
                temp+= s[i+j];
            }
            
            // see if previous calculation = d (rons birth day / total of combination of pieces)
            if (temp == d) {
                combinations++;
            }
        }
        
        // return the answer
        return combinations;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        string[] tokens_d = Console.ReadLine().Split(' ');
        int d = Convert.ToInt32(tokens_d[0]);
        int m = Convert.ToInt32(tokens_d[1]);
        int result = solve(n, s, d, m);
        Console.WriteLine(result);
    }
}
