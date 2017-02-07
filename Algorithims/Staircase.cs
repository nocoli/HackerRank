using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        int k = n;
        int stairs = 1;
        
        for (int i = 0; i < n; i++) {
            for (int j = 0; j <k-1; j++) {
                Console.Write(" ");
            }
            for (int x = 0; x<stairs; x++) {
                Console.Write("#");
            }
            Console.WriteLine();
            k-=1;
            stairs+=1;
        }
    }
}
