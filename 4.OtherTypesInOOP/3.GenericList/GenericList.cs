using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.GenericList
{
    
    class GenericList<T> where T : IComparable<T>
    {
        const int DefaultCapacity = 16;

        private T[] elements;
        private int count = 0;
        private int capacity;
        public GenericList(int capacity = DefaultCapacity)
        {
            this.Capacity = capacity;
            elements = new T[capacity];
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid capacity");
                }
                this.capacity = value;
            }
        }

        public void Add(T element)
        {
            
            if (count == capacity-1)
            {
                Grow();
            }
            this.elements[count] = element;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || count == null || elements.Length == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (count >= index+1)
            {
                for (int i = index; i<count-1; i++)
                {
                    elements[i] = elements[i+1];
                }

                this.count--;
            }
            else
            {
                throw new ArgumentOutOfRangeException() ;
            }
          
        }
        public void Insert(int index, T value)
        {
            if (index < 0 || elements.Length == 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                for (int i = index; i < count + 1; i++)
                   {
                        T a =this.elements[i];
                        this.elements[i] = value;
                         value = a;
                    }
                 this.count++;
            }
            
        }
        public void Clear()
        {
            this.count = 0;
            this.elements = new T[count];
        }
        public int FindingIndex(T value)
        {
            for (int i = 0; i<count; i++)
            {
                if (elements[i].Equals(value))
                {
                    return i;
                }
            }
            throw new ArgumentException("This value is not in array");
        }
        public bool Contains(T value)
        {
            bool isIn = false;
            for (int i = 0; i < count; i++)
            {
                if (elements[i].Equals(value))
                {
                    isIn = true;
                }
            }
            if (isIn)
            {
               return true;
            }
            else
           {
              return false;
           }
            
        }
        private void Grow()
        {
            T[] currArray = new T[capacity];
            for (int i = 0; i < capacity; i++)
            {
                currArray[i] = elements[i];
            }
            int help = capacity;
            this.capacity = 2 * capacity;
            elements = new T[capacity];
            for (int i = 0; i < help; i++)
            {
                elements[i] = currArray[i];
            }
        }
        public T Accessing(int value)
        {
            for (int i = 0; i < count; i++)
            {
                if (value.Equals(i))
                {
                    return elements[i];
                }
            }
            throw new ArgumentException("This index is not in array");
        }
        public T Min()
        {
            T small = this.elements[0];
            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].CompareTo(small) < 0)
                {
                    small = elements[i];
                }
            }
            return small;
        }
        public T Max()
        {
            T max = elements[0];
            for (int i = 0; i < count; i++)
            {
                if (this.elements[i].CompareTo(max) > 0)
                {
                    max = elements[i];
                }
            }
            return max;
        }
        
        public override string ToString()
        {
            
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for(int i=0 ; i<count ; i++){
                    sb.Append(elements[i].ToString());
                }
               return sb.ToString();
        }
    }
}
