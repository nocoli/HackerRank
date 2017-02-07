using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int[][] arr = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
        
        // initialise highest value variable
        int highestValue = -99;
        
        // intialise temporary glass value
        int tempGlassVal = 0;
        
        // starting number
        int length = 0;
        int height = 0;
        
        // calculate 16 hour glasses
        for (int i = 0; i < 16; i++) {
            // reset temp value to 0
			tempGlassVal = 0;
            
			// add all of the values from the hour glass
            tempGlassVal = tempGlassVal + 
			arr[height][length] + 
			arr[height][length+1] + 
			arr[height][length+2] + 
			arr[height+1][length+1] + 
			arr[height+2][length] + 
			arr[height+2][length+1] + 
			arr[height+2][length+2];     
            
			// if the value from the hour glass is higher
			// than the previous then store it to highest variable
            if (tempGlassVal > highestValue) {
                highestValue = tempGlassVal;
            }
            
            // change the starting point of each iteration
			// to the next hour glass
            length = length+1;
            if (length > 3) {
                length = 0;
                height = height +1;
            }
        }
        
        Console.WriteLine(highestValue);
        
    }
}
