using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


//Inheritance Example along with Excursion_Option
public class Excursions
{
    string location;
    string day;
    public int numppl;

	public List<Excursion_Option> bookedExcursions { get; set; }

	public Excursions( int numDays, string location, int numppl)
	{
        bookedExcursions = new List<Excursion_Option>();
        this.location = location;
        this.numppl = numppl;
    }
	public int excursions_Menu( int budget)
	{
        int y;
        Console.WriteLine("Which option would you like to pick: \n");
        Console.WriteLine("1. Book an Excursion\n");
        Console.WriteLine("2. View Excursions\n");
        Console.WriteLine("3. Print Booked Excurison\n");
        Console.WriteLine("4. Return to Menu\n");
        string x = Console.ReadLine();
        switch (x)
        {
            case "1":
                y = bookExcursion(budget);
                return y;
            case "2":
                printExcursionOptions();
                excursions_Menu(budget);
                break;
            case "3":
                printBookedExcursions();
                return budget;
            case "4":
                return budget;
        }
        return budget;
    }
    public void printExcursionOptions()
    {
        Console.WriteLine("Excursions Available: \n");
        IEnumerable<string> excurAvail;
        string excursionFile = @"C:\Users\DSU\OneDrive - Dakota State University\Desktop\Fall 2023\Final Project\ExcursionList.txt";
        excurAvail = File.ReadAllLines(excursionFile);
        Console.WriteLine(String.Join(Environment.NewLine, excurAvail));
    }
    public int bookExcursion( int budget )
	{
        Console.WriteLine("Which Excursion would you like to book?");
        string x = Console.ReadLine();

        //These are hard coded in values because I didnt have the resources to do read in files
        //You can read in from a file 
        if ( String.Compare( x, "Monument") == 0 )
        {
            int cost = 200;
            string con = "24251";
            Excursion_Option exc = new Excursion_Option(x, cost);
            exc.printConfirmation(cost, con, numppl);

            budget = budget - (cost * numppl);
        }
        if (String.Compare(x, "Art Museum") == 0)
        {
            int cost = 150;
            string con = "24221";
            Excursion_Option exc = new Excursion_Option(x, cost);
            exc.printConfirmation(cost, con, numppl);

            budget = budget - (cost * numppl);
        }

        bool validInput = false;
        while ( validInput == false )
        {
            Console.WriteLine("Would you like to book public transportation?");
            string trav = Console.ReadLine();
            if (trav == "Y")
            {
                Console.WriteLine("What form of transportation? Metro, Bus");
                string rideType = Console.ReadLine();
                bool validInput2 = false;
                while (validInput2 == false)
                {
                    if (rideType == "Metro")
                    {
                        Transportation ride = new Metro();
                        //This where you could read in from a file off the location, instead I chose to make this hard-coded
                        ride.allocatedTime = 2;
                        ride.startingPoint = x;
                        ride.endingPoint = "hotel";
                        ride.startTime = 1;
                        ride.endTime = 3;
                        budget = ride.bookTransport(numppl, budget);
                        ride.printInformation();
                        validInput2 = true;
                    }
                    else if (rideType == "Bus")
                    {
                        Transportation ride = new Bus();
                        //This where you could read in from a file off the location, instead I chose to make this hard-coded
                        ride.allocatedTime = 2;
                        ride.startingPoint = x;
                        ride.endingPoint = "hotel";
                        ride.startTime = 1;
                        ride.endTime = 4;
                        budget = ride.bookTransport(numppl, budget);
                        ride.printInformation();
                        validInput2 = true;
                    }
                    
                }
                validInput = true;
            }
            else if (trav == "N")
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        return budget;
	}
    public void printBookedExcursions()
    {
        if( bookedExcursions.Count == 0)
        {
            Console.WriteLine("No Excursions Booked\n\n\n\n\n");
        }
        else
        {
            Console.WriteLine("Booked Excursions: \n");
            for (int i = 0; i < bookedExcursions.Count; i++)
            {
                Console.WriteLine(bookedExcursions[i].name + "\n");
            }
            Console.WriteLine("\n\n\n\n");
        }
        return;
    }
}
