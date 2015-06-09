using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массив чисел(через пробел)\r\n");
            string sourceArray = Console.ReadLine();
            string[] strItems = sourceArray.Split(' ');
            int[] intItems = new int[strItems.Length];

            for (int i = 0; i < strItems.Length; i++)
            {
                if (!int.TryParse(strItems[i], out intItems[i]))
                {
                    Console.WriteLine("Ошибка ввода");
                    return;
                }
            }

            int min = getExtraValue(intItems);
            int max = getExtraValue(intItems, true);

            Console.WriteLine("Результат " + (min + max));
            Console.ReadKey();
        }

        static int getExtraValue(int[] arr, bool isItMax = false)
        {
            int result = 0;
            if (isItMax)
            {
                result = arr[1];
                for (int i = 1; i < arr.Length; i+=2)
                {
                    if (arr[i] < result)
                    {
                        result = arr[i];
                    }
                }         
            }
            else
            {
                result = arr[0];
                for (int i = 0; i < arr.Length; i += 2)
                {
                    if (arr[i] > result)
                    {
                        result = arr[i];
                    }
                }
            }
            return result;
        }

    }
}
