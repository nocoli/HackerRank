using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int tempResult;
        
        for (int i = 1; i <11;i++) {
            tempResult = n*i;
            Console.WriteLine(n + " x " + i + " = " + tempResult);
        }
    }
}