using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Metro : Transportation
{
	private int stopsNeeded;
	private int totalCost;
	public bool booked;

	public override int bookTransport( int num, int budget)
	{
		stopsNeeded = this.startTime - this.endTime;
		stopsNeeded = stopsNeeded * 15;
		totalCost = (stopsNeeded * 1);
		totalCost = totalCost * num;
		if(totalCost >= budget)
		{
			booked = true;
			budget = budget - totalCost;
		}
		return budget;
	}

	public void printInformation()
	{
		throw new NotImplementedException();
	}

}
