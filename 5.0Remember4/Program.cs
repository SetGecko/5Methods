using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._0Remember4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] dishes) User;
            Console.WriteLine("Введите имя пользователя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите 5 любибых блюд");
            User.dishes = new string[5];
            for (int i = 0; i < User.dishes.Length ;i++)
            {
                User.dishes[i] = Console.ReadLine();
            }

            Console.ReadKey();
        }
    }
}
