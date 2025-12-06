namespace BTH5_BT4
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
            this.lbFont = new System.Windows.Forms.Label();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.ckbBold = new System.Windows.Forms.CheckBox();
            this.ckbItalic = new System.Windows.Forms.CheckBox();
            this.ckbUnderlined = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.rbCenter = new System.Windows.Forms.RadioButton();
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.rtbDisplay = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFont
            // 
            this.lbFont.AutoSize = true;
            this.lbFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFont.Location = new System.Drawing.Point(25, 25);
            this.lbFont.Name = "lbFont";
            this.lbFont.Size = new System.Drawing.Size(71, 32);
            this.lbFont.TabIndex = 0;
            this.lbFont.Text = "Font";
            // 
            // cbFont
            // 
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(102, 25);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(188, 28);
            this.cbFont.TabIndex = 1;
            this.cbFont.SelectedIndexChanged += new System.EventHandler(this.cbFont_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size";
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.cbSize.Location = new System.Drawing.Point(420, 25);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(103, 28);
            this.cbSize.TabIndex = 3;
            this.cbSize.SelectedIndexChanged += new System.EventHandler(this.cbSize_SelectedIndexChanged);
            // 
            // ckbBold
            // 
            this.ckbBold.AutoSize = true;
            this.ckbBold.Location = new System.Drawing.Point(31, 95);
            this.ckbBold.Name = "ckbBold";
            this.ckbBold.Size = new System.Drawing.Size(22, 21);
            this.ckbBold.TabIndex = 4;
            this.ckbBold.UseVisualStyleBackColor = true;
            this.ckbBold.CheckedChanged += new System.EventHandler(this.ckbBold_CheckedChanged);
            // 
            // ckbItalic
            // 
            this.ckbItalic.AutoSize = true;
            this.ckbItalic.Location = new System.Drawing.Point(102, 95);
            this.ckbItalic.Name = "ckbItalic";
            this.ckbItalic.Size = new System.Drawing.Size(22, 21);
            this.ckbItalic.TabIndex = 5;
            this.ckbItalic.UseVisualStyleBackColor = true;
            this.ckbItalic.CheckedChanged += new System.EventHandler(this.ckbItalic_CheckedChanged);
            // 
            // ckbUnderlined
            // 
            this.ckbUnderlined.AutoSize = true;
            this.ckbUnderlined.Location = new System.Drawing.Point(173, 95);
            this.ckbUnderlined.Name = "ckbUnderlined";
            this.ckbUnderlined.Size = new System.Drawing.Size(22, 21);
            this.ckbUnderlined.TabIndex = 6;
            this.ckbUnderlined.UseVisualStyleBackColor = true;
            this.ckbUnderlined.CheckedChanged += new System.EventHandler(this.ckbUnderlined_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Color";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(420, 88);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(49, 28);
            this.btnColor.TabIndex = 11;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbRight);
            this.groupBox1.Controls.Add(this.rbCenter);
            this.groupBox1.Controls.Add(this.rbLeft);
            this.groupBox1.Location = new System.Drawing.Point(31, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 127);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Align Text";
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.Location = new System.Drawing.Point(6, 85);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(72, 24);
            this.rbRight.TabIndex = 2;
            this.rbRight.TabStop = true;
            this.rbRight.Text = "Right";
            this.rbRight.UseVisualStyleBackColor = true;
            this.rbRight.CheckedChanged += new System.EventHandler(this.rbRight_CheckedChanged);
            // 
            // rbCenter
            // 
            this.rbCenter.AutoSize = true;
            this.rbCenter.Location = new System.Drawing.Point(6, 55);
            this.rbCenter.Name = "rbCenter";
            this.rbCenter.Size = new System.Drawing.Size(82, 24);
            this.rbCenter.TabIndex = 1;
            this.rbCenter.TabStop = true;
            this.rbCenter.Text = "Center";
            this.rbCenter.UseVisualStyleBackColor = true;
            this.rbCenter.CheckedChanged += new System.EventHandler(this.rbCenter_CheckedChanged);
            // 
            // rbLeft
            // 
            this.rbLeft.AutoSize = true;
            this.rbLeft.Location = new System.Drawing.Point(6, 25);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(62, 24);
            this.rbLeft.TabIndex = 0;
            this.rbLeft.TabStop = true;
            this.rbLeft.Text = "Left";
            this.rbLeft.UseVisualStyleBackColor = true;
            this.rbLeft.CheckedChanged += new System.EventHandler(this.rbLeft_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BTH5_BT4.Properties.Resources.underline_text;
            this.pictureBox3.Location = new System.Drawing.Point(201, 88);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BTH5_BT4.Properties.Resources.italic_font;
            this.pictureBox2.Location = new System.Drawing.Point(130, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTH5_BT4.Properties.Resources.bold_text;
            this.pictureBox1.Location = new System.Drawing.Point(59, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDisplay.Location = new System.Drawing.Point(288, 181);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(192, 26);
            this.rtbDisplay.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 297);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ckbUnderlined);
            this.Controls.Add(this.ckbItalic);
            this.Controls.Add(this.ckbBold);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFont);
            this.Controls.Add(this.lbFont);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFont;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.CheckBox ckbBold;
        private System.Windows.Forms.CheckBox ckbItalic;
        private System.Windows.Forms.CheckBox ckbUnderlined;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbRight;
        private System.Windows.Forms.RadioButton rbCenter;
        private System.Windows.Forms.RadioButton rbLeft;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox rtbDisplay;
    }
}

