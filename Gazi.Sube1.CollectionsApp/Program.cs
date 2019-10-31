using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.Sube1.CollectionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList();
            //al.Add("2");
            //al.Add(5);

            //Console.WriteLine(al.Capacity);
            //Console.WriteLine(al.Count);

            //for (int i = 0; i < al.Count; i++)
            //{
            //    Console.WriteLine(al[i]);
            //}

            //foreach (object item in al)
            //{
            //    Console.WriteLine(item);
            //}

            //Hashtable ht = new Hashtable();
            //ht.Add(6, "Ankara");
            //ht.Add(34, "İstanbul");
            //ht.Add(35, "İzmir");

            //foreach (DictionaryEntry item in ht)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //Queue q = new Queue();
            //q.Enqueue("Emre");
            //q.Enqueue("Şükret");
            //q.Enqueue("Salih");

            //q.Dequeue();
            //Console.WriteLine(q.Peek());

            //Stack s = new Stack();
            //s.Push("Tabak1");
            //s.Push("Tabak2");
            //s.Push("Tabak3");

            //s.Pop();
            //foreach (object item in s)
            //{
            //    Console.WriteLine(item);
            //}

            //Generic Collections

            Deneme<int,byte> d = new Deneme<int,byte>();

            List<int> lst = new List<int>();
            

            Console.ReadKey();
        }
    }

    class Deneme<T,U> where T:struct//Generic Constraints
                        where U:struct
    {
        public T sayi1;
        public U sayi2;
    }
}
