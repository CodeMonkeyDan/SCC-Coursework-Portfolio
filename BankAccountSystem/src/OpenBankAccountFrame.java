//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #8: Robust Lab7 (Bank Account System)


import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.regex.Pattern;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JTextField;


public class OpenBankAccountFrame extends JFrame implements ActionListener
{
	//create serialVersionUID for version control
	private static final long serialVersionUID = 1L;
	//declare variables
    JTextField fNameTxtFld = new JTextField(25);
    JTextField lNameTxtFld = new JTextField(25);
    JTextField emailTxtFld = new JTextField(25);
    JTextField phoneTxtFld = new JTextField(25);

	
	public OpenBankAccountFrame()
	{
		//variables for frame & objects, heights & widths
		int frameWidth = 400;
		int frameHeight = 255;
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
        JLabel menuLbl = new JLabel ("<html><b>Open Bank Account</b></html>");
        add(menuLbl);
		objectWidth = menuLbl.getPreferredSize().width;
		objectHeight = menuLbl.getPreferredSize().height;
        menuLbl.setBounds(TitleFrame.centerH(frameWidth, objectWidth), 30, objectWidth, objectHeight);
        
        JLabel fNameLbl = new JLabel ("First Name:");
        add(fNameLbl);
		objectWidth = fNameLbl.getPreferredSize().width;
		objectHeight = fNameLbl.getPreferredSize().height;
        fNameLbl.setBounds(50, 70, objectWidth, objectHeight);
        add(fNameTxtFld);
        fNameTxtFld.setBounds(160, 70, 176, objectHeight);

        JLabel lNameLbl = new JLabel ("Last Name:");
        add(lNameLbl);
		objectWidth = lNameLbl.getPreferredSize().width;
		objectHeight = lNameLbl.getPreferredSize().height;
        lNameLbl.setBounds(50, 90, objectWidth, objectHeight);
        add(lNameTxtFld);
        lNameTxtFld.setBounds(160, 90, 176, objectHeight);

        JLabel emailLbl = new JLabel ("Email:");
        add(emailLbl);
		objectWidth = emailLbl.getPreferredSize().width;
		objectHeight = emailLbl.getPreferredSize().height;
        emailLbl.setBounds(50, 110, objectWidth, objectHeight);
        add(emailTxtFld);
        emailTxtFld.setBounds(160, 110, 176, objectHeight);

        JLabel phoneLbl = new JLabel ("Phone Number:");
        add(phoneLbl);
		objectWidth = phoneLbl.getPreferredSize().width;
		objectHeight = phoneLbl.getPreferredSize().height;
        phoneLbl.setBounds(50, 130, objectWidth, objectHeight);
        add(phoneTxtFld);
        phoneTxtFld.setBounds(160, 130, 176, objectHeight);


        //create and add button
        JButton continueBtn = new JButton ("Continue");
        add(continueBtn);
        continueBtn.setBounds(275, 170, 90, 30);
        continueBtn.addActionListener(this);
	}

	
	//methods for action listener
	@Override
	public void actionPerformed(ActionEvent e)
	{
		if (!validateFields())
		{
			return;
		}
		
		//formats phone number before storing in bank account
		String formattedPhoneNum = formatPhoneNum(phoneTxtFld.getText());
		
		//create bank account if all fields are verified
		Main.userAccount = new BankAccount();
		Main.userAccount.setAccountFirstName(fNameTxtFld.getText());
		Main.userAccount.setAccountLastName(lNameTxtFld.getText());
		Main.userAccount.setAccountEmail(emailTxtFld.getText());
		Main.userAccount.setAccountPhoneNumber(formattedPhoneNum);
		//set flag to true only after all information has been collected
		MainMenuFrame.accountCreated = true;
		JOptionPane.showMessageDialog(null, "Bank Account has been successfully created.", "Bank Account", 			JOptionPane.PLAIN_MESSAGE);
		
		this.dispose();
		new MainMenuFrame();
	}
	
	
	//method to validate fields
	private boolean validateFields()
	{
		//check for empty fields
		if (fNameTxtFld.getText().isEmpty() || lNameTxtFld.getText().isEmpty() || emailTxtFld.getText().isEmpty() || 			phoneTxtFld.getText().isEmpty())
		{
			JOptionPane.showMessageDialog(null, "All fields must be complete.", "Error", 				JOptionPane.WARNING_MESSAGE);
			return false;
		}
		
		//validate email format
		if (!isValidEmail(emailTxtFld.getText()))
		{
            JOptionPane.showMessageDialog(null, "Invalid Email Format\n\nPlease enter a valid email address.", 				"Error", JOptionPane.ERROR_MESSAGE);
            return false;
		}
		
		//validate phone number format
		if (!isValidPhoneNumber(phoneTxtFld.getText()))
		{
        JOptionPane.showMessageDialog(null, "Invalid Phone Number\n\nPlease enter a valid 10-digit phone number.", 				"Error", JOptionPane.ERROR_MESSAGE);
        return false;
		}
		
		//return true if all checks pass
		return true;
	}
	
	//method to validate email inputs
    private static boolean isValidEmail(String email)
    {
        //define a regex pattern for a valid email
        String emailRegex = "^[A-Za-z0-9+_.-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$";
        //compile the regex pattern
        Pattern pattern = Pattern.compile(emailRegex);
        
        boolean isMatch = pattern.matcher(email).matches();
        
        return isMatch;
    }
    
    
    //method to validate phone number inputs
    private static boolean isValidPhoneNumber(String phone)
    {
        //define regex patterns for a valid phone number
        String phoneRegex = "^(\\(\\d{3}\\)[-.\\s]?\\d{3}[-.\\s]?\\d{4})$|^(\\d{3})[-.\\s]?(\\d{3})[-.\\s]?(\\d{4})$";
        //compile the regex pattern
        Pattern pattern = Pattern.compile(phoneRegex);

        boolean isMatch = pattern.matcher(phone).matches();
        
        return isMatch;
    }
    
    
    //method to format phone number
    private static String formatPhoneNum(String num)
    {
    	//removes all non-digit characters
    	String digits = num.replaceAll("\\D", "");
    	
    	//returns formatted phone number
    	return digits.substring(0, 3) + "." + digits.substring(3, 6) + "." + digits.substring(6);
    }
}
