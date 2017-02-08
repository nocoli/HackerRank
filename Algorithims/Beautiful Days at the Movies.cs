using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] tokens_s = Console.ReadLine().Split(' ');
        int i = Convert.ToInt32(tokens_s[0]);
        int j = Convert.ToInt32(tokens_s[1]);
        int k = Convert.ToInt32(tokens_s[2]);
        
        int beautifulDays = 0;
        int iReverse;
        
        for (int x = i; x <= j; x++) {
            
            iReverse = reversed(x);
            
            if ((Math.Abs(x - iReverse)) % k == 0) {
            
                beautifulDays++;
            }
            
        }
        
        Console.WriteLine(beautifulDays);
    }
    
    
    // reverses number
        static int reversed(int num) {
            int num2 = 0;
            while (num > 0)
            {
                int d= num % 10;
                num2 = num2 * 10 + d;
                num /= 10;
            }
            return num2;
        }
}