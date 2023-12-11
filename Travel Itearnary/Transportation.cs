using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I want my transportation class to be polymorphism with the forms along with abstract
public class Transportation
{ 
	int allocatedTime;
	string startingPoint;
	string endingPoint;
	string startTime;
	string endTime;

	//public abstract void book();
    public string cheapestOption(Rental_Car rentalCar, Bus bus, Metro metro)
	{
		throw new NotImplementedException();
	}

	public string fastestOption(Rental_Car rentalCar, Bus bus, Metro metro)
	{
		throw new NotImplementedException();
	}

	public void bookTransport()
	{
		throw new NotImplementedException();
	}
	
}
