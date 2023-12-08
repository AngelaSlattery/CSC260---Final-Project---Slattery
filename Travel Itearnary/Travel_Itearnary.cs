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
        Airport Airport1 = new Airport();
        Airport1.pickAirport();
        Airport1.location = location;
        Airport1.bookDestinationFlight( howManyDays, howManyTravelers);
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
}
