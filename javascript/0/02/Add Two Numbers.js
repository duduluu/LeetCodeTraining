class ListNode {
  val;
  next;
  constructor(val) {
    this.val = val;
  }
}

/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
function addTwoNumbers(l1, l2) {
  let result = new ListNode(0);
  let curNode = result;
  let prevNode = curNode;
  let curSum = 0;

  do {
    curSum = curNode.val;
    if (l1) {
      curSum += l1.val;
      l1 = l1.next;
    }
    if (l2) {
      curSum += l2.val;
      l2 = l2.next;
    }
    curNode.val = curSum % 10;
    curNode.next = new ListNode(parseInt(curSum / 10));
    prevNode = curNode;
    curNode = curNode.next;
  } while (l1 || l2);

  if (curNode.val === 0) {
    prevNode.next = null;
  }

  return result;
};