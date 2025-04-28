//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #8: Robust Lab7 (Bank Account System)


import javax.swing.JFrame;
import javax.swing.JOptionPane;


public class Main
{
	//declaring instances of account types
	protected static BankAccount userAccount = null;
	protected static SavingsAccount userSavings = null;
	protected static CheckingAccount userChecking = null;
	protected static CryptoAccount userCrypto = null;
	protected static MutualFunds userMF = null;

	//variable for total bank balance - i could not get it to work right when declaring it in BankAccountClass?
	protected static double bankBalance;
	
	
	//starts program: plays music and displays the title screen
	public static void main(String[] args)
	{
		BackgroundMusic.PlayBackgroundMusic("resources/audio/money.wav");
		new TitleFrame();
	}
	
	
	//method to open specific account types
	public static void openSpecificAccount(String type)
	{
		//confirms if user want to open specific account
		int openAccount = JOptionPane.showConfirmDialog(null, "Would you like to open a " + type + " Account?", 			"Account", JOptionPane.YES_NO_OPTION);
		
		//if yes, open a new account
		if (openAccount == JOptionPane.YES_OPTION)
		{
			//switch case to open the correct type of account
			switch (type)
			{
				//opens a savings account for user
				case "Savings":
					userSavings = new SavingsAccount(userAccount.getAccountNumber(), 									userAccount.getAccountFirstName(), userAccount.getAccountLastName(), 									userAccount.getAccountEmail(), userAccount.getAccountPhoneNumber());
					userSavings.setSavingsInterestRate();
					
					JOptionPane.showMessageDialog(null, "Savings Account has been successfully created.",
							"Open Account", JOptionPane.PLAIN_MESSAGE);
					break;
					
				//opens a checking account for user
				case "Checking":
					userChecking = new CheckingAccount(userAccount.getAccountNumber(), 									userAccount.getAccountFirstName(), userAccount.getAccountLastName(), 									userAccount.getAccountEmail(), userAccount.getAccountPhoneNumber());
					userChecking.setCheckingOverdraftLimit();
					
					JOptionPane.showMessageDialog(null, "Checking Account has been successfully created.",
							"Open Account", JOptionPane.PLAIN_MESSAGE);
					break;
				
				//opens a crypto account for user
				case "Crypto Currency":
					userCrypto = new CryptoAccount(userAccount.getAccountNumber(), 									userAccount.getAccountFirstName(), userAccount.getAccountLastName(), 									userAccount.getAccountEmail(), userAccount.getAccountPhoneNumber());
					userCrypto.setCryptoType();
					
					JOptionPane.showMessageDialog(null, "Crypto Currency Account has been successfully created.", 							"Open Account", JOptionPane.PLAIN_MESSAGE);
					break;
					
				//opens a mutual funds account for user
				case "Mutual Funds":
					userMF = new MutualFunds(userAccount.getAccountNumber(), 									userAccount.getAccountFirstName(), userAccount.getAccountLastName(), 									userAccount.getAccountEmail(), userAccount.getAccountPhoneNumber());
					userMF.setMFRiskLevel();
					
					JOptionPane.showMessageDialog(null, "Mutual Funds Account has been successfully created.",
							"Open Account", JOptionPane.PLAIN_MESSAGE);
			}
		}
	}
	
	
	//thank user and exit program
	public static void endProgram(JFrame frame)
	{
		//verifies if user really wants to exit program
		int exit = JOptionPane.showConfirmDialog(null, "Are you sure you want to exit the program?", "Exit Program", 			JOptionPane.YES_NO_OPTION);
		
		//if yes, thanks user and exits program
		if (exit == JOptionPane.YES_OPTION)
		{
			frame.dispose();
			new ExitProgram();
		}
	}
}
