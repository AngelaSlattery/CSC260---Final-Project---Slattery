using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Encapsulation Example
public class payment
{
    private string cardNumber;
    private int CIV;
    private int expired;

    public string Card
    {
        get { return cardNumber; }
        set { cardNumber = value; }
    }
    public int security
    {
        get { return CIV; }
        set { CIV = value; }
    }
    public int exp
    {
        get { return expired; }
        set { expired = value; }
    }
}