using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 0; i < t; i++) {
        string[] tokens = Console.ReadLine().Split(' ');
        long start = Convert.ToInt64(tokens[0]);
        long finish = Convert.ToInt64(tokens[1]);
            
        long sqrCount = 0;
            
            
        double sqrStart = Math.Sqrt(start);
        double sqrFinish = Math.Sqrt(finish);
        
        var sqrStartFloored = Math.Floor(sqrStart);
        var sqrFinishFloored = Math.Floor(sqrFinish);
            
        for (double x = sqrStartFloored; x <= sqrFinishFloored; x++) {
            
            double temp = x*x;
            
            if (temp >= start && temp <= finish) {
                sqrCount++;
            }
        }
        Console.WriteLine(sqrCount);
        }
        
    }
}