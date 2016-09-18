using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Task1
    {
        public static int maxValue = 100; 
        public static int minValueArray = 2;
        public static int maxValueArray = 20;
        public static int increasingOrDescending = 0;
        static void Main(string[] args)
        {
       
            Random random = new Random();
            int K = random.Next(1, 10);
            Console.WriteLine(" K= " + K);
            List<List<int>> arrayInt = new List<List<int>>();

            for (int i = 0; i < K; i++)
            {
                Console.Write("\n Набор " + (i+1)+ ": ");
                List<int> array = new List<int>();
                //Определяем размер
                int _maxValue= random.Next(minValueArray, maxValueArray);
                //Заполнение массива 
                while (array.Count < _maxValue)
                {
                    array.Add(random.Next(1, maxValue));
                    Console.Write(array[array.Count - 1] + " ");
                }
                //Обозначаем конец массива цифрой 0 
                array.Add(0);
                Console.Write(array[array.Count - 1] + " ");

                arrayInt.Add(array);
                CheckIncreasingOrDescending(array);

            }
            Console.WriteLine("\n Количество наборов, элементы которых возрастают или убывают = " + increasingOrDescending);


            Console.ReadKey();

        }

        static void CheckIncreasingOrDescending(List<int> _array)
        {
            bool checkIncreasing = true;
            bool checkDescending = true;

            for (int i = 1; i < _array.Count-1; i++)
            {
                if (_array[i-1] > _array[i])
                    checkDescending = false;
                if (_array[i - 1] < _array[i])
                    checkIncreasing = false;
            }
            if (checkIncreasing || checkDescending)
                increasingOrDescending++;

        }
    }
}

    
