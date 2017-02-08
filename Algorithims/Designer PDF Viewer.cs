using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] h_temp = Console.ReadLine().Split(' ');
        int[] h = Array.ConvertAll(h_temp,Int32.Parse);
        string word = Console.ReadLine();
        
        int highestLetter = 0;
        
        int tempDigit;
        
        for (int i = 0; i < word.Length; i++) {
            
            tempDigit = charToDigit(word[i]);
            
            if (h[tempDigit-1] > highestLetter) {
                highestLetter = h[tempDigit-1];
            }      
        }
        
        Console.WriteLine(highestLetter * 1 * (word.Length));
             
    }
    
    static int charToDigit(char character){
    return character-96;
}
}
