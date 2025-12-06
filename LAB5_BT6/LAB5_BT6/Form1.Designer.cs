namespace LAB5_BT6
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lbFonts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbFonts
            // 
            this.lbFonts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFonts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbFonts.FormattingEnabled = true;
            this.lbFonts.HorizontalScrollbar = true;
            this.lbFonts.ItemHeight = 30;
            this.lbFonts.Location = new System.Drawing.Point(35, 27);
            this.lbFonts.Name = "lbFonts";
            this.lbFonts.Size = new System.Drawing.Size(461, 424);
            this.lbFonts.TabIndex = 0;
            this.lbFonts.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbFonts_DrawItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.lbFonts);
            this.Name = "Form1";
            this.Text = "All Fonts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ListBox lbFonts;
    }
}

