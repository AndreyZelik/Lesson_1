using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
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
            double count = 0;
            List<DateTime> dates = new List<DateTime>();

            if (!InputValue(out count, "Введите число\r\n"))
            {
                return;
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите дату \r\n");
                string sourceArray = Console.ReadLine();
                string[] strItems = sourceArray.Split(' ');
                int[] dItems = new int[strItems.Length];

                for (int j = 0; j < strItems.Length; j++)
                {
                    if (!int.TryParse(strItems[j], out dItems[j]))
                    {
                        Console.WriteLine("Ошибка ввода");
                        return;
                    }
                }
                dates.Add(new DateTime(2001, 1, 1, dItems[0], dItems[1], dItems[2]));
            }
            
            dates.Sort();
            
            for (int i = 0; i < dates.Count; i++)
            {
                Console.WriteLine("Результат\r\n{0} {1} {2}", dates[i].Hour, dates[i].Minute, dates[i].Second);
            }
            Console.ReadLine();
        }
    }
}
