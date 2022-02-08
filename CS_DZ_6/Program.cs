using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 10;
            string exit = "exit";
            string userInput;

            for(int i = 0; i < tryCount; i++)
            {
                Console.Write("Введите exit для выхода: ");
                userInput = Console.ReadLine();

                if(userInput == exit)
                {
                    Console.WriteLine("Программа закрыта.");
                    break;
                }
                else
                {
                    Console.WriteLine("Программа выполнится еще " + (tryCount - i) + " раз");
                }
            }
        }
    }
}
