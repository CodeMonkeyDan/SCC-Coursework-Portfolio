using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_Project_Gui
{
    public static class PanelExtensions
    {
        // graphic design is my passion. we are rounding edges.
        public static void SetRoundedRegion(this Panel panel, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath(); // what we use to make the rounding
            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            // fiddled with these until i got the shape i wanted
            path.CloseFigure();

            panel.Region = new Region(path); // update the region to the new path
        }

    }
}
