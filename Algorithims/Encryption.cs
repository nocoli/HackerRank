using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        
        int l = s.Length;
        
        // find how many rows and columns
        int rows = Convert.ToInt32(Math.Floor(Math.Sqrt(l)));
        int columns = Convert.ToInt32(Math.Ceiling(Math.Sqrt(l)));
               
        // check to make sure there will be enough space in the 2d array
        // if not, add an extra row
        if (l > rows * columns) {
            rows++;
        }
        
        // initialize the 2d array
        char[,] array2Da = new char[rows, columns];
        
        int counter = 0;
        
        // assign every index of the original string to a position
        // in the array
        while (counter < l) {
            
         for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                // add blank character if over string size
                if (counter >= l) {
                    array2Da[i, j] = ' ';
                }
                else {
                array2Da[i, j] = s[counter];
                counter = counter + 1;
                }
                }
            }
        }
               
        // print the 2d array via columns with spaces inbetween
        // each of the columns
        for (int a = 0; a < columns; a++)
        {
            for (int b = 0; b < rows; b++)
            {
                if (array2Da[b, a] == ' ') {
                    
                }
                else {
                Console.Write(array2Da[b, a]);
                }
            }
            Console.Write(' ');
        }
        
    }
}
