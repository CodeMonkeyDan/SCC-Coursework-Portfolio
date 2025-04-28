import java.awt.*;


/**
 * A person that can be manipulated and that draws itself on a canvas.
 * 
 * @author  Michael K�lling and David J. Barnes
 * @version 2016.02.29
 */

public class Person
{
    private int height;
    private int width;
    private int xPosition;
    private int yPosition;
    private String color;
    private boolean isVisible;

    /**
     * Create a new person at default position with default color.
     */
    public Person()
    {
        height = 60;
        width = 30;
        xPosition = 280;
        yPosition = 190;
        color = "black";
        isVisible = false;
    }

    /**
     * Make this person visible. If it was already visible, do nothing.
     */
    public void makeVisible()
    {
        isVisible = true;
        draw();
    }
    
    /**
     * Make this person invisible. If it was already invisible, do nothing.
     */
    public void makeInvisible()
    {
        erase();
        isVisible = false;
    }
    
    /**
     * Move the person a few pixels to the right.
     */
    public void moveRight()
    {
        moveHorizontal(20);
    }

    /**
     * Move the person a few pixels to the left.
     */
    public void moveLeft()
    {
        moveHorizontal(-20);
    }

    /**
     * Move the person a few pixels up.
     */
    public void moveUp()
    {
        moveVertical(-20);
    }

    /**
     * Move the person a few pixels down.
     */
    public void moveDown()
    {
        moveVertical(20);
    }

    /**
     * Move the person horizontally by 'distance' pixels.
     */
    public void moveHorizontal(int distance)
    {
        erase();
        xPosition += distance;
        draw();
    }

    /**
     * Move the person vertically by 'distance' pixels.
     */
    public void moveVertical(int distance)
    {
        erase();
        yPosition += distance;
        draw();
    }

    /**
     * Slowly move the person horizontally by 'distance' pixels.
     */
    public void slowMoveHorizontal(int distance)
    {
        int delta;

        if(distance < 0) 
        {
            delta = -1;
            distance = -distance;
        }
        else 
        {
            delta = 1;
        }

        for(int i = 0; i < distance; i++)
        {
            xPosition += delta;
            draw();
        }
    }

    /**
     * Slowly move the person vertically by 'distance' pixels.
     */
    public void slowMoveVertical(int distance)
    {
        int delta;

        if(distance < 0) 
        {
            delta = -1;
            distance = -distance;
        }
        else 
        {
            delta = 1;
        }

        for(int i = 0; i < distance; i++)
        {
            yPosition += delta;
            draw();
        }
    }
    
    /**
     * Slowly move the person diagonally by 'distance' pixels.
     */
    public void slowMove(int horizontalDistance, int verticalDistance)
    {
        // Determine the direction for horizontal and vertical movement
        int horizontalDelta = (horizontalDistance < 0) ? -1 : 1;
        int verticalDelta = (verticalDistance < 0) ? -1 : 1;

        // Make sure distances are positive
        horizontalDistance = Math.abs(horizontalDistance);
        verticalDistance = Math.abs(verticalDistance);

        // Move diagonally by the smaller of the two distances
        int distance = Math.max(horizontalDistance, verticalDistance);

        for (int i = 0; i < distance; i++)
        {
            if (i < horizontalDistance) 
            {
                xPosition += horizontalDelta;
            }

            if (i < verticalDistance)
            {
                yPosition += verticalDelta;
            }
            draw(); // Draw after each movement step
        }
    }
    
    /**
     * Quickly move the person horizontally by 'distance' pixels.
     */
    public void fastMoveHorizontal(int distance)
    {
        int delta;

        if(distance < 0) 
        {
            delta = -3;
            distance = -distance;
        }
        else 
        {
            delta = 3;
        }

        for(int i = 0; i < distance; i++)
        {
            xPosition += delta;
            draw();
        }
    }

