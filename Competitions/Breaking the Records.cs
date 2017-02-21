using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] score_temp = Console.ReadLine().Split(' ');
        int[] score = Array.ConvertAll(score_temp,Int32.Parse);
        // your code goes here
        
        int highestScore = score[0];
        int lowestScore = score[0];
        
        int highestScoreBroken = 0;
        int lowestScoreBroken = 0;
        
        for (int i = 1; i < n;i++) {
            // check if games score is higher than highest record
            if (score[i] > highestScore) {
                highestScore = score[i];
                highestScoreBroken++;
            }
            
            // check if games score is lower than lowest record
            if (score[i] < lowestScore) {
                lowestScore = score[i];
                lowestScoreBroken++;
            }
        }
        
        Console.WriteLine(highestScoreBroken + " " + lowestScoreBroken);
    }
}
