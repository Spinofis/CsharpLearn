using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn.OOP
{
    public class LineOfCreditAccount : BankAccount
    {
	public LineOfCreditAccount(string name, decimal initialBalance) : base(name, initialBalance)
	{

	}

	public sealed override void PerformMonthEndTransactions()
	{
	    if (Balance < 0)
	    {
		// Negate the balance to get a positive interest charge:
		var interest = -Balance * 0.07m;
		MakeWithdrawal(interest, DateTime.Now, "Charge monthly interest");
	    }
	}
    }
}
