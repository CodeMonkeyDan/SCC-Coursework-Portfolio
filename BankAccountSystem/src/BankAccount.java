//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #8: Robust Lab7 (Bank Account System)


import java.util.Random;


public class BankAccount
{
	//declare bank account attributes/properties
	protected String accountNumber;
	private String accountFirstName;
	private String accountLastName;
	private String accountEmail;
	private String accountPhoneNumber;

	
	//create random
	static Random newRandom = new Random();
	
	
	//constructors
	public BankAccount()
	{
		setAccountNumber();
	}
	
	public BankAccount(String number, String fName, String lName, String email, String phone)
	{
		this.accountNumber = number;
		this.accountFirstName = fName;
		this.accountLastName = lName;
		this.accountEmail = email;
		this.accountPhoneNumber = phone;
	}
	
	
	//mutators-setters
	protected void setAccountNumber()
	{
		this.accountNumber = String.valueOf(newRandom.nextInt(900000000) + 100000000);
	}
	
	protected void setAccountFirstName(String first)
	{
		this.accountFirstName = first;
	}
	
	protected void setAccountLastName(String last)
	{
		this.accountLastName = last;
	}
	
	protected void setAccountEmail(String email)
	{
		this.accountEmail = email;
	}
	
	protected void setAccountPhoneNumber(String phone)
	{
		this.accountPhoneNumber = phone;
	}
	
	protected void setBankBalance(double amount)
	{
		Main.bankBalance += amount;
	}
	
	
	//accessors-getters
	public String getAccountNumber()
	{
		return accountNumber;
	}
	
	public String getAccountFirstName()
	{
		return accountFirstName;
	}
	
	public String getAccountLastName()
	{
		return accountLastName;
	}
	
	public String getAccountEmail()
	{
		return accountEmail;
	}
	
	public String getAccountPhoneNumber()
	{
		return accountPhoneNumber;
	}
	
	
	//methods to be overridden
	public void deposit(double deposit)
	{
		
	}
	public void withdraw(double withdraw)
	{
		
	}
	public void balance()
	{
		
	}
}
