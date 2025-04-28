//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #9: Animation


import java.awt.Image;
import java.awt.MediaTracker;

import javax.swing.ImageIcon;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;


public class TitleFrame extends JFrame
{
	//create serialVersionUID for version control
	private static final long serialVersionUID = 1L;
	
	public TitleFrame()
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
        
        
		//fetch code monkey image path
		String imagePath = System.getProperty("iconPath", "resources/images/Pantera.png");
		try
		{
			ImageIcon image = new ImageIcon (imagePath);
			
            //check if the image failed to load
            if (image.getImageLoadStatus() != MediaTracker.COMPLETE)
            {
                throw new Exception("Image file not loaded properly: " + imagePath);
            }
            
            //scale the image
            Image scaledImage = image.getImage().getScaledInstance(1000, 420, Image.SCALE_SMOOTH);
            ImageIcon scaledIcon = new ImageIcon(scaledImage);
			
			JLabel imageLbl = new JLabel(scaledIcon);
			add(imageLbl);
			objectWidth = imageLbl.getPreferredSize().width;
			objectHeight = imageLbl.getPreferredSize().height;
	        imageLbl.setBounds(TitleFrame.centerH(frameWidth, objectWidth), 50, objectWidth, objectHeight);
		}
		catch (Exception e)
		{
			JOptionPane.showMessageDialog(this, e.getMessage(), "Image Load Error", 				JOptionPane.ERROR_MESSAGE);
		}
		
        
        JLabel createdByLbl = new JLabel ("created by:");
        add(createdByLbl);
		objectWidth = createdByLbl.getPreferredSize().width;
		objectHeight = createdByLbl.getPreferredSize().height;
        createdByLbl.setBounds(centerH(frameWidth, objectWidth), 500, objectWidth, objectHeight);
        
        JLabel signatureLbl = new JLabel ("<html><i>CodeMonkeyDan</i></html>");
        add(signatureLbl);
		objectWidth = signatureLbl.getPreferredSize().width;
		objectHeight = signatureLbl.getPreferredSize().height;
        signatureLbl.setBounds(centerH(frameWidth, objectWidth), 520, objectWidth, objectHeight); 
		
        
        //set delay 1 second = 1000 milliseconds - concert will automatically start without user interaction
        long endTime = System.currentTimeMillis() + 4000;
        while (System.currentTimeMillis() < endTime);
        
        this.dispose();
		Concert newConcert = new Concert();
		newConcert.animate();
	}
	
	
	//method used to center objects
	public static int centerH(int fW, int oW)
	{
		int center = (fW - oW) / 2;
		return center;
	}
}
