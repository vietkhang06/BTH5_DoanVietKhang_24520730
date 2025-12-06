using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BTH5_BT10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboDashStyle.DataSource = Enum.GetValues(typeof(DashStyle));
            cboLineJoin.DataSource = Enum.GetValues(typeof(LineJoin));
            cboDashCap.DataSource = Enum.GetValues(typeof(DashCap));
            cboStartCap.DataSource = Enum.GetValues(typeof(LineCap));
            cboEndCap.DataSource = Enum.GetValues(typeof(LineCap));
            cboDashStyle.SelectedItem = DashStyle.DashDot;
            cboLineJoin.SelectedItem = LineJoin.Round;
            cboStartCap.SelectedItem = LineCap.RoundAnchor;
            cboEndCap.SelectedItem = LineCap.ArrowAnchor;
            cboDashCap.SelectedItem = DashCap.Flat;
            cboWidth.SelectedItem = 10;
        }

        private void UpdateDrawing(object sender, EventArgs e)
        {
            pnlDraw.Invalidate();
        }

        private void cboDashStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDrawing(sender, e);
        }

        private void cboWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDrawing(sender, e);
        }

        private void cboLineJoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDrawing(sender, e);
        }

        private void cboDashCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDrawing(sender, e);
        }

        private void cboStartCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDrawing(sender, e);
        }

        private void cboEndCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDrawing(sender, e);
        }

        private void pnlDraw_Paint(object sender, PaintEventArgs e)
        {
            if (cboWidth.SelectedItem == null) return;
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float width = Convert.ToSingle(cboWidth.SelectedItem);
            DashStyle dStyle = (DashStyle)cboDashStyle.SelectedItem;
            LineJoin lJoin = (LineJoin)cboLineJoin.SelectedItem;
            DashCap dCap = (DashCap)cboDashCap.SelectedItem;
            LineCap sCap = (LineCap)cboStartCap.SelectedItem;
            LineCap eCap = (LineCap)cboEndCap.SelectedItem;
            using (Pen p = new Pen(Color.Red, width))
            {
                p.DashStyle = dStyle;
                p.LineJoin = lJoin;
                p.DashCap = dCap;
                p.StartCap = sCap;
                p.EndCap = eCap;
                Point p1 = new Point(50, 50);
                Point p2 = new Point(150, 250);
                Point p3 = new Point(350, 50);
                g.DrawLines(p, new Point[] { p1, p2, p3 });
            }
        }
    }
}