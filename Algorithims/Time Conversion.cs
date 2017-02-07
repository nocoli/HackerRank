using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string time = Console.ReadLine();
        
        if (time == "12:00:00AM") {
            Console.WriteLine("00:00:00");
        }
        else if (time == "12:00:00PM") {
            Console.WriteLine("12:00:00");
        }
        else {
        
        string hour;
        string minute;
        string second;
            
        string zerozero = "00";
        
        string[] sections = time.Split(':');
        hour = sections[0];
        minute = sections[1];
        second = sections[2];
        
        int x = Int32.Parse(hour);
        
        if (second.Contains("P") && hour!= "12") {
            
            x = x+12;
        }
            
        if (x==24) {
            Console.WriteLine(zerozero + ":" + minute + ":" + second.Substring(0,2));
        }
        else if (hour=="12" && second.Contains("A")) {
            Console.WriteLine(zerozero + ":" + minute + ":" + second.Substring(0,2));
        }
        
        else {

            if (x < 10) {
                Console.WriteLine("0"+x+":"+minute+":"+second.Substring(0,2));
            }
            else {
            
                string y = x.ToString();             
                
        Console.WriteLine(y + ":" + minute + ":" + second.Substring(0,2));
            }
            }
        }
    }
}
