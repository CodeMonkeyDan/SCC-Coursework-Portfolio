//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #8: Robust Lab7 (Bank Account System)


import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.text.NumberFormat;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;


public class DisplayDetailsFrame extends JFrame implements ActionListener
{
	//create serialVersionUID for version control
	private static final long serialVersionUID = 1L;
	int frameWidth = 400;
	int objectWidth;
	int objectHeight;
	int objectVerticalPlacement = 0;

	
	public DisplayDetailsFrame()
	{
		//set a custom icon if previously found
		if (TitleFrame.iconLoaded)
		{
			setIconImage(TitleFrame.icon.getImage());
		}
		
		
		//create frame
        setTitle ("DMS Bank Account System");
        //closes application if user hits the 'X'
        setDefaultCloseOperation (JFrame.EXIT_ON_CLOSE);
        //disables layout managers for manual positioning of objects
        setLayout (null);
        
        
        //create and add labels, centering horizontally based on frame size
        addLabel("<html><b>Bank Account Details</b></html>", true);
        objectVerticalPlacement += 10;
        
        //adds main account details
        addLabel("<html><u>Main Account</u></html>", true);
        addLabel("User: " + Main.userAccount.getAccountFirstName() + " " + Main.userAccount.getAccountLastName(), 			false);
        addLabel("Account # " + Main.userAccount.getAccountNumber(), false);
        addLabel("Phone Number: " + Main.userAccount.getAccountPhoneNumber(), false);
        addLabel("Email: " + Main.userAccount.getAccountEmail(), false);
        addLabel("<html><b>Total Account Balance: " +
        	NumberFormat.getCurrencyInstance().format(Main.bankBalance) + "</b></html>", false);

        
        //checks if user has a savings account, and displays details if yes
        if (Main.userSavings != null)
        {
            addLabel("<html><u>Savings Account</u></html>", true);
            addLabel("Account # " + Main.userSavings.getAccountNumber(), false);
            addLabel("Interest Rate: " + Main.userSavings.getSavingsInterestRate(), false);
            addLabel("<html><b>Savings Account Balance: " +
            	NumberFormat.getCurrencyInstance().format(Main.userSavings.getSavingsBalance()) + "</b></html>", false);
        }
        
        
        //checks if user has a checking account, and displays details if yes
        if (Main.userChecking != null)
        {
            addLabel("<html><u>Checking Account</u></html>", true);
            addLabel("Account # " + Main.userChecking.getAccountNumber(), false);
            addLabel("Overdraft Limit: " + 				NumberFormat.getCurrencyInstance().format(Main.userChecking.getCheckingOverdraftLimit()), false);
            addLabel("<html><b>Checking Account Balance: " +
            	NumberFormat.getCurrencyInstance().format(Main.userChecking.getCheckingBalance()) + "</b></html>", 				false);
        }
        
        
        //checks if user has a crypto account, and displays details if yes
        if (Main.userCrypto != null)
        {
            addLabel("<html><u>Cryptocurrency Account</u></html>", true);
            addLabel("Account # " + Main.userCrypto.getAccountNumber(), false);
            addLabel("Crypto Type: " + Main.userCrypto.getCryptoType(), false);
            addLabel("<html><b>Crypto Account Balance: " +
            	NumberFormat.getCurrencyInstance().format(Main.userCrypto.getCryptoBalance()) + "</b></html>", false);
        }
        
        
        //checks if user has a mutual funds account, and displays details if yes
        if (Main.userMF != null)
        {
            addLabel("<html><u>Mutual Funds Account</u></html>", true);
            addLabel("Account # " + Main.userMF.getAccountNumber(), false);
            addLabel("Risk Level: " + Main.userMF.getMFRiskLevel(), false);
            addLabel("<html><b>Mutual Funds Account Balance: " +
            		NumberFormat.getCurrencyInstance().format(Main.userMF.getMFBalance()) + "</b></html>", false);
        }
        
        
        //create and add button
        JButton closeBtn = new JButton ("Close");
        add(closeBtn);
        objectVerticalPlacement += 40;
        closeBtn.setBounds(275, objectVerticalPlacement, 90, 30);
        closeBtn.addActionListener(this);
        
        
		//variables for frame & objects, heights & widths
		int frameHeight = objectVerticalPlacement + 85;
        setSize (frameWidth, frameHeight);
        setResizable (false);
        //centers the window
        setLocationRelativeTo (null);
        setVisible (true);
	}


	//methods for Action Listener
	@Override
	public void actionPerformed(ActionEvent e)
	{
		this.dispose();
		new MainMenuFrame();		
	}
	
	
	//helper method to add labels
	private void addLabel(String text, boolean isTitle)
	{
	    JLabel label = new JLabel(text);
	    add(label);
	    objectWidth = label.getPreferredSize().width;
	    objectHeight = label.getPreferredSize().height;
	    objectVerticalPlacement += isTitle ? 30 : 20;
	    label.setBounds(TitleFrame.centerH(frameWidth, objectWidth), objectVerticalPlacement, objectWidth, 			objectHeight);
	}
}
