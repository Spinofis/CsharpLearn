using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpLearn.OOP
{
    public class BankAccount : BankAccountAbstract
    {
	public string Number { get; }
	public string Owner { get; set; }
	public decimal Balance
	{
	    get
	    {
		decimal balance = 0;
		foreach (var item in allTransactions)
		{
		    balance += item.Amount;
		}

		return balance;
	    }

	    set { initialBalance = value; }
	}

	private List<Transaction> allTransactions = new List<Transaction>();

	private decimal initialBalance;

	public BankAccount(string name, decimal initialBalance)
	{
	    this.Owner = name;
	    this.Balance = initialBalance;
	}


	public override void MakeDeposit(decimal amount, DateTime date, string note)
	{
	    if (amount <= 0)
	    {
		throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
	    }
	    var deposit = new Transaction(amount, date, note);
	    allTransactions.Add(deposit);
	}

	public void MakeWithdrawal(decimal amount, DateTime date, string note)
	{
	    if (amount <= 0)
	    {
		throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
	    }
	    if (Balance - amount < 0)
	    {
		throw new InvalidOperationException("Not sufficient funds for this withdrawal");
	    }
	    var withdrawal = new Transaction(-amount, date, note);
	    allTransactions.Add(withdrawal);
	}

	public virtual void PerformMonthEndTransactions() { }

	
    }
}
