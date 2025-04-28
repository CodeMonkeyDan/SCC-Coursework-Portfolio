//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #8: Robust Lab7 (Bank Account System)


import java.awt.MediaTracker;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;


public class TitleFrame extends JFrame implements ActionListener
{
	//create serialVersionUID for version control
	private static final long serialVersionUID = 1L;
	//create static flag to track icon loading
	public static boolean iconLoaded = false;
	//create static image icon
	public static ImageIcon icon;


	public TitleFrame()
	{
		//variables for frame & objects, heights & widths
		int frameWidth = 400;
		int frameHeight = 215;
		int objectWidth;
		int objectHeight;

		
		//set a custom icon
		//fetch the image path
		String imagePath = System.getProperty("iconPath", "resources/images/money-icon-19.png");
		try
		{
			icon = new ImageIcon (imagePath);
			
            //check if the image failed to load
            if (icon.getImageLoadStatus() != MediaTracker.COMPLETE)
            {
                throw new Exception("Icon file not loaded properly: " + imagePath);
            }
			
			setIconImage(icon.getImage());
			iconLoaded = true;
		}
		catch (Exception e)
		{
			JOptionPane.showMessageDialog(this, e.getMessage(), "Icon Load Error", 				JOptionPane.ERROR_MESSAGE);
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
        JLabel titleLbl = new JLabel ("<html><b>DMS Bank Account System</b></html>");
        add(titleLbl);
		objectWidth = titleLbl.getPreferredSize().width;
		objectHeight = titleLbl.getPreferredSize().height;
        titleLbl.setBounds(centerH(frameWidth, objectWidth), 30, objectWidth, objectHeight); 
        
        JLabel createdByLbl = new JLabel ("created by:");
        add(createdByLbl);
		objectWidth = createdByLbl.getPreferredSize().width;
		objectHeight = createdByLbl.getPreferredSize().height;
        createdByLbl.setBounds(centerH(frameWidth, objectWidth), 70, objectWidth, objectHeight);
        
        JLabel signatureLbl = new JLabel ("<html><i>CodeMonkeyDan</i></html>");
        add(signatureLbl);
		objectWidth = signatureLbl.getPreferredSize().width;
		objectHeight = signatureLbl.getPreferredSize().height;
        signatureLbl.setBounds(centerH(frameWidth, objectWidth), 90, objectWidth, objectHeight); 

        
        //create and add button
        JButton continueBtn = new JButton ("Continue");
        add(continueBtn);
        continueBtn.setBounds(275, 130, 90, 30);
        continueBtn.addActionListener(this);
	}
	
	
	//method used to center objects
	public static int centerH(int fW, int oW)
	{
		int center = (fW - oW) / 2;
		return center;
	}


	//method for action listener
	@Override
	public void actionPerformed(ActionEvent e)
	{
		//closes title frame and opens main menu frame
		this.dispose();
		new MainMenuFrame();
	}
}
