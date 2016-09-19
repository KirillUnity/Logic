using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{

    class Task4
    {
        public static int recurseCount = 0;
        public static int f = 0;


        static void Main(string[] args)
        {
            for (int i = 3; i < 8; i++)
            {
                Console.WriteLine(Fib(i));
            }
            Console.WriteLine("Количеством рекурсивных вызовов ="+recurseCount);

            Console.ReadKey();

        }
        public static int Fib(int N)
        {
            recurseCount++;
            int f0 = 1;
            int f1 = 1;
            for (int i = 3; i <= N; i++)
            {
                f = f0 + f1;
                f0 = f1;
                f1 = f;
            }
            return f;
        }


    }

}
