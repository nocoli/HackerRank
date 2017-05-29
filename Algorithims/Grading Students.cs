using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] solve(int[] grades){
        // Complete this function
        int[] temp_arr = new int[grades.Length];
        for (int x = 0; x <= grades.Length-1; x++) {
            if (grades[x] < 38) {
                temp_arr[x] = grades[x];
            }
            else {
                if (grades[x] % 5 == 3) {
                    temp_arr[x] = grades[x] + 2;
                } else if (grades[x] % 5 == 4) {
                    temp_arr[x] = grades[x] + 1;
                } else {
                    temp_arr[x] = grades[x];
                }
            }
        }
        
        return temp_arr;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for(int grades_i = 0; grades_i < n; grades_i++){
           grades[grades_i] = Convert.ToInt32(Console.ReadLine());   
        }

        int[] result = solve(grades);

        Console.WriteLine(String.Join("\n", result));
        

    }
}