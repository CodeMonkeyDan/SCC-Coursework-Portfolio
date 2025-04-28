//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Final Project: Escaping Death


import java.awt.Color;
import java.awt.Font;
import java.awt.Image;
import java.awt.MediaTracker;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;


public class ExitProgram extends JFrame implements ActionListener
{
	//create serialVersionUID for version control
	private static final long serialVersionUID = 1L;
	
	//declare image for exit frame
	private ImageIcon image;
	
	
	public ExitProgram()
	{
		//variables for frame & objects, heights & widths
		int frameWidth = 1024;
		int frameHeight = 1024;
		int objectWidth;
		int objectHeight;
		
		
		//create frame
        setTitle ("Escaping Death");
        setSize (frameWidth, frameHeight);
        setResizable (false);
        // CLOSE APPLICATION IF USER HITS THE 'X'
        setDefaultCloseOperation (JFrame.EXIT_ON_CLOSE);
        // CENTERS THE WINDOW
        setLocationRelativeTo (null);
        // DISABLES LAYOUT MANAGERS FOR MANUAL POSITIONING OF OBJECTS
        setLayout (null);
        getContentPane().setBackground(Color.BLACK);
        
		// SET A CUSTOM ICON IF PREVIOUSLY FOUND
		if (Main.iconLoaded)
		{
			setIconImage(Main.icon.getImage());
		}
        
        
        //create and add labels, centering horizontally based on frame size
        JLabel thankYouLbl = new JLabel ("<html><b>Thanks for playing, I hope you enjoyed it!</b></html>");
        thankYouLbl.setFont(new Font("Arial", Font.BOLD, 24));
        thankYouLbl.setForeground(Color.RED);
        add(thankYouLbl);
		objectWidth = thankYouLbl.getPreferredSize().width;
		objectHeight = thankYouLbl.getPreferredSize().height;
        thankYouLbl.setBounds(Main.centerH(frameWidth, objectWidth), 200, objectWidth, objectHeight);
        
        JLabel createdByLbl = new JLabel ("created by:");
        createdByLbl.setFont(new Font("Arial", Font.BOLD, 24));
        createdByLbl.setForeground(Color.RED);
        add(createdByLbl);
		objectWidth = createdByLbl.getPreferredSize().width;
		objectHeight = createdByLbl.getPreferredSize().height;
        createdByLbl.setBounds(Main.centerH(frameWidth, objectWidth), 400, objectWidth, objectHeight);
        
        JLabel signatureLbl = new JLabel ("<html><i>CodeMonkeyDan</i></html>");
        signatureLbl.setFont(new Font("Arial", Font.BOLD, 24));
        signatureLbl.setForeground(Color.RED);
        add(signatureLbl);
		objectWidth = signatureLbl.getPreferredSize().width;
		objectHeight = signatureLbl.getPreferredSize().height;
        signatureLbl.setBounds(Main.centerH(frameWidth, objectWidth), 450, objectWidth, objectHeight);
        
        
		//fetch code monkey image path
		String imagePath = System.getProperty("iconPath", "resources/images/codemonkey-full.png");
		try
		{
			image = new ImageIcon (imagePath);
			
            //check if the image failed to load
            if (image.getImageLoadStatus() != MediaTracker.COMPLETE)
            {
                throw new Exception("Image file not loaded properly: " + imagePath);
            }
            
            //scale the image
            Image scaledImage = image.getImage().getScaledInstance(300,300, Image.SCALE_SMOOTH);
            ImageIcon scaledIcon = new ImageIcon(scaledImage);
			
			JLabel imageLbl = new JLabel(scaledIcon);
			add(imageLbl);
			objectWidth = imageLbl.getPreferredSize().width;
			objectHeight = imageLbl.getPreferredSize().height;
	        imageLbl.setBounds(Main.centerH(frameWidth, objectWidth), 500, objectWidth, objectHeight);
		}
		catch (Exception e)
		{
			JOptionPane.showMessageDialog(this, e.getMessage(), "Image Load Error", 				JOptionPane.ERROR_MESSAGE);
		}
        
		
        //create and add button
        JButton exitBtn = new JButton ("Exit");
        exitBtn.setBackground(Color.BLACK);						// SET BACKGROUND TO BLACK
        exitBtn.setForeground(Color.RED);						// SET TEXT COLOR TO RED
        exitBtn.setFont(new Font("Arial", Font.BOLD, 16));		// SET CUSTOM FONT
        exitBtn.setBorderPainted(false);						// REMOVE BUTTON BORDER
        exitBtn.setFocusPainted(false);							// REMOVE FOCUS OUTLINE
        exitBtn.setBounds(900, 940, 90, 30);
        add(exitBtn, 0);
        exitBtn.addActionListener(this);
        
        
        setVisible (true);
	}


	//method for action listener
	@Override
	public void actionPerformed(ActionEvent e)
	{
		System.exit(0);
	}
}
