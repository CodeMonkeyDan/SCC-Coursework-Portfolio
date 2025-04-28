//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Final Project: Escaping Death


import javax.swing.*;
import java.awt.*;
import java.util.Timer;
import java.util.TimerTask;


public class StoryFrame extends JFrame
{
	// CREATE SERIAL VERSION UID FOR VERSION CONTROL
	private static final long serialVersionUID = 1L;
	
	private JTextArea textArea;
    private int index = 0;
    private float opacity = 1.0f;
    private Timer timer;
    // DECLARE FULLTEXT & MODE
    private String fullText;
    private String mode;
    

    public StoryFrame(String mode)
    {
    	this.mode = mode;
    	
    	int frameWidth = 1024;
    	int frameHeight = 1024;
    	
		// CREATE FRAME
        setTitle ("Escaping Death");
        setSize (frameWidth, frameHeight);
        setResizable (false);
        // CENTERS THE WINDOW
        setLocationRelativeTo (null);
        setLayout(new BorderLayout());


        // SETUP LABEL
        textArea = new JTextArea();
        textArea.setFont(new Font("Monospaced", Font.BOLD, 24));
        textArea.setForeground(Color.RED);
        textArea.setBackground(Color.BLACK); // Match the background
        textArea.setLineWrap(true);
        textArea.setWrapStyleWord(true);
        textArea.setEditable(false);
        textArea.setFocusable(false);

        // PADDING
        textArea.setMargin(new Insets(300, 50, 50, 50));


        // BLACK BACKGROUND
        getContentPane().setBackground(Color.BLACK);
        add(textArea, BorderLayout.CENTER);

        // REMOVE WINDOW DECORATIONS FOR FADE TO WORK
        setUndecorated(true);
        setVisible(true);
        
        
        // STORY
        if (mode.equals("Intro"))
        {
        	fullText = "The first thing I noticed was the pain — a sharp, burning ache around my wrists. I tried to move, but the ropes dug in tighter. Panic flickered in my chest as I forced my eyes open. Everything was blurry at first, just dark stone walls and the weak glow of a single, swaying bulb overhead. I racked my brain, desperate for any memory of how I got here, but there was nothing. Just a blank, terrifying void. The air was cold and wet, heavy with the smell of mildew. As I looked around, it hit me: I was in some kind of basement… or dungeon. My heart pounded faster. Somewhere out there, in the dark beyond the light, I thought I heard something move.";
        }
        else
        {
        	fullText = "The door creaked open, spilling a sliver of moonlight across the grimy floor. I stumbled into the night, gasping for breath, but it wasn’t over — not yet. From the shadows behind me, I heard rapid footsteps. I turned just in time to see him — the one who put me in that hell. Without thinking, I raised the gun I'd fought so hard to find. A single shot rang out, splitting the night. He collapsed mid-charge, a twisted expression frozen on his face. For a long moment, I stood there trembling, the gun still smoking in my hands. I hadn't just escaped the dungeon. I'd survived the nightmare.";

        }
        
        
        startTypewriterEffect();
    }

    
    // TYPE WRITER EFFECT FOR STORY INTRO
    private void startTypewriterEffect()
    {
    	// TIMER TO TYPE EACH LETTER
        timer = new Timer();
        timer.schedule(new TimerTask()
        {
            @Override
            public void run()
            {
            	// RUN UNTIL THE FULL TEXT HAS BEEN DISPLAYED
                if (index < fullText.length())
                {
                	textArea.setText(textArea.getText() + fullText.charAt(index));

                    index++;
                }
                else
                {
                    timer.cancel();
                    try
                    {
                    	// HOLD FRAME FOR 3 SECONDS BEFORE FADE
						Thread.sleep(3000);
					}
                    catch (InterruptedException e)
                    {
						e.printStackTrace();
					}
                    // START TO FADE OUT THE FRAME
                    startFadeOut();
                }
            }
        }, 0, 50); // TYPING SPEED
    }

    
    // METHOD TO FADE OUT FRAME
    private void startFadeOut()
    {
    	// TIMER FOR FADE SPEED
        Timer fadeTimer = new Timer();
        fadeTimer.schedule(new TimerTask()
        {
            @Override
            public void run()
            {
            	// SLOWLY LOWER OPACITY
                opacity -= 0.05f;
                // CHECK FRAME OPACITY
                if (opacity <= 0)
                {
                	// CANCEL TIMER AND OPEN ROOM FRAME AFTER FADE OUT
                    fadeTimer.cancel();
                    openNewFrame();
                }
                else
                {
                    setOpacitySafely(opacity);
                }
            }
        }, 0, 100); // FADE SPEED
    }

    
    // METHOD TO VERIFY OPACITY IS WORKING PROPERLY
    private void setOpacitySafely(float opacityValue)
    {
        try
        {
            setOpacity(opacityValue);
        }
        catch (UnsupportedOperationException e)
        {
            System.out.println("Opacity not supported on this system.");
        }
    }

    
    // METHOD TO CLOSE INTRO FRAME AND OPEN ROOM FRAME
    private void openNewFrame()
    {
        this.dispose();
        if (mode.equals("Intro"))
        {
        	new RoomFrame();
        }
        else
        {
        	new ExitProgram();
        }
    }
}
