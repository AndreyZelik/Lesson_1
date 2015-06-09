using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {

        static bool isItSimple(double value)
        {
            double[] allPointers = {2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0 };
            for (int i = 0; i < allPointers.Length; i++)
            {
                if(((value % allPointers[i]) == 0) & (value != allPointers[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool InputValue(out double value, string message)
        {
            Console.WriteLine(message);
            if (!double.TryParse(Console.ReadLine(), out value))
            {
                    Console.WriteLine("Ошибка ввода");
                    Console.ReadKey();
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            double value = 0;
            if (!InputValue(out value, "Введите число\r\n"))
            {
                return;
            }

            for (int i = 2; i < value; i++)
            {
                if (isItSimple(i) )
                {
                    Console.Write(i+" ");
                }
            }
            Console.ReadKey();
        }
    }
}
