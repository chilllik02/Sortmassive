using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {

        static int[] n = { 1, 2, 3, 11, 8, 4 };

        static int m;
        static void Main(string[] args)
        {
            Sortonemassive();
            Printonemassive();
        }


        static void Sortonemassive()
        {
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = i + 1; j < n.Length; j++)
                {
                    if (n[i] > n[j])
                    {
                        m = n[i];
                        n[i] = n[j];
                        n[j] = m;
                    }
                }

            }
        }

        static void Printonemassive()
        {
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }
        }
    }
}
