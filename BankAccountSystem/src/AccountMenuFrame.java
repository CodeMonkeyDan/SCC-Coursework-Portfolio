//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #8: Robust Lab7 (Bank Account System)


import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.text.NumberFormat;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;


public class AccountMenuFrame extends JFrame implements ActionListener
{
	//create serialVersionUID for version control
	private static final long serialVersionUID = 1L;
	//create combo box string
	JComboBox<String> accountChoiceCmbBx;
	//create account type to pass in so correct account type is manipulated
	BankAccount accountType;

	
	public AccountMenuFrame(BankAccount aT, String type)
	{
		accountType = aT;
		
		//variables for frame & objects, heights & widths
		int frameWidth = 400;
		int frameHeight = 235;
		int objectWidth;
		int objectHeight;

		
		//set a custom icon if previously found
		if (TitleFrame.iconLoaded)
		{
			setIconImage(TitleFrame.icon.getImage());
		}
		
		
		//create frame
        setTitle ("DMS Bank Account System");
        setSize (frameWidth, frameHeight);
        setResizable (false);
        //closes application if user hits the 'X'
        setDefaultCloseOperation (JFrame.EXIT_ON_CLOSE);
        //centers the window
        setLocationRelativeTo (null);
        //disables layout managers for manual positioning of objects
        setLayout (null);
        setVisible (true);
        
        
        //create and add labels, centering horizontally based on frame size
        JLabel menuLbl = new JLabel ("<html><b>" + type + " Menu</b></html>");
        add(menuLbl);
		objectWidth = menuLbl.getPreferredSize().width;
		objectHeight = menuLbl.getPreferredSize().height;
        menuLbl.setBounds(TitleFrame.centerH(frameWidth, objectWidth), 30, objectWidth, objectHeight);
        
        JLabel mainChoiceLbl = new JLabel ("What would you like to do today?");
        add(mainChoiceLbl);
		objectWidth = mainChoiceLbl.getPreferredSize().width;
		objectHeight = mainChoiceLbl.getPreferredSize().height;
        mainChoiceLbl.setBounds(TitleFrame.centerH(frameWidth, objectWidth), 70, objectWidth, objectHeight);
        
        
		//add combo box to frame
		String[] accountArray ={
				"Make a Deposit", 
				"Make a Withdraw",
				"Display Balance",
				"Return to Main Menu",
				"Exit the Application" };
		accountChoiceCmbBx = new JComboBox<>(accountArray);
		add(accountChoiceCmbBx);
		objectWidth = accountChoiceCmbBx.getPreferredSize().width;
		objectHeight = accountChoiceCmbBx.getPreferredSize().height;
        accountChoiceCmbBx.setBounds(TitleFrame.centerH(frameWidth, objectWidth), 100, objectWidth, objectHeight);
		
		
        //create and add button
        JButton continueBtn = new JButton ("Continue");
        add(continueBtn);
        continueBtn.setBounds(275, 150, 90, 30);
        continueBtn.addActionListener(this);
	}


	//methods for action listener
	@Override
	public void actionPerformed(ActionEvent e)
	{
		int accountChoice = accountChoiceCmbBx.getSelectedIndex();
		
		switch (accountChoice)
		{
			//deposit into specific bank account
			case 0:
			{
				
				//asks user how much they would like to deposit into account
				accountType.deposit(getValidDoubleInput("How much would you like to deposit?"
						+ "\n(maximum $100,000.00 per deposit)", .01, 100000));
				break;
			}
			
			//withdraw from specific bank account
			case 1:
			{
				//asks user how much they would like to withdraw from account
				accountType.withdraw(getValidDoubleInput("How much would you like to withdraw?"
						+ "\n(maximum $10,000.00 per withdraw)", .01, 10000));
				break;
			}
			
			//display balance of specific bank account
			case 2:
			{
				//displays savings account balance
				accountType.balance();
				break;
			}
			
			//return to main menu
			case 3:
			{
				//return to main menu
				this.dispose();
				new MainMenuFrame();
				break;
			}
			
			//exit the program
			case 4:
			{
				//exit the program
				Main.endProgram(this);
				break;
			}
		}
	}
	
	
	//method to validate double inputs
	protected static double getValidDoubleInput(String prompt, double min, double max)
	{
		//infinite loop until a valid double is returned or until user hits cancel
		while (true)
		{
			String userInput = JOptionPane.showInputDialog(null, prompt, "Question", JOptionPane.QUESTION_MESSAGE);
			
			//calls the main menu if user hits cancel or 'x'
			if (userInput == null)
			{
				new MainMenuFrame();
				return 0;
			}
			
			//verifies that the user input something
			if (userInput.trim().isEmpty())
			{
				//displays error if user did not input anything
				JOptionPane.showMessageDialog(null, "Invalid Input\n\nField cannot be left blank", "Error", 					JOptionPane.ERROR_MESSAGE);
				continue; //if user input was empty, returns to the beginning of the loop
			}
			
			//verifies that the user input a double
			try
			{
				double number = Double.parseDouble(userInput.trim());
				//verifies the double was within the acceptable range
				if (number >= min && number <= max)
				{
					return number;
				}
				else //displays error if the input was out of range
				{
					JOptionPane.showMessageDialog(null, "Invalid Input\n\nPlease enter a number between " + 						NumberFormat.getCurrencyInstance().format(min) + " and " + 						NumberFormat.getCurrencyInstance().format(max), "Error", JOptionPane.WARNING_MESSAGE);
				}
			}
			catch (NumberFormatException e) //displays error if the user did not input a double
			{
				JOptionPane.showMessageDialog(null,  "Invalid Input\n\nPlease enter a valid number", "Error", 					JOptionPane.ERROR_MESSAGE);
			}
		}
	}
}
