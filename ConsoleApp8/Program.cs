using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваш выбор? к - камень, н - ножницы, б - бумага");
            string choise = Console.ReadLine();

            string[] KNB = new string[3];
            KNB[0] = "к";
            KNB[1] = "н";
            KNB[2] = "б";
            Random rnd = new Random();
            int i = rnd.Next(0, 3);
            string compChoise = (KNB[i]);
            Console.WriteLine("Выбор компьютера: " + compChoise);

            if (choise == compChoise)
            {
                Console.WriteLine("Ничья");
            }
            else
            {
                if(choise == "к")
                {
                    if(compChoise == "н")
                    {
                        Console.WriteLine("Вы выиграли");
                    }
                    else
                    {
                        Console.WriteLine("Вы проиграли");
                    }
                }
                if (choise == "н")
                {
                    if (compChoise == "б")
                    {
                        Console.WriteLine("Вы выиграли");
                    }
                    else
                    {
                        Console.WriteLine("Вы проиграли");
                    }
                }
                if (choise == "б")
                {
                    if (compChoise == "к")
                    {
                        Console.WriteLine("Вы выиграли");
                    }
                    else
                    {
                        Console.WriteLine("Вы проиграли");
                    }
                }
            }
            Console.Read();
        }
    }
}
