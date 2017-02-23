using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        int like = 0;
        int share = 5;
        int sum = 0;
              
        for (int i = 1; i <= n; i++) {
            // how many people like in on i'th day
            like = (int)Math.Floor(share/2.0);
            // it then gets shared to the amount of people who like it * 3
            share = like*3;
            // number of people who like it on i'th day added to total
            sum+= like;
        }
        
        // print out answer
        Console.WriteLine(sum);
    }
}