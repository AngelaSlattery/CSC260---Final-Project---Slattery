using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Bus : Transportation
{
	public int stopsNeeded;
	public int totalCost = 1;
    private bool booked = false;
    string ticketConfirm;

    public override int bookTransport(int num, int budget)
    {
        stopsNeeded = this.startTime - this.endTime;
        stopsNeeded = stopsNeeded * 30;
        totalCost = (stopsNeeded * 2);
        totalCost = totalCost * num;
        if (totalCost < budget)
        {
            booked = true;
            ticketConfirm = "12432DBW";
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
