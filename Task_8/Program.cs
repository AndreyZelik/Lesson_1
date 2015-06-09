using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество дней\r\n ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сумму на каждый из дней(через пробел)\r\n ");
            string arr = Console.ReadLine();
            string[] sItems = arr.Split(' ');
            int[] items = new int[k];
            for (int i = 0; i < k; i++)
            {
                items[i] = int.Parse(sItems[i]);
            }

            double sum = 0;
            sum = getMax(items);
            Console.WriteLine("Результат = " + sum);
            Console.ReadKey();
        }

        static int getMax(int[] arr)
        {
            if (arr.Length > 0)
            {
                int max = arr[0];
                int step = 0;
                for (int i = 1; i < arr.Length + 1; i++)
                {
                    if (i * arr[i - 1] > max)
                    {
                        max = i * arr[i - 1];
                        step = i - 1;
                    }
                }

                int[] newArr = new int[arr.Length - step - 1];
                for (int i = step + 1, j = 0; i < arr.Length; i++, j++)
                {
                    newArr[j] = arr[i];
                }
                return max + getMax(newArr);
            }
            else return 0;
        }

    }
}
