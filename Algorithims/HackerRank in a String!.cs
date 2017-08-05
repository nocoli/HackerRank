using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            // your code goes here
            char[] hackerrank = {'h', 'a', 'c', 'k', 'e', 'r', 'r', 'a', 'n', 'k'};
            
            int hackerIndex = 0;
            bool stop = false;
            
            while (!stop) {
                for (int i = 0; i < s.Length; i++) {
                    if (hackerIndex == 10) {
                        stop = true;
                    }
                    else {
                        if (s[i] == hackerrank[hackerIndex]) {
                            hackerIndex++;
                        }
                    }
                    if (i == s.Length-1) {
                        stop = true;
                    }
                }
            }
            
            if (hackerIndex == 10) {
                Console.WriteLine("YES");
            } 
            else {
                Console.WriteLine("NO");
            }
        }
    }
}
