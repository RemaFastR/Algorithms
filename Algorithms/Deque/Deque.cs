using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms
{
    public class Deque<T> : IEnumerable<T>
    {
        // Голова
        DequeItem<T> head;
        // Хвост
        DequeItem<T> tail;
        // Количество элементов в списке
        int count;

        public void AddFirst(T data){
            DequeItem<T> item = new DequeItem<T>(data);
            DequeItem<T> temp = head;
            item.Next = temp;
            head = item;
            if (count == 0)
            {
                tail = head;
            }
            else
            {
                temp.Previous = item;
            }
            count++;
        }

        public void AddLast(T data){
            DequeItem<T> item = new DequeItem<T>(data); 

            if (head == null)
            {
                head = item;
            }
            else
            {
                tail.Next = item;
                item.Previous = tail;
            }
            tail = item;
            count++;
        }

        public T RemoveFirst(){
            if (count == 0)
            throw new InvalidOperationException();
            T output = head.Data;
            if(count==1)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
                head.Previous = null;
            }
            count--;
            return output;
        }

        public T RemoveLast()
        {
            if (count == 0)
                throw new InvalidOperationException();
            T output = tail.Data;
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.Previous;
                tail.Next = null;
            }
            count--;
            return output;
        }

        public DequeItem<T> GetHead(){
            return head;
        }

        public int GetCount(){
            return count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}