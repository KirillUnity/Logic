using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Point
    {
        public double x;
        public double y;
        public Point(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

    }
    class Task3
    {
        static void Main(string[] args)
        {
            Point A = new Point(-6.46f, 1.93f);
            Point B = new Point(-0.83f, -7.67f);
            Point C = new Point(-9.29f, 0.34f);
            Point D = new Point(-3.68f, -5.72f);
            Perim(A,B,C,D);
            Console.ReadKey();
        }
        public static void Perim(Point A, Point B, Point C, Point D)
        {
            double ab = Math.Sqrt(Math.Pow((A.x - B.x), 2) + Math.Pow((A.y - B.y), 2));
            double bc = Math.Sqrt(Math.Pow((B.x - C.x), 2) + Math.Pow((B.y - C.y), 2));
            double ac = Math.Sqrt(Math.Pow((A.x - C.x), 2) + Math.Pow((A.y - C.y), 2));
            double ad = Math.Sqrt(Math.Pow((A.x - D.x), 2) + Math.Pow((A.y - D.y), 2));
            double bd = Math.Sqrt(Math.Pow((B.x - D.x), 2) + Math.Pow((B.y - D.y), 2));
            double cd= Math.Sqrt(Math.Pow((C.x - D.x), 2) + Math.Pow((C.y - D.y), 2));

            double pABC = (ab + bc + ac);
            double pABD = (ab + bd + ad);
            double pACD = (ac + cd + ad);

            Console.WriteLine(pABD+" "+ pABC + " " + pACD);
        }


    }
}