    /**
     * Quickly move the person vertically by 'distance' pixels.
     */
    public void fastMoveVertical(int distance)
    {
        int delta;

        if(distance < 0) 
        {
            delta = -3;
            distance = -distance;
        }
        else 
        {
            delta = 3;
        }

        for(int i = 0; i < distance; i++)
        {
            yPosition += delta;
            draw();
        }
    }
    
    /**
     * Quickly move the person diagonally by 'distance' pixels.
     */
    public void fastMove(int horizontalDistance, int verticalDistance)
    {
        // Determine the direction for horizontal and vertical movement
        int horizontalDelta = (horizontalDistance < 0) ? -3 : 3;
        int verticalDelta = (verticalDistance < 0) ? -3 : 3;

        // Make sure distances are positive
        horizontalDistance = Math.abs(horizontalDistance);
        verticalDistance = Math.abs(verticalDistance);

        // Move diagonally by the smaller of the two distances
        int distance = Math.max(horizontalDistance, verticalDistance);

        for (int i = 0; i < distance; i++)
        {
            if (i < horizontalDistance) 
            {
                xPosition += horizontalDelta;
            }

            if (i < verticalDistance)
            {
                yPosition += verticalDelta;
            }
            draw(); // Draw after each movement step
        }
    }
    
    /**
     * Run the person horizontally by 'distance' pixels.
     */
    public void runHorizontal(int distance)
    {
        int delta;

        if(distance < 0) 
        {
            delta = -6;
            distance = -distance;
        }
        else 
        {
            delta = 6;
        }

        for(int i = 0; i < distance; i++)
        {
            xPosition += delta;
            draw();
        }
    }

    /**
     * Run the person vertically by 'distance' pixels.
     */
    public void runVertical(int distance)
    {
        int delta;

        if(distance < 0) 
        {
            delta = -6;
            distance = -distance;
        }
        else 
        {
            delta = 6;
        }

        for(int i = 0; i < distance; i++)
        {
            yPosition += delta;
            draw();
        }
    }
    
    /**
     * Run the person diagonally by 'distance' pixels.
     */
    public void runMove(int horizontalDistance, int verticalDistance)
    {
        // Determine the direction for horizontal and vertical movement
        int horizontalDelta = (horizontalDistance < 0) ? -6 : 6;
        int verticalDelta = (verticalDistance < 0) ? -6 : 6;

        // Make sure distances are positive
        horizontalDistance = Math.abs(horizontalDistance);
        verticalDistance = Math.abs(verticalDistance);

        // Move diagonally by the smaller of the two distances
        int distance = Math.max(horizontalDistance, verticalDistance);

        for (int i = 0; i < distance; i++)
        {
            if (i < horizontalDistance) 
            {
                xPosition += horizontalDelta;
            }

            if (i < verticalDistance)
            {
                yPosition += verticalDelta;
            }
            draw(); // Draw after each movement step
        }
    }

    /**
     * Change the size to the new size (in pixels). Size must be >= 0.
     */
    public void changeSize(int newHeight, int newWidth)
    {
        erase();
        height = newHeight;
        width = newWidth;
        draw();
    }

    /**
     * Change the color. Valid colors are "red", "yellow", "blue", "green",
     * "magenta" and "black".
     */
    public void changeColor(String newColor)
    {
        color = newColor;
        draw();
    }

