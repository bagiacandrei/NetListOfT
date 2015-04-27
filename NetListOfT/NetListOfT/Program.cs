using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetListOfT
{
    class Program
    {
        public static void Main()
        {
            MyList <int> list = new MyList<int>();
            MyList<int> list2 = new MyList<int>();
            list.Add(2);
            //list.Clear();
            list.Add(10);
            list.Add(2);
            list.RemoveAt(1);
            Console.WriteLine(list[1].ToString());
                Console.WriteLine("\nCount :{0}", list.Count);//nr de elemente din lista
                if (list.Contains(2))
                    Console.WriteLine("Contains works");
                list2 = list.FindAll(2);
              Console.WriteLine("FindAll function: {0}",list2[1].ToString());
            //foreach(MyList<int> item in list)
               // Console.WriteLine(item.ToString());
           } 
        
        }
    }

