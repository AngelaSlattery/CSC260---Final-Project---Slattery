using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I want my transportation class to be polymorphism with the forms along with abstract
abstract class Transportation
{ 
	public int allocatedTime;
	public string startingPoint;
	public string endingPoint;
	public int startTime;
	public int endTime;

	//public abstract void book();
	public abstract int bookTransport(int num, int totalCost);
	public abstract void printInformation();

	public Transportation()
	{

	}

	
}
