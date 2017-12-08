/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function ( nums, target ) {
  let map = {};
  for ( var i = 0; i < nums.length; i++ ) {
    let curNum = nums[i];
    if ( map[curNum] > -1 ) {
      return [i, map[curNum]];
    }
    map[target - curNum] = i;
  }
};