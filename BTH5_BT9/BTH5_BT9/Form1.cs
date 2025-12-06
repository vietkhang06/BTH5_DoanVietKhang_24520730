using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTH5_BT9
{
    public partial class Form1 : Form
    {
        private Color currentColor = Color.DarkRed;
        public Form1()
        {
            InitializeComponent();
            cbboxShapes.SelectedIndex = 0;
        }

        private void cbboxShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (cbboxShapes.SelectedItem == null) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; 
            Brush currentBrush = new SolidBrush(currentColor);
            Pen currentPen = new Pen(currentColor, 3);
            Rectangle rect = new Rectangle(100, 100, 200, 150); 
            Rectangle square = new Rectangle(100, 100, 150, 150);
            string choice = cbboxShapes.SelectedItem.ToString();
            switch (choice)
            {
                case "Circle":
                    g.DrawEllipse(currentPen, square);
                    break;
                case "Square":
                    g.DrawRectangle(currentPen, square);
                    break;
                case "Filled Square":
                    g.FillRectangle(currentBrush, square);
                    break;
                case "Filled Circle":
                    g.FillEllipse(currentBrush, square);
                    break;
                case "Rectangle":
                    g.DrawRectangle(currentPen, rect);
                    break;
                case "Filled Rectangle":
                    g.FillRectangle(currentBrush, rect);
                    break;
                case "Ellipse":
                    g.DrawEllipse(currentPen, rect);
                    break;
                case "Filled Ellipse": 
                    g.FillEllipse(currentBrush, rect);
                    break;
                case "Pie":
                    g.DrawPie(currentPen, square, 0, 150);
                    break;
                case "Filled Pie":
                    g.FillPie(currentBrush, square, 0, 150);
                    break;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            colorDialog1.Color = currentColor;
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog1.Color;
                this.Invalidate();
            }
        }
    }
}
