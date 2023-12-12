using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class Rental_Car : Transportation
{
    int totalCost;
	bool downPay;
	public bool book;
	public int numVec;
	public string confirmationCode;

    public override int bookTransport(int num, int budget)
    {
		numVec = checkSize(num);
		if ( budget - (numVec*500) >= 0)
		{
			book = true;
			budget = budget - (numVec*500);
			confirmationCode = "1243BDIw";
			return budget;
		}
		else
		{
			Console.WriteLine("You do not have enough money to Rent a Car");
            return budget;
        }
    }
	public override void printInformation()
	{
		Console.WriteLine("Rental Car: \n");
		Console.WriteLine("Vehicles: ", this.numVec);
		Console.WriteLine("\nConfirmation Code: ", this.confirmationCode);
		Console.WriteLine("\n\n\n");

	}
	//See if family will fit in one car
	private int checkSize( int riders)
	{
		int vec = riders / 5;
		if ( vec == 0)
		{
			return 1;
		}
		return vec;
	}
}
