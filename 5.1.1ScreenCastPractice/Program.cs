using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1._1ScreenCastPractice
{
    internal class Program
    {
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];
            for (int i = 0; i < result.Length; i ++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            int temp = 0;
            for (int i = 0; i < result.Length; i++)
                for (int j = i + 1;j < result.Length; j++)
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            return result;
        }
        static void Main(string[] args)
        {

            //var array = new int[5];
            //var array = new int[5];
            int[] array = GetArrayFromConsole();
            //Console.WriteLine(array);

            //GetArrayFromConsole();
            Console.ReadKey();
        }
    }
}
