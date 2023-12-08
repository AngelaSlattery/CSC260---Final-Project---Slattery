using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

public class Flight_Details : Airport
{
	public string airline;
	public string flightNum;
	public string day;
	public string departTime;
	public string arrivalTime;
	public int flightCost;


	public void printFlight()
	{
		Console.WriteLine("Airline: " + airline + "\n");
        Console.WriteLine("Flight Number: " + flightNum + "\n");
        Console.WriteLine("Day: " + day + "\n");
        Console.WriteLine("Depart Time: " + departTime + "\n");
        Console.WriteLine("Arrival Time: " + arrivalTime + "\n");
        Console.WriteLine("Flight Cost: " + flightCost + "\n\n");
    }

	public void bookFlight()
	{

	}

}
