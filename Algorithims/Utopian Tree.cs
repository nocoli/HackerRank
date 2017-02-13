using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        int heightOfTree = 0;
        
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            
			// if no cycles, tree remains at 1 height
            if (n == 0) {
                heightOfTree = 1;
            }
            
			// if there are cycles 
            else {
				// start the height of the tree at 1
                heightOfTree = 1;
				
				// loop through each cycle
            for (int i = 1; i <= n; i++) {
                
				// if its the first cycle, it doubles in size
                if (i == 1) {
                    heightOfTree = (heightOfTree *2);
                }
				//if its a summer cycle, the tree grows by 1
                else if (i % 2 == 0) {
                    heightOfTree = (heightOfTree+1);
                }
				// if its spring, the tree doubles in height
                else if (i % 2 == 1) {
                    heightOfTree = (heightOfTree*2);
                }
    
            }
            }
			// print out height of tree after n cycles
            Console.WriteLine(heightOfTree);
        }
        
    }
}
