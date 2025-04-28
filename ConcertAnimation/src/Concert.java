//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #9: Animation


import java.util.Random;


public class Concert
{
	//declare objects
	//stage and steps
	private Square stage;
	private Square step1;
	private Square step1Shadow;
	private Square step2;
	private Square step2Shadow;
	private Square step3;
	
	//phil and mic
	private Person phil;
	private Square micBase;
	private Square micStand;
	private MicrophoneHandle micHandle;
	private Circle micHead;
	
	//darrell and guitar
	private Person darrell;
	private Guitar darrellGuitar;
	
	//rex and guitar
	private Person rex;
	private Guitar rexGuitar;
	
	//vinnie and drums
	private Person vinnie;
	private MicrophoneHandle leftStick;
	private MicrophoneHandle rightStick;
	private Circle drum1;
	private Circle drum1Trim;
	private Circle drum2;
	private Circle drum2Trim;
	private Square drum3;
	private Square drum3Trim;
	private Square drum4;
	private Square drum4Trim;
	
	//lightbar
	private Square lightBar;
	private Square lightBarTrim;
	private Circle[] light = new Circle[10];
	
	//random number generator
	private Random random = new Random();

	//person array
	private Person[] fan = new Person[9];
	
	//system time for pauses in animation
	long endTime = System.currentTimeMillis();
	
	//drawn boolean
	private boolean drawn;
	

