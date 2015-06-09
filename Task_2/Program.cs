using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int universCount = 0;
            int[] teams;
            int hallsCount = 0;
            
            if (!InputValue(out universCount, "Введите количество университетов, которые участвуют в олимпиаде\r\n")) 
            { 
                return; 
            }

            teams = new int[universCount];

            Console.WriteLine("Введите количество команд от каждого универа(через пробел)\r\n");
            string strTeams = Console.ReadLine();
            string[] teamForOneUniver = strTeams.Split(' ');

            for (int i = 0; i < universCount; i++)
            {
                if (!int.TryParse(teamForOneUniver[i], out teams[i]))
                {
                    Console.WriteLine("Ошибка ввода");
                    return;  
                }
            }

            if (!InputValue(out hallsCount, "Введите количество залов\r\n"))
            {
                return;
            }

            int resultTeamCount = 0;

            for (int i = 0; i < hallsCount; i++)
            {
                for (int j = 0; j < universCount; j++)
                {
                    if (teams[j] > 0)
                    {
                        resultTeamCount++;
                        teams[j]--;
                    }
                }
                
            }

            Console.WriteLine("Максимальное количество команд для участия  -  " + resultTeamCount);
            Console.ReadKey();
        }

        private static bool InputValue(out int universCount, string message)
        {
            Console.WriteLine(message);
            if (!int.TryParse(Console.ReadLine(), out universCount))
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();
                return false;
            }
            return true;
        }
    }
}
