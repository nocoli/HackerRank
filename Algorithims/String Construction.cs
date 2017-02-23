using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < n; a0++){
            string s = Console.ReadLine();
            
            int cost = 0;
            // list of chars already purchased
            var list = new List<string>();
            
            // for each char in string
            for (int i = 0; i < s.Length; i++) {
                // if string contains char not yet purchased
                if (!list.Contains(Convert.ToString(s[i])))
                {
                    // add $1 to the total cost
                    cost++;
                    // add char to list of purchased chars
                    list.Add(Convert.ToString(s[i]));
                }
            }
            
            // print out the total cost
            Console.WriteLine(cost);
        }
    }
}
