using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plesoczki_Á_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, max_seb,sorszam;
            bool van;
            Console.WriteLine("Hány auto sebbeségét kérjem be?");
            n = Convert.ToInt32(Console.ReadLine());
            int[] seb = new int[n];
            Console.WriteLine();
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}. autó : ",i+1);
                seb[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nMenyi a maximálisan megengedett sebeség?");
            Console.Write("max sebbesség: ");
            max_seb = Convert.ToInt32(Console.ReadLine());

            i = 0;
            while ((i < n) && !(seb[i] % 5 == 2))
                i++;
            van = i < n;
            if (van)
            {
                sorszam = i + 1;
                Console.WriteLine("\n\nVolt szabálysértő.\nAz első szabálysértő sorszáma {0}", sorszam);
               
            }
            else
            {
                Console.WriteLine("\n\n Nem volt szabálysértő");
            }
            Console.ReadLine();
        }
    }
}
