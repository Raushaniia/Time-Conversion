using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string timeConversion(string s) {
        // Complete this function
        int hours = Convert.ToInt32(s.Substring(0,2));
        int minutes = Convert.ToInt32(s.Substring(3,2));
        int seconds = Convert.ToInt32(s.Substring(6,2));
        string mer = s.Substring(8,2);
        if( mer == "PM" && hours != 12){
            hours = hours + 12;
        }
        else if(mer == "AM" && hours == 12){
            hours = 0;
        }
        else;
        string result = string.Format("{0:00}", hours) + ":" + string.Format("{0:00}", minutes) + ":" + string.Format("{0:00}",              seconds);
        return result;
     }
    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
