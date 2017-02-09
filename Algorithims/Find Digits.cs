using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            
            // SOLUTION START //
            int even = 0; //initialise counter for number that evenly divide
            string temp = n.ToString();
            int intLength = temp.Length;

            // iterate through every character of the int
            for (int i = 0; i < intLength; i++) {
                // converting char to int
                int b = Convert.ToInt32(temp[i]);
                // converting int back to proper value
                b = b - 48;
                
                // make sure not diving by 0 (would cause error)
                if (b != 0) {
                    // if evenly divides
                    if (n % b == 0) {
                        even = even+1;
                    }    
                }  
            }          
            Console.WriteLine(even);
        }
    }
}