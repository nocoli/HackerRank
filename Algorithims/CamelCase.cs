using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        
        int wordCount = 0;
        
        for (int i = 0; i < s.Length; i++) {
            if (char.IsUpper(s[i])) {
                wordCount++;
            }
        }
        
        Console.WriteLine(wordCount+1);
    }
}
