using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTraining.CSharp._0._01 {
    class Two_Sum {
        public int[] TwoSum(int[] nums, int target) {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++) {
                var curNum = nums[i];
                if (map.TryGetValue(curNum, out int matchIndex)) {
                    return new int[] { i, matchIndex };
                }
                if (map.ContainsKey(target - curNum)) {
                    continue;
                }
                map.Add(target - curNum, i);
            }
            return new int[] { 0, 0 };
        }
    }
}
