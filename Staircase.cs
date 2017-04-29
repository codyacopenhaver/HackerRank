//https://www.hackerrank.com/challenges/staircase
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int s = n;
        int h = 0;
        for(int i = 0; i < n; i++){
            --s;
            ++h;
            Console.Write(new StringBuilder().Insert(0, " ", s).ToString());
            Console.WriteLine(new StringBuilder().Insert(0, "#", h).ToString());
        }
        
    }
}
