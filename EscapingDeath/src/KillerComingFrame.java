//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Final Project: Escaping Death


import java.awt.Color;
import java.awt.Font;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.Timer;


public class KillerComingFrame extends JFrame implements ActionListener
{
	// CREATE SERIAL VERSION UID FOR VERSION CONTROL
	private static final long serialVersionUID = 1L;
	
	// FRAME DIMENSIONS
	int frameWidth = 1024;
	int frameHeight = 1024;
	
	// DECLARE CLASS VARIABLES
    private Timer timer;
    private int scaler = 50;
    private int killerHold = 50;
    	
    
	public KillerComingFrame()
	{
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
		

		setVisible(true);
		

		// START IMAGE UPDATE SEQUENCE
        startImageSequence();
	}
	
	
	// METHOD TO TIME IMAGE GENERATION
	private void startImageSequence()
	{
	    // CREATE TIMER TO RUNIMAGE LOADING PROCESS
	    timer = new Timer(10, new ActionListener()
	    {
	        @Override
	        public void actionPerformed(ActionEvent event)
	        {
	            String imagePath;

	            // RUNS UNTIL IMAGE IS FULL SCREEN
	            if (scaler > 1)
	            {
	                imagePath = "resources/images/roomKiller.jpg";
	                loadFrameImage(imagePath, scaler);
	                scaler--;
	            }
	            // HOLDS FINAL FRAME OF KILLER AT FULL SCREEN
	            else if (killerHold > 0)
	            {
	                imagePath = "resources/images/roomKiller.jpg";
	                // MANUALLY ADJUST NO SCALING, FULL SCREEN
	                loadFrameImage(imagePath, 1);
	                // COUNTDOWN TO HOLD THIS IMAGE
	                killerHold--;
	            }
	            // FINALLY SHOW GAME OVER SCREEN
	            else
	            {
	                imagePath = "resources/images/GameOver.jpg";
	                // MANUALLY ADJUST NO SCALING, FULL SCREEN
	                loadFrameImage(imagePath, 1);
	                // STOP TIMER AND LOOP
	                timer.stop();
	                createExitButton();
	            }
	        }
	    });

	    // START TIMER TO BEGIN LOADING IMAGES
	    timer.start();
	}


	// METHOD TO LOAD KILLER IMAGE
	private void loadFrameImage(String image, int scaler)
	{	    
		String imagePath = System.getProperty("killerPath", image);
		
		// IF SCALER DROPPED TO 0, RETURN TO 1 TO SHOW FULL SCREEN
		if (scaler == 0)
		{
			scaler = 1;
		}
		
		// FETCH TITLE IMAGE PATH
		ImageIcon gameOverImage = Main.loadBackgroundImage(this, imagePath, frameWidth / scaler, frameHeight / scaler);
		
        // CREATE LABEL FOR TITLE IMAGE
		JLabel gameOverScreen = new JLabel(gameOverImage);
		gameOverScreen.setBounds(0, 0, frameWidth, 988);
		add(gameOverScreen, 0);
		
	    revalidate();
	    repaint();
	}
	
	
	// CREATE EXIT BUTTON
	private void createExitButton()
	{
        JButton exitBtn = new JButton ("Exit");
        exitBtn.setBackground(Color.BLACK);						// SET BACKGROUND TO BLACK
        exitBtn.setForeground(Color.RED);						// SET TEXT COLOR TO RED
        exitBtn.setFont(new Font("Arial", Font.BOLD, 16));		// SET CUSTOM FONT
        exitBtn.setBorderPainted(false);						// REMOVE BUTTON BORDER
        exitBtn.setFocusPainted(false);							// REMOVE FOCUS OUTLINE
        exitBtn.setBounds(900, 940, 90, 30);
        add(exitBtn, 0);
        exitBtn.addActionListener(this);
        
	    revalidate();
	    repaint();
	}


	// DISPOSE OF FRAME AND GO TO EXIT SCREEN
	@Override
	public void actionPerformed(ActionEvent e)
	{
		this.dispose();
		new ExitProgram();
	}
}
