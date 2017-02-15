using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        long n = Convert.ToInt64(Console.ReadLine());
        
        long count = 0;
        
		// if the string has only 1 character and it is 'a'
        if (s.Length == 1 && s[0] == 'a') {
            Console.WriteLine(n);
        }
        else {

            // if number longer than length do this (otherwise don't)
            if (n > s.Length) {
            double temp2 = n / s.Length;
                
                temp2 = Math.Floor(temp2);
            
            long tempR = Convert.ToInt64(temp2);
            
            for (int i = 0; i < s.Length; i++) {
                if (s[i] == 'a') {
                    count++;
                }
            }
            
            count = Convert.ToInt64(tempR) * count;
            
            // calculate remainder
            long temp3 = n % s.Length;
            
            for (int j = 0;j < temp3; j++) {
                if (s[j] == 'a') {
                    count++;
                }
            }
            
            // if number is less than the length of the string
            }
            else  {
                for (int b = 0; b < s.Length-1; b++) {
                    if (s[b] == 'a') {
                        count++;
                    }
                }
            }
			
			// print out the count
			Console.WriteLine(count);
        }
    }
}
