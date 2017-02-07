using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        int sum = 0;
        int max = 0;

        // While n is greater than 0
        while (n > 0)
        {
            // If there is a remainder of 1 after dividing by 2
            if (n % 2 == 1)
            {
                sum++;

                if (sum > max)
                    max = sum;
            }
            else sum = 0;

            n = n / 2;
        }

        Console.WriteLine(max);
    }
}