    /**
     * Draw the person with current specifications on screen.
     */
    public void draw()
    {
        int bh = (int)(height * 0.7);  // body height
        int hh = (height - bh) / 2;  // half head height
        int hw = width / 2;  // half width
        int x = xPosition;
        int y = yPosition;
        if(isVisible) {
            Canvas canvas = Canvas.getCanvas();
            int[] xpoints = { x-3, x-hw, x-hw, x-(int)(hw*0.2)-1, x-(int)(hw*0.2)-1, x-hw, 
                              x-hw+(int)(hw*0.4)+1, x, x+hw-(int)(hw*0.4)-1, x+hw, x+(int)(hw*0.2)+1, 
                              x+(int)(hw*0.2)+1, x+hw, x+hw, x+3, x+(int)(hw*0.6), 
                              x+(int)(hw*0.6), x+3, x-3, x-(int)(hw*0.6), x-(int)(hw*0.6) };
            int[] ypoints = { y, y+(int)(bh*0.2), y+(int)(bh*0.4), y+(int)(bh*0.2), 
                              y+(int)(bh*0.5), y+bh, y+bh, y+(int)(bh*0.65), y+bh, y+bh, 
                              y+(int)(bh*0.5), y+(int)(bh*0.2), y+(int)(bh*0.4), y+(int)(bh*0.2), 
                              y, y-hh+3, y-hh-3, y-hh-hh, y-hh-hh, y-hh-3, y-hh+3 };            
            canvas.draw(this, color, new Polygon(xpoints, ypoints, 21));
            canvas.wait(10);
        }
    }
    
    /**
     * Draw the person with current specifications on screen.
     */
    public void pumpRFist()
    {
        int bh = (int)(height * 0.7);  // body height
        int hh = (height - bh) / 2;  // half head height
        int hw = width / 2;  // half width
        int x = xPosition;
        int y = yPosition;
        if(isVisible) {
            Canvas canvas = Canvas.getCanvas();
            int[] xpoints = { x-3,							//1
            					x-hw,						//2
            					x-hw,						//3
            					x-(int)(hw*0.2)-1,			//4
            					x-(int)(hw*0.2)-1,			//5
            					x-hw,						//6
            					x-hw+(int)(hw*0.4)+1,		//7
            					x,							//8
            					x+hw-(int)(hw*0.4)-1,		//9
            					x+hw,						//10
            					x+(int)(hw*0.2)+1,	//9		//11
            					x+(int)(hw*0.2)+1,			//12
            					x+hw,						//13
            					x+hw,						//14
            					x+3,						//15
            					x+(int)(hw*0.6),			//16
            					x+(int)(hw*0.6),			//17
            					x+3,						//18
            					x-3,						//19
            					x-(int)(hw*0.6),			//20
            					x-(int)(hw*0.6) };			//21
            int[] ypoints = { y,							//1
            					y+(int)(bh*0.2),			//2
            					y+(int)(bh*0.4),			//3
            					y+(int)(bh*0.2), 			//4
            					y+(int)(bh*0.5),			//5
            					y+bh,						//6
            					y+bh,						//7
            					y+(int)(bh*0.65),			//8
            					y+bh,						//9
            					y+bh,						//10
            					y+(int)(bh*0.5),			//11
            					y+(int)(bh*0.2),			//12
            					y+(int)(bh*0.4)-20,			//13
            					y+(int)(bh*0.2)-20,			//14
            					y,							//15
            					y-hh+3,						//16
            					y-hh-3,						//17
            					y-hh-hh,					//18
            					y-hh-hh,					//19
            					y-hh-3,						//20
            					y-hh+3 };					//21
            canvas.draw(this, color, new Polygon(xpoints, ypoints, 21));
            canvas.wait(10);
        }
    }
    
