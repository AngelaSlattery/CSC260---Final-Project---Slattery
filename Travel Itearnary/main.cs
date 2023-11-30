using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalProject
{
    internal class Main
    {
        public bool printMenu(Travel_Itearnary Trip1)
        {
            bool endProgram = false;
            string x;
            Console.WriteLine("1. Book Excursion\n");
            Console.WriteLine("2. Book Flight\n");
            Console.WriteLine("3. Book Transportation\n");
            Console.WriteLine("4. Print Itearnary\n");
            Console.WriteLine("5. End Program\n");
            x = Console.ReadLine();

            switch (x)
            {
                case "1":
                    Trip1.bookExcursion();
                    break;
                case "2":
                    Trip1.bookFlight();
                    break;
                case "3":
                    break;
                case "4":
                    Trip1.printItearnary();
                    break;
                case "5":
                    endProgram = true;
                    break;

            }
            return endProgram;
        }
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
                end = printMenu(Trip1);
            }

        }

    }
}