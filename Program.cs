using System;
/*
 * Solution by: Yarin Bekhor
 * Problem: LeetCode 21 - Merge Two Sorted Lists
 * Strategy: Iterative merge using pointers without creating new nodes.
 *            Handles duplicates and merges lists in O(n + m) time.
 * Complexity: 
 *    Time - O(n + m), where n and m are the lengths of the input lists.
 *    Space - O(1) extra space (in-place using pointers, aside from a dummy head node).
 */


namespace Minimum_Size_Subarray_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public Node<int>MergeTwoSortedLists(Node<int> list1, Node<int> list2)
        {

            Node<int> temp1 = list1;
            Node<int> temp2 = list2;
            Node<int> mergelist = new Node<int>(0);
            Node<int> mergelist2 = mergelist;
            if (temp1 == null && temp2 == null)
                return null;
            if (temp1 == null && temp2 != null)
            {
                mergelist = temp2;
                return mergelist;
            }
            if (temp2 == null && temp1 != null)
            {
                mergelist = temp1;
                return mergelist;
            }

            while (temp1!=null && /*||*/temp2!=null)
            {

                if (temp1.GetValue() < temp2.GetValue())
                {
                    mergelist.SetNext(temp1);
                    mergelist = mergelist.GetNext();
                    temp1 = temp1.GetNext();
                }
                else if(temp2.GetValue() < temp1.GetValue())
                {
                    mergelist.SetNext(temp2);
                    mergelist = mergelist.GetNext();
                    temp2 = temp2.GetNext();
                }
                else if (temp1.GetValue() == temp2.GetValue())
                {
                    mergelist.SetNext(temp2);
                    mergelist = mergelist.GetNext();
                    mergelist.SetNext(temp1);
                    mergelist = mergelist.GetNext();

                    temp1 = temp1.GetNext();
                    temp2 = temp2.GetNext();
                }
            }
            if(temp1!=null && temp2==null)
            {
                    mergelist.SetNext(temp1);
            }
            if (temp2 != null && temp1 == null)
            {
                mergelist.SetNext(temp2);
            }

            return mergelist2.GetNext(); ;
        }



    }
    public class Node<T>
    {
        private T value;
        private Node<T> next;
        //-----------------------------------
        //constructors
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }
        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }
        //-----------------------------------
        //getters
        public T GetValue()
        {
            return this.value;
        }
        public Node<T> GetNext()
        {
            return this.next;
        }
        //-----------------------------------
        //setters
        public void SetValue(T value)
        {
            this.value = value;
        }
        public void SetNext(Node<T> next)
        {
            this.next = next;
        }
        public bool HasNext()
        {
            return (this.next != null);
        }
        //-----------------------------------
        //ToString
        public override string ToString()
        {
            return value + " --> " + next;
        }
    }
}
