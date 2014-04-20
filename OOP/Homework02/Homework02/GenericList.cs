using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework02
{
    public class GenericList<T>
    {
        const int DefaultSize = 32;
        private T[] array;
        public uint Count { get; private set; }

        public GenericList()
        {
            array = new T[DefaultSize];
        }
        public GenericList(int size)
        {
            if (size >= 0)
            {
                array = new T[size];
            }
            else
            {
                throw new ArgumentOutOfRangeException(String.Format("Negative index{0}", size));
            }
        }
        public void AddElement(T element)
        {
            if (Count == array.Count())
            {
                ExpandArray();
            }
            array[Count] = element;
            Count++;
        }
        private void ExpandArray()
        {
            T[] tempArr = new T[Count * 2];
            Array.Copy(array, tempArr, Count);
            Count++;
        }
        public T this[int index]
        {
            get
            {
                if (index <= Count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return array[index];
                }
            }
            set
            {
                if (index >= Count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                else array[index] = value;
            }
        }
        public void RemoveElement(int index)
        {
            try
            {
                if (index <= Count && index >=0)
                {
                    T[] tempArr = new T[array.Count() - 1];
                    int iter = 0;
                    for (int i = 0; i < array.Count(); i++)
                    {
                        if (iter == index)
                        {
                            i++;
                        }
                        tempArr[iter] = array[i];
                        iter++;
                    }
                    Count--;
                    array = tempArr;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index - {0}, is not accesible - index out of range", index);
            }
        }
        public void InsertElement(int index, T element)
        {
            try
            {
                if (index <= Count && index >= 0)
                {
                    T[] tempArr = new T[array.Count() + 1];
                    int iter = 0;
                    for (int i = 0; i < tempArr.Count(); i++)
                    {
                        if (i == index)
                        {
                            tempArr[i] = element;
                        }
                        else
                        {
                            tempArr[i] = array[iter];
                            iter++;
                        }
                    }
                    Count++;
                    array = tempArr;
                }
                else throw new IndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index - {0}, is not accesible - index out of range", index);
            }
        }
        public T Min()
        {
            if (Count == 0)
            {
                throw new Exception("There is no Min value in empty list");
            }
            else if (Count == 1) return array[0];
            else if (array[0] is IComparable<T>)
            {
                T min = array[0];
                for (int i = 0; i < Count; i++)
                {
                    if ((min as IComparable<T>).CompareTo(array[i]) > 0)
                    {
                        min = array[i];
                    }
                }
                return min;
            }
            else throw new TypeAccessException("You can't find Min value in non-comparable list");
        }
        public T Max()
        {
            if (Count == 0)
            {
                throw new Exception("There is no Max value in empty list");
            }
            else if (Count == 1) return array[0];
            else if (array[0] is IComparable<T>)
            {
                T max = array[0];
                for (int i = 0; i < Count; i++)
                {
                    if ((max as IComparable<T>).CompareTo(array[i]) < 0)
                    {
                        max = array[i];
                    }
                }
                return max;
            }
            else throw new TypeAccessException("You can't find Max value in non-comparable list");
        }
        public void Clear()
        {
            array = new T[0];
            Count = 0;
        }
        public override String ToString()
        {
            T[] temp = new T[Count];
            Array.Copy(array, temp, Count);
            return String.Join(", ", temp);
        }
    }
}
