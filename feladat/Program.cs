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

        static int F02(int[] args) 
        {
            int szamalo = 0;
            for (int i = 0; args.Length > i; i++)
            {
                if (args[i] % 2 ==0)
                {
                    szamalo++;
                }
            }
            return szamalo;
        }

        static double F03(int[] args)
        {
            double atlag = 0;
            for (int i = 0; args.Length > i; i++)
            {
                atlag += args[i];
            }
            return atlag/args.Length;
        }

        static int[] F04(int[] args)
        {
            int[] paratlanok = new int[10];
            for (int i = 0 ; args.Length > i; i++)
            {
                if (args[i] % 2 == 0)
                {
                    paratlanok[i] = args[i]+1;
                }
                else
                {
                    paratlanok[i] = args[i];
                }
            }
            return paratlanok;
        }

        static void Main(string[] args)
        {
        }
    }
}
