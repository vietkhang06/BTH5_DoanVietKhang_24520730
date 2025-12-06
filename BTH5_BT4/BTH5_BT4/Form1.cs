using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BTH5_BT4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FontFamily[] fontFamilies = FontFamily.Families;
            foreach (FontFamily font in fontFamilies)
            {
                cbFont.Items.Add(font.Name);
            }
            cbFont.SelectedIndex = 0;
            cbSize.SelectedIndex = 0;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                rtbDisplay.ForeColor = colorDialog1.Color;
                btnColor.BackColor = colorDialog1.Color;
            }
        }
        private void CapNhat()
        {
            if (cbFont.SelectedItem == null | cbSize.SelectedItem == null) return;
            string fontName = cbFont.SelectedItem.ToString();
            float sizeName = float.Parse(cbSize.SelectedItem.ToString());
            FontStyle fontstyle = FontStyle.Regular;
            if(ckbBold.Checked) fontstyle = fontstyle | FontStyle.Bold;
            if(ckbItalic.Checked) fontstyle = fontstyle | FontStyle.Italic;
            if (ckbUnderlined.Checked) fontstyle |= FontStyle.Underline;
            rtbDisplay.Font = new Font(fontName, sizeName, fontstyle);
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhat();
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhat();
        }

        private void ckbBold_CheckedChanged(object sender, EventArgs e)
        {
            CapNhat();
        }

        private void ckbItalic_CheckedChanged(object sender, EventArgs e)
        {
            CapNhat();
        }

        private void ckbUnderlined_CheckedChanged(object sender, EventArgs e)
        {
            CapNhat();
        }

        private void rbLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLeft.Checked) rtbDisplay.TextAlign = HorizontalAlignment.Left;
        }
        private void rbCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCenter.Checked) rtbDisplay.TextAlign = HorizontalAlignment.Center;
        }
        private void rbRight_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRight.Checked) rtbDisplay.TextAlign = HorizontalAlignment.Right;
        }
    }
}
