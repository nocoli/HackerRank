using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp,Int32.Parse);
            
            // students on time variable
            int studentsOnTime = 0;
            
            // check the how many kids arrived to class on time
            foreach (int value in a)
            {
                if (value <= 0) {
                    studentsOnTime++;
                }    
            }
            
            // if enough kids arrived on time print "YES"
            if (studentsOnTime < k)
            {
                Console.WriteLine("YES");
            }
            // if not enough kids arrvied on time print "NO"
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
