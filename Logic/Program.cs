using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Task2
    {
        public static int ValueNoTooth = 0;
        public static double MaxValue = 100f;
        public static int MinValueArray = 3;
        public static int MaxValueArray = 20;

        static void Main(string[] args)
        {
            Random random = new Random();
            int N = random.Next(MinValueArray, MaxValueArray);
            Console.WriteLine(" N= " + N);
            List<double> arrayFloat = new List<double>();
            //Заполняем массив
            for (int i = 0; i < N; i++)
            {
                arrayFloat.Add(random.NextDouble()* MaxValue);
                Console.Write(arrayFloat[i]+" " );
            }
           // Проверяем массив на наличие зубцов
            CheckTooth(arrayFloat);

            Console.WriteLine("\n"+ValueNoTooth);
            Console.ReadKey();
        }

        static void CheckTooth(List<double> _array)
        {
            for (int i = 1; i < _array.Count - 1; i++)
            {
                bool toothDown = _array[i - 1] > _array[i] && _array[i] < _array[i + 1];
                bool toothUp = _array[i - 1] < _array[i] && _array[i] > _array[i + 1];
                if (!toothDown && !toothUp) { 
                    //Получаем нормер элемента, который не является зубцом
                  ValueNoTooth = i+1; 
                    break;
                }
            }
        }
    }
}
