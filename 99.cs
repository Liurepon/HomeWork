using System;
class Program {
    static void Main(string[] args) {
        Console.WriteLine("開始");
      
        int i = 1;
        
        
        while (i <= 9 )
        {
            int j = 1;
            int k;
            while (j <= 9)
            {
                k = i * j;
                Console.Write(i);
                Console.Write("X");
                Console.Write(j);
                Console.Write("=");
                if (k < 10)
                {
                    Console.Write(" ");
                }
                Console.Write(k + " ");
                j++;
            }
            Console.WriteLine("");
          i++;

        }
       

        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine("結束");
        Console.WriteLine(); Console.WriteLine();
        Console.WriteLine();
    }
}
