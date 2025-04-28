//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Final Project: Escaping Death


import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Image;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;
import java.util.HashMap;
import java.util.Map;
import java.util.Random;
import javax.swing.BorderFactory;
import javax.swing.ImageIcon;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JLayeredPane;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JTextArea;
import javax.swing.SwingConstants;


public class RoomFrame extends JFrame implements ActionListener
{
	// CREATE SERIAL VERSION UID FOR VERSION CONTROL
	private static final long serialVersionUID = 1L;
	
	// DECLARE CLASS VARIABLES
	// LAYERED PANE TO LAYER OBJECTS
	private JLayeredPane layeredPane;
	// WALL PANELS
	private JPanel wallPanel;
	private JLayeredPane[] walls = new JLayeredPane[4];
	private int wallIndex = 0;
	// BUTTONS TO TURN AND LOOK AT DIFFERENT WALL PANELS
	private JButton leftTurnBtn;
	private JButton rightTurnBtn;
	// INVENTORY SLOTS
	private JLabel[] inventorySlots = new JLabel[10];
	// STORES WHAT INVENTORY ITEM IS IN HAND
	private int currentItemInHand = -1;
	// DOOR CODE BAR
	private JLabel[] doorCodeSlots = new JLabel[6];
    // GERNERATE RANDOM 6-DIGIT DOOR CODE
	private Random random = new Random();
	private int doorCode = random.nextInt(900000) + 100000;
	// ARRAY TO STORE THE INDIVIDUAL DOOR CODE DIGITS
	private int[] doorCodeDigits = new int[6];
	// GENERATE RANDOM 6-DIGIT COMPUTER PIN
	private int computerPin = random.nextInt(900000) + 100000;
	// GENERATE RANDOM 6-DIGIT SAFE COMBINATION
	private int safeCombination = random.nextInt(900000) + 100000;
	// FLAGS FOR FOUND DOOR CODES
	private boolean firstDoorCodeFound = false;
	private boolean thirdDoorCodeFound = false;
	private boolean fourthDoorCodeFound = false;
	private boolean fifthDoorCodeFound = false;
	private boolean sixthDoorCodeFound = false;
	// ITEMS TO BE PICKED UP / BROKEN
	JLabel candle = new JLabel();
	JLabel piggyBank = new JLabel();
	JLabel looseBrick = new JLabel();
	// FLAGS TO DETERMINE IF ITEMS HAVE ALREADY BEEN USED
	private boolean meltedCandle = false;
	private boolean coinSpent = false;
	// FLAGS TO DETERMINE IF TASKS HAVE ALREADY BEEN COMPLETED
	private boolean pictureScaryCut = false;
	private boolean computerUnlocked = false;
	private boolean safeUnlocked = false;
	// FLAGS TO DETERMINE IF ITEM WAS FOUND
	private boolean candleFound = false;
	private boolean chiselFound = false;
	private boolean coinFound = false;
	private boolean magnetFound = false;
	private boolean screwdriverFound = false;
	private boolean keyFound = false;
	private boolean hammerFound = false;
	private boolean razorBladeFound = false;
	private boolean gunFound = false;
	// FLAG FOR HANDS TIED
	private boolean handsBound = true;
	// FLAGS FOR POWER OBJECTS
	private boolean throwSwitchPowerGreenSign = false;
	JLabel greenSign = new JLabel();
	private boolean buttonSwitchPowerToaster = true;
	JLabel computerScreenOff = new JLabel();
	// FLAG FOR ALARM
	private boolean alarmSounded = true;
	
