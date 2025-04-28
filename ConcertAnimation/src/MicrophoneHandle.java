//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #9: Animation


import java.awt.*;


public class MicrophoneHandle
{
    private int xPosition;
    private int yPosition;
    private String color;
    private boolean isVisible;

    /**
     * Create a new handle/drumstick at default position with default color.
     */
    public MicrophoneHandle()
    {
        xPosition = 180;
        yPosition = 190;
        color = "black";
        isVisible = false;
    }

    /**
     * Make this handle/drumstick visible. If it was already visible, do nothing.
     */
    public void makeVisible()
    {
        isVisible = true;
        draw();
    }
    
    /**
     * Make this handle/drumstick invisible. If it was already invisible, do nothing.
     */
    public void makeInvisible()
    {
        erase();
        isVisible = false;
    }
    
    /**
     * Move the handle/drumstick a few pixels to the right.
     */
    public void moveRight()
    {
        moveHorizontal(20);
    }

    /**
     * Move the handle/drumstick a few pixels to the left.
     */
    public void moveLeft()
    {
        moveHorizontal(-20);
    }

    /**
     * Move the handle/drumstick a few pixels up.
     */
    public void moveUp()
    {
        moveVertical(-20);
    }

    /**
     * Move the handle/drumstick a few pixels down.
     */
    public void moveDown()
    {
        moveVertical(20);
    }

    /**
     * Move the handle/drumstick horizontally by 'distance' pixels.
     */
    public void moveHorizontal(int distance)
    {
        erase();
        xPosition += distance;
        draw();
    }

    /**
     * Move the handle/drumstick vertically by 'distance' pixels.
     */
    public void moveVertical(int distance)
    {
        erase();
        yPosition += distance;
        draw();
    }

    /**
     * Slowly move the handle/drumstick horizontally by 'distance' pixels.
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
     * Slowly move the handle/drumstick vertically by 'distance' pixels.
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
     * Change the color. Valid colors are "red", "yellow", "blue", "green",
     * "magenta" and "black".
     */
    public void changeColor(String newColor)
    {
        color = newColor;
        draw();
    }

    /**
     * Draw the handle/drumstick with current specifications on screen.
     */
    public void draw()
    {
        int x = xPosition;
        int y = yPosition;
        if(isVisible) {
            Canvas canvas = Canvas.getCanvas();
            int[] xpoints = { x, x-3, x+12, x+15 };
            int[] ypoints = { y, y+3, y+18, y+15 };
            canvas.draw(this, color, new Polygon(xpoints, ypoints, 4));
            canvas.wait(10);
        }
    }
    
    /**
     * Draw the handle/drumstick with current specifications on screen.
     */
    public void play()
    {
        int x = xPosition;
        int y = yPosition;
        if(isVisible) {
            Canvas canvas = Canvas.getCanvas();
            int[] xpoints = { x-3, x-3, x+12, x+12 };
            int[] ypoints = { y+15, y+18, y+18, y+15 };
            canvas.draw(this, color, new Polygon(xpoints, ypoints, 4));
            canvas.wait(10);
        }
    }

    /**
     * Erase the handle/drumstick on screen.
     */
    private void erase()
    {
        if(isVisible) {
            Canvas canvas = Canvas.getCanvas();
            canvas.erase(this);
        }
    }
}
