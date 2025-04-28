//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #9: Animation


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
		int frameWidth = 1000;
		int frameHeight = 600;
		int objectWidth;
		int objectHeight;
		
		
		//create frame
        setTitle ("Lab #9: Animation - Pantera Concert");
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
        JLabel thankYouLbl = new JLabel ("<html><b>Thanks for watching, I hope you enjoyed the show!</b></html>");
        add(thankYouLbl);
		objectWidth = thankYouLbl.getPreferredSize().width;
		objectHeight = thankYouLbl.getPreferredSize().height;
        thankYouLbl.setBounds(TitleFrame.centerH(frameWidth, objectWidth), 150, objectWidth, objectHeight);
        
        JLabel createdByLbl = new JLabel ("created by:");
        add(createdByLbl);
		objectWidth = createdByLbl.getPreferredSize().width;
		objectHeight = createdByLbl.getPreferredSize().height;
        createdByLbl.setBounds(TitleFrame.centerH(frameWidth, objectWidth), 200, objectWidth, objectHeight);
        
        JLabel signatureLbl = new JLabel ("<html><i>CodeMonkeyDan</i></html>");
        add(signatureLbl);
		objectWidth = signatureLbl.getPreferredSize().width;
		objectHeight = signatureLbl.getPreferredSize().height;
        signatureLbl.setBounds(TitleFrame.centerH(frameWidth, objectWidth), 220, objectWidth, objectHeight);
        
        
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
            Image scaledImage = image.getImage().getScaledInstance(150,150, Image.SCALE_SMOOTH);
            ImageIcon scaledIcon = new ImageIcon(scaledImage);
			
			JLabel imageLbl = new JLabel(scaledIcon);
			add(imageLbl);
			objectWidth = imageLbl.getPreferredSize().width;
			objectHeight = imageLbl.getPreferredSize().height;
	        imageLbl.setBounds(TitleFrame.centerH(frameWidth, objectWidth), 240, objectWidth, objectHeight);
		}
		catch (Exception e)
		{
			JOptionPane.showMessageDialog(this, e.getMessage(), "Image Load Error", 				JOptionPane.ERROR_MESSAGE);
		}
        
		
        //create and add button
        JButton exitBtn = new JButton ("Exit");
        add(exitBtn);
        exitBtn.setBounds(TitleFrame.centerH(frameWidth, 90), 410, 90, 30);
        exitBtn.addActionListener(this);
	}


	//method for action listener
	@Override
	public void actionPerformed(ActionEvent e)
	{
		System.exit(0);
	}
}