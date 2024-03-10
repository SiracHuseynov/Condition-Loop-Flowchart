using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.ci tapsirig
            //Verilmis ededin reqemlerinin hasilini tapin.
            //Console.WriteLine("Ededi daxil edin: ");
            //int eded = Convert.ToInt16(Console.ReadLine());
            //int hasil = 1;
            //int qaliq;

            //while (eded > 0)
            //{
            //    qaliq = eded % 10;
            //    hasil *= qaliq;
            //    eded /= 10;
            //}
            //Console.WriteLine(hasil);

            #endregion

            #region 2.ci tapsirig
            //Verilmis ededin sade ve ya murekkeb oldugunu tapan alqoritm. 
            Console.WriteLine("Ededi daxil edin: ");
            int eded = Convert.ToInt16(Console.ReadLine());  
            bool f = true;


            if (eded < 0)
            {
                Console.WriteLine("Duzgun deyer daxil edin");
            }
            else if (eded == 0 || eded == 1)
            {
                Console.WriteLine($"{eded} ne sadedir, nede murekkeb");
            }
            else if (eded > 1)
            {
                for (int i = 2; i < eded; i++)
                {
                    if (eded % i == 0)
                    {
                        f = false;
                        break;
                    }

                }
                if (f)
                {
                    Console.WriteLine("Eded sadedir!");
                }
                else
                {
                    Console.WriteLine("Eded murekkebdir!");
                }
            }


            #endregion

            #region 3.cu tapsirig

            //Verilmis ededin faktorialini tapin. 

            //Console.WriteLine("Ededi daxil edin: ");
            //int eded = Convert.ToInt16(Console.ReadLine());
            //int hasil = 1;

            //if (eded < 0)
            //{
            //    Console.WriteLine("Menfi ededin faktoriali olmur!");
            //}
            //else if (eded == 0)
            //{
            //    Console.WriteLine("0-in faktoriali 1-dir!");
            //}
            //else
            //{
            //    while (eded > 0)
            //    {
            //        hasil *= eded;
            //        eded--;
            //    }
            //    Console.WriteLine(hasil);
            //}


            #endregion

            #region 4.cu tapsirig
            // Verilmiş ədədin polindrom olub olmadığını tapan alqoritm(Meselen: 1221->polindrom, 1231->polindrom deyil)(optional) 
            //Console.WriteLine("Ededi daxil edin: ");
            //int eded = Convert.ToUInt16(Console.ReadLine());
            //int qaliq;
            //int realEded = eded;
            //int reverseEded = 0;

            //while (eded != 0)
            //{
            //    qaliq = eded % 10;
            //    reverseEded = reverseEded * 10 + qaliq;
            //    eded /= 10;
            //}

            //if (reverseEded == realEded)
            //{
            //    Console.WriteLine("Bu eded polindromdur");
            //}
            //else
            //{
            //    Console.WriteLine("Bu eded polindrom deyil!");
            //}

            #endregion



        }
    }
}
