using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BTH5_BT11
{
    public partial class Form1 : Form
    {
        Point startPoint;
        Point endPoint;
        bool isDrawing = false;
        Color currentPenColor = Color.Blue;
        Bitmap mainBitmap;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mainBitmap = new Bitmap(pnlDraw.Width, pnlDraw.Height);
            using (Graphics g = Graphics.FromImage(mainBitmap))
            {
                g.Clear(Color.White);
            }
            pnlDraw.BackgroundImage = mainBitmap;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                currentPenColor = colorDialog1.Color;
            }
        }

        private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void pnlDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                pnlDraw.Invalidate();
            }
        }

        private void pnlDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                endPoint = e.Location;

                using (Graphics g = Graphics.FromImage(mainBitmap))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    DrawShape(g);
                }
                pnlDraw.Invalidate();
            }
        }

        private void pnlDraw_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing)
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                DrawShape(e.Graphics);
            }
        }

        private void DrawShape(Graphics g)
        {
            float width = 1;
            float.TryParse(tbWidth.Text, out width);
            Pen p = new Pen(currentPenColor, width);
            int x = Math.Min(startPoint.X, endPoint.X);
            int y = Math.Min(startPoint.Y, endPoint.Y);
            int w = Math.Abs(startPoint.X - endPoint.X);
            int h = Math.Abs(startPoint.Y - endPoint.Y);
            Rectangle rect = new Rectangle(x, y, w, h);
            if (rbLine.Checked)
            {
                g.DrawLine(p, startPoint, endPoint);
            }
            else
            {
                Brush b = null;

                if (rbSolidBrush.Checked)
                {
                    b = new SolidBrush(Color.Green);
                }
                else if (rbHatchBrush.Checked)
                {
                    b = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
                }
                else if (rbTextureBrush.Checked)
                {
                    Bitmap texture = new Bitmap(10, 10);
                    using (Graphics tg = Graphics.FromImage(texture))
                    {
                        tg.Clear(Color.White);
                        tg.FillRectangle(Brushes.Gray, 0, 0, 5, 5);
                        tg.FillRectangle(Brushes.Gray, 5, 5, 5, 5);
                    }
                    b = new TextureBrush(texture);
                }
                else if (rbLinearGradientBrush.Checked)
                {
                    if (w > 0 && h > 0)
                        b = new LinearGradientBrush(rect, Color.Red, Color.Green, LinearGradientMode.Vertical);
                    else
                        b = new SolidBrush(Color.Red);
                }
                if (b != null)
                {
                    if (rbRectangle.Checked) g.FillRectangle(b, rect);
                    else if (rbEllipse.Checked) g.FillEllipse(b, rect);
                }
            }
        }
    }
}