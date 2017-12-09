/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function (s) {
  let length = s.length;
  if (length === 0) {
    return 0;
  }
  if (length === 1) {
    return 1;
  }

  let result = 1;
  let curIndex = 0;
  let curChar = 0;
  let preIndex = 0;
  let start = 0;
  let curLength = 0;

  let map = Array(256);
  while (curIndex < s.length) {
    curChar = s[curIndex].charCodeAt(0);
    preIndex = map[curChar] || 0;

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
};