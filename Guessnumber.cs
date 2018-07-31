using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Guess_number_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            int  終極密碼;
            
            
            終極密碼 = (int)(new Random().NextDouble()*100+1);
            Debug.WriteLine(終極密碼);
            Console.WriteLine("歡迎參加終極密碼大賽");
            string 參賽者輸入的整數;
            

            int 參賽者猜的整數;
            bool 參賽者輸入的整數是int;
            bool 參賽者輸入的整數是;
            參賽者輸入的整數是 = false;

            while (!參賽者輸入的整數是)
            {
                Console.WriteLine();
                Console.WriteLine("請輸入一個1到100的整數");
                參賽者輸入的整數 = Console.ReadLine();
                參賽者輸入的整數是int = int.TryParse(參賽者輸入的整數, out 參賽者猜的整數);

                if (參賽者輸入的整數是int)
                {
                    Console.Write("參賽者猜的整數   為");
                    Console.WriteLine(參賽者輸入的整數);
                    if (參賽者猜的整數 > 終極密碼)
                    {
                        Console.WriteLine("往小一點的方向猜");
                    }
                    if (參賽者猜的整數 < 終極密碼)
                    {
                        Console.WriteLine("往大一點的方向猜");
                    }
                    if (參賽者猜的整數 == 終極密碼)
                    {
                        參賽者輸入的整數是 = true;
                        Console.WriteLine("恭喜你答對惹");
                    }
                }
            }

        }
    }
}