    /**
     * Draw the person with current specifications on screen.
     */
    public void pumpLFist()
    {
        int bh = (int)(height * 0.7);  // body height
        int hh = (height - bh) / 2;  // half head height
        int hw = width / 2;  // half width
        int x = xPosition;
        int y = yPosition;
        if(isVisible) {
            Canvas canvas = Canvas.getCanvas();
            int[] xpoints = { x-3,							//1
            					x-hw,						//2
            					x-hw,						//3
            					x-(int)(hw*0.2)-1,			//4
            					x-(int)(hw*0.2)-1,			//5
            					x-hw,						//6
            					x-hw+(int)(hw*0.4)+1,		//7
            					x,							//8
            					x+hw-(int)(hw*0.4)-1,		//9
            					x+hw,						//10
            					x+(int)(hw*0.2)+1,	//9		//11
            					x+(int)(hw*0.2)+1,			//12
            					x+hw,						//13
            					x+hw,						//14
            					x+3,						//15
            					x+(int)(hw*0.6),			//16
            					x+(int)(hw*0.6),			//17
            					x+3,						//18
            					x-3,						//19
            					x-(int)(hw*0.6),			//20
            					x-(int)(hw*0.6) };			//21
            int[] ypoints = { y,							//1
            					y+(int)(bh*0.2)-20,			//2
            					y+(int)(bh*0.4)-20,			//3
            					y+(int)(bh*0.2), 			//4
            					y+(int)(bh*0.5),			//5
            					y+bh,						//6
            					y+bh,						//7
            					y+(int)(bh*0.65),			//8
            					y+bh,						//9
            					y+bh,						//10
            					y+(int)(bh*0.5),			//11
            					y+(int)(bh*0.2),			//12
            					y+(int)(bh*0.4),			//13
            					y+(int)(bh*0.2),			//14
            					y,							//15
            					y-hh+3,						//16
            					y-hh-3,						//17
            					y-hh-hh,					//18
            					y-hh-hh,					//19
            					y-hh-3,						//20
            					y-hh+3 };					//21
            canvas.draw(this, color, new Polygon(xpoints, ypoints, 21));
            canvas.wait(10);
        }
    }
    
    /**
     * Draw the person with current specifications on screen.
     */
    public void raiseBothHands()
    {
        int bh = (int)(height * 0.7);  // body height
        int hh = (height - bh) / 2;  // half head height
        int hw = width / 2;  // half width
        int x = xPosition;
        int y = yPosition;
        if(isVisible) {
            Canvas canvas = Canvas.getCanvas();
            int[] xpoints = { x-3,							//1
            					x-hw,						//2
            					x-hw,						//3
            					x-(int)(hw*0.2)-1,			//4
            					x-(int)(hw*0.2)-1,			//5
            					x-hw,						//6
            					x-hw+(int)(hw*0.4)+1,		//7
            					x,							//8
            					x+hw-(int)(hw*0.4)-1,		//9
            					x+hw,						//10
            					x+(int)(hw*0.2)+1,	//9		//11
            					x+(int)(hw*0.2)+1,			//12
            					x+hw,						//13
            					x+hw,						//14
            					x+3,						//15
            					x+(int)(hw*0.6),			//16
            					x+(int)(hw*0.6),			//17
            					x+3,						//18
            					x-3,						//19
            					x-(int)(hw*0.6),			//20
            					x-(int)(hw*0.6) };			//21
            int[] ypoints = { y,							//1
            					y+(int)(bh*0.2)-20,			//2
            					y+(int)(bh*0.4)-20,			//3
            					y+(int)(bh*0.2), 			//4
            					y+(int)(bh*0.5),			//5
            					y+bh,						//6
            					y+bh,						//7
            					y+(int)(bh*0.65),			//8
            					y+bh,						//9
            					y+bh,						//10
            					y+(int)(bh*0.5),			//11
            					y+(int)(bh*0.2),			//12
            					y+(int)(bh*0.4)-20,			//13
            					y+(int)(bh*0.2)-20,			//14
            					y,							//15
            					y-hh+3,						//16
            					y-hh-3,						//17
            					y-hh-hh,					//18
            					y-hh-hh,					//19
            					y-hh-3,						//20
            					y-hh+3 };					//21
            canvas.draw(this, color, new Polygon(xpoints, ypoints, 21));
            canvas.wait(10);
        }
    }

    /**
     * Erase the person on screen.
     */
    private void erase()
    {
        if(isVisible) {
            Canvas canvas = Canvas.getCanvas();
            canvas.erase(this);
        }
    }
}
