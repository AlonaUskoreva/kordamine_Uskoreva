using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine_Uskoreva
{
	class Program
	{
		static void Main(string[] args)
        {
            //10. Varinat          
            /*Antud kahemõõtmeline numbrimassiiv(kasutage juhuslike numbrite generaatorit)Sorteeri iga paaritu rida kasvavas järjekorras
            ja iga paarisarv kahanevas järjekorras, misjärel printige k-nda veeru väärtus.*/


            /* Console.WriteLine("Sisesta ridade arv");
             int rows = Int32.Parse(Console.ReadLine());

             Console.WriteLine("Sisesta veeru arv");
             int cols = Int32.Parse(Console.ReadLine());
             int[,] a = new int[rows, cols];
             Random r = new Random(DateTime.Now.Millisecond);

             //täitmine juhuslike numbritega
             for (int i = 0; i < rows; i++)
             {
                 for (int j = 0; j < cols; j++)
                 {
                     a[i, j] = r.Next(-100, 100);
                     Console.Write("{0}\t", a[i, j]);
                 }
                 Console.WriteLine("");
             }

             //sorteerimine
             for (int i = 0; i < rows; i++)
             {
                 for (int j = 0; j < cols; j++)
                 {
                     for (int k = j + 1; k < cols; k++)
                         if (i % 2 == 1)
                         {
                             if (a[i, k] < a[i, k - 1])
                             {
                                 int prev = a[i, k];
                                 a[i, k] = a[i, k - 1];
                                 a[i, k - 1] = prev;
                             }
                         }
                         else
                         {
                             if (a[i, k] > a[i, k - 1])
                             {
                                 int prev = a[i, k];
                                 a[i, k] = a[i, k - 1];
                                 a[i, k - 1] = prev;
                             }
                         }
                 }
             }
             Console.WriteLine("Pärast sorteerimine");
             for (int i = 0; i < rows; i++)
             {
                 for (int j = 0; j < cols; j++)
                 {

                     Console.Write("{0}\t", a[i, j]);
                 }
                 Console.WriteLine("");
             }

             Console.WriteLine("Pärast sorteerimine");
             Console.WriteLine("");
             Console.WriteLine("Sisestage väljundi veeru number");
             Console.WriteLine("");
             int k_line = Int32.Parse(Console.ReadLine());


             for (int i = 0; i < rows; i++)
             {

                 Console.WriteLine("{0}", a[i, k_line - 1]);
             }*/


            /* Antnud ülikooli üliõpilaste teave sisaldab järgmisi elemente 
             */
            string[]= new string[8] { "A", "B", "C", "D", "E" };
            nimed[2] = "Alia";
            int nr = 0;
            while (nr < 8)
            {
                Console.WriteLine("Tere,{0} õpilane", nimed[nr]);
                nr = nr + 1;
            }
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine("Tere,{0} õpilane", nimed[i]);
            }
            foreach (var nimi in nimed)
            {
                Console.WriteLine("Tere,{0} õpilane", nimi);
            }
            nr = 0;
            do
            {
                Console.WriteLine("Tere,{0} õpilane", nimed[i]);
                nr++;
             } while (nr != nimed.Length);

            Console.ReadLine()

            Random rnd = new Random();
            int N = rnd.Next(2, 6);
            int M = rnd.Next(7, 14);
            int[] mass = new int[M - N];
            for (int i = N; i < M + 1; i++)
            {
                mass[i - N] = i;
                Console.WriteLine(i * i);
            }
            foreach (var m in mass)
                int sum = 0;
            int mult = 1;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Palun sisesta number: ");
                int smt = Convert.ToInt32(Console.ReadLine());
                sum += smt;
                mult = smt * mult;
            }
            {
                double avg = sum / 5;
                Console.WriteLine($"Nums AVG={avg}\nNums SUM={sum}\nNums multiplited={mult}");
            }
            int A = rnd.Next(1, 25);
            int AA;//Kasutaja arv
            int K = 1;//Katset
            do
            {
                Console.WriteLine("{0} Katse. Mis arv?", K);
                AA = int.Parse(Console.ReadLine())

                K++;
            } while (AA != A && K != 6);
            if (AA == A)
            {
                Console.WriteLine("Palju õnne!");
            }
            else
            {
                Console.WriteLine("Proovi veel!");
            }
            */


           Console.ReadLine();
        }
    }
}