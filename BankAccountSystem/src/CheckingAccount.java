//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #8: Robust Lab7 (Bank Account System)


import javax.swing.JOptionPane;
import java.text.NumberFormat;


public class CheckingAccount extends BankAccount
{
	//declare checking attributes/properties
	private int checkingOverdraftLimit;
	private double checkingBalance;
	
	
	//constructors
	public CheckingAccount()
	{

	}
	
	public CheckingAccount(String accountNumber, String accountFirstName, String accountLastName, String accountEmail, 		String accountPhoneNumber)
	{
		super(accountNumber, accountFirstName, accountLastName, accountEmail, accountPhoneNumber);
		this.accountNumber = getAccountNumber() + ".CHK";
		this.checkingBalance = 0;
	}
	
	
	//mutators-setters
	protected void setCheckingOverdraftLimit()
	{
		int randomOverdraft = (newRandom.nextInt(25) + 1) * 100;
		this.checkingOverdraftLimit = randomOverdraft;
	}
	
	protected void setCheckingBalance(double amount)
	{
		this.checkingBalance = amount;
	}
	
	
	//accessors-getters
	public double getCheckingOverdraftLimit()
	{
		return checkingOverdraftLimit;
	}
	
	public double getCheckingBalance()
	{
		return checkingBalance;
	}
	
	
	//checking deposit method
	@Override
	public void deposit(double deposit)
	{
		//checks for 0 in case user hit cancel
		if(deposit != 0)
		{
			setCheckingBalance(getCheckingBalance() + deposit);
			setBankBalance(deposit);
			JOptionPane.showMessageDialog(null, "Checking Deposit Successful!\nNew Balance: " + 				NumberFormat.getCurrencyInstance().format(getCheckingBalance()));
		}
	}
	
	
	//checking withdraw method
	@Override
	public void withdraw(double withdraw)
	{
		//checks for 0 in case user hit cancel
		if(withdraw != 0)
		{
			if (getCheckingBalance() - withdraw < -checkingOverdraftLimit)
			{
				JOptionPane.showMessageDialog(null, "Cannot withdraw more " +
					NumberFormat.getCurrencyInstance().format(getCheckingOverdraftLimit()) +
					" over the balance in the account!", "Error", JOptionPane.ERROR_MESSAGE);
			}
			else
			{
				setCheckingBalance(getCheckingBalance() - withdraw);
				setBankBalance(-withdraw);
				JOptionPane.showMessageDialog(null, "Withdraw successful!\nNew Balance: " + 					NumberFormat.getCurrencyInstance().format(getCheckingBalance()));
			}
		}
	}
	
	
	//view checking balance method
	@Override
	public void balance()
	{
		JOptionPane.showMessageDialog(null, "Account #" + getAccountNumber() + "\nBalance: " + 			NumberFormat.getCurrencyInstance().format(getCheckingBalance()));
	}
}
