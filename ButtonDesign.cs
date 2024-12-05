using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eilidh_finalproject
{
    public class ButtonDesign : Button
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Color e8aca1 = Color.FromArgb(232, 172, 161);
            Color fae7d1 = Color.FromArgb(250, 231, 209);
            Pen btnBorder = new Pen(e8aca1, 2);
            Pen hideWhite = new Pen(fae7d1, 10);
            g.DrawRectangle(hideWhite, 0, 0, this.Width, this.Height);
            g.DrawRectangle(btnBorder, 0, 0, this.Width, this.Height);
        }
    }
}
