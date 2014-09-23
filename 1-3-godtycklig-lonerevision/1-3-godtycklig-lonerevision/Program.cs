using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_godtycklig_lonerevision
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSalaries = 0;
            Console.Write("Ange antal löner att mata in: ");
                numberOfSalaries = int.Parse(Console.ReadLine());

            if (numberOfSalaries < 2)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Du måste mata in minst två löner för att kunna göra en beräkning!");
                Console.ResetColor();

                if (Console.ReadKey(true).Key != ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }

                else
                {

                }
                
            }

            

        }

        static void ProcessSalaries(int numberOfSalaries)
        {
            int[] salaries = new int[numberOfSalaries];
        }
    }
}
