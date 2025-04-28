//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #8: Robust Lab7 (Bank Account System)


import javax.swing.JOptionPane;
import java.text.NumberFormat;


public class MutualFunds extends BankAccount
{
	//declare mutual fund attributes/properties
	private String mfRiskLevel;
	private double mfBalance;
	
	
	//constructors
	public MutualFunds()
	{

	}
	
	public MutualFunds(String accountNumber, String accountFirstName, String accountLastName, String accountEmail,
			String accountPhoneNumber)
	{
		super(accountNumber, accountFirstName, accountLastName, accountEmail, accountPhoneNumber);
		this.accountNumber = getAccountNumber() + ".MFS";
		this.mfRiskLevel = "";
		this.mfBalance = 0;
	}
	
	
	//mutators-setters
	protected void setMFRiskLevel()
	{
		//randomly generate risk level
	    String[] riskLevels = { "Low", "Medium", "High" };
	    int level = newRandom.nextInt(3);
	    this.mfRiskLevel = riskLevels[level];
	}
	
	protected void setMFBalance(double amount)
	{
		this.mfBalance = amount;
	}
	
	
	//accessors-getters
	public String getMFRiskLevel()
	{
		return mfRiskLevel;
	}
	
	public double getMFBalance()
	{
		return mfBalance;
	}
	
	
	//mutual funds deposit method
	@Override
	public void deposit(double deposit)
	{
		//checks for 0 in case user hit cancel
		if(deposit != 0)
		{
			setMFBalance(getMFBalance() + deposit);
			setBankBalance(deposit);
			JOptionPane.showMessageDialog(null, "Mutual Funds Deposit Successful!\nNew Balance: " + 				NumberFormat.getCurrencyInstance().format(getMFBalance()));
		}
	}
	
	
	//mutual funds withdraw method
	@Override
	public void withdraw(double withdraw)
	{
		//checks for 0 in case user hit cancel
		if(withdraw != 0)
		{
			if (getMFBalance() - withdraw < 0)
			{
				JOptionPane.showMessageDialog(null, "Cannot withdraw more than the balance in the account!", "Error", 					JOptionPane.ERROR_MESSAGE);
			}
			else
			{
				setMFBalance(getMFBalance() - withdraw);
				setBankBalance(-withdraw);
				JOptionPane.showMessageDialog(null, "Withdraw successful!\nNew Balance: " + 					NumberFormat.getCurrencyInstance().format(getMFBalance()));
			}
		}
	}
	
	
	//view mutual funds balance method
	@Override
	public void balance()
	{
		JOptionPane.showMessageDialog(null, "Account #" + getAccountNumber() + "\nBalance: " + 			NumberFormat.getCurrencyInstance().format(getMFBalance()));
	}
}