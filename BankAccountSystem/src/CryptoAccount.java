//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #8: Robust Lab7 (Bank Account System)


import javax.swing.JOptionPane;
import java.text.NumberFormat;


public class CryptoAccount extends BankAccount
{
	//declare crypto attributes/properties
	private String cryptoType;
	private double cryptoBalance;
	
	
	//constructors
	public CryptoAccount()
	{

	}
	
	public CryptoAccount(String accountNumber, String accountFirstName, String accountLastName, String accountEmail, 		String accountPhoneNumber)
	{
		super(accountNumber, accountFirstName, accountLastName, accountEmail, accountPhoneNumber);
		this.accountNumber = getAccountNumber() + ".CRY";
		this.cryptoType = "";
		this.cryptoBalance = 0;
	}
	
	
	//mutators-setters
	protected void setCryptoType()
	{
		this.cryptoType = getValidStringInput("Enter the type of Crypto Currency:");
	}
	
	protected void setCryptoBalance(double amount)
	{
		this.cryptoBalance = amount;
	}
	
	
	//accessors-getters
	public String getCryptoType()
	{
		return cryptoType;
	}
	
	public double getCryptoBalance()
	{
		return cryptoBalance;
	}
	
	
	//crypto deposit method
	@Override
	public void deposit(double deposit)
	{
		//checks for 0 in case user hit cancel
		if(deposit != 0)
		{
			setCryptoBalance(getCryptoBalance() + deposit);
			setBankBalance(deposit);
			JOptionPane.showMessageDialog(null, "Crypto Deposit Successful!\nNew Balance: " + 				NumberFormat.getCurrencyInstance().format(getCryptoBalance()));
		}
	}
	
	
	//crypto withdraw method
	@Override
	public void withdraw(double withdraw)
	{
		//checks for 0 in case user hit cancel
		if(withdraw != 0)
		{
			if (getCryptoBalance() - withdraw < 0)
			{
				JOptionPane.showMessageDialog(null, "Cannot withdraw more than the balance in the account!", "Error", 					JOptionPane.ERROR_MESSAGE);
			}
			else
			{
				setCryptoBalance(getCryptoBalance() - withdraw);
				setBankBalance(-withdraw);
				JOptionPane.showMessageDialog(null, "Withdraw successful!\nNew Balance: " + 					NumberFormat.getCurrencyInstance().format(getCryptoBalance()));
			}
		}
	}
	
	
	//view crypto balance method
	@Override
	public void balance()
	{
		JOptionPane.showMessageDialog(null, "Account #" + getAccountNumber() + "\nBalance: " + 			NumberFormat.getCurrencyInstance().format(getCryptoBalance()));
	}
	
	
	//method to validate string inputs
	protected static String getValidStringInput(String prompt)
	{
		//infinite loop until a valid string is returned or until user hits cancel
		while (true)
		{
			String userInput = JOptionPane.showInputDialog(null, prompt, "Question", JOptionPane.QUESTION_MESSAGE);
			
			//calls the main menu if user hits cancel or 'x'
			if (userInput == null)
			{
				new MainMenuFrame();
				return null;
			}
			
			//verifies that the user input something
			if (!userInput.trim().isEmpty())
			{
				return userInput.trim();
			}
			//displays error if user did not input anything
			JOptionPane.showMessageDialog(null, "Invalid Input\n\nField cannot be left blank", "Error", 				JOptionPane.ERROR_MESSAGE);
		}
	}
}
