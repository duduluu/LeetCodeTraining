/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number}
 */
var findMedianSortedArrays = function (nums1, nums2) {
  let lengthCombine = nums1.length + nums2.length;
  let numsCombine = Array(lengthCombine);

  let index = 0;
  let i1 = 0;
  let i2 = 0;

  while (index < lengthCombine) {
    if (nums1[i1] === undefined) {
      numsCombine[index] = nums2[i2];
      i2++;
    } else if (nums2[i2] === undefined) {
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

  if (numsCombine.length % 2 === 0) {
    return (numsCombine[(lengthCombine >> 1) - 1] + numsCombine[lengthCombine >> 1]) / 2.0;
  } else {
    return numsCombine[lengthCombine >> 1];
  }
};