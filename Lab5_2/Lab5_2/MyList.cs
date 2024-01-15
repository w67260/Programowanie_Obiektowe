using System;

namespace Lab5_2
{
    public partial class MyList<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node Next;
        }

        private Node first = null;
        private Node last = null;

        public void Add(T element)
        {
            if (first == null)
                first = last = new Node() { Value = element };
            else
                last = last.Next = new Node() { Value = element };
        }

        private Node Get(int i)
        {
            var e = first;
            while (i-- > 0 && e != null)
                e = e.Next;
            if(e == null)
                throw new IndexOutOfRangeException();
            return e;
        }

        public T this[int i] { get => Get(i).Value; set => Get(i).Value = value; }

        public int Count
        {
            get
            {
                int count = 0;
                var current = first;
                while (current != null)
                {
                    count++;
                    current = current.Next;
                }
                return count;
            }
        }

        public void Remove(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                first = first.Next;
                if (first == null)
                {
                    last = null;
                }
            }
            else
            {
                var previous = Get(index - 1);
                previous.Next = previous.Next.Next;
                if (previous.Next == null)
                {
                    last = previous;
                }
            }
        }
    }
}
