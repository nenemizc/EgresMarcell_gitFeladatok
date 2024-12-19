using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feladat
{
    internal class Program
    {
        static void F01(int[] args)
        {
            Random rnd = new Random();
            for (int i = 0; args.Length > i; i++)
            {
                args[i] += rnd.Next(1, 50);
            }
        }

        static void Main(string[] args)
        {
        }
    }
}
