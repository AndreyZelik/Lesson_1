using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число \r\n");
            int k = int.Parse(Console.ReadLine());
            int count = 0;
            int count_iter = 0;
            int bufvalue = 0;
            for (int i = 1; i < k; i++)
            {
                bufvalue = 0;
                count_iter = 0;
                for (int j = i; j < k; j++)
                {
                    bufvalue += j;
                    count_iter++;
                    if (bufvalue == k)
                    {
                        break;
                    }
                    else if (bufvalue > k)
                    {
                        count_iter = 0;
                        break;
                    }
                }
                if (count < count_iter) { count = count_iter; }
            }

            Console.WriteLine("Результат = " + count);
            Console.ReadKey();
        }
    }
}
