//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #8: Robust Lab7 (Bank Account System)


import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JComboBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;


public class MainMenuFrame extends JFrame implements ActionListener
{
	//create serialVersionUID for version control
	private static final long serialVersionUID = 1L;
	//create combo box string
	JComboBox<String> mainChoiceCmbBx;
	//flag - account can only be created if all information has been input
	protected static boolean accountCreated = false;
	
	public MainMenuFrame()
	{
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
        JLabel menuLbl = new JLabel ("<html><b>Main Menu</b></html>");
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
		String[] mainArray ={
				"Open a Bank Account", 
				"Display your Account Details",
				"View Savings Account Menu",
				"View Checking Account Menu",
				"View Crypto Account Menu",
				"View Mutual Funds Menu",
				"Exit the Application" };
		mainChoiceCmbBx = new JComboBox<>(mainArray);
		add(mainChoiceCmbBx);
		objectWidth = mainChoiceCmbBx.getPreferredSize().width;
		objectHeight = mainChoiceCmbBx.getPreferredSize().height;
        mainChoiceCmbBx.setBounds(TitleFrame.centerH(frameWidth, objectWidth), 100, objectWidth, objectHeight);
		
		
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
		int mainChoice = mainChoiceCmbBx.getSelectedIndex();
		
		switch (mainChoice)
		{
			case 0:
				//checks is a user bank account already exists
				if (accountCreated == true)
				{
					JOptionPane.showMessageDialog(null, "You have already opened a Bank Account.", "Error", 							JOptionPane.WARNING_MESSAGE);
				}
				//if no user bank account exists, closes main menu frame and opens open bank account frame
				else
				{
					this.dispose();
					new OpenBankAccountFrame();
				}
				break;
				
			case 1:
				if (validateAccount())
				{
					this.dispose();
					new DisplayDetailsFrame();
				}
				break;
				
			case 2:
				//makes sure user has a bank account
				if (validateAccount())
				{
					//string for formatting forms
					String typeSA = "Savings";
					
					//checks if the user has a savings account, if not, asks if they would like to open one
					if (Main.userSavings == null)
					{
						Main.openSpecificAccount(typeSA);
					}
					
					//checks if the user has a savings account, opens account menu if so
					if (Main.userSavings != null)
					{
						//initialize account type to pass to other methods
						BankAccount accountTypeSA = Main.userSavings;
						
						//close main menu and opens account menu
						this.dispose();
						new AccountMenuFrame(accountTypeSA, typeSA);
					}
				}
				break;

			case 3:
				//makes sure user has a bank account
				if (validateAccount())
				{
					//string for formatting forms
					String typeCA = "Checking";
					
					//checks if the user has a checking account, if not, asks if they would like to open one
					if (Main.userChecking == null)
					{
						Main.openSpecificAccount(typeCA);
					}
					
					//checks if the user has a checking account, opens account menu if so
					if (Main.userChecking != null)
					{
						//initialize account type to pass to other methods
						BankAccount accountTypeCA = Main.userChecking;
						
						//close main menu and opens account menu
						this.dispose();
						new AccountMenuFrame(accountTypeCA, typeCA);
					}
				}
				break;
				
			case 4:
				//makes sure user has a bank account
				if (validateAccount())
				{
					//string for formatting forms
					String typeCR = "Crypto Currency";
					
					//checks if the user has a crypto account, if not, asks if they would like to open one
					if (Main.userCrypto == null)
					{
						Main.openSpecificAccount(typeCR);
					}
					
					//checks if the user has a crypto account, opens account menu if so
					if (Main.userCrypto != null)
					{
						//initialize account type to pass to other methods
						BankAccount accountTypeCR = Main.userCrypto;
						
						//close main menu and opens account menu
						this.dispose();
						new AccountMenuFrame(accountTypeCR, typeCR);
					}
					
				}
				break;
				
			case 5:
				//makes sure user has a bank account
				if (validateAccount())
				{
					//string for formatting forms
					String typeMF = "Mutual Funds";
					
					//checks if the user has a mutual funds account, if not, asks if they would like to open one
					if (Main.userMF == null)
					{
						Main.openSpecificAccount(typeMF);
					}
					
					//checks if the user has a mutual funds account, opens account menu if so
					if (Main.userMF != null)
					{
						//initialize account type to pass to other methods
						BankAccount accountTypeMF = Main.userMF;
						
						//close main menu and opens account menu
						this.dispose();
						new AccountMenuFrame(accountTypeMF, typeMF);
					}	
				}
				break;
				
			case 6:
				//exit the program
				Main.endProgram(this);
				break;
		}	
	}
	
	
	//method to check if a bank account exists
	public static boolean validateAccount()
	{
		if (accountCreated == false)
		{
			JOptionPane.showMessageDialog(null, "You must first Open a Bank Account.", "Error", 							JOptionPane.ERROR_MESSAGE);
		}
		return accountCreated;
	}
}
