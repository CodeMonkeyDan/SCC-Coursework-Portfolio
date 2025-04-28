//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #8: Robust Lab7 (Bank Account System)


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
		int frameWidth = 400;
		int frameHeight = 305;
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
        JLabel thankYouLbl = new JLabel ("<html><b>Thank you for choosing DMS Bank Account System!</b></html>");
        add(thankYouLbl);
		objectWidth = thankYouLbl.getPreferredSize().width;
		objectHeight = thankYouLbl.getPreferredSize().height;
        thankYouLbl.setBounds(TitleFrame.centerH(frameWidth, objectWidth), 30, objectWidth, objectHeight);
        
        JLabel goodByeLbl = new JLabel ("Good Bye");
        add(goodByeLbl);
		objectWidth = goodByeLbl.getPreferredSize().width;
		objectHeight = goodByeLbl.getPreferredSize().height;
		goodByeLbl.setBounds(TitleFrame.centerH(frameWidth, objectWidth), 50, objectWidth, objectHeight);
        
        JLabel createdByLbl = new JLabel ("created by:");
        add(createdByLbl);
		objectWidth = createdByLbl.getPreferredSize().width;
		objectHeight = createdByLbl.getPreferredSize().height;
        createdByLbl.setBounds(TitleFrame.centerH(frameWidth, objectWidth), 90, objectWidth, objectHeight);
        
        JLabel signatureLbl = new JLabel ("<html><i>CodeMonkeyDan</i></html>");
        add(signatureLbl);
		objectWidth = signatureLbl.getPreferredSize().width;
		objectHeight = signatureLbl.getPreferredSize().height;
        signatureLbl.setBounds(TitleFrame.centerH(frameWidth, objectWidth), 110, objectWidth, objectHeight);
        
        
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
            Image scaledImage = image.getImage().getScaledInstance(75, 75, Image.SCALE_SMOOTH);
            ImageIcon scaledIcon = new ImageIcon(scaledImage);
			
			JLabel imageLbl = new JLabel(scaledIcon);
			add(imageLbl);
			objectWidth = imageLbl.getPreferredSize().width;
			objectHeight = imageLbl.getPreferredSize().height;
	        imageLbl.setBounds(TitleFrame.centerH(frameWidth, objectWidth), 130, objectWidth, objectHeight);
		}
		catch (Exception e)
		{
			JOptionPane.showMessageDialog(this, e.getMessage(), "Image Load Error", 				JOptionPane.ERROR_MESSAGE);
		}
        
		
        //create and add button
        JButton exitBtn = new JButton ("Exit");
        add(exitBtn);
        exitBtn.setBounds(275, 220, 90, 30);
        exitBtn.addActionListener(this);
	}


	//method for action listener
	@Override
	public void actionPerformed(ActionEvent e)
	{
		System.exit(0);
	}
}