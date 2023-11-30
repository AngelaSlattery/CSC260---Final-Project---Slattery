using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Travel_Itearnary
{
	public string location;
	public int howManyTravelers;
	public int budgetTotal;
	public int howManyDays;

    public Travel_Itearnary( string location, int people, int budget, int day)
    {
        this.location = location;
        this.howManyTravelers = people;
        this.budgetTotal = budget;
        this.howManyDays = day;        
    }

	public void bookFlight()
	{
		throw new NotImplementedException();
	}

	public void printItearnary()
	{
		throw new NotImplementedException();
	}

    public void bookExcursion()
    {
        throw new NotImplementedException();
    }

    public void bookTransportation()
    {
        throw new NotImplementedException();
    }

    public bool printMenu()
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
                bookExcursion();
                break;
            case "2":
                bookFlight();
                break;
            case "3":
                break;
            case "4":
                printItearnary();
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
             //end = printMenu();
        }

    }
}
