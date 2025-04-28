//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Final Project: Escaping Death


import java.awt.Color;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Random;
//import javax.swing.Timer;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;


public class TitleFrame extends JFrame implements ActionListener
{
	// CREATE SERIAL VERSION UID FOR VERSION CONTROL
	private static final long serialVersionUID = 1L;
	
	int frameWidth = 1024;
	int frameHeight = 1024;
	Random random = new Random();
	
	
	public TitleFrame()
	{
		// CREATE FRAME
        setTitle ("Escaping Death");
        setSize (frameWidth, frameHeight);
        setResizable (false);
        // CLOSES APPLICATION IF USER HITS THE 'X'
        setDefaultCloseOperation (JFrame.EXIT_ON_CLOSE);
        // CENTERS THE WINDOW
        setLocationRelativeTo (null);
        // DISABLES LAYOUT MANAGERS FOR MANUAL POSITIONING OF OBJECTS
        setLayout (null);
        
        
		// SET A CUSTOM ICON IF PREVIOUSLY FOUND
		if (Main.iconLoaded)
		{
			setIconImage(Main.icon.getImage());
		}
		
		Main.glitchLoop = true;
		
		displayTitleImage("title");
		createEnterButton();
		
		
        setVisible (true);
        
        
        // SCREEN GLITCH
        int min = 3000;
        int max = 8000;
        // LOOPS UNTIL USER HITS ENTER TO LEAVE TITLE SCREEN
		while (Main.glitchLoop)
		{
			// GENERATES DELAY BEFORE SCREEN GLITCHES
			int delay = random.nextInt(max - min) + min;
			try
			{
				Thread.sleep(delay);
				// DETERMINES THE NUMBER OF SCREENS THAT WILL FLASH
				int numberOfGlitches = random.nextInt(5) + 5;
				// LOOPS RANDOM GLITCH SCREENS
				for (int i = 0; i < numberOfGlitches; i++)
				{
					displayTitleImage("glitch");
					Thread.sleep(50);
				}
				// DISPLAYS AN EERIE FACE
				displayTitleImage("face");
				Thread.sleep(750);
				// DETERMINES THE NUMBER OF SCREEN THAT WILL FALSH
				numberOfGlitches = random.nextInt(5) + 5;
				// LOOPS RANDOM GLITCH SCREENS
				for (int i = 0; i < numberOfGlitches; i++)
				{
					displayTitleImage("glitch");
					Thread.sleep(50);
				}
				// DISPLAYS THE TITLE SCREEN AGAIN
				displayTitleImage("title");
				// DISPLAY THE ENTER BUTTON
				createEnterButton();
			}
			catch (InterruptedException e)
			{
				e.printStackTrace();
				JOptionPane.showMessageDialog(null, "Delay Error: " + e.getMessage(), "Error", JOptionPane.ERROR_MESSAGE);
			}
		}
	}

	
	// LOADS SCREEN IMAGE BASED ON TYPE
	private void displayTitleImage(String type)
	{
		String imagePath = "";
		int index = -1;
		
		// IMAGE PATHS FOR THE MAIN TITLE SCREEN
		if (type == "title")
		{
			imagePath = System.getProperty("titlePath", "resources/images/TitleScreen-edit2.jpg");
		}
		// IMAGE PATHS FOR TITLE SCREEN GLTICHES
		else if (type == "glitch")
		{
	        String[] glitchImagePath =
	        	{
	        		"resources/images/glitch1.jpg",
	        		"resources/images/glitch2.jpg",
	        		"resources/images/glitch3.jpg",
	        		"resources/images/glitch4.jpg",
	        		"resources/images/glitch5.jpg",
	        		"resources/images/glitch6.jpg",
	        		"resources/images/glitch7.jpg",
	        		"resources/images/glitch8.jpg"
	        	};
	        
	        index = random.nextInt(8);
	        
	        imagePath = System.getProperty("glitchPath", glitchImagePath[index]);
		}
		// IMAGE PATHS FOR TITLE SCREEN FACE
		else if (type == "face")
		{
	        String[] faceImagePath =
	        	{
	        		"resources/images/face1.jpg",
	        		"resources/images/face2.jpg",
	        		"resources/images/face3.png",
	        		"resources/images/face4.jpg"
	        	};
	        
	        index = random.nextInt(4);
		    
			// FETCH IMAGE PATH
			imagePath = System.getProperty("glitchPath", faceImagePath[index]);
		}
		
		// LOAD IMAGE
		ImageIcon titleImage = Main.loadBackgroundImage(this, imagePath, frameWidth, frameHeight);
		
        // CREATE LABEL FOR TITLE IMAGE
		JLabel titleScreen = new JLabel(titleImage);
		titleScreen.setBounds(0, 0, frameWidth, 988);
		add(titleScreen, 0);
		
	    revalidate();
	    repaint();
	}

	
    // CREATE ENTER BUTTON
	private void createEnterButton()
	{
        JButton enterBtn = new JButton ("Enter");
        enterBtn.setBackground(Color.BLACK);					// SET BACKGROUND TO BLACK
        enterBtn.setForeground(Color.RED);						// SET TEXT COLOR TO RED
        enterBtn.setFont(new Font("Arial", Font.BOLD, 16));		// SET CUSTOM FONT
        enterBtn.setBorderPainted(false);						// REMOVE BUTTON BORDER
        enterBtn.setFocusPainted(false);						// REMOVE FOCUS OUTLINE
        enterBtn.setBounds(900, 940, 90, 30);
        add(enterBtn, 0);
        enterBtn.addActionListener(this);
        
	    revalidate();
	    repaint();
	}
	

	// METHOD FOR ACTION LISTENER
	@Override
	public void actionPerformed(ActionEvent e)
	{
		Main.glitchLoop = false;
		this.dispose();
		new StoryFrame("Intro");
	}
}
