using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        
        int charsChanged = 0;
        
        for (int i = 0; i < s.Length-2; i+=3) {
            if (s[i] != 'S') {
                charsChanged++;
            }
            if (s[i+1] != 'O') {
               charsChanged++; 
            }
            if (s[i+2] != 'S') {
                charsChanged++;
            }
        }
        
        Console.WriteLine(charsChanged);
    }
}
