//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #9: Animation


import java.awt.Polygon;


public class Guitar
{
    private int xPosition;
    private int yPosition;
    private String color;
    private boolean isVisible;

    /**
     * Create a new guitar at default position with default color.
     */
    public Guitar()
    {
        xPosition = 180;
        yPosition = 190;
        color = "red";
        isVisible = false;
    }

    /**
     * Make this guitar visible. If it was already visible, do nothing.
     */
    public void makeVisible()
    {
        isVisible = true;
        draw();
    }
    
    /**
     * Make this guitar invisible. If it was already invisible, do nothing.
     */
    public void makeInvisible()
    {
        erase();
        isVisible = false;
    }
    
    /**
     * Move the guitar a few pixels to the right.
     */
    public void moveRight()
    {
        moveHorizontal(20);
    }

    /**
     * Move the guitar a few pixels to the left.
     */
    public void moveLeft()
    {
        moveHorizontal(-20);
    }

    /**
     * Move the guitar a few pixels up.
     */
    public void moveUp()
    {
        moveVertical(-20);
    }

    /**
     * Move the guitar a few pixels down.
     */
    public void moveDown()
    {
        moveVertical(20);
    }

    /**
     * Move the guitar horizontally by 'distance' pixels.
     */
    public void moveHorizontal(int distance)
    {
        erase();
        xPosition += distance;
        draw();
    }

    /**
     * Move the guitar vertically by 'distance' pixels.
     */
    public void moveVertical(int distance)
    {
        erase();
        yPosition += distance;
        draw();
    }

    /**
     * Slowly move the guitar horizontally by 'distance' pixels.
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
     * Slowly move the guitar vertically by 'distance' pixels.
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
     * Slowly move the guitar diagonally by 'distance' pixels.
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
     * Change the color. Valid colors are "red", "yellow", "blue", "green",
     * "magenta" and "black".
     */
    public void changeColor(String newColor)
    {
        color = newColor;
        draw();
    }

    /**
     * Draw the guitar with current specifications on screen.
     */
    private void draw()
    {
        int x = xPosition;
        int y = yPosition;
        if(isVisible) {
            Canvas canvas = Canvas.getCanvas();
            int[] xpoints = { x, x+16, x+21, x+19, x+25, x+17, x+1, x+5, x-6, x-18, x-13, x-23, x-10, x-2 };
            int[] ypoints = { y, y-4,  y-9,  y-3,  y+2,  y-1,  y+3, y+7, y+8, y+16, y+7,  y+2,  y+2,  y-5 };
            canvas.draw(this, color, new Polygon(xpoints, ypoints, 14));
            canvas.wait(10);
        }
    }

    /**
     * Erase the guitar on screen.
     */
    private void erase()
    {
        if(isVisible) {
            Canvas canvas = Canvas.getCanvas();
            canvas.erase(this);
        }
    }

}
