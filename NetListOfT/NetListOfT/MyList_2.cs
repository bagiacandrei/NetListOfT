using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetListOfT
{
     class MyList<T>:IEnumerable<T>
    {
        private int index;
        private T[] memory;
        
         
        public MyList()
        {
            index = 0;
            memory = new T[index];
            
            
        }
        public int Count { get { return index; } }
        public void Add(T item)
        {
            T[] copy = new T[index];
            copy = this.memory;
            memory = null;
            memory=new T[index+1];
            for (int i = 0; i < index; i++)
                memory[i] = copy[i];
            this.memory[index] = item;
            index++;
        }
        public T this[int index]
        {
            get { return memory[index]; }
            set
            {
                if (index < 0 || index > Count)
                    throw new ArgumentOutOfRangeException("!!!");
            }
        }
         public void Clear()
        {
            memory = null;
            index = 0;
            memory = new T[index];

        }
         public bool Contains(T item)
         {
             for(int i=0;i<index;i++)
             {    
                 System.Collections.Generic.EqualityComparer<T> c=System.Collections.Generic.EqualityComparer<T>.Default;//habar nu am cei astaaaa
                 
                 if (c.Equals(memory[i],item))
                     return true;
                 
             }
             return false;
         }
         public void RemoveAt(int position)
         {
             T[] copy = new T[index];
             copy = this.memory;
             memory = null;
             memory = new T[index - 1];
             for (int i =0 ; i < position; i++)
                     memory[i] = copy[i];
             for (int i = position; i < index - 1; i++)
                 memory[i] = copy[i + 1];
                 
             index--;
         }
         public MyList<T> FindAll(T item)
         {
             MyList<T> list = new MyList<T>();
             
             for (int i = 0; i < index; i++)
                 {
                     System.Collections.Generic.EqualityComparer<T> c = System.Collections.Generic.EqualityComparer<T>.Default;

                     if (c.Equals(memory[i], item))
            
                     list.Add(memory[i]);
                 }
             return list;

         }
         public IEnumerator<T> GetEnumerator()
         {
             return this.GetEnumerator();
         }

         IEnumerator IEnumerable.GetEnumerator()
         {
             return GetEnumerator();
         }
        
    }
}
