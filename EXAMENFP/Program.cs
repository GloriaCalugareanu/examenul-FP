using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMENFP
{
    class Program
    {
        static void Main(string[] args)
        {
             //Problema1();
            //Problema2();
            //Problema3();
            //Problema4();
            //Problema5();
            // Problema6();
            //Problema7();
            int[] v = new int[15];

            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < v.Length; i++)

            {

                v[i] = int.Parse(Console.ReadLine());

            }
        }

        private static void Problema7()
        {
            int Inaltimepisica;
            Console.Write("Introduceti inaltmea pisicii ");
            Inaltimepisica = int.Parse(Console.ReadLine());
            Console.WriteLine(incapePisica(Inaltimepisica));
            bool incapePisica(int n)
            {
                if (n <= 15)
                    return true;
                else
                    return false;
            }
            Console.ReadKey();
        }

        private static int Problema6(int n,int minimul=-1)
        {

            if (n / 10 > 0)
            {
                if (n % 2 == 0)
                {
                    if (minimul == -1 || n % 10 < minimul)
                        return Problema6(n / 10, n % 10);
                    else return Problema6(n / 10, minimul);
                }
                else
                    return Problema6(n / 10, minimul);
            }
            else return minimul;

           
        }

        private static void Problema5()
        {
            int nr = int.Parse(Console.ReadLine());
            int maxim1 = 0;
            int maxim2 = 0;
           int maxim3 = 0;
           while (nr != 0)
            {
               {
                    if (nr > maxim1 && maxim1 <= maxim2 && maxim1 <= maxim3)
                    {
                        maxim1 = nr;
                    }
                    else
                        if (nr > maxim2 && maxim2 <= maxim1 && maxim2 <= maxim3)
                    {
                        maxim2 = nr;
                    }
                    else
                        if (nr > maxim3 && maxim3 <= maxim1 && maxim3 <= maxim2)
                    {
                        maxim3 = nr;
                    }
                    nr = int.Parse(Console.ReadLine());
                }
            }

        }
    

        private static void Problema4()
        {
            int n, k;
            Console.Write("INTRODUCETI n ");
            n = int.Parse(Console.ReadLine());
            int i = 1;
            while (n != 0)
            {
                k = 0;
                while (n != 0 && k < i)
                {
                   Console.WriteLine(i + " ");
                    k++;
                    n--;
                }
                i++;
           }
            Console.ReadKey();
        }

        private static void Problema3()
        {
           
        }

        private static void Problema2(int[] v, int t)
        {
            bool yes = false;

            int j = 0, i = 0;



            while ((yes == false) && (i < 10))

            {

                while ((yes == false) && (j < 10))

                {

                    if ((v[i] + v[j] == t) && (i != j))

                        Console.Write($"Indicii a două elemente din vector a căror sumă este egală cu {t} sunt {i} si {j}");

                    yes = true;

                }

                j++;

            }

            i++;
        }

        private static void Problema1()
        {
            int n, p, c, nr;
            p = 1;
            nr = 0;
            n = Convert.ToInt32(Console.ReadLine());
            while (n != 0)
            {
                c = n % 10;
                c = 9 - c;
                n = n / 10;
                nr = c * p + nr;
                p = p * 10;
            }
            Console.WriteLine(nr);
            Console.ReadKey();
        }
    }
}
