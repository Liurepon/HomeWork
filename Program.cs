using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 質數
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y; //除數
            x = 6;
            
            bool 是質數;
            while (x <= 15)
            {
                是質數 = true;
                y = 2;
                while(y<x && 是質數)
                {
                    if (x % y == 0)
                    {
                        是質數 = false;
                    }
                    y += 1;
                    
                }
                if (是質數)
                {
                    Console.WriteLine(x + " ");
                }
                 x += 1;
            }
            Console.WriteLine("是質數");
        }
    }
}
