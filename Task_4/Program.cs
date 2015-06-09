using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int refereeCount = 0;
            if (!InputValue(out refereeCount, "Введите количество судей\r\n"))
            {
                return;
            }

            Console.WriteLine("Введите оценки (через пробел)\r\n");
            string sourceArray = Console.ReadLine();
            string[] strItems = sourceArray.Split(' ');
            double[] dItems = new double[strItems.Length];

            for (int i = 0; i < strItems.Length; i++)
            {
                if (!double.TryParse(strItems[i], out dItems[i]))
                {
                    Console.WriteLine("Ошибка ввода");
                    return;
                }
            }

            double result = 0;

            for (int i = 0; i < dItems.Length; i++)
            {
                result += dItems[i];
            }

            result -= getExtraValue(dItems);
            result -= getExtraValue(dItems, true);
            Console.WriteLine("Итог  " + Math.Round((result / (refereeCount - 2)), 1));
            Console.ReadKey();
        }

        static double getExtraValue(double[] arr, bool isItMax = false)
        {
            double result = 0;
            if (isItMax)
            {
                result = arr[0];
                for (int i = 1; i < arr.Length; i ++)
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
                for (int i = 1; i < arr.Length; i ++)
                {
                    if (arr[i] > result)
                    {
                        result = arr[i];
                    }
                }
            }
            return result;
        }

        private static bool InputValue(out int value, string message)
        {
            Console.WriteLine(message);
            if (!int.TryParse(Console.ReadLine(), out value))
            {
                if (value < 3 || value > 10)
                {
                    Console.WriteLine("Ошибка ввода");
                    Console.ReadKey();
                    return false;
                }
            }
            return true;
        }

    }
}
