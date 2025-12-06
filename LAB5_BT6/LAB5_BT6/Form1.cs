using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5_BT6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection installedFonts = new InstalledFontCollection();
            foreach (FontFamily font in installedFonts.Families)
            {
                lbFonts.Items.Add(font.Name);
            }
        }

        private void lbFonts_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.DrawBackground();
            string fontName = lbFonts.Items[e.Index].ToString();
            Font fontToDraw;
            try
            {
                fontToDraw = new Font(fontName, 14, FontStyle.Regular);
            }
            catch
            {
                fontToDraw = new Font("Arial", 14, FontStyle.Regular);
            }
            Brush textBrush;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                textBrush = SystemBrushes.HighlightText; 
            }
            else
            {
                textBrush = SystemBrushes.WindowText; 
            }
            e.Graphics.DrawString(fontName, fontToDraw, textBrush, e.Bounds.X, e.Bounds.Y + 2);
            fontToDraw.Dispose();
            e.DrawFocusRectangle();
        }
    }
}
