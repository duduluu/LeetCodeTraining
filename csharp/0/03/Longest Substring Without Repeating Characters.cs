using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTraining.CSharp._0._03 {
    class Longest_Substring_Without_Repeating_Characters {
        public int LengthOfLongestSubstring(string s) {
            int length = s.Length;
            if (length == 0) {
                return 0;
            }
            if (length == 1) {
                return 1;
            }

            int result = 1;
            int curIndex = 0;
            int curChar;
            int preIndex;
            int start = 0;
            int curLength;

            int[] map = new int[256];
            while (curIndex < s.Length) {
                curChar = s[curIndex];
                preIndex = map[curChar];

                if (start < preIndex) {
                    start = preIndex;
                }

                curIndex++;
                map[curChar] = curIndex;
                curLength = curIndex - start;
                if (result < curLength) {
                    result = curLength;
                }
            }

            return result;
        }
    }
}
