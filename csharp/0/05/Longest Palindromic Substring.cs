using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTraining.CSharp._0._05 {
    class Longest_Palindromic_Substring {
        public string LongestPalindrome(string s) {
            if (s.Length < 2) {
                return s;
            }

            int start = 0;
            int maxlength = 1;
            
            int seedLeft = (s.Length - 1) / 2;
            int seedRight = s.Length / 2;

            int i = seedLeft;
            int j = seedRight;

            int il, jl, ml, nl, sl,
                ir, jr, mr, nr, sr,
                curLength;

            while (i > -1 && j < s.Length) {
                if (s[i] == s[j]) {
                    i--;
                    j++;
                } else {
                    break;
                }
            }
            start = i + 1;
            maxlength = j - start;
            
            if (seedLeft == seedRight) {
                ml = seedLeft - 1;
                nl = seedLeft;
                mr = seedRight;
                nr = seedRight + 1;
            } else {
                ml = seedLeft;
                nl = seedLeft;
                mr = seedRight;
                nr = seedRight;
            }

            while (ml > -1 && nr < s.Length) {
                if ((ml + nl + 1) <= maxlength) break;

                il = ml;
                jl = nl;
                ir = mr;
                jr = nr;
                
                while (il > -1 && il < s.Length && jl > -1 && jl < s.Length) {
                    if (s[il] == s[jl]) {
                        il--;
                        jl++;
                    } else {
                        break;
                    }
                }
                while (ir > -1 && ir < s.Length && jr > -1 && jr < s.Length) {
                    if (s[ir] == s[jr]) {
                        ir--;
                        jr++;
                    } else {
                        break;
                    }
                }
                sl = il + 1;
                curLength = jl - sl;
                if (maxlength < curLength) {
                    maxlength = curLength;
                    start = sl;
                }
                sr = ir + 1;
                curLength = jr - sr;
                if (maxlength < curLength) {
                    maxlength = curLength;
                    start = sr;
                }

                if (ml == nl) {
                    ml--;
                    nr++;
                } else {
                    nl--;
                    mr++;
                }
            }
            
            return s.Substring(start, maxlength);
        }
    }
}
