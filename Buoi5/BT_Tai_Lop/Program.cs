using System;
using System.Collections;
/*
namespace BT_Tai_Lop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Nhap_n(out n);
            ArrayList lst = new ArrayList();
            Nhap(lst, n);
            Console.Write("1.Mang vua nhap: ");
            Xuat(lst);
            Console.WriteLine("\n2.Mang co {0} so chan", demchan(lst));
            if (boi5(lst))
                Console.WriteLine("3.Mang co ton tai so chia het 5");
            else
                Console.WriteLine("3.Mang ko ton tai so chia het 5");
        }
        static void Nhap_n(out int n)
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
        }
        static void Nhap(ArrayList lst, int n)
        {
            for(int i=0; i < n; i++)
            {
                Console.Write("Nhap ptu thu {0}:", i);
                lst.Add(Console.ReadLine());
            }
        }
        static void Xuat(ArrayList lst)
        {
            for (int i = 0; i < lst.Count; i++)
                Console.Write(lst[i] + "\t");
        }
        static int demchan(ArrayList lst)
        {
            int d = 0;
            for (int i = 0; i < lst.Count; i++)
                if (int.Parse(lst[i].ToString()) % 2 == 0)
                    d++;
            return d;
        }
        static int tongam(ArrayList lst)
        {
            int s = 0;
            for (int i = 0; i < lst.Count; i++)
                if (int.Parse(lst[i].ToString()) < 0)
                    s = s + int.Parse(lst[i].ToString());
            return s;
        }
        static bool boi5(ArrayList lst)
        {
            for (int i = 0; i < lst.Count; i++)
                if (int.Parse(lst[i].ToString()) % 5 == 0)
                    return true;
            return false;
        }
    }
}
*/