namespace BTH5_BT11
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbLinearGradientBrush = new System.Windows.Forms.RadioButton();
            this.rbTextureBrush = new System.Windows.Forms.RadioButton();
            this.rbHatchBrush = new System.Windows.Forms.RadioButton();
            this.rbSolidBrush = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.rbRectangle = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.pnlDraw = new System.Windows.Forms.FlowLayoutPanel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 660);
            this.panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbLinearGradientBrush);
            this.groupBox3.Controls.Add(this.rbTextureBrush);
            this.groupBox3.Controls.Add(this.rbHatchBrush);
            this.groupBox3.Controls.Add(this.rbSolidBrush);
            this.groupBox3.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox3.Location = new System.Drawing.Point(24, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 308);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brushes";
            // 
            // rbLinearGradientBrush
            // 
            this.rbLinearGradientBrush.AutoSize = true;
            this.rbLinearGradientBrush.Location = new System.Drawing.Point(18, 170);
            this.rbLinearGradientBrush.Name = "rbLinearGradientBrush";
            this.rbLinearGradientBrush.Size = new System.Drawing.Size(182, 24);
            this.rbLinearGradientBrush.TabIndex = 4;
            this.rbLinearGradientBrush.TabStop = true;
            this.rbLinearGradientBrush.Text = "LinearGradientBrush";
            this.rbLinearGradientBrush.UseVisualStyleBackColor = true;
            // 
            // rbTextureBrush
            // 
            this.rbTextureBrush.AutoSize = true;
            this.rbTextureBrush.Location = new System.Drawing.Point(18, 124);
            this.rbTextureBrush.Name = "rbTextureBrush";
            this.rbTextureBrush.Size = new System.Drawing.Size(129, 24);
            this.rbTextureBrush.TabIndex = 3;
            this.rbTextureBrush.TabStop = true;
            this.rbTextureBrush.Text = "TextureBrush";
            this.rbTextureBrush.UseVisualStyleBackColor = true;
            // 
            // rbHatchBrush
            // 
            this.rbHatchBrush.AutoSize = true;
            this.rbHatchBrush.Location = new System.Drawing.Point(18, 79);
            this.rbHatchBrush.Name = "rbHatchBrush";
            this.rbHatchBrush.Size = new System.Drawing.Size(119, 24);
            this.rbHatchBrush.TabIndex = 2;
            this.rbHatchBrush.TabStop = true;
            this.rbHatchBrush.Text = "HatchBrush";
            this.rbHatchBrush.UseVisualStyleBackColor = true;
            // 
            // rbSolidBrush
            // 
            this.rbSolidBrush.AutoSize = true;
            this.rbSolidBrush.Checked = true;
            this.rbSolidBrush.Location = new System.Drawing.Point(18, 35);
            this.rbSolidBrush.Name = "rbSolidBrush";
            this.rbSolidBrush.Size = new System.Drawing.Size(111, 24);
            this.rbSolidBrush.TabIndex = 1;
            this.rbSolidBrush.TabStop = true;
            this.rbSolidBrush.Text = "SolidBrush";
            this.rbSolidBrush.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.tbWidth);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox2.Location = new System.Drawing.Point(24, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pen";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnColor.ForeColor = System.Drawing.Color.Black;
            this.btnColor.Location = new System.Drawing.Point(58, 75);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(113, 32);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Color...";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(78, 29);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(78, 26);
            this.tbWidth.TabIndex = 1;
            this.tbWidth.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEllipse);
            this.groupBox1.Controls.Add(this.rbRectangle);
            this.groupBox1.Controls.Add(this.rbLine);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(24, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Location = new System.Drawing.Point(18, 85);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(80, 24);
            this.rbEllipse.TabIndex = 2;
            this.rbEllipse.TabStop = true;
            this.rbEllipse.Text = "Ellipse";
            this.rbEllipse.UseVisualStyleBackColor = true;
            // 
            // rbRectangle
            // 
            this.rbRectangle.AutoSize = true;
            this.rbRectangle.Location = new System.Drawing.Point(18, 55);
            this.rbRectangle.Name = "rbRectangle";
            this.rbRectangle.Size = new System.Drawing.Size(107, 24);
            this.rbRectangle.TabIndex = 1;
            this.rbRectangle.TabStop = true;
            this.rbRectangle.Text = "Rectangle";
            this.rbRectangle.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Checked = true;
            this.rbLine.Location = new System.Drawing.Point(18, 25);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(64, 24);
            this.rbLine.TabIndex = 0;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDraw.Location = new System.Drawing.Point(284, 0);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(756, 660);
            this.pnlDraw.TabIndex = 1;
            this.pnlDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseDown);
            this.pnlDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseMove);
            this.pnlDraw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 660);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Bai Thi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlDraw;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.RadioButton rbRectangle;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbLinearGradientBrush;
        private System.Windows.Forms.RadioButton rbTextureBrush;
        private System.Windows.Forms.RadioButton rbHatchBrush;
        private System.Windows.Forms.RadioButton rbSolidBrush;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

