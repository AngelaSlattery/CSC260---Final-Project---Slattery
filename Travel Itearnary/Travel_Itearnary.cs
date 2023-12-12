using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    bool rental_car = false;
    public Airport Airport1 = new Airport();
    public Excursions excursion1 { get; set;}

    public Travel_Itearnary( string location, int people, int budget, int day)
    {
        this.location = location;
        this.howManyTravelers = people;
        this.budgetTotal = budget;
        this.howManyDays = day;
        this.remainingBudget = budget;
        excursion1 = new Excursions( day, location, howManyTravelers);
        //transport = new Transportation();
}

	public void bookFlight()
	{
        Airport1.pickAirport();
        Airport1.seatNum = howManyTravelers;
        Airport1.location = location;

        remainingBudget = Airport1.flightMenu( this.remainingBudget );
	}

	public void printTripFinances()
	{
        Console.WriteLine("Location: \n" + location);
        Console.WriteLine("Starting Budget: \n" + budgetTotal);
        Console.WriteLine("Remaining Budget: \n" + remainingBudget);
        //Console.WriteLine("Destination Flight: "+ Airport1)
	}

    public void bookExcursion()
    {
        //Make it off the locations of the city
        this.remainingBudget = excursion1.excursions_Menu( this.remainingBudget);
    }

    public void bookRentalCar()
    {
        if (rental_car == false)
        {
             rental_car = true;
             Transportation car = new Rental_Car();
             remainingBudget = car.bookTransport( howManyTravelers, remainingBudget);
        }
        else
        {
            Console.WriteLine("Rental Car is already Booked\n"); 
        }
    }
    
    public bool printMenu()
    {
        bool endProgram = false;
        string x;
        Console.WriteLine("1. Book Excursion\n");
        Console.WriteLine("2. Book Flight\n");
        Console.WriteLine("3. Book Rental Car\n");
        Console.WriteLine("4. Print Trip Finances\n");
        Console.WriteLine("5. Increase Budget\n");
        Console.WriteLine("6. End Program\n");
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
                bookRentalCar();
                break;
            case "4":
                printTripFinances();
                break;
            case "5":
                Console.WriteLine("By how much?");
                string increase = Console.ReadLine();
                int increaseInt = Convert.ToInt32(increase);
                budgetTotal = increaseInt + budgetTotal;
                remainingBudget = increaseInt + remainingBudget;
                break;
            case "6":
                endProgram = true;
                break;

        }
        return endProgram;
    }  
}
