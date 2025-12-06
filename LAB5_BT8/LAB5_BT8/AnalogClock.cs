using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace LAB5_BT8
{
    public partial class AnalogClock : UserControl
    {
        private Timer timer;

        public AnalogClock()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            this.BackColor = Color.Black;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (s, e) => { this.Invalidate(); };
            timer.Start();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            int w = this.Width;
            int h = this.Height;
            int cw = w / 2;
            int ch = h / 2;
            int radius = Math.Min(w, h) / 2 - 20;
            g.TranslateTransform(cw, ch);
            for(int i = 0; i < 60; i++)
            {
                if(i % 5 == 0)
                {
                    g.FillEllipse(Brushes.White, -6, -radius, 12, 12);
                }
                else
                {
                    g.FillEllipse(Brushes.White, -2, -radius, 4, 4);
                }
                g.RotateTransform(6);
            }
            DateTime now = DateTime.Now;
            g.ResetTransform();
            g.TranslateTransform(cw, ch);
            float hourAngle = (now.Hour % 12 + now.Minute / 60f) * 30;
            DrawPolygonHand(g, hourAngle, radius * 0.5f, 10, Pens.White);
            float minuteAngle = (now.Minute + now.Second / 60f) * 6;
            DrawPolygonHand(g, minuteAngle, radius * 0.7f, 8, Pens.White);
            float secondAngle = now.Second * 6;
            DrawPolygonHand(g, secondAngle, radius * 0.85f, 4, Pens.White);
            g.FillEllipse(Brushes.White, -3, -3, 6, 6);
        }
        private void DrawPolygonHand(Graphics g, float angle, float length, int width, Pen pen)
        {
            var state = g.Save();
            g.RotateTransform(angle);
            PointF[] pointFs = new PointF[]
            {
                new PointF(0, -length),
                new PointF(width, -length/5),
                new PointF(0, length / 5),
                new PointF(-width, -length / 5)
            };
            g.DrawPolygon(pen, pointFs);
            g.Restore(state);
        }
    }
}
