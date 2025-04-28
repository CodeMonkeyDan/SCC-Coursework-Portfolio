//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Final Project: Escaping Death

import java.awt.Component;
import java.awt.Image;
import java.awt.MediaTracker;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;

public class Main
{
	// CREATE STATIC FLAG TO TRACK ICON LOADING
	public static boolean iconLoaded = false;
	// CREATE STATIC IMAGE ICON
	public static ImageIcon icon;
	// CREATE STATIC BOOLEAN FOR GLITCH LOOP
	public static boolean glitchLoop;

	
	public static void main(String[] args)
	{
		BackgroundMusic.PlayBackgroundMusic("resources/audio/the-visitor.wav");
		loadIcon();
		new TitleFrame();
	}
	
	
	// SET A CUSTOM ICON
	public static void loadIcon()
	{
		// FETCH THE IMAGE PATH
		String imagePath = System.getProperty("iconPath", "resources/images/hatchet-icon.jpg");
		try
		{
			icon = new ImageIcon (imagePath);
			
            // CHECK IF THE IMAGE FAILED TO LOAD
            if (icon.getImageLoadStatus() != MediaTracker.COMPLETE)
            {
                throw new Exception("Icon file not loaded properly: " + imagePath);
            }
			
            // UPDATE FLAG TO TRUE IF ICON LOADED
			iconLoaded = true;
		}
		catch (Exception e)
		{
			JOptionPane.showMessageDialog(null, e.getMessage(), "Icon Load Error", JOptionPane.ERROR_MESSAGE);
		}
	}
	
	
	// METHOD TO LOAD BACKGROUND IMAGES
	public static ImageIcon loadBackgroundImage(Component parent, String imagePath, int width, int height)
	{
		ImageIcon image = null;
		try
		{
			// LOAD TITLE IMAGE
			image = new ImageIcon (imagePath);
			
            // CHECK IF THE IMAGE FAILED TO LOAD AND THROW EXCEPTION IF FAILED
            if (image.getImageLoadStatus() != MediaTracker.COMPLETE)
            {
                throw new Exception("Image file not loaded properly: " + imagePath);
            }
            
    		// SCALE THE IMAGE TO FIT THE FRAME
    		Image scaled = image.getImage().getScaledInstance(width, height, Image.SCALE_SMOOTH);
    		image = new ImageIcon(scaled);            
		}
		
		// DISPLAY EXCEPTION ERROR MESSAGE IF IMAGE FAILED
		catch (Exception e)
		{
			JOptionPane.showMessageDialog(parent, e.getMessage(), "Image Load Error", JOptionPane.ERROR_MESSAGE);
		}
		
		return image;
	}
	
	
	// METHOD USED TO CENTER OBJECTS
	public static int centerH(int fW, int oW)
	{
		int center = (fW - oW) / 2;
		return center;
	}
}