	public Concert()
	{
		//initialize objects
		//initialize stage
		stage = new Square();
		step1 = new Square();
		step1Shadow = new Square();
		step2 = new Square();
		step2Shadow = new Square();
		step3 = new Square();
		
		//initialize lights
		lightBar = new Square();
		lightBarTrim = new Square();
        //initialize the light circles array
        for (int i = 0; i < light.length; i++)
        {
            light[i] = new Circle();
        }
		
        //initialize phil and mic
		phil = new Person();
		micBase = new Square();
		micStand = new Square();
		micHandle = new MicrophoneHandle();
		micHead = new Circle();
		
		//initialize darrell and guitar
		darrell = new Person();
		darrellGuitar = new Guitar();
		
		//initialize rex and guitar
		rex = new Person();
		rexGuitar = new Guitar();
		
		//initialize vinnie and drums
		vinnie = new Person();
		leftStick = new MicrophoneHandle();
		rightStick = new MicrophoneHandle();
		drum1 = new Circle();
		drum1Trim = new Circle();
		drum2 = new Circle();
		drum2Trim = new Circle();
		drum3 = new Square();
		drum3Trim = new Square();
		drum4 = new Square();
		drum4Trim = new Square();
		
        //initialize the light circles array
        for (int i = 0; i < fan.length; i++)
        {
            fan[i] = new Person();
        }
		
        //initialize drawn boolean
		drawn = false;
	}
	
	
	//draw canvas - set up stage
	public void draw()
	{
		if (!drawn)
		{
			//draw stage
            stage.changeColor("lightGray");
            stage.moveHorizontal(-310);
            stage.moveVertical(-120);
            stage.changeSize(250, 1000);
            stage.makeVisible();
            
            //draw step1
            step1.changeColor("gray");
            step1.moveHorizontal(460);
            step1.moveVertical(130);
            step1.changeSize(15, 100);
            step1.makeVisible();
            
            //draw step2
            step2.changeColor("gray");
            step2.moveHorizontal(465);
            step2.moveVertical(145);
            step2.changeSize(15, 90);
            step2.makeVisible();
            
            //draw shadow for step1
            step1Shadow.changeColor("black");
            step1Shadow.moveHorizontal(465);
            step1Shadow.moveVertical(145);
            step1Shadow.changeSize(2, 90);
            step1Shadow.makeVisible();
            
            //draw step3
            step3.changeColor("gray");
            step3.moveHorizontal(470);
            step3.moveVertical(160);
            step3.changeSize(15, 80);
            step3.makeVisible();
            
            //draw shadow for step2
            step2Shadow.changeColor("black");
            step2Shadow.moveHorizontal(470);
            step2Shadow.moveVertical(160);
            step2Shadow.changeSize(2, 80);
            step2Shadow.makeVisible();
            
            //draw lightbar
            lightBarTrim.changeColor("gray");
            lightBarTrim.moveHorizontal(288);
            lightBarTrim.moveVertical(-117);
            lightBarTrim.changeSize(24,264);
            lightBarTrim.makeVisible();
            lightBar.changeColor("black");
            lightBar.moveHorizontal(290);
            lightBar.moveVertical(-115);
            lightBar.changeSize(20,260);
            lightBar.makeVisible();
            //loop through lights and draw them
            for (int i = 0; i < light.length; i++)
            {
                light[i].changeColor("green");
                light[i].moveHorizontal(380 + (i * 25)); // Adjust horizontal position for each light
                light[i].moveVertical(-83);
                light[i].changeSize(15);
                light[i].makeVisible();
            }
            
            //draw phil and mic
            phil.moveHorizontal(175);
            phil.moveVertical(-30);
            phil.makeVisible();
            micBase.changeColor("gray");
            micBase.moveHorizontal(260);
            micBase.moveVertical(110);
            micBase.changeSize(5, 21);
            micBase.makeVisible();
            micStand.changeColor("gray");
            micStand.moveHorizontal(269);
            micStand.moveVertical(80);
            micStand.changeSize(30,5);
            micStand.makeVisible();
            micHandle.moveHorizontal(395);
            micHandle.moveVertical(0);
            micHandle.makeVisible();
            micHead.changeColor("darkGray");
            micHead.moveHorizontal(335);
            micHead.moveVertical(95);
            micHead.changeSize(10);
            micHead.makeVisible();
            
            //draw darrell and guitar
            darrell.moveHorizontal(0);
            darrell.moveVertical(-20);
            darrell.makeVisible();
            darrellGuitar.changeColor("darkRed");
            darrellGuitar.moveHorizontal(105);
            darrellGuitar.moveVertical(-10);
            darrellGuitar.makeVisible();

            //draw rex and guitar
            rex.moveHorizontal(420);
            rex.moveVertical(-60);
            rex.makeVisible();
            rexGuitar.changeColor("darkBlue");
            rexGuitar.moveHorizontal(525);
            rexGuitar.moveVertical(-50);
            rexGuitar.makeVisible();

            //draw vinnie and drums
            drum3Trim.changeColor("gray");
            drum3Trim.moveHorizontal(98);
            drum3Trim.moveVertical(-67);
            drum3Trim.changeSize(21);
            drum3Trim.makeVisible();
            drum3.changeColor("black");
            drum3.moveHorizontal(100);
            drum3.moveVertical(-65);
            drum3.changeSize(17);
            drum3.makeVisible();
            drum4Trim.changeColor("gray");
            drum4Trim.moveHorizontal(139);
            drum4Trim.moveVertical(-67);
            drum4Trim.changeSize(21);
            drum4Trim.makeVisible();
            drum4.changeColor("black");
            drum4.moveHorizontal(141);
            drum4.moveVertical(-65);
            drum4.changeSize(17);
            drum4.makeVisible();
            vinnie.moveHorizontal(160);
            vinnie.moveVertical(-150);
            vinnie.makeVisible();
            leftStick.changeColor("tan");
            leftStick.moveHorizontal(231);
            leftStick.moveVertical(-154);
            leftStick.makeVisible();
            rightStick.changeColor("tan");
            rightStick.moveHorizontal(261);
            rightStick.moveVertical(-154);
            rightStick.makeVisible();
            drum1Trim.changeColor("gray");
            drum1Trim.moveHorizontal(178);
            drum1Trim.moveVertical(-27);
            drum1Trim.changeSize(29);
            drum1Trim.makeVisible();
            drum1.changeColor("black");
            drum1.moveHorizontal(180);
            drum1.moveVertical(-25);
            drum1.changeSize(25);
            drum1.makeVisible();
            drum2Trim.changeColor("gray");
            drum2Trim.moveHorizontal(210);
            drum2Trim.moveVertical(-27);
            drum2Trim.changeSize(29);
            drum2Trim.makeVisible();
            drum2.changeColor("black");
            drum2.moveHorizontal(212);
            drum2.moveVertical(-25);
            drum2.changeSize(25);
            drum2.makeVisible();
            
            //draw fans
            fan[0].moveHorizontal(-170);
            fan[0].moveVertical(100);
            fan[0].changeSize(50, 30);
            fan[0].makeVisible();
            fan[1].moveHorizontal(-150);
            fan[1].moveVertical(350);
            fan[1].changeSize(70, 30);
            fan[1].makeVisible();
            fan[2].moveHorizontal(0);
            fan[2].moveVertical(200);
            fan[2].changeSize(50, 50);
            fan[2].makeVisible();
            fan[3].moveHorizontal(120);
            fan[3].moveVertical(230);
            fan[3].changeSize(50, 40);
            fan[3].makeVisible();
            fan[4].moveHorizontal(220);
            fan[4].moveVertical(340);
            fan[4].changeSize(40, 20);
            fan[4].makeVisible();
            fan[5].moveHorizontal(310);
            fan[5].moveVertical(110);
            fan[5].changeSize(55, 25);
            fan[5].makeVisible();
            fan[6].moveHorizontal(450);
            fan[6].moveVertical(220);
            fan[6].changeSize(45, 30);
            fan[6].makeVisible();
            fan[7].moveHorizontal(500);
            fan[7].moveVertical(300);
            fan[7].changeSize(50, 35);
            fan[7].makeVisible();
            fan[8].moveHorizontal(600);
            fan[8].moveVertical(90);
            fan[8].changeSize(45, 25);
            fan[8].makeVisible();

            //change drawn boolean to true
			drawn = true;
		}
	}
	
	
	//method to animate the video
	public void animate()
	{
		drawn = false;
		draw();
		
		//intro - light show and start music
		for (int i = 0; i < 10; i++)
		{
			lightShow();
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 200;
	        while (System.currentTimeMillis() < endTime);
			
		}
		//start music
		Music.PlayMusic("resources/audio/Walk.wav");
		//another brief light show
		for (int i = 0; i < 7; i++)
		{
			lightShow();
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 200;
	        while (System.currentTimeMillis() < endTime);
			
		}
		
		
		//vinnie starts playing drums
		for (int i = 0; i < 5; i++)
		{
			leftStick.play();
			rightStick.play();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 200;
	        while (System.currentTimeMillis() < endTime);
	        
	        leftStick.draw();
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 200;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.play();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 200;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 200;
	        while (System.currentTimeMillis() < endTime);
		}
		
		
		//vinnie speeds up drums
		for (int i = 0; i < 10; i++)
		{
			leftStick.play();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 50;
	        while (System.currentTimeMillis() < endTime);
	        
	        leftStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 50;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.play();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 50;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 50;
	        while (System.currentTimeMillis() < endTime);
		}
		
		
		//phil pumps up crowd
		for (int i = 0; i < 2; i++)
		{
			leftStick.play();
			rightStick.play();
			phil.pumpLFist();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 200;
	        while (System.currentTimeMillis() < endTime);
	        
	        leftStick.draw();
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 200;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.play();
	        phil.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 200;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 200;
	        while (System.currentTimeMillis() < endTime);
		}
		
		
		//couple fans join in
		for (int i = 0; i < 2; i++)
		{
			leftStick.play();
			rightStick.play();
			phil.pumpLFist();
			fan[3].pumpRFist();
			fan[5].pumpRFist();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 190;
	        while (System.currentTimeMillis() < endTime);
	        
	        leftStick.draw();
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 190;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.play();
	        phil.draw();
	        fan[3].draw();
	        fan[5].draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 190;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 190;
	        while (System.currentTimeMillis() < endTime);
		}
		
		
		//more fans join in
		for (int i = 0; i < 3; i++)
		{
			leftStick.play();
			rightStick.play();
			phil.pumpLFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[8].pumpRFist();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 175;
	        while (System.currentTimeMillis() < endTime);
	        
	        leftStick.draw();
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 175;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.play();
	        phil.draw();
	        fan[2].draw();
	        fan[3].draw();
	        fan[4].draw();
	        fan[5].draw();
	        fan[8].draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 175;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 175;
	        while (System.currentTimeMillis() < endTime);
		}
		
		
		//all fans join in
			fistPumping(2, true);
		
		
		//phil works his way to front of stage
		for (int i = 0; i < 2; i++)
		{
			leftStick.play();
			rightStick.play();
			phil.fastMove(-3, 2);
			for (int j = 0; j < fan.length; j++)
			{
				fan[j].pumpRFist();
			}
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        leftStick.draw();
	        rightStick.draw();
			phil.fastMove(-3, 2);
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.play();
			phil.fastMove(-3, 2);
			for (int j = 0; j < fan.length; j++)
			{
				fan[j].draw();
			}
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.draw();
			phil.fastMove(-2, 1);
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
		}
		
		
		//phil pumps up crowd second time
			fistPumping(3, true);
		
		
		//phil moves to other side of stage
		for (int i = 0; i < 4; i++)
		{
			leftStick.play();
			rightStick.play();
			phil.fastMoveHorizontal(2);
			for (int j = 0; j < fan.length; j++)
			{
				fan[j].pumpRFist();
			}
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        leftStick.draw();
	        rightStick.draw();
			phil.fastMoveHorizontal(2);
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.play();
			phil.fastMoveHorizontal(2);
			for (int j = 0; j < fan.length; j++)
			{
				fan[j].draw();
			}
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.draw();
			phil.fastMoveHorizontal(2);
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
		}
		
		
		//phil pumps up crowd third time
			fistPumping(3, true);
        
		
        //phil makes his way to the mic pt1
			leftStick.play();
			rightStick.play();
			phil.fastMove(2, -2);
			for (int j = 0; j < fan.length; j++)
			{
				fan[j].pumpRFist();
			}
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        leftStick.draw();
	        rightStick.draw();
			phil.fastMove(1, -1);
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.play();
			phil.fastMoveHorizontal(2);
			for (int j = 0; j < fan.length; j++)
			{
				fan[j].draw();
			}
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.draw();
			phil.fastMoveHorizontal(2);
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
		
		
		//phil works his way to mic pt2
        for (int i = 0; i < 2; i++)
        {
    		leftStick.play();
    		rightStick.play();
    		phil.fastMoveHorizontal(2);
    		for (int j = 0; j < fan.length; j++)
    		{
    			fan[j].pumpRFist();
    		}
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            long endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
    		phil.fastMoveHorizontal(2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.play();
    		phil.fastMoveHorizontal(2);
    		for (int j = 0; j < fan.length; j++)
    		{
    			fan[j].draw();
    		}
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
    		phil.fastMoveHorizontal(2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
        }

        
		//singing starts, fans continue
			fistPumping(3, false);

		
		//fans move to front of stage pt1
		for (int i = 0; i < 2; i++)
		{
			leftStick.play();
			rightStick.play();
			fan[0].pumpRFist();
			fan[1].pumpRFist();
			fan[2].fastMove(2, -2);
			fan[2].pumpRFist();
			fan[3].fastMove(1, -2);
			fan[3].pumpRFist();
			fan[4].fastMoveVertical(-3);
			fan[4].pumpRFist();
			fan[5].fastMove(-1, -2);
			fan[5].pumpRFist();
			fan[6].pumpRFist();
			fan[7].pumpRFist();
			fan[8].pumpRFist();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 50;
	        while (System.currentTimeMillis() < endTime);
	        
	        leftStick.draw();
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 50;
	        while (System.currentTimeMillis() < endTime);
			
	        rightStick.play();
	        fan[0].draw();
	        fan[1].draw();
			fan[2].fastMove(2, -2);
			fan[3].fastMove(1, -2);
			fan[4].fastMoveVertical(-3);
			fan[5].fastMove(-1, -2);
	        fan[6].draw();
	        fan[7].draw();
	        fan[8].draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 50;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 50;
	        while (System.currentTimeMillis() < endTime);
		}
		

		//fans move to front of stage pt2
        for (int i = 0; i < 3; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].fastMove(3, -1);
			fan[0].pumpRFist();
			fan[1].fastMove(2, -2);
			fan[1].pumpRFist();
			fan[2].fastMove(2, -2);
			fan[2].pumpRFist();
			fan[3].fastMove(1, -2);
			fan[3].pumpRFist();
			fan[4].fastMoveVertical(-3);
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].fastMove(-2, -2);
			fan[6].pumpRFist();
			fan[7].fastMove(-1, -2);
			fan[7].pumpRFist();
			fan[8].pumpRFist();
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 50;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 50;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].fastMove(3, -1);
			fan[1].fastMove(2, -2);
    		fan[2].fastMove(2, -2);
    		fan[3].fastMove(1, -2);
    		fan[4].fastMoveVertical(-3);
			fan[5].draw();
			fan[6].fastMove(-2, -2);
			fan[7].fastMove(-1, -2);
            fan[8].draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 50;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 50;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//fans move to front of stage pt3
        for (int i = 0; i < 5; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].fastMoveHorizontal(2);
			fan[0].pumpRFist();
			fan[1].fastMove(2, -2);
			fan[1].pumpRFist();
			fan[2].fastMove(2, -2);
			fan[2].pumpRFist();
			fan[3].fastMove(1, -2);
			fan[3].pumpRFist();
			fan[4].fastMoveVertical(-3);
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].fastMove(-2, -2);
			fan[6].pumpRFist();
			fan[7].fastMove(-1, -2);
			fan[7].pumpRFist();
			fan[8].pumpRFist();
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].fastMoveHorizontal(2);
			fan[1].fastMove(2, -2);
    		fan[2].fastMove(2, -2);
    		fan[3].fastMove(1, -2);
    		fan[4].fastMoveVertical(-3);
			fan[5].draw();
			fan[6].fastMove(-2, -2);
			fan[7].fastMove(-1, -2);
            fan[8].draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//fans move to front of stage pt4
        for (int i = 0; i < 2; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].fastMoveHorizontal(2);
			fan[0].pumpRFist();
			fan[1].fastMove(2, -2);
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].fastMove(1, -2);
			fan[3].pumpRFist();
			fan[4].fastMove(2, -2);
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].fastMove(-2, 2);
			fan[6].pumpRFist();
			fan[7].fastMove(-1, -2);
			fan[7].pumpRFist();
			fan[8].pumpRFist();
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].fastMoveHorizontal(2);
			fan[1].fastMove(2, -2);
    		fan[2].draw();
    		fan[3].fastMove(1, -2);
			fan[4].fastMove(2, -2);
			fan[5].draw();
			fan[6].fastMove(-2, 2);
			fan[7].fastMove(-1, -2);
            fan[8].draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//fans move to front of stage pt5
        for (int i = 0; i < 2; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].fastMoveHorizontal(2);
			fan[0].pumpRFist();
			fan[1].fastMove(2, -2);
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].fastMove(1, -2);
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].fastMoveHorizontal(-2);
			fan[6].pumpRFist();
			fan[7].fastMove(-1, -2);
			fan[7].pumpRFist();
			fan[8].pumpRFist();
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].fastMoveHorizontal(2);
			fan[1].fastMove(2, -2);
    		fan[2].draw();
    		fan[3].draw();
			fan[4].fastMove(1, -2);
			fan[5].draw();
			fan[6].fastMoveHorizontal(-2);
			fan[7].fastMove(-1, -2);
            fan[8].draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//fans move to front of stage pt6
        for (int i = 0; i < 2; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].fastMoveHorizontal(2);
			fan[0].pumpRFist();
			fan[1].fastMove(2, -2);
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].fastMoveVertical(-2);
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].fastMoveHorizontal(-2);
			fan[6].pumpRFist();
			fan[7].fastMove(-1, -2);
			fan[7].pumpRFist();
			fan[8].pumpRFist();
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].fastMoveHorizontal(2);
			fan[1].fastMove(2, -2);
    		fan[2].draw();
    		fan[3].draw();
			fan[4].fastMoveVertical(-2);
			fan[5].draw();
			fan[6].fastMoveHorizontal(-2);
			fan[7].fastMove(-1, -2);
            fan[8].draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//fans move to front of stage pt7
        for (int i = 0; i < 3; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].fastMoveHorizontal(2);
			fan[0].pumpRFist();
			fan[1].fastMove(2, -2);
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].fastMoveHorizontal(-2);
			fan[6].pumpRFist();
			fan[7].fastMoveHorizontal(-2);
			fan[7].pumpRFist();
			fan[8].pumpRFist();
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].fastMoveHorizontal(2);
			fan[1].fastMove(2, -2);
    		fan[2].draw();
    		fan[3].draw();
			fan[4].draw();
			fan[5].draw();
			fan[6].fastMoveHorizontal(-2);
			fan[7].fastMoveHorizontal(-2);
            fan[8].draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//fans move to front of stage pt8
        for (int i = 0; i < 3; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].pumpRFist();
			fan[1].fastMoveHorizontal(2);
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].fastMoveHorizontal(-2);
			fan[6].pumpRFist();
			fan[7].fastMoveHorizontal(-2);
			fan[7].pumpRFist();
			fan[8].pumpRFist();
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].draw();
			fan[1].fastMoveHorizontal(2);
    		fan[2].draw();
    		fan[3].draw();
			fan[4].draw();
			fan[5].draw();
			fan[6].fastMoveHorizontal(-2);
			fan[7].fastMoveHorizontal(-2);
            fan[8].draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//fans move to front of stage pt9
        for (int i = 0; i < 3; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].pumpRFist();
			fan[1].fastMoveHorizontal(2);
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].fastMoveHorizontal(-2);
			fan[6].pumpRFist();
			fan[7].fastMove(-2, 1);
			fan[7].pumpRFist();
			fan[8].pumpRFist();
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].draw();
			fan[1].fastMoveHorizontal(2);
    		fan[2].draw();
    		fan[3].draw();
			fan[4].draw();
			fan[5].draw();
			fan[6].fastMoveHorizontal(-2);
			fan[7].fastMove(-2, 1);
            fan[8].draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//fans move to front of stage pt10
        for (int i = 0; i < 4; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].pumpRFist();
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].pumpRFist();
			fan[7].fastMoveHorizontal(-2);
			fan[7].pumpRFist();
			fan[8].pumpRFist();
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].draw();
			fan[1].draw();
    		fan[2].draw();
    		fan[3].draw();
			fan[4].draw();
			fan[5].draw();
			fan[6].draw();
			fan[7].fastMoveHorizontal(-2);
            fan[8].draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 175;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//singing starts, fans continue
	        fistPumping(1, false);
	        fistPumping(14, true);
	        fistPumping(8, false);
        
        
		//fan works his way on stage pt1
        for (int i = 0; i < 5; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].pumpRFist();
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].pumpRFist();
			fan[7].pumpRFist();
			fan[7].pumpRFist();
			fan[8].fastMoveHorizontal(-2);
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].draw();
			fan[1].draw();
    		fan[2].draw();
    		fan[3].draw();
			fan[4].draw();
			fan[5].draw();
			fan[6].draw();
			fan[7].draw();
			fan[8].fastMoveHorizontal(-2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//fan works his way on stage pt2
        for (int i = 0; i < 6; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].pumpRFist();
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].pumpRFist();
			fan[7].pumpRFist();
			fan[7].pumpRFist();
			fan[8].fastMoveVertical(-2);
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].draw();
			fan[1].draw();
    		fan[2].draw();
    		fan[3].draw();
			fan[4].draw();
			fan[5].draw();
			fan[6].draw();
			fan[7].draw();
			fan[8].fastMoveVertical(-2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//fan works his way on stage pt3
        for (int i = 0; i < 6; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].pumpRFist();
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].pumpRFist();
			fan[7].pumpRFist();
			fan[7].pumpRFist();
			fan[8].fastMoveHorizontal(-2);
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
			fan[8].fastMoveHorizontal(-2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].draw();
			fan[1].draw();
    		fan[2].draw();
    		fan[3].draw();
			fan[4].draw();
			fan[5].draw();
			fan[6].draw();
			fan[7].draw();
			fan[8].fastMoveHorizontal(-2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
			fan[8].fastMoveHorizontal(-2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//fan works his way on stage pt4
        for (int i = 0; i < 3; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].pumpRFist();
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].pumpRFist();
			fan[7].pumpRFist();
			fan[7].pumpRFist();
			fan[8].fastMove(-2, -2);
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
			fan[8].fastMove(-2, -2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].draw();
			fan[1].draw();
    		fan[2].draw();
    		fan[3].draw();
			fan[4].draw();
			fan[5].draw();
			fan[6].draw();
			fan[7].draw();
			fan[8].fastMove(-2, -2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
			fan[8].fastMove(-2, -2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//fan works his way on stage pt5
        for (int i = 0; i < 8; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].pumpRFist();
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].pumpRFist();
			fan[7].pumpRFist();
			fan[7].pumpRFist();
			fan[8].fastMoveHorizontal(-2);
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
			fan[8].fastMoveHorizontal(-2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].draw();
			fan[1].draw();
    		fan[2].draw();
    		fan[3].draw();
			fan[4].draw();
			fan[5].draw();
			fan[6].draw();
			fan[7].draw();
			fan[8].fastMoveHorizontal(-2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
			fan[8].fastMoveHorizontal(-2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//fan works his way on stage pt6
			leftStick.play();
			rightStick.play();
			fan[0].pumpRFist();
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].pumpRFist();
			fan[7].pumpRFist();
			fan[7].pumpRFist();
			fan[8].fastMove(-2, -2);
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        leftStick.draw();
	        rightStick.draw();
			fan[8].fastMove(-2, -2);
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
			
	        rightStick.play();
			fan[0].draw();
			fan[1].draw();
			fan[2].draw();
			fan[3].draw();
			fan[4].draw();
			fan[5].draw();
			fan[6].draw();
			fan[7].draw();
			fan[8].fastMove(-2, -2);
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.draw();
			fan[8].fastMove(-2, -2);
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);

        
		//fan works his way on stage pt7
        for (int i = 0; i < 4; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].pumpRFist();
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].pumpRFist();
			fan[7].pumpRFist();
			fan[7].pumpRFist();
			fan[8].fastMoveVertical(-2);
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
			fan[8].fastMoveVertical(-2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].draw();
			fan[1].draw();
    		fan[2].draw();
    		fan[3].draw();
			fan[4].draw();
			fan[5].draw();
			fan[6].draw();
			fan[7].draw();
			fan[8].fastMoveVertical(-2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
			fan[8].fastMoveVertical(-2);
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//fan get crowd ready to catch
        for (int i = 0; i < 3; i++)
        {
    		leftStick.play();
    		rightStick.play();
			fan[0].pumpRFist();
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].pumpRFist();
			fan[7].pumpRFist();
			fan[7].pumpRFist();
			fan[8].raiseBothHands();
			lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            leftStick.draw();
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
    		
            rightStick.play();
			fan[0].draw();
			fan[1].draw();
    		fan[2].draw();
    		fan[3].draw();
			fan[4].draw();
			fan[5].draw();
			fan[6].draw();
			fan[7].draw();
			fan[8].draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
            
            rightStick.draw();
    		lightShow();
    		
            //set delay 1 second = 1000 milliseconds
            endTime = System.currentTimeMillis() + 150;
            while (System.currentTimeMillis() < endTime);
        }
        
        
		//fan runs towards crowd
			leftStick.play();
			rightStick.play();
	        for (int i = 0; i < fan.length-1; i++)
	        {
	        	fan[i].raiseBothHands();
	        }
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        leftStick.draw();
	        rightStick.draw();
	        fan[8].runVertical(33);
			lightShow();
			
	        rightStick.play();
	        fan[8].runVertical(4);
			lightShow();
			
			fan[8].fastMove(4, -4);
			fan[8].fastMoveHorizontal(4);
			fan[8].fastMove(16, 16);
			fan[8].slowMove(3, -3);
			fan[8].slowMoveHorizontal(3);
			fan[8].slowMove(8, 8);
			fan[8].slowMove(2, -2);
			fan[8].slowMoveHorizontal(2);
			fan[8].slowMove(4, 4);
			
			rightStick.draw();
			lightShow();
			
			//set delay 1 second = 1000 milliseconds
			endTime = System.currentTimeMillis() + 150;
			while (System.currentTimeMillis() < endTime);
		
		
		//fan works his way back into position pt1
		for (int i = 0; i < 2; i++)
		{
			leftStick.play();
			rightStick.play();
			fan[0].pumpRFist();
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].pumpRFist();
			fan[7].pumpRFist();
			fan[7].pumpRFist();
			fan[8].fastMove(2, 2);
			fan[8].pumpRFist();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        leftStick.draw();
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
			
	        rightStick.play();
			fan[0].draw();
			fan[1].draw();
			fan[2].draw();
			fan[3].draw();
			fan[4].draw();
			fan[5].draw();
			fan[6].draw();
			fan[7].draw();
			fan[8].fastMove(2, 2);
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
		}

		
		//fan works his way back into position pt2
		for (int i = 0; i < 2; i++)
		{
			leftStick.play();
			rightStick.play();
			fan[0].pumpRFist();
			fan[1].pumpRFist();
			fan[2].pumpRFist();
			fan[3].pumpRFist();
			fan[4].pumpRFist();
			fan[5].pumpRFist();
			fan[6].pumpRFist();
			fan[7].pumpRFist();
			fan[7].pumpRFist();
			fan[8].fastMoveVertical(2);
			fan[8].pumpRFist();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        leftStick.draw();
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
			
	        rightStick.play();
			fan[0].draw();
			fan[1].draw();
			fan[2].draw();
			fan[3].draw();
			fan[4].draw();
			fan[5].draw();
			fan[6].draw();
			fan[7].draw();
			fan[8].fastMoveVertical(2);
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
		}
		
		
		//phil and fans fist pumping - RESPECT
			fistPumping(29, true);
		
		//getting in place for solo, fans in awe
			leftStick.play();
			rightStick.play();
			for (int i = 0; i < 35; i++)
			{
				darrell.slowMove(1, 1);
				darrellGuitar.slowMove(1, 1);
				lightShow();
			}
	
	        leftStick.draw();
	        rightStick.draw();
			for (int i = 0; i < 30; i++)
			{
				phil.slowMove(-1, -1);
				lightShow();
			}
	        phil.raiseBothHands();
	
			rightStick.play();
			for (int i = 0; i < fan.length; i++)
			{
				fan[i].raiseBothHands();
				lightShow();
			}
	        
	        rightStick.draw();
        
        //guitar solo with crazy light show
        int counter = 0;
		for (int i = 0; i < 780; i++)
		{
			lightShow();
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 20;
	        while (System.currentTimeMillis() < endTime);
	        
	        if ((counter - 10) % 40 ==0)
	        {
	    		leftStick.play();
	    		rightStick.play();
	        }
	        if ((counter - 20) % 40 ==0)
	        {
	            leftStick.draw();
	            rightStick.draw();
	        }
	        if ((counter - 30) % 40 ==0)
	        {
	    		rightStick.play();
	        }
	        if ((counter - 40) % 40 ==0)
	        {
	            rightStick.draw();
	        }
	        counter++;
		}
		
		
		//phil and darrell return to positions
			leftStick.play();
			rightStick.play();
			for (int i = 0; i < 30; i++)
			{
				phil.slowMove(1, 1);
				lightShow();
			}
	
	        leftStick.draw();
	        rightStick.draw();
			for (int i = 0; i < 35; i++)
			{
				darrell.slowMove(-1, -1);
				darrellGuitar.slowMove(-1, -1);
				lightShow();
			}
	
			rightStick.play();
			for (int i = 0; i < fan.length; i++)
			{
				fan[i].draw();
				lightShow();
			}
	        
	        rightStick.draw();
        
        
	    //phil and fans fist pumping again
	        fistPumping(40, true);
        
        
		//vinnie speeds up drums and crazy light show for ending
		for (int i = 0; i < 30; i++)
		{
			phil.slowMove(-1, -1);
			lightShow();
		}
        phil.raiseBothHands();
        lightShow();
		for (int i = 0; i < fan.length; i++)
		{
			fan[i].raiseBothHands();
			lightShow();
		}
		for (int i = 0; i < 100; i++)
		{
			leftStick.play();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 50;
	        while (System.currentTimeMillis() < endTime);
	        
	        leftStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 50;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.play();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 50;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 50;
	        while (System.currentTimeMillis() < endTime);
		}
		
		
		//song ends, canvas closes, exit program frame called
		Canvas.getCanvas().closeCanvas();
		new ExitProgram();
	}
	
	
	//method to run the light show
	public void lightShow()
	{
		//set colors for light show
		String[] colors = { "red", "blue", "yellow", "green", "white" };
		
		//randomize the light to be switched, the color it turns, and if it get toggled on or off
		int lightIndex = random.nextInt(10);
		int colorIndex = random.nextInt(colors.length);
		int lightToggle = random.nextInt(3);
		
		//lights are toggled 2:1 on:off
		if (lightToggle == 1)
		{
            light[lightIndex].changeColor("black");
		}
		else
		{
            light[lightIndex].changeColor(colors[colorIndex]);
		}
	}
	
	
	//method for fist pumping, with or without phil
	public void fistPumping(int duration, boolean withPhil)
	{
		for (int i = 0; i < duration; i++)
		{
			leftStick.play();
			rightStick.play();
			if (withPhil) phil.pumpLFist();
			for (int j = 0; j < fan.length; j++)
			{
				fan[j].pumpRFist();
			}
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        leftStick.draw();
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.play();
			if (withPhil) phil.draw();
			for (int j = 0; j < fan.length; j++)
			{
				fan[j].draw();
			}
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
	        
	        rightStick.draw();
			lightShow();
			
	        //set delay 1 second = 1000 milliseconds
	        endTime = System.currentTimeMillis() + 150;
	        while (System.currentTimeMillis() < endTime);
		}
	}
}