	// FRAME DIMENSIONS
	private final int frameWidth = 1024;
	private final int frameHeight = 1024;
	
	
	public RoomFrame()
	{
		// BREAK THE DOOR CODE INTO INDIVIDUAL DIGITS
		for (int i = 0; i < 6; i++)
		{
		    doorCodeDigits[i] = (doorCode / (int) Math.pow(10, 5 - i)) % 10;
		}
		
		// VARIABLES FOR FRAME & OBJECTS, HEIGHTS & WIDTHS
		int objectWidth;
		int objectHeight;
		
		// CREATE FRAME
        setTitle ("Escaping Death");
        setSize (frameWidth, frameHeight);
        setResizable (false);
        // CLOSE APPLICATION IF USER HITS THE 'X'
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
		
		
		// CREATE LAYERED PANE TO HOLD EVERYTHING
		layeredPane = new JLayeredPane();
		layeredPane.setBounds(0, 0, frameWidth, 805);
		layeredPane.setLayout(null);
		layeredPane.setBackground(Color.BLACK);
		layeredPane.setOpaque(true); 
		setContentPane(layeredPane);
		
		
		// CREATE WALL PANELS
		wallPanel = new JPanel(null);
		// CREATE & STORE WALL PANELS
		for (int i = 0; i < 4; i++)
		{
		    walls[i] = createWallPanel(i);
		}
		wallPanel.add(walls[wallIndex]);
		wallPanel.setBounds(0, 0, frameWidth, 805);
		layeredPane.add(wallPanel, Integer.valueOf(0));
		
		
		// CREATE INVENTORY/NAVIGATION BAR & LABEL
		JPanel inventoryBar = new JPanel();
		inventoryBar.setOpaque(false);
		leftTurnBtn = new JButton("<");
        leftTurnBtn.setBackground(Color.BLACK);
        leftTurnBtn.setForeground(Color.RED);
        leftTurnBtn.setFocusPainted(false);
		rightTurnBtn = new JButton(">");
        rightTurnBtn.setBackground(Color.BLACK);
        rightTurnBtn.setForeground(Color.RED);
        rightTurnBtn.setFocusPainted(false);
        
		JPanel itemPanel = new JPanel();
		itemPanel.setOpaque(false);
		for (int i = 0; i < inventorySlots.length; i++)
		{
			inventorySlots[i] = new JLabel();
			inventorySlots[i].setPreferredSize(new Dimension(75,75));
			inventorySlots[i].setBorder(BorderFactory.createLineBorder(Color.DARK_GRAY, 2));

			// NEEDED FOR HANDLE INVENTORY CLICK 
		    final int index = i;
		    inventorySlots[i].addMouseListener(new MouseAdapter()
		    {
		        @Override
		        public void mouseClicked(MouseEvent e)
		        {
		            handleInventoryClick(index);
		        }
		    });
		    
			itemPanel.add(inventorySlots[i]);
		}
		
		// ADDS ITEMS TO INVENTORY BAR
		inventoryBar.add(leftTurnBtn);
		inventoryBar.add(itemPanel);
		inventoryBar.add(rightTurnBtn);
		leftTurnBtn.addActionListener(this);
		rightTurnBtn.addActionListener(this);

		// ADD INVENTORY BAR TO LAYERED PANE
		objectWidth = inventoryBar.getPreferredSize().width;
		objectHeight = inventoryBar.getPreferredSize().height;
        inventoryBar.setBounds(Main.centerH(frameWidth, objectWidth), 890, objectWidth, objectHeight);
        layeredPane.add(inventoryBar, Integer.valueOf(1));
        
        JLabel inventoryLbl = new JLabel("Inventory");
        inventoryLbl.setForeground(Color.RED);
		objectWidth = (inventoryLbl.getPreferredSize().width) + 4;
		objectHeight = inventoryLbl.getPreferredSize().height;
        inventoryLbl.setBounds(Main.centerH(frameWidth, objectWidth), 875, objectWidth, objectHeight);
        layeredPane.add(inventoryLbl, Integer.valueOf(1));
        
        
        // CREATE DOOR CODE BAR & LABEL
        JPanel doorCodeBar = new JPanel();
        doorCodeBar.setOpaque(false);

        // FORMAT AND ADD EACH DOOR CODE SLOT TO DOOR CODE BAR
		for (int i = 0; i < doorCodeSlots.length; i++)
		{
			doorCodeSlots[i] = new JLabel();
			doorCodeSlots[i].setPreferredSize(new Dimension(45,45));
		    doorCodeSlots[i].setHorizontalAlignment(SwingConstants.CENTER);
		    doorCodeSlots[i].setVerticalAlignment(SwingConstants.CENTER);
		    doorCodeSlots[i].setFont(new Font("Arial", Font.PLAIN, 40));
			doorCodeSlots[i].setBorder(BorderFactory.createLineBorder(Color.DARK_GRAY, 2));
			doorCodeBar.add(doorCodeSlots[i]);
		}

		// ADD CODE BAR TO LAYERED PANE
		objectWidth = doorCodeBar.getPreferredSize().width;
		objectHeight = doorCodeBar.getPreferredSize().height;
		doorCodeBar.setBounds(Main.centerH(frameWidth, objectWidth), 820, objectWidth, objectHeight);
		layeredPane.add(doorCodeBar, Integer.valueOf(1));
		
        JLabel doorCodeLbl = new JLabel("Door Code");
        doorCodeLbl.setForeground(Color.RED);
		objectWidth = (doorCodeLbl.getPreferredSize().width) + 4;
		objectHeight = doorCodeLbl.getPreferredSize().height;
        doorCodeLbl.setBounds(Main.centerH(frameWidth, objectWidth), 805, objectWidth, objectHeight);
        layeredPane.add(doorCodeLbl, Integer.valueOf(1));
        

        setVisible (true);
	}
	
	
	// METHOD TO LOAD WALL IMAGES
    private JLayeredPane createWallPanel(int wallIndex)
    {        
        // IMAGE PATHS FOR THE DIFFERENT BACKGROUNDS ON EACH WALL
        String[] backgroundImagePath =
        	{
        		"resources/images/wall8.jpg",
        		"resources/images/wall5.jpg",
        		"resources/images/wall12.jpg",
        		"resources/images/wall11.jpg",
        	};
        
		// FETCH WALL IMAGE PATH
        String imagePath = System.getProperty("wall" + (wallIndex + 1) + "Path", backgroundImagePath[wallIndex]);
		ImageIcon image = Main.loadBackgroundImage(this, imagePath, frameWidth, frameHeight);
		
        // CREATE LAYERED PANE FOR WALL IMAGE
		JLayeredPane wallPanel = new JLayeredPane();
		wallPanel.setBounds(0, 0, frameWidth, 800);

		JLabel wallImage = new JLabel(image);
		wallImage.setBounds(0, 0, frameWidth, 800);
		wallPanel.add(wallImage, Integer.valueOf(0));

		// ADD OBJECTS TO EACH WALL PANEL
		switch (wallIndex)
		{
			case 0:
				JLabel wallScratch = createClickableObject("resources/images/wallScratch.jpg", 7, 625, 177, 38, 					"wallScratch");
				wallPanel.add(wallScratch, Integer.valueOf(1));
				
				JLabel table = createClickableObject("resources/images/table.png", 400, 500, 550, 250, "table");
				wallPanel.add(table, Integer.valueOf(2));
				
				JLabel computer = createClickableObject("resources/images/computer.png", 700, 380, 125, 150, "computer");
				wallPanel.add(computer, Integer.valueOf(3));
				
				computerScreenOff = createClickableObject("resources/images/computerScreenOff.png", 720, 392, 75, 60, 					"computerScreenOff");
				computerScreenOff.setVisible(true);
				wallPanel.add(computerScreenOff, Integer.valueOf(4));
				
				greenSign = createClickableObject("resources/images/greenSign" + doorCodeDigits[3] + ".png", 150, 60, 					100, 150, "greenSign");
				greenSign.setVisible(false);
				wallPanel.add(greenSign, Integer.valueOf(1));
				
				JLabel mirror = createClickableObject("resources/images/mirror.png", 450, 100, 200, 250, "mirror");
				wallPanel.add(mirror, Integer.valueOf(1));
				
				JLabel safe = createClickableObject("resources/images/safe.png", 570, 580, 140, 160, "safe");
				wallPanel.add(safe, Integer.valueOf(3));
				
				JLabel toolbox = createClickableObject("resources/images/toolbox.png", 170, 400, 250, 350, "toolbox");
				wallPanel.add(toolbox, Integer.valueOf(3));
				
				break;
				
				
			case 1:
				JLabel rustyKitchen = createClickableObject("resources/images/rustyKitchen.png", 274, 375, 700, 300, 					"rustyKitchen");
				wallPanel.add(rustyKitchen, Integer.valueOf(1));
				
				JLabel refrigerator = createClickableObject("resources/images/refrigerator.png", 25, 260, 200, 420, 					"refrigerator");
				wallPanel.add(refrigerator, Integer.valueOf(1));
				
				JLabel pictureScary = createClickableObject("resources/images/pictureScary.png", 515, 60, 200, 250, 					"pictureScary");
				wallPanel.add(pictureScary, Integer.valueOf(1));
				
				JLabel toaster = createClickableObject("resources/images/toaster.png", 330, 310, 80, 100, "toaster");
				wallPanel.add(toaster, Integer.valueOf(1));
				
				JLabel barbedWire = createClickableObject("resources/images/barbedWire.png", 810, 310, 100, 100, 					"barbedWire");
				wallPanel.add(barbedWire, Integer.valueOf(1));
				
				looseBrick = createClickableObject("resources/images/looseBrick.png", 202, 102, 80, 38, "looseBrick");
				wallPanel.add(looseBrick, Integer.valueOf(1));
				
				break;
				
				
			case 2:
				JLabel door = createClickableObject("resources/images/door.png", 600, 75, 400, 500, "door");
				wallPanel.add(door, Integer.valueOf(1));
				
				JLabel doorCodePic = createClickableObject("resources/images/picture" + doorCodeDigits[4] + ".png", 400, 60, 					150, 200, "doorCodePic");
				wallPanel.add(doorCodePic, Integer.valueOf(1));
				
				JLabel woodStove = createClickableObject("resources/images/woodStove.png", 100, 350, 225, 250, "woodStove");
				wallPanel.add(woodStove, Integer.valueOf(1));
				
				JLabel airDuct = createClickableObject("resources/images/airduct.png", 120, 15, 175, 75, "airDuct");
				wallPanel.add(airDuct, Integer.valueOf(1));
				
				JLabel buttonSwitch = createClickableObject("resources/images/buttonSwitch.png", 550, 315, 50, 75, 					"buttonSwitch");
				wallPanel.add(buttonSwitch, Integer.valueOf(1));
				
				JLabel throwSwitch = createClickableObject("resources/images/throwSwitch.png", 485, 305, 50, 75, 					"throwSwitch");
				wallPanel.add(throwSwitch, Integer.valueOf(1));
				
				break;
				
				
			case 3:
				JLabel bookshelf = createClickableObject("resources/images/bookshelf.png", 325, 50, 600, 500, "bookshelf");
				wallPanel.add(bookshelf, Integer.valueOf(1));
				
				JLabel gumballMachine = createClickableObject("resources/images/gumballMachine.png", 95, 225, 120, 350, 					"gumballMachine");
				wallPanel.add(gumballMachine, Integer.valueOf(1));
				
				JLabel book1 = createClickableObject("resources/images/book1.png", 350, 80, 19, 100, "book1");
				wallPanel.add(book1, Integer.valueOf(2));
				
				JLabel book2 = createClickableObject("resources/images/book2.png", 370, 77, 17, 103, "book2");
				wallPanel.add(book2, Integer.valueOf(2));
				
				JLabel book3 = createClickableObject("resources/images/book3.png", 387, 96, 10, 84, "book3");
				wallPanel.add(book3, Integer.valueOf(2));
				
				JLabel book4 = createClickableObject("resources/images/book4.png", 398, 96, 9, 84, "book4");
				wallPanel.add(book4, Integer.valueOf(2));
				
				JLabel book5 = createClickableObject("resources/images/book5.png", 408, 104, 10, 76, "book5");
				wallPanel.add(book5, Integer.valueOf(2));
				
				JLabel book6 = createClickableObject("resources/images/book6.png", 419, 102, 12, 78, "book6");
				wallPanel.add(book6, Integer.valueOf(2));
				
				JLabel book7 = createClickableObject("resources/images/book7.png", 350, 213, 16, 85, "book7");
				wallPanel.add(book7, Integer.valueOf(2));
				
				JLabel book8 = createClickableObject("resources/images/book8.png", 367, 218, 13, 80, "book8");
				wallPanel.add(book8, Integer.valueOf(2));
				
				JLabel book9 = createClickableObject("resources/images/book9.png", 381, 223, 9, 75, "book9");
				wallPanel.add(book9, Integer.valueOf(2));
				
				JLabel book10 = createClickableObject("resources/images/book10.png", 391, 215, 16, 83, "book10");
				wallPanel.add(book10, Integer.valueOf(2));
				
				JLabel book11 = createClickableObject("resources/images/book11.png", 408, 205, 8, 93, "book11");
				wallPanel.add(book11, Integer.valueOf(2));
				
				JLabel book12 = createClickableObject("resources/images/book12.png", 417, 199, 14, 99, "book12");
				wallPanel.add(book12, Integer.valueOf(2));
				
				JLabel toyCar = createClickableObject("resources/images/toyCar.png", 450, 485, 120, 50, "toyCar");
				wallPanel.add(toyCar, Integer.valueOf(2));
				
				JLabel toyTrain = createClickableObject("resources/images/toyTrain.png", 650, 485, 170, 50, "toyTrain");
				wallPanel.add(toyTrain, Integer.valueOf(2));
				
				piggyBank = createClickableObject("resources/images/piggyBank.png", 700, 250, 100, 50, "piggyBank");
				wallPanel.add(piggyBank, Integer.valueOf(2));
				
				candle = createClickableObject("resources/images/candle.png", 600, 325, 50, 80, "candle");
				wallPanel.add(candle, Integer.valueOf(2));
				
				JLabel armyMen = createClickableObject("resources/images/armyMen.png", 450, 375, 50, 30, "armyMen");
				wallPanel.add(armyMen, Integer.valueOf(2));
				
				JLabel jackInBox = createClickableObject("resources/images/jackInBox.png", 770, 325, 50, 80, "jackInBox");
				wallPanel.add(jackInBox, Integer.valueOf(2));
				
				JLabel lockbox = createClickableObject("resources/images/lockbox.png", 550, 105, 200, 75, "lockbox");
				wallPanel.add(lockbox, Integer.valueOf(2));
				
				break;
		}
		
        return wallPanel;
    }

    
    // METHOD TO CREATE CLICKABLE OBJECTS
    private JLabel createClickableObject(String imagePath, int x, int y, int width, int height, String objectId)
    {
        ImageIcon scaledIcon = null;
            
        try
        {
            // LOAD IMAGE
            ImageIcon originalIcon = new ImageIcon(imagePath);
            
            // SCALE IMAGE
            Image scaledImage = originalIcon.getImage().getScaledInstance(width, height, Image.SCALE_SMOOTH);
            scaledIcon = new ImageIcon(scaledImage);
        }
        catch (Exception e)
        {
            JOptionPane.showMessageDialog(null, e.getMessage(), "Image Load Error", JOptionPane.ERROR_MESSAGE);
            // EMPTY IMAGE TO PREVENT CRASH
            scaledIcon = new ImageIcon();
        }

        // CREATE LABEL WITH SCALED IMAGE
        JLabel objectLbl = new JLabel(scaledIcon);
        objectLbl.setBounds(x, y, width, height);
        // STORE OBJECT IDENTIFIER
        objectLbl.putClientProperty("objectId", objectId);

        // ADD CLICK EVENT
        objectLbl.addMouseListener(new MouseAdapter()
        {
            @Override
            public void mouseClicked(MouseEvent e)
            {
                handleObjectClick(objectLbl);
            }
        });

        return objectLbl;
    }

	
	
