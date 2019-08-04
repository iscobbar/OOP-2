using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            Matematik m1 = new Matematik();
            m1.topla(3, 5);
            //Ex2
            Matematik.Staticstopla(4, 6);

            Console.Read();
        }
    }
    class Matematik
    {
        //Ex1
        public void topla(int s1, int s2)
        {
            Console.WriteLine("Sonuç: " + (s1 + s2));
        }
        //Ex2
        public static void Staticstopla(int s1, int s2)
        {
            Console.WriteLine("Sonuç: " + (s1 + s2));
        }
    }

}