using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeTraining.CSharp._0._04 {
    class Median_of_Two_Sorted_Arrays {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            int[] numsCombine = new int[nums1.Length + nums2.Length];
            
            int index = 0;
            int i1 = 0;
            int i2 = 0;
            
            while (index < numsCombine.Length) {
                if (nums1.Length == i1) {
                    numsCombine[index] = nums2[i2];
                    i2++;
                } else if (nums2.Length == i2) {
                    numsCombine[index] = nums1[i1];
                    i1++;
                } else if (nums1[i1] < nums2[i2]) {
                    numsCombine[index] = nums1[i1];
                    i1++;
                } else {
                    numsCombine[index] = nums2[i2];
                    i2++;
                }
                index++;
            }

            if (numsCombine.Length % 2 == 0) {
                return (numsCombine[numsCombine.Length / 2 - 1] + numsCombine[numsCombine.Length / 2]) / 2.0;
            } else {
                return numsCombine[numsCombine.Length / 2];
            }
        }
    }
}
