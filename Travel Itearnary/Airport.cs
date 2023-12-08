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
    public  Flight_Details reTurn = new Flight_Details();

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
	public void bookDestinationFlight( int numDays, int numPpl)
	{
		seatNum = numPpl;
        IEnumerable<string> flights;
        IEnumerable<string> book;
        //Find out how to get dulles as string
        //File path needs to be FIXED!!!!!!!
        string flightFilePath = @"C:\Users\DSU\OneDrive - Dakota State University\Desktop\Fall 2023\Final Project\Dulles.txt";
        string fileName = String.Concat(flightFilePath, location, ".txt");

		//In this scenario, all flights are the exact same everyday.  This obviously could be different if I had more sample files
		//for particular days
		Console.WriteLine(flightFilePath);
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
        flightMenu();
		
    }

	public void bookReturnFlight()
	{

	}

	public void boardingPass()
	{
		throw new NotImplementedException();
	}

	public void flightMenu()
	{
        Console.WriteLine("Which option would you like to pick: \n");
        Console.WriteLine("1. Print Flights\n");
        Console.WriteLine("2. Search Return Flight\n");
        Console.WriteLine("3. Return to Menu\n");
        string x = Console.ReadLine();
        switch (x)
        {
            case "1":
                too.printFlight();
                break;
            case "2":
                bookReturnFlight();
                break;
            case "3":
                return;
        }
    }
}
