using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static int combinationInteger(int i, int i2)
    {
        int intgr = i + i2;
        return intgr;
    }
    
    static double combinationDouble(double d, double d2)
    {
        double dbl = d + d2;
        return dbl;
    }
    
    static string combinationString(string s, string s2)
    {
        string strng = s + s2;
        return strng;
    }
    
    static void Main(String[] args) {
        int i = 12;
        double d = 4.0;
        string s = "HackerRank ";
        
        int i2 = 4;
        double d2 = 4.0;
        string s2 =("is the best place to learn and practice coding!");
        
        int resultInteger = combinationInteger(i,i2);
        Console.WriteLine(resultInteger);
        
        double resultDouble = combinationDouble(d, d2);
        Console.WriteLine(resultDouble);
        
        string resultString = combinationString(s, s2);
        Console.WriteLine(resultString);
        
    }
}