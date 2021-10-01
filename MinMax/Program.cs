using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] { 3, 6, -3, 5, 7 };

            int min = array[0];

            for (int i=1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            Console.WriteLine(min);
            Console.ReadKey();
        }
    }
}
