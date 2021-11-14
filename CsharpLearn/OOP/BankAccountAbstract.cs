using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn.OOP
{
    public abstract class BankAccountAbstract
    {
	public abstract void MakeDeposit(decimal amount, DateTime date, string note);
	

	public void MakeWithdrawal(decimal amount, DateTime date, string note)
	{
	    
	}
    }
}
