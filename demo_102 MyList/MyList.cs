using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_102
{
    internal class MyList<T>//模拟数组
    {
        private T[] data=new T[0];
        private int counts = 0;//元素个数
        public int Capacity
        {
            get
            {
                return data.Length;
            }
        }
        public int Count
        {
            get
            {
                return counts;
            }
        }
        public void Add(T item)
        {
            if(data.Length == 0) 
            {
                data = new T[4];
            }
            if (data.Length == counts)
            {
                T[] temp = new T[counts * 2];
                for (int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];//赋给新数组
                }
            }
            data[counts] = item;
            counts++;
        }
        public T this[int index]//索引器
        {
            get
            {
                if (index < 0 || index > counts - 1)
                {
                    throw new System.ArgumentOutOfRangeException("Invalid Index");
                }
                return data[index];//访问
            }
            set 
            { 
                data[index] = value;//赋值
            }
        }
        public void Insert(int index, T item)
        {
            if (index < 0 || index > counts - 1)
            {
                throw new System.ArgumentOutOfRangeException("Invalid Index");
            }
            if (data.Length == counts)
            {
                T[] temp = new T[counts * 2];
                for (int i = 0; i < data.Length; i++)
                {
                    temp[i] = data[i];
                }
            }
            for (int i = counts-1; i>index ; i--)
            {
                data[i+1]= data[i];
            }
            data[index] = item;
            counts++;
        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index > counts - 1)
            {
                throw new System.ArgumentOutOfRangeException("Invalid Index");
            }
            for(int i=index+1;i<counts;i++)
            {
                data[i-1]= data[i];
                counts--;
            }
        }
        public int IndexOf(T item)
        {
            int index = -1;
            for (int i=0; i<counts;i++)
            {
                if (item.Equals(data[i]))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public void Sort()
        {
            Array.Sort(data, 0, counts);
        }
    }
}
