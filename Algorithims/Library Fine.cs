using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_d1 = Console.ReadLine().Split(' ');
        int d1 = Convert.ToInt32(tokens_d1[0]);
        int m1 = Convert.ToInt32(tokens_d1[1]);
        int y1 = Convert.ToInt32(tokens_d1[2]);
        string[] tokens_d2 = Console.ReadLine().Split(' ');
        int d2 = Convert.ToInt32(tokens_d2[0]);
        int m2 = Convert.ToInt32(tokens_d2[1]);
        int y2 = Convert.ToInt32(tokens_d2[2]);
        
        int fine = 0;
        
        DateTime returnedDay = new DateTime(y1, m1, d1);
        DateTime expectedReturnDay = new DateTime(y2, m2, d2);
        
        if (returnedDay.Date <= expectedReturnDay.Date) {
            // do nothing because fine will remain 0
        }
        // if returned after calender year
        else if (y1 > y2) {
            fine = 10000;
        }
        // if returned within same year but months late
        else if (m1 > m2) {
            fine = (m1 - m2) * 500;
        }
        // if only returned days late (in same month)
        else {
            fine = (d1 - d2) * 15;
        }
        
        // print fine amount
        Console.WriteLine(fine);
    }
}
