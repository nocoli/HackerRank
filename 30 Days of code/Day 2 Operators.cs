using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        double mealCost = double.Parse(Console.ReadLine());
        int tipPercent = Int32.Parse(Console.ReadLine());
        int taxPercent = Int32.Parse(Console.ReadLine());   
        
        double tip = (mealCost * (tipPercent/100.00));
        double tax = (mealCost * (taxPercent/100.00));       
        
        double totalCost = mealCost + tip + tax;
        
        Console.WriteLine("The total meal cost is " + Math.Round(totalCost) + " dollars.");
    }
}