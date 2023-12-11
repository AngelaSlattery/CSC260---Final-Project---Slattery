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
    int budgetTotal;
    public int remainingBudget;
    public int howManyDays;
    public Airport Airport1 = new Airport();
    public Excursions excursion1 { get; set;}
    public Transportation transport { get; set; }

    public Travel_Itearnary( string location, int people, int budget, int day)
    {
        this.location = location;
        this.howManyTravelers = people;
        this.budgetTotal = budget;
        this.howManyDays = day;
        this.remainingBudget = budget;
        excursion1 = new Excursions( day, location, howManyTravelers);
        transport = new Transportation();
}

	public void bookFlight()
	{
        Airport1.pickAirport();
        Airport1.seatNum = howManyTravelers;
        Airport1.location = location;

        remainingBudget = Airport1.flightMenu( this.remainingBudget );
	}

	public void printItearnary()
	{
        Console.WriteLine("Location: \n" + location);
        Console.WriteLine("Starting Budget: \n" + budgetTotal);
        Console.WriteLine("Remaining Budget: \n" + remainingBudget);
        //Console.WriteLine("Destination Flight: "+ Airport1)
	}

    public void bookExcursion()
    {
        //Make it off the locations of the city
        remainingBudget = excursion1.excursions_Menu( this.remainingBudget);
    }

    public void bookTransportation()
    {
        
    }
    
    public bool printMenu()
    {
        bool endProgram = false;
        string x;
        Console.WriteLine("1. Book Excursion\n");
        Console.WriteLine("2. Book Flight\n");
        Console.WriteLine("3. Book Transportation\n");
        Console.WriteLine("4. Print Itinerary\n");
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
