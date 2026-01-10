using CustomDoublyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList
{
    public class CustomDoublyLinkedList<T>
    {
        private ListNode<T> head;
        private ListNode<T> tail;
        private int count;

        public int Count => count;

        public void AddFirst(T element)
        {
            var newNode = new ListNode<T>(element);
            if (count == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }
            count++;
        }

        public void AddLast(T element)
        {
            var newNode = new ListNode<T>(element);
            if (count == 0)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Previous = tail;
                tail.Next = newNode;
                tail = newNode;
            }
            count++;
        }

        public T RemoveFirst()
        {
            if (count == 0) throw new InvalidOperationException("The list is empty.");
            T value = head.Value;
            head = head.Next;
            if (head != null) head.Previous = null;
            else tail = null; // List became empty
            count--;
            return value;
        }

        public T RemoveLast()
        {
            if (count == 0) throw new InvalidOperationException("The list is empty.");
            T value = tail.Value;
            tail = tail.Previous;
            if (tail != null) tail.Next = null;
            else head = null; // List became empty
            count--;
            return value;
        }

        public void ForEach(Action<T> action)
        {
            var currentNode = head;
            while (currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }

        public T[] ToArray()
        {
            T[] array = new T[count];
            var currentNode = head;
            for (int i = 0; i < count; i++)
            {
                array[i] = currentNode.Value;
                currentNode = currentNode.Next;
            }
            return array;
        }
    }
}