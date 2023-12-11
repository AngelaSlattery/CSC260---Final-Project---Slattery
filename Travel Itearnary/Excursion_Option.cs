using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Excursion_Option
{
	public string name;
	public int excursionCost;
	private string confirmationNum;
	bool booked;
	string day;

	public Excursion_Option( string name, int cost  )
	{
		this.name = name;
		this.excursionCost = cost;
    }
	public void printConfirmation( int cost, string con, int numPpl)
	{
		Console.WriteLine("Name: " + name + "\n");
        Console.WriteLine("ConfirmationNum: " + con + "\n");
		Console.WriteLine("Number of Tickets: " + numPpl + "\n");
    }

	public int transportation()
	{
		throw new NotImplementedException();
	}
}
