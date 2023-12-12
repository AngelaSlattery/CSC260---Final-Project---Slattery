using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Metro : Transportation
{
	public int stopsNeeded;
	public int totalCost = 3;
	private bool booked;
	string ticketConfirm;

	public override int bookTransport( int num, int budget)
	{
		stopsNeeded = this.startTime - this.endTime;
		stopsNeeded = stopsNeeded * 15;
		totalCost = stopsNeeded * 2;
		totalCost = totalCost * num;
		if(totalCost < budget)
		{
			booked = true;
			ticketConfirm = "1242DVe2";
			budget = budget - totalCost;
		}
        else
        {
            Console.WriteLine("Cannot book public transportation\n");
        }
        return budget;
	}

	public override void printInformation()
	{
        Console.WriteLine("Transportation: \n");
        Console.WriteLine("Start: ", this.startingPoint, "\nEnd: ", this.endingPoint);
        Console.WriteLine("\nStops Needed: ", this.stopsNeeded);
        Console.WriteLine("\nTicket Confirmation: ", ticketConfirm);
		Console.WriteLine("\n\n\n");
    }

}
