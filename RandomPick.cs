using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random k = new Random() ;
            
            string[] P;
            P = new string[] {"喵喵", "藍藍", "維維", "天天", "江豆" };
            int Left = P.Length;

            for (int i = 0; i < P.Length; i += 1)
            {
              Double  DD = k.NextDouble();
              int index = (int)(DD * Left );
                Console.WriteLine(P[index]);
                {
                    string 暫存 = P[index];
                    P[index] = P[Left - 1];
                    P[Left - 1] = 暫存;
                }
                Left -= 1;
            }
            

        }
    }
}