	// METHOD FOR ACTION LISTENER (SWITCHING WALL VIEWS)
	@Override
	public void actionPerformed(ActionEvent e)
	{
	    Object source = e.getSource();

	    // TURNING TO SWITCH WALLS
	    if (source == leftTurnBtn)
	    {
	        switchWall(-1);
	    }
	    else if (source == rightTurnBtn)
	    {
	        switchWall(1);
	    }
	}
	
	
    // METHOD TO TURN (SWITCH WALLS)
    private void switchWall(int direction)
    {
        // REMOVE CURRENT WALL
        wallPanel.remove(walls[wallIndex]);

        // UPDATE INDEX
        wallIndex = (wallIndex + direction + 4) % 4;

        // ADD NEW WALL
        wallPanel.add(walls[wallIndex]);

        // REFRESH PANEL
        wallPanel.revalidate();
        wallPanel.repaint();
    }
	
	
	// METHOD FOR SELECTING INVENTORY ITEMS
	private void handleInventoryClick(int index)
	{
	    // IF THE CLICKED SLOT IS ALREADY SELECTED, UNESELECT IT
	    if (currentItemInHand == index)
	    {
	        inventorySlots[index].setBorder(BorderFactory.createLineBorder(Color.DARK_GRAY, 2));
	        currentItemInHand = -1;
	    }
	    // ELSE RESET ALL BORDERS AND SELECT NEW ONE
	    else
	    {
	        for (int i = 0; i < inventorySlots.length; i++)
	        {
	            inventorySlots[i].setBorder(BorderFactory.createLineBorder(Color.DARK_GRAY, 2));
	        }

	        inventorySlots[index].setBorder(BorderFactory.createLineBorder(Color.LIGHT_GRAY, 3));
	        currentItemInHand = index;
	    }
	}
	
	
	// METHOD TO MAP OBJECT CLICKS
	private void handleObjectClick(JLabel clickedObject)
	{		
	    String objectId = (String) clickedObject.getClientProperty("objectId");
	    
	    // MAKE SURE USER HAS GOT HANDS FREE BEFORE ANYTHING ELSE CAN BE DONE
		if (handsBound && !"barbedWire".equals(objectId))
		{
			JOptionPane.showMessageDialog(this, "I need to find a way to get my hands free before I can do anything else.");
			return;
		}
		
	    // CREATE HASHMAP FOR CLICKABLE OBJECTS
	    Map<String, Runnable> actionMap = new HashMap<>();
	    
	    actionMap.put("barbedWire",  this::handleBarbedWire);
	    actionMap.put("buttonSwitch",  this::handleButtonSwitch);
	    actionMap.put("throwSwitch",  this::handleThrowSwitch);
	    actionMap.put("wallScratch",  this::handleWallScratch);
	    actionMap.put("candle",  this::handleCandle);
	    actionMap.put("woodStove",  this::handleWoodStove);
	    actionMap.put("mirror",  this::handleMirror);
	    actionMap.put("greenSign",  this::handleGreenSign);
	    actionMap.put("doorCodePic",  this::handleDoorCodePic);
	    actionMap.put("toaster",  this::handleToaster);
	    actionMap.put("book1",  this::handleBook1);
	    actionMap.put("book2",  this::handleBook2);
	    actionMap.put("book3",  this::handleBook3);
	    actionMap.put("book4",  this::handleBook4);
	    actionMap.put("book5",  this::handleBook5);
	    actionMap.put("book6",  this::handleBook6);
	    actionMap.put("book7",  this::handleBook7);
	    actionMap.put("book8",  this::handleBook8);
	    actionMap.put("book9",  this::handleBook9);
	    actionMap.put("book10",  this::handleBook10);
	    actionMap.put("book11",  this::handleBook11);
	    actionMap.put("book12",  this::handleBook12);
	    actionMap.put("looseBrick",  this::handleLooseBrick);
	    actionMap.put("gumballMachine",  this::handleGumballMachine);
	    actionMap.put("lockbox",  this::handleLockbox);
	    actionMap.put("airDuct",  this::handleAirDuct);
	    actionMap.put("toolbox",  this::handleToolbox);
	    actionMap.put("piggyBank",  this::handlePiggyBank);
	    actionMap.put("pictureScary",  this::handlePictureScary);
	    actionMap.put("computer",  this::handleComputer);
	    actionMap.put("computerScreenOff",  this::handleComputer);
	    actionMap.put("safe",  this::handleSafe);
	    actionMap.put("door",  this::handleDoor);
	    actionMap.put("table", () -> JOptionPane.showMessageDialog(this, "Looks like an ordinary table."));
	    actionMap.put("rustyKitchen", () -> JOptionPane.showMessageDialog(this, "This kitchen looks disgusting."));
	    actionMap.put("refrigerator", () -> JOptionPane.showMessageDialog(this, "An awful odor is coming from the refrigerator. I am not opening that!"));
	    actionMap.put("bookshelf", () -> JOptionPane.showMessageDialog(this, "A big bookshelf with an assortment of things on it."));
	    actionMap.put("toyCar", () -> JOptionPane.showMessageDialog(this, "That's a cool antique car, but now is not the time to be playing with toys."));
	    actionMap.put("toyTrain", () -> JOptionPane.showMessageDialog(this, "Choo-choo. Get it together man, I need to find a way out of here."));
	    actionMap.put("armyMen", () -> JOptionPane.showMessageDialog(this, "A few little army men, if only the real army was here to help me get out."));
	    actionMap.put("jackInBox", () -> JOptionPane.showMessageDialog(this, "I swear that thing is starting at me."));
	    
	    
	    // EXECUTE CORRESPONDING ACTION FOR EACH OBJECT
	    if (actionMap.containsKey(objectId))
	    {
	        actionMap.get(objectId).run();
	    }
	}
	
	
	// METHOD FOR BARBED WIRE
	private void handleBarbedWire()
	{
		if (handsBound)
		{
			JOptionPane.showMessageDialog(this, "I think I can use this barbed wire to cut my hands free from this rope.");
			handsBound = false;
		}
		else
		{
			JOptionPane.showMessageDialog(this, "I should probably not mess with this anymore, it's pretty sharp.");
		}
	}
	
	
	// METHOD FOR BUTTON SWITCH
	private void handleButtonSwitch()
	{
		JOptionPane.showMessageDialog(this, "Hmm, I wonder what this switch does.");
		buttonSwitchPowerToaster = !buttonSwitchPowerToaster;
		computerScreenOff.setVisible(buttonSwitchPowerToaster);
	}
	
	
	// METHOD FOR THROW SWITCH
	private void handleThrowSwitch()
	{
		throwSwitchPowerGreenSign = !throwSwitchPowerGreenSign;
		greenSign.setVisible(throwSwitchPowerGreenSign);
		if (throwSwitchPowerGreenSign)
		{
			JOptionPane.showMessageDialog(this, "I hear a buzzing behind me now.");
		}
		else
		{
			JOptionPane.showMessageDialog(this, "The buzzing stopped.");
		}
	}
	
	
	// METHOD FOR WALL SCRATCH CLUE
	private void handleWallScratch()
	{
	    JOptionPane.showMessageDialog(this, "It looks like there is something on the wall here, the number " + 			doorCodeDigits[0] + " is written in blood! Along with the words; 'Computer On Toaster Off.'.");
	    // CHECK IF NUMBER HAS BEEN FOUND ALREADY
	    if (!firstDoorCodeFound)
	    {
	        addDoorCodeSlot(0, Color.RED);
	        // SET FLAG FOR FOUND NUMBER
	        firstDoorCodeFound = true;
	    }
	}
	
	
	// METHOD FOR CANDLE
	private void handleCandle()
	{
	    JOptionPane.showMessageDialog(this, "Looks like there is something inside this candle, better take it with me.");
	    candle.setVisible(false);
	    addToInventorySlot(0, "resources/images/candle.png");
	    candleFound = true;
	}
	
	
	// METHOD FOR WOOD STOVE
	private void handleWoodStove()
	{
		if (currentItemInHand == 0 && candleFound && !meltedCandle)
		{
			JOptionPane.showMessageDialog(this, "I bet I can use this to melt that candle. An Orange number " + 				doorCodeDigits[1] + " was inside!");
			meltedCandle = true;
			inventorySlots[0].setIcon(null);
			addDoorCodeSlot(1, new Color(255, 140, 0));
		}
		else
		{
			JOptionPane.showMessageDialog(this, "The stove feels very hot.");
		}
	}
	
	
	// METHOD FOR MIRROR
	private void handleMirror()
	{
		JOptionPane.showMessageDialog(this, "I see something smudged on the mirror. I blow on it to fog it up and see the word Yellow and the number " + doorCodeDigits[2] + "!");
		// CHECK IF NUMBER HAS BEEN FOUND ALREADY
		if (!thirdDoorCodeFound)
		{
			addDoorCodeSlot(2, Color.YELLOW);
	        // SET FLAG FOR FOUND NUMBER
	        thirdDoorCodeFound = true;
		}
	}
	
	
	// METHOD FOR GREEN SIGN
	private void handleGreenSign()
	{
		JOptionPane.showMessageDialog(this, "Where did that come from? The number " + doorCodeDigits[3] + " in Green.");
		// CHECK IF NUMBER HAS BEEN FOUND ALREADY
		if (!fourthDoorCodeFound)
		{
			addDoorCodeSlot(3, Color.GREEN);
	        // SET FLAG FOR FOUND NUMBER
	        fourthDoorCodeFound = true;
		}
	}
	
	
	// METHOD FOR DOOR CODE PICTURE
	private void handleDoorCodePic()
	{
		JOptionPane.showMessageDialog(this, "The roman numeral number " + doorCodeDigits[4] + " in Blue.");
		// CHECK IF NUMBER HAS BEEN FOUND ALREADY
		if (!fifthDoorCodeFound)
		{
			addDoorCodeSlot(4, Color.BLUE);
	        // SET FLAG FOR FOUND NUMBER
	        fifthDoorCodeFound = true;
		}
	}
	
	
	// METHOD FOR TOASTER
	private void handleToaster()
	{
		// CHECK IF THE TOASTER IS POWERED ON
		if (buttonSwitchPowerToaster)
		{
			JOptionPane.showMessageDialog(this, "Oh No! I should have tried to kill the power first!");
			killerComing();
		}
		else
		{
			JOptionPane.showMessageDialog(this,
				"I look inside and see a Purple plastic number " + doorCodeDigits[5] + " inside!");
			// CHECK IF NUMBER HAS BEEN FOUND ALREADY
			if (!sixthDoorCodeFound)
			{
				addDoorCodeSlot(5, new Color(128, 0, 128));
		        // SET FLAG FOR FOUND NUMBER
		        sixthDoorCodeFound = true;
			}
		}
	}
	
	
	// METHOD FOR BOOK 1
	private void handleBook1()
	{
		showWrappedMessage("THE HOSTAGE: A masked killer stalked the darkened house, his footsteps silent on the wooden floors. One by one, he captured his victims, binding them in the basement with nothing but their fear for company. He whispered chilling promises of death, but left them in suspense—would they escape, or would they become just another forgotten name?");
	}
	
	
	// METHOD FOR BOOK 2
	private void handleBook2()
	{
		showWrappedMessage("THE WHISPERING WALLS: In the dead of night, Sarah awoke to a soft whispering from the walls. At first, she thought it was the wind, but the voices grew clearer, calling her name. She pressed her ear against the cold plaster, but the whispering stopped. The moment she turned to leave, a chilling voice murmured, 'Do not go. We are waiting for you.'");
	}
	
	
	// METHOD FOR BOOK 3
	private void handleBook3()
	{
		showWrappedMessage("ALONE: Late at night, Marcus felt something cold brush against his cheek. He opened his eyes, but no one was there. He turned his head back to the pillow and closed his eyes again, only to feel a hand grip his shoulder. His heart raced as the whispering began, soft at first, then louder. 'You shouldn't have slept alone.'");
	}
	
	
	// METHOD FOR BOOK 4
	private void handleBook4()
	{
		showWrappedMessage("THE DOLL'S EYE: Every night, Amelia placed her grandmother's old porcelain doll on the shelf by the bed. Each morning, it was always staring at her. One night, she decided to turn its head around before bed, but when she awoke, the doll's head was facing the wall. She laughed it off—until she saw the fresh bloodstain on the back of its neck, and a voice whispered in her ear, 'Now, I’m watching you.'");
		JOptionPane.showMessageDialog(this, "Inside was a piece of paper that said; 'Look for the Loose Brick'.");
	}
	
	
	// METHOD FOR BOOK 5
	private void handleBook5()
	{
		showWrappedMessage("THE HIDDEN ROOM: Julia discovered an old key hidden in the attic, wrapped in faded cloth. Curious, she searched the house and found a small door behind a bookcase, one she had never noticed before. When she unlocked it, she stepped into a room full of mirrors—each reflecting a version of herself that wasn’t quite right. One mirror showed her smiling, but Julia was frozen in terror.");
	}
	
	
	// METHOD FOR BOOK 6
	private void handleBook6()
	{
		showWrappedMessage("THE SLEEPING EYE: Mark woke up in the middle of the night to the feeling of someone watching him. His room was dark, and the air felt thick. He turned on the lamp, but there was no one there. Yet, when he glanced at the wall, he saw an eye—wide open, staring at him. He rushed to the door, but the eye followed him. He turned around to find his reflection in the mirror, but the eye in it wasn’t his.");
	}
	
	
	// METHOD FOR BOOK 7
	private void handleBook7()
	{
		showWrappedMessage("THE EMPTY CRADLE: Every night, Emma heard the faint sound of a baby crying from the nursery. She checked the crib, but it was always empty. One night, she decided to wait in the shadows, hoping to finally catch a glimpse of the child. As the crying grew louder, the room grew colder. When she stepped forward, she froze—there, in the crib, was a rotting, lifeless baby, staring at her with hollow eyes. The crying didn’t stop.");
	}
	
	
	// METHOD FOR BOOK 8
	private void handleBook8()
	{
		showWrappedMessage("THE LAST BREATHE: John sat alone in his room, his breath shallow. He had been sick for days, but tonight felt different. As the night deepened, he heard a faint voice calling his name. He tried to call out, but no sound came. The voice grew louder, and he felt an icy hand on his shoulder. When he turned, he saw no one—only his own reflection in the mirror, smiling back at him. It wasn’t his smile.");
		JOptionPane.showMessageDialog(this, "There was a note inside with the letters; 'RYOGBP'.");
	}
	
	
	// METHOD FOR BOOK 9
	private void handleBook9()
	{
		showWrappedMessage("THE KILLER'S GAME: Each night, a killer would visit the house and leave a note with a name written in blood. The victim would be found in the morning, lifeless and cold. One night, it was Peter's name on the note. As he waited in terror, the killer never came. Hours passed. He finally went to sleep, relieved—but when he woke up, he found the note beside him, and his name was scratched out. His reflection in the mirror grinned back at him. He was the killer.");
	}
	
	
	// METHOD FOR BOOK 10
	private void handleBook10()
	{
		JOptionPane.showMessageDialog(this, "FROM THE ABYSS:...But the book has been hollowed out, and inside is a chisel.");
		addToInventorySlot(1, "resources/images/chisel.png");
		chiselFound = true;
	}
	
	
	// METHOD FOR BOOK 11
	private void handleBook11()
	{
		showWrappedMessage("THE SILENT SKY: Late one night, Carla stood on her porch, staring at the sky. The stars blinked in strange patterns, too perfect to be natural. Then, one by one, the lights vanished, leaving only an unnatural, impenetrable darkness. A cold breeze whispered her name, and she felt a presence behind her. When she turned, no one was there—but a voice echoed inside her mind, 'We are already here.'");
	}
	
	
	// METHOD FOR BOOK 12
	private void handleBook12()
	{
		showWrappedMessage("THE NIGHTMARE CREATURES: Every night, James was chased by grotesque monsters in his dreams. They had no faces, only hollow eyes that followed him with an unnerving, silent stare. One night, as they cornered him, he woke up with a gasp—only to find the monsters standing at the foot of his bed, their eyes glowing in the dark. 'You can never escape,' they whispered in unison. 'We are your dreams.'");
	}
	
	
    // METHOD TO WRAP TEXT IN JOPTIONPANE
    public void showWrappedMessage(String message)
    {
    	// CREATE JTEXTAREA TO HOLD MESSAGE
        JTextArea textArea = new JTextArea(message, 6, 50);
        
        // SET JTEXTAREA TO NOT BE EDITABLE
        textArea.setEditable(false);
        
        // SET TEXT AREA TO AUTO-WRAP
        textArea.setWrapStyleWord(true);
        textArea.setLineWrap(true);
        
        // DISPALY MESSAGE IN JOPTIONPANE
        JOptionPane.showMessageDialog(this, textArea);
    }
	
	
	// METHOD FOR LOOSE BRICK
	private void handleLooseBrick()
	{
		// CHECK IF CHISEL HAS BEEN FOUND AND THAT IT IS THE SELECTED ITEM
		if (currentItemInHand == 1 && chiselFound)
		{
			JOptionPane.showMessageDialog(this, "I bet I can use this chisel to get that brick out. I knew it! Behind the brick was a coin.");
			looseBrick.setVisible(false);
			addToInventorySlot(2, "resources/images/coin.png");
			coinFound = true;
		}
		else
		{
			JOptionPane.showMessageDialog(this, "It looks like someone has recently mortared that brick in place.");
		}
	}
	
	
	// METHOD FOR GUMBALL MACHINE
	private void handleGumballMachine()
	{
		// CHECK IF COIN HAS BEEN FOUND, AND THAT IT IS THE SELECTED ITEM AND IF IT HAS BEEN USED ALREADY
		if (currentItemInHand == 2 && coinFound && !coinSpent)
		{
			JOptionPane.showMessageDialog(this, "I've got a coin, why not? Instead of a piece of gum, a magnet was dispensed.");
			coinSpent = true;
			inventorySlots[2].setIcon(null);
			addToInventorySlot(3, "resources/images/magnet.png");
			magnetFound = true;
		}
		else
		{
			JOptionPane.showMessageDialog(this, "An antique gumball machine.");
		}
	}
	
	
	// METHOD FOR LOCKBOX
	private void handleLockbox()
	{
		// CHECK IF magnet HAS BEEN FOUND AND THAT IT IS THE SELECTED ITEM
		if (currentItemInHand == 3 && magnetFound)
		{
			// CHECK IF SCREWDRIVER HAS ALREADY BEEN RETRIEVED
			if (!screwdriverFound)
			{
				JOptionPane.showMessageDialog(this, "After sliding the magnet across the front, I hear a click.");
				JOptionPane.showMessageDialog(this, "Found a screwdriver inside.");
				addToInventorySlot(4, "resources/images/screwdriver.png");
				screwdriverFound = true;
			}
			else
			{
				JOptionPane.showMessageDialog(this, "There is nothing else in the box.");
			}
		}
		else
		{
			JOptionPane.showMessageDialog(this, "It is locked, but I do not see a keyhole.");
		}
	}
	
	
	// METHOD FOR AIRDUCT
	private void handleAirDuct()
	{
		// CHECK IF SCREWDRIVER HAS BEEN FOUND AND THAT IT IS THE SELECTED ITEM
		if (currentItemInHand == 4 && screwdriverFound)
		{
			// CHECK IF KEY HAS ALREADY BEEN RETRIEVED
			if (!keyFound)
			{
				JOptionPane.showMessageDialog(this, "I can use this screwdriver to remove the vent cover. Found a hidden key!");
				addToInventorySlot(5, "resources/images/key.png");
				keyFound = true;
			}
			else
			{
				JOptionPane.showMessageDialog(this, "There is nothing else behind vent cover.");
			}
		}
		else
		{
			JOptionPane.showMessageDialog(this, "I think I can see something in the vent.");
		}
	}
	
	
	// METHOD FOR TOOLBOX
	private void handleToolbox()
	{
		// CHECK IF KEY HAS BEEN FOUND AND THAT IT IS THE SELECTED ITEM
		if (currentItemInHand == 5 && keyFound)
		{
			// CHECK IF HAMMER HAS ALREADY BEEN RETRIEVED
			if (!hammerFound)
			{
				JOptionPane.showMessageDialog(this, "I use the key to open the toolbox, there is a hammer insde.");
				addToInventorySlot(6, "resources/images/hammer.png");
				hammerFound = true;
			}
			else
			{
				JOptionPane.showMessageDialog(this, "There is nothing else in the tool box.");
			}
		}
		else
		{
			JOptionPane.showMessageDialog(this, "The toolbox is locked. I need to find the key.");
		}
	}
	
	
	// METHOD FOR PIGGYBANK
	private void handlePiggyBank()
	{
		// CHECK IF HAMMER HAS BEEN FOUND AND THAT IT IS THE SELECTED ITEM
		if (currentItemInHand == 6 && hammerFound)
		{
			JOptionPane.showMessageDialog(this, "I suppose, I've got nothign else to loose. Found a razor blade after smashing the piggy bank.");
			piggyBank.setVisible(false);
			addToInventorySlot(7, "resources/images/razorBlade.png");
			razorBladeFound = true;
		}
		else
		{
			JOptionPane.showMessageDialog(this, "Some poor kids piggy bank.");
		}
	}
	
	
	// METHOD FOR PICTURE SCARY
	private void handlePictureScary()
	{
		// CHECK IF RAZOR HAS BEEN FOUND AND THAT IT IS THE SELECTED ITEM AND IF THE PICTURE HAS BEEN ALREADY CUT
		if (currentItemInHand == 7 && razorBladeFound && !pictureScaryCut)
		{
			JOptionPane.showMessageDialog(this, "This picture is so scary, I'm almost afraid to cut it.");
			JOptionPane.showMessageDialog(this, "On the inside of the painting was a clue; 'COMPUTER PIN: " + computerPin + "'.");
			pictureScaryCut = true;
		}
		// CHECKS IF PICTURE HAS ALREADY BEEN CUT
		else if (pictureScaryCut)
		{
			JOptionPane.showMessageDialog(this, "On the inside of the painting was a clue; 'COMPUTER PIN: " + computerPin + "'.");
		}
		else
		{
			JOptionPane.showMessageDialog(this, "What a spooky picture, it gives me the creeps!");
		}
	}
	
	
	// METHOD FOR COMPUTER
	private void handleComputer()
	{
		// CHECKS IF TOASTER IS OFF (COMPUTER HAS POWER)
		if (!buttonSwitchPowerToaster)
		{
			// CHECKS IF COMPUTER HAS BEEN UNLOCKED YET
			if (!computerUnlocked)
			{
			    String input = JOptionPane.showInputDialog(this, "The computer is locked with a pin. I could try entering a code:");
			    // ONLY RUN IF USER HITS OK, IF USER EXITS NOTHING HAPPENS
			    if (input != null)
			    {
			        try
			        {
			        	//PARSE USER INPUT INTO INTEGER
			            int userInput = Integer.parseInt(input);
			            
			            // CHECK IF USER INPUT MATCHES DOOR CODE
			            if (userInput == computerPin)
			            {
			            	computerUnlocked = true;
			                JOptionPane.showMessageDialog(this, "A message shows up on the screen; 'The combination to the safe is: " + safeCombination + "'.");
			            }
			            else
			            {
			                killerComing();
			            }
			        }
			        // HANDLE CASE WHERE USER INPUT WAS INVALID
			        catch (NumberFormatException e)
			        {
			            killerComing();
			        }
			    }
			}
			else
			{
				JOptionPane.showMessageDialog(this, "A message shows up on the screen; 'The combination to the safe is: " + safeCombination + "'.");
			}
		}
		else
		{
			JOptionPane.showMessageDialog(this, "The computer is powered off.");
		}
	}
	
	
	// METHOD FOR SAFE
	private void handleSafe()
	{
		// CHECKS IF SAFE IS UNLOCKED
		if (!safeUnlocked)
		{
		    String input = JOptionPane.showInputDialog(this, "The safe is locked. I could try guessing the combination:");
		    // ONLY RUN IF USER HITS OK, IF USER EXITS NOTHING HAPPENS
		    if (input != null)
		    {
		        try
		        {
		        	//PARSE USER INPUT INTO INTEGER
		            int userInput = Integer.parseInt(input);
		            
		            // CHECK IF USER INPUT MATCHES DOOR CODE
		            if (userInput == safeCombination)
		            {
		            	safeUnlocked = true;
		                JOptionPane.showMessageDialog(this, "There was a gun inside. Better take it just in case.");
		    			addToInventorySlot(8, "resources/images/gun.png");
		    			gunFound = true;
		                
		            }
		            else
		            {
		                killerComing();
		            }
		        }
		        // HANDLE CASE WHERE USER INPUT WAS INVALID
		        catch (NumberFormatException e)
		        {
		            killerComing();
		        }
		    }
		}
		else
		{
			JOptionPane.showMessageDialog(this, "There is nothing else in the safe.");
		}
	}
	
	
	// METHOD FOR EXIT DOOR
	private void handleDoor()
	{
	    String input = JOptionPane.showInputDialog(this, "The door is locked with a keypad. I could try entering a code:");
	    // ONLY RUN IF USER HITS OK, IF USER EXITS NOTHING HAPPENS
	    if (input != null)
	    {
	        try
	        {
	        	//PARSE USER INPUT INTO INTEGER
	            int userInput = Integer.parseInt(input);
	            
	            // CHECK IF USER INPUT MATCHES DOOR CODE
	            if (userInput == doorCode)
	            {
	            	alarmSounded = false;
	            	JOptionPane.showMessageDialog(this, "The door opens with a creak!");
	            	if (currentItemInHand == 8 && gunFound)
	            	{
	            		this.dispose();
	            		new StoryFrame("Escape");
	            	}
	            	else
	            	{
	            		killerComing();
	            	}
	            }
	            else
	            {
	                killerComing();
	            }
	        }
	        // HANDLE CASE WHERE USER INPUT WAS INVALID
	        catch (NumberFormatException e)
	        {
	            killerComing();
	        }
	    }
	}
	
	
	// METHOD TO ADD DOOR CODE TO DOOR CODE SLOTS
	private void addDoorCodeSlot(int index, Color color)
	{
    	// LOOP THROUGH DOOR CODE SLOTS TO LOOK FOR FIRST EMPTY SLOT
        for (int i = 0; i < doorCodeSlots.length; i++)
        {
        	// FINDS FIRST EMPTY SLOT
            if (doorCodeSlots[i].getText().isEmpty())
            {
                // SET THE NUMBER TO THE FIRST OPEN SLOT
                doorCodeSlots[i].setText(String.valueOf(doorCodeDigits[index]));
                // SET COLOR OF NUMBER FOUND
                doorCodeSlots[i].setForeground(color);
                // EXIT LOOP ONCE FIRST EMPTY SPOT IS FOUND AND FILLED
                break;
            }
        }
	}
	
	
	// METHOD TO ADD ITEMS TO INVENTORY SLOTS
	private void addToInventorySlot(int slot, String imagePath)
	{
		ImageIcon itemIcon = new ImageIcon(imagePath);
        Image image = itemIcon.getImage();
        Image scaledImg = image.getScaledInstance(70, 70, Image.SCALE_SMOOTH);
        itemIcon = new ImageIcon(scaledImg);
		inventorySlots[slot].setIcon(itemIcon);
	}
	
	
	// KILLER WAS ALERTED, GAME OVER
	public void killerComing()
	{
		if (alarmSounded)
		{
			JOptionPane.showMessageDialog(this, "You hear an alarm in the distance and footsteps racing down the hallway.");
		}
		else
		{
			JOptionPane.showMessageDialog(this, "The last thought in your head was you should have had your gun ready.");
		}
        this.dispose();
        new KillerComingFrame();
	}
}
