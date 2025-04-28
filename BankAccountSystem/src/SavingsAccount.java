//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #8: Robust Lab7 (Bank Account System)


import javax.swing.JOptionPane;
import java.text.NumberFormat;


public class SavingsAccount extends BankAccount
{
	//declare savings attributes/properties
	private double savingsInterestRate;
	private double savingsBalance;
	
	
	//constructors
	public SavingsAccount()
	{

	}
	
	public SavingsAccount(String accountNumber, String accountFirstName, String accountLastName, String accountEmail, 		String accountPhoneNumber)
	{
		super(accountNumber, accountFirstName, accountLastName, accountEmail, accountPhoneNumber);
		this.accountNumber = getAccountNumber() + ".SAV";
		this.savingsBalance = 0;
	}
	
	
	//mutators-setters
	protected void setSavingsInterestRate()
	{
		double randomInterest = 0.5 + (5.5 - 0.5) * newRandom.nextDouble();
		randomInterest = Math.round(randomInterest * 100.0) / 100.0;
		this.savingsInterestRate = randomInterest;
	}
	
	protected void setSavingsBalance(double amount)
	{
		this.savingsBalance = amount;
	}
	
	
	//accessors-getters
	public double getSavingsInterestRate()
	{
		return savingsInterestRate;
	}
	public double getSavingsBalance()
	{
		return savingsBalance;
	}
	
	
	//savings deposit method
	@Override
	public void deposit(double deposit)
	{
		//checks for 0 in case user hit cancel
		if(deposit != 0)
		{
			setSavingsBalance(getSavingsBalance() + deposit);
			setBankBalance(deposit);
			JOptionPane.showMessageDialog(null, "Savings Deposit Successful!\nNew Balance: " + 			NumberFormat.getCurrencyInstance().format(getSavingsBalance()));
		}
	}
	
	//savings withdraw method
	@Override
	public void withdraw(double withdraw)
	{
		//checks for 0 in case user hit cancel
		if(withdraw != 0)
		{
			if (getSavingsBalance() - withdraw < 0)
			{
				JOptionPane.showMessageDialog(null, "Cannot withdraw more than the balance in the account!", "Error", 					JOptionPane.ERROR_MESSAGE);
			}
			else
			{
				setSavingsBalance(getSavingsBalance() - withdraw);
				setBankBalance(-withdraw);
				JOptionPane.showMessageDialog(null, "Withdraw successful!\nNew Balance: " + 					NumberFormat.getCurrencyInstance().format(getSavingsBalance()));
			}
		}
	}
	
	
	//view savings balance method
	@Override
	public void balance()
	{
		JOptionPane.showMessageDialog(null, "Account #" + getAccountNumber() + "\nBalance: " + 			NumberFormat.getCurrencyInstance().format(getSavingsBalance()));
	}
}
