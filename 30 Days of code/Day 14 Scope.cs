using System;
using System.Linq;

class Difference {
    private int[] elements;
    public int maximumDifference;
	
	// SOLTUON START //
    public Difference(int[] array)
    {
        elements = array;
    }

    public void computeDifference()
    {
        maximumDifference = Math.Abs(elements.Max() - elements.Min());
    }
	// SOLTUON END //
	} // End of Difference Class

class Solution {
    static void Main(string[] args) {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}