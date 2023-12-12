using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Windows.Forms.AxHost;
using System.Security.Cryptography;

public class Airport
{
	public string location;
	public int seatNum;
    public Flight_Details too = new Flight_Details();
    public Flight_Details reTurn = new Flight_Details();

    public Airport()
	{

    }
	public void pickAirport()
	{
        //Reads in the names from the file along with the Airports
        IEnumerable<string> airportLocations;
        string airportFilePath = @"C:\Users\DSU\OneDrive - Dakota State University\Desktop\Fall 2023\Final Project\AirportCity.txt";
        airportLocations = File.ReadAllLines(airportFilePath);
        Console.WriteLine(String.Join(Environment.NewLine, airportLocations));

        //Once further advanced, I can make it so it only shows the locations around the city typed
        Console.WriteLine("Which airport do you want?\n");
        string location = Console.ReadLine();
    }
	public int bookDestinationFlight(int budgetTotal)
	{
        if ( too.book == true)
        {
            Console.WriteLine("Destiantion flight is alread booked");
            return budgetTotal;
        }
        IEnumerable<string> flights;
        IEnumerable<string> book;
        //Find out how to get dulles as string
        //File path needs to be FIXED!!!!!!!
        string flightFilePath = @"C:\Users\DSU\OneDrive - Dakota State University\Desktop\Fall 2023\Final Project\Dulles.txt";
        string fileName = String.Concat(flightFilePath, location, ".txt");

		//In this scenario, all flights are the exact same everyday.  This obviously could be different if I had more sample files
		//for particular days
		flights = File.ReadAllLines(flightFilePath);
        Console.WriteLine(String.Join(Environment.NewLine, flights));
		Console.WriteLine("\n\nWhat is your desired flight number?");
		string flightNum = Console.ReadLine();


    //See if you can make it so these values won't change
        too.flightNum = flightNum;
		too.day = "January8";
		too.airline = "United";
		too.departTime = "9:00";
		too.arrivalTime = "2:00";
		too.flightCost = 356;
        too.book = true;

        Console.WriteLine("Book? Y or N\n");
        string x = Console.ReadLine();
        if (x == "Y")
        {
            int minus = budgetTotal - (too.flightCost * seatNum);
            if (  minus >= 0)
            {
                too.bookFlight();
                return minus;
            }
            else
            {
                Console.WriteLine("The flight selected is too expensive");
                return budgetTotal;
            }
                
        }
        return budgetTotal;
    }

	public int bookReturnFlight(int budgetTotal)
	{
        if (reTurn.book == true)
        {
            Console.WriteLine("Return flight is alread booked");
            return budgetTotal;
        }
        IEnumerable<string> flights;
        IEnumerable<string> book;

        //Find out how to get dulles as string
        //File path needs to be FIXED!!!!!!!
        string flightFilePath = @"C:\Users\DSU\OneDrive - Dakota State University\Desktop\Fall 2023\Final Project\DullesReturn.txt";
        string fileName = String.Concat(flightFilePath, location, ".txt");

        //In this scenario, all flights are the exact same everyday.  This obviously could be different if I had more sample files
        //for particular days
        flights = File.ReadAllLines(flightFilePath);
        Console.WriteLine(String.Join(Environment.NewLine, flights));
        Console.WriteLine("\n\nWhat is your desired flight number?");
        string flightNum = Console.ReadLine();

        //See if you can make it so these values won't change
        reTurn.flightNum = flightNum;
        reTurn.day = "January10";
        reTurn.airline = "United";
        reTurn.departTime = "9:00";
        reTurn.arrivalTime = "2:00";
        reTurn.flightCost = 256;

        Console.WriteLine("Book? Y or N\n");
        string x = Console.ReadLine();
        if (x == "Y")
        {
            int minus = budgetTotal - (too.flightCost*seatNum);
            if (minus >= 0)
            {
                too.bookFlight();
                return minus;
            }
            else
            {
                Console.WriteLine("The flight selected is too expensive");
                return budgetTotal;
            }

        }
        return budgetTotal;
    }

	public int flightMenu( int budgetTotal)
	{
        int y;
        Console.WriteLine("Which option would you like to pick: \n");
        Console.WriteLine("1. Book Destination Flights\n");
        Console.WriteLine("2. Book Return Flight\n");
        Console.WriteLine("3. Print Tickets\n");
        Console.WriteLine("4. Return to Menu\n");
        string x = Console.ReadLine();
        switch (x)
        {
            case "1":
                y = bookDestinationFlight(budgetTotal);
                return y;
            case "2":
                y = bookReturnFlight(budgetTotal);
                return y;
            case "3":
                if ( too.book == true )
                {
                    too.printFlight();
                }
                else
                {
                    Console.WriteLine("Destination Flight Not Booked\n");
                }
                if (reTurn.book == true)
                {
                    reTurn.printFlight();
                }
                else
                {
                    Console.WriteLine("Return Flight Not Booked\n");
                }
                Console.WriteLine("\n\n\n\n");
                break;
            case "4":
                return budgetTotal;
        }
        return budgetTotal;
    }
}
