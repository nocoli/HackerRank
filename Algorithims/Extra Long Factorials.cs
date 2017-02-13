using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;  // for big int
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        BigInteger answer = n;
        
        for (int i = 1; i < n; i++) {
            answer = answer * i;
        }
        
        Console.WriteLine(answer);
    }
}
