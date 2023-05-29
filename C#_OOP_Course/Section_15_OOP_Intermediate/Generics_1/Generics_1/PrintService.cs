using System;

namespace Generics_1
{
    internal class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void add(T value)
        {
            if (_count == _values.Length)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public T first()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }

        public T max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("Empty list");
            }
            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max; 
        }

    }
}
