# Merge Two Sorted Lists - LeetCode 21

**Solution by:** Yarin Bekhor  

## Problem Description
Given two sorted linked lists `list1` and `list2`, merge them into a single sorted linked list.  
The merged list should be made by splicing together the nodes of the first two lists.  

**Example:**
Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
Example 2:

Input: list1 = [], list2 = []
Output: []
Example 3:

Input: list1 = [], list2 = [0]
Output: [0]

## Strategy
- Use an **iterative merge approach** with a dummy head node.
- Compare nodes from both lists one by one and attach the smaller node to the merged list.
- Handle duplicates by including each node separately.
- After one list is exhausted, attach the remaining nodes from the other list.
- Avoid creating new nodes except for the dummy head, keeping the merge **in-place**.

## Complexity Analysis
- **Time Complexity:** O(n + m)  
  Where `n` and `m` are the lengths of `list1` and `list2`. Every node is visited exactly once.  
- **Space Complexity:** O(1) extra space  
  Only a dummy node is used; the merge uses existing nodes without additional memory.
