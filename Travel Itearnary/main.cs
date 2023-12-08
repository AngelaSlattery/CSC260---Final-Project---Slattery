using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject
{
    class main
    {
        static void Main(string[] args)
        {
            bool end = false;

            Console.WriteLine("Where are you going?\n");
            string loc = Console.ReadLine();
            Console.WriteLine("How many people are going?\n");
            string ppl = Console.ReadLine();
            int pplnum = Convert.ToInt32(ppl);
            Console.WriteLine("What is your budget (# amount)?\n");
            string strinbud = Console.ReadLine();
            int bud = Convert.ToInt32(strinbud);
            Console.WriteLine("How many days will you travel?\n");
            string strinday = Console.ReadLine();
            int day = Convert.ToInt32(strinday);

            //Create Trip1 with input data
            Travel_Itearnary Trip1 = new Travel_Itearnary(loc, pplnum, bud, day);
            while (end == false)
            {
                end = Trip1.printMenu();
            }

            return;
        }
    }
    
}