using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Excursion_Option
{
	public string name;
	public int excursionCost;
	bool booked;
	string day;



	public Excursion_Option( string name, int cost  )
	{
		this.name = name;
		this.excursionCost = cost;
    }
	public void printConfirmation()
	{
		throw new NotImplementedException();
	}

	public int transportation()
	{
		throw new NotImplementedException();
	}
}
