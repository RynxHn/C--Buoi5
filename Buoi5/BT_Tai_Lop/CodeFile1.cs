using System;
using System.Collections;

namespace BT_Tai_Lop
{
    class B1
    {
        static void Main(string[] args)
        {
            int n;
            Nhap_n(out n);
            ArrayList lst = new ArrayList();
            input(lst, n);
            Console.WriteLine("TBC cua mang: " + TBC(lst));
            //Timx(lst);
            Themx(lst, n);
        }
        static void Nhap_n(out int n)
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
        }
        static void input(ArrayList lst, int n)
        {
            for (int i = 0; i < n; i++)
            {
                try
                {
                    Console.Write("Nhap ptu thu {0}:", i);
                    lst.Add(int.Parse(Console.ReadLine()));
                }
                catch (FormatException)
                {
                    Console.Write("Nhap sai! Nhap lai ptu thu {0}:", i);
                    lst.Add(int.Parse(Console.ReadLine()));
                }
            }
        }
        static void output(ArrayList lst)
        {
            for (int i = 0; i < lst.Count; i++)
                Console.Write(lst[i] + "\t");
        }
        static float TBC(ArrayList lst)
        {
            int s = 0,d =0;
            for(int i=0; i<lst.Count; i++)
            {
                s += int.Parse(lst[i].ToString());
                d++;
            }
            return (float)s / d;
        }
        static void Timx(ArrayList lst)
        {
            int x;
            Console.Write("Nhap x: ");
            x = int.Parse(Console.ReadLine());
            for(int i=0; i < lst.Count; i++)
                if(int.Parse(lst[i].ToString()) == x)
                    Console.WriteLine("{0} co trong mang, o vi tri {1}", x, lst[i]);
        }
        /*
        static void Themx(ArrayList lst, int n)
        {
            int m = 0, x = 0;
            Console.Write("Nhap x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Nhap m: ");
            m = int.Parse(Console.ReadLine());
            int[] newarr = new int[n + 1];
            for(int i=0; i <n; i++)
            {
                
            }
            lst[m] = x;
            n++;
            output(lst);
        }*/
    }
}
