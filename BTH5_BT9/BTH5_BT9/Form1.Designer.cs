namespace BTH5_BT9
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
            this.cbboxShapes = new System.Windows.Forms.ComboBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // cbboxShapes
            // 
            this.cbboxShapes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxShapes.FormattingEnabled = true;
            this.cbboxShapes.Items.AddRange(new object[] {
            "Circle",
            "Square",
            "Ellipse",
            "Pie",
            "Filled Circle",
            "Filled Square",
            "Filled Ellipse",
            "Filled Pie"});
            this.cbboxShapes.Location = new System.Drawing.Point(31, 25);
            this.cbboxShapes.Name = "cbboxShapes";
            this.cbboxShapes.Size = new System.Drawing.Size(215, 28);
            this.cbboxShapes.TabIndex = 0;
            this.cbboxShapes.SelectedIndexChanged += new System.EventHandler(this.cbboxShapes_SelectedIndexChanged);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(277, 25);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(49, 28);
            this.btnColor.TabIndex = 1;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.cbboxShapes);
            this.Name = "Form1";
            this.Text = "ComboBoxTest";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbboxShapes;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

