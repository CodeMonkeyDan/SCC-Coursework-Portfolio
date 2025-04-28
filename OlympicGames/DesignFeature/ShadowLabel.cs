using System;
using System.Drawing;
using System.Windows.Forms;

public class ShadowLabel : Label
{
    public Color ShadowColor { get; set; } = Color.FromArgb(100, 0, 0, 0); // gray is better than black. art 101
    public int ShadowOffset { get; set; } = 2; // how far off the shadow should be. this is less than the
    // text box distance to give the ILLUSION OF DEPTH OF THE LIGHTSOUIRCE.

    protected override void OnPaint(PaintEventArgs e)
    {
        Graphics g = e.Graphics;
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias; // make it actually Look At Smooth

        using (SolidBrush shadowBrush = new SolidBrush(ShadowColor)) // shadowcolor as dictated in the call in the orginal form
        using (SolidBrush textBrush = new SolidBrush(this.ForeColor))
        {
            // draw shadow first
            g.DrawString(this.Text, this.Font, shadowBrush, ShadowOffset, ShadowOffset);

            // aaaan dmake it text
            g.DrawString(this.Text, this.Font, textBrush, 0, 0);
        }
    }
